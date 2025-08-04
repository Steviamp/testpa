using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using QWinpanel.services.Requests;
using QWinpanel.services.Responses;
using QWinpanel.Services.Requests;
using QWinpanel.Services.Responses;
using System;
using Microsoft.Extensions.Configuration;

namespace QWinpanel.services
{
    public class WinPanelAPIService
    {
        private static string ClientId = "winpanel";
        private static string ClientSecret = "E27DD485-1D02-46D7-B764-2BC89CE0B730";

        private static string AuthenticationApiUrl = "/auth";
        private static string LoginApiUrl = "/logon";
        private static string RefreshInfoApiUrl = "/refresh-info";
        private static string StopApiUrl = "/stop";
        private static string NextTicketApiUrl = "/next-ticket";
        private static string PriorityApiUrl = "/prio";
        private static string UpdatePriorityApiUrl = "/change-prio";
        private static string TicketsApiUrl = "/ticket-track";
        private static string CallTicketApiUrl = "/call-ticket";
        private static string LogoutApiUrl = "/logout";        

        private static HttpClient GetHttpClient()
        {
            var config = new ConfigurationBuilder()
                      .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                      .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                      .Build();
            string apiUrl = config["ApiUrl"];

            var handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            HttpClient httpClient = new HttpClient(handler);
            httpClient.BaseAddress = new Uri(apiUrl);
            return httpClient;
        }

        public static async Task<CustomResponse> Authentication()
        {
            return await AuthRequest("POST", AuthenticationApiUrl);
        }

        public static async Task<CustomResponse> Login(LoginRequest MyItem)
        {
            return await CustomResponseRequest("POST", LoginApiUrl, MyItem);
        }

        public static async Task<CustomResponse> GetRefreshInfo(CommonRequest MyItem)
        {
            return await CustomResponseRequest("POST", RefreshInfoApiUrl, MyItem);
        }

        public static async Task<CustomResponse> Stop(CommonRequest MyItem)
        {
            return await CustomResponseRequest("POST", StopApiUrl, MyItem);
        }

        public static async Task<CustomResponse> NextTicket(CommonRequest MyItem)
        {
            return await CustomResponseRequest("POST", NextTicketApiUrl, MyItem);
        }

        public static async Task<CustomResponse> GetPriority(CommonRequest MyItem)
        {
            return await CustomResponseRequest("POST", PriorityApiUrl, MyItem);
        }

        public static async Task<CustomResponse> UpdatePriority(UpdatePriorityRequest MyItem)
        {
            return await CustomResponseRequest("POST", UpdatePriorityApiUrl, MyItem);
        }

        public static async Task<CustomResponse> GetTickets(GetTicketsRequest MyItem)
        {
            return await CustomResponseRequest("POST", TicketsApiUrl, MyItem);
        }

        public static async Task<CustomResponse> CallTicket(CallTicketRequest MyItem)
        {
            return await CustomResponseRequest("POST", CallTicketApiUrl, MyItem);
        }

        public static async Task<CustomResponse> Logout(LogoutRequest MyItem)
        {
            return await CustomResponseRequest("POST", LogoutApiUrl, MyItem);
        }
                
        private static async Task<CustomResponse> CustomResponseRequest(string Method, string Uri, object? BodyContent)
        {
            CustomResponse MyCustomResponseAuth = await AuthRequest("POST", AuthenticationApiUrl);
            if (MyCustomResponseAuth.HttpResponseCode == 200)
            {
                AuthenticationResponse MyAuthenticationResponse = JsonConvert.DeserializeObject<AuthenticationResponse>(MyCustomResponseAuth.Data);
                CustomResponse MyCustomResponse = new CustomResponse();
                HttpClient httpClient = GetHttpClient();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", MyAuthenticationResponse.token);

                try
                {
                    var RequestMessage = new HttpRequestMessage(new HttpMethod(Method), new Uri(httpClient.BaseAddress + Uri));
                    if (BodyContent != null) RequestMessage.Content = JsonContent.Create(BodyContent);
                    var ResponseMessage = await httpClient.SendAsync(RequestMessage);
                    string ResponseBody = await ResponseMessage.Content.ReadAsStringAsync();
                    MyCustomResponse = new CustomResponse { HttpResponseCode = (int)ResponseMessage.StatusCode, Data = ResponseBody };
                }
                catch (Exception ex)
                {
                    MyCustomResponse = new CustomResponse { HttpResponseCode = 500, Data = JsonConvert.SerializeObject(new ErrorResponse { Error = ex.Message }) };
                }

                return MyCustomResponse;
            }
            else return MyCustomResponseAuth;
        }

        private static async Task<CustomResponse> AuthRequest(string Method, string Uri)
        {
            CustomResponse MyCustomResponse = new CustomResponse();
            HttpClient httpClient = GetHttpClient();

            try
            {
                var RequestMessage = new HttpRequestMessage(new HttpMethod(Method), new Uri(httpClient.BaseAddress + Uri));
                RequestMessage.Headers.Add("ClientId", ClientId);
                RequestMessage.Headers.Add("ClientSecret", ClientSecret);
                var ResponseMessage = await httpClient.SendAsync(RequestMessage);
                string ResponseBody = await ResponseMessage.Content.ReadAsStringAsync();
                MyCustomResponse = new CustomResponse { HttpResponseCode = (int)ResponseMessage.StatusCode, Data = ResponseBody };
            }
            catch (Exception ex)
            {
                MyCustomResponse = new CustomResponse { HttpResponseCode = 500, Data = JsonConvert.SerializeObject(new ErrorResponse { Error = ex.Message }) };
            }

            return MyCustomResponse;
        }
    }
}
