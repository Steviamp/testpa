using Newtonsoft.Json;
using QWinpanel.services.Responses;
using QWinpanel.services;
using QWinpanel.Services.Requests;
using QWinpanel.Services.Responses;
using Serilog;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;

namespace Login_and_Register
{
    public partial class frmLogin : Form
    {
        private string AdminPassword = "1yXf9zJBdU";

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public frmLogin()
        {
            InitializeComponent();
            InitPage();
        }

        private void InitPage()
        {
            txtUsername.Text = Environment.UserName;
            txtUsername.BackColor = ColorTranslator.FromHtml("#E6E7E9");
            txtUsername.ReadOnly = true;
            lblPassword.Visible = false;
            txtPassword.Visible = false;
            btnOtherUser.Visible = true;
            lblBack.Visible = false;

            lblCopryright.Text = "Copyright © " + DateTime.Now.Year.ToString() + " Mellon Technologies";
            lblVersion.Text = "v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var computername = System.Environment.GetEnvironmentVariable("CLIENTNAME", EnvironmentVariableTarget.Process);

                bool AllowPostLogin = false;
                bool AllowLogin = false;
                string ErrorMsg = "";

                string cashierNr = "";
                string host = "";

                if (txtPassword.Visible)
                {
                    if (txtPassword.Text == AdminPassword) AllowPostLogin = true;
                    else ErrorMsg = "Wrong password.";
                }
                else AllowPostLogin = true;

                if (AllowPostLogin)
                {
                    LoginRequest MyItem = new LoginRequest { windowsUser = txtUsername.Text, dnsServer = GetPrimaryDns(), computerName = computername };

                    CustomResponse MyCustomResponse = await WinPanelAPIService.Login(MyItem);
                    if (MyCustomResponse.HttpResponseCode == 200)
                    {
                        AllowLogin = true;
                        GetRefreshInfoResponse MyGetRefreshInfoResponse = JsonConvert.DeserializeObject<GetRefreshInfoResponse>(MyCustomResponse.Data);
                        cashierNr = MyGetRefreshInfoResponse.cashierNr;
                        host = MyGetRefreshInfoResponse.host;
                    }
                    else
                    {
                        if (MyCustomResponse.HttpResponseCode == 404) ErrorMsg = "User with username " + txtUsername.Text + " not found.";
                        else
                        {
                            if (MyCustomResponse.Data.Length > 0)
                            {
                                ErrorResponse MyErrorResponse = JsonConvert.DeserializeObject<ErrorResponse>(MyCustomResponse.Data);
                                ErrorMsg = MyErrorResponse.Error;
                            }
                        }
                    }
                }

                if (AllowLogin)
                {
                    frmDashboard MyfrmDashboard = new frmDashboard(cashierNr, host, txtUsername.Text);
                    MyfrmDashboard.Show();
                    this.Hide();
                }
                else
                {
                    Log.Error("Login form error:" + ErrorMsg, DateTime.Now);
                    MessageBox.Show(ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Login form exception:" + ex.Message, DateTime.Now);
            }
        }

        private void btnOtherUser_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            txtUsername.ReadOnly = false;
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            btnOtherUser.Visible = false;
            lblBack.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            InitPage();
        }

        private void pnlLogin_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnlLogin_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private string GetPrimaryDns()
        {
            try
            {
                foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (ni.OperationalStatus == OperationalStatus.Up &&
                        (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet ||
                         ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211))
                    {
                        IPInterfaceProperties ipProps = ni.GetIPProperties();
                        IPAddress primaryDns = ipProps.DnsAddresses.FirstOrDefault();

                        if (primaryDns != null)
                        {
                            return primaryDns.ToString();
                        }
                    }
                }
                return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
