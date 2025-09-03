using System.Text.Json.Serialization;

namespace QWinpanel.services.Responses
{
    public class BaseResponse
    {
        public int HttpResponseCode { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string ErrorCode { get; set; }


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Error { get; set; }
    }
}
