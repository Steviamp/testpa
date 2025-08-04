using QWinpanel.services.Responses;
using QWinpanel.services;
using QWinpanel.services.Requests;
using Newtonsoft.Json;
using QWinpanel;
using QWinpanel.Services.Responses;
using QWinpanel.Properties;
using Serilog;
using QWinpanel.Services.Requests;
using System.Linq.Expressions;

namespace Login_and_Register
{
    public partial class frmDashboard : Form
    {
        private int TimerInterval = 10000;
        private System.Timers.Timer MyTimer = new System.Timers.Timer();

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public string cashierNr = "";
        public string host = "";
        public string windowsUser = "";        

        public frmDashboard(string MycashierNr, string Myhost, string MywindowsUser)
        {
            cashierNr = MycashierNr;
            host = Myhost;
            windowsUser = MywindowsUser;
            InitializeComponent();
        }

        private async void frmDashboard_Load(object sender, EventArgs e)
        {
            await InitPage();
        }

        private async Task InitPage()
        {
            txtCashier.ShortcutsEnabled = false;
            txtwaitingCustomersMQ.ShortcutsEnabled = false;
            txtwaitingCustomersBQ.ShortcutsEnabled = false;
            txtServiceName.ShortcutsEnabled = false;
            txtQueue.ShortcutsEnabled = false;
            txtTicketNo.ShortcutsEnabled = false;
            txtCustomerText.ShortcutsEnabled = false;
            await RefreshInfo();
            StartTimer();
        }

        public void StartTimer()
        {
            try
            {
                MyTimer = new System.Timers.Timer();
                MyTimer.Interval = TimerInterval;
                MyTimer.Elapsed += MyTimer_Elapsed;
                MyTimer.Start();
            }
            catch (Exception ex)
            {
                Log.Error("Dashboard form StartTimer exception:" + ex.Message, DateTime.Now);
            }
        }

        private void StopTimer()
        {
            try
            {
                MyTimer.Stop();
            }
            catch (Exception ex)
            {
                Log.Error("Dashboard form StopTimer exception:" + ex.Message, DateTime.Now);
            }
        }

        private async void MyTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            await RefreshInfo();
        }

        private async Task RefreshInfo()
        {
            try
            {
                CommonRequest MyItem = new CommonRequest { cashierNr = cashierNr, host = host };

                CustomResponse MyCustomResponse = await WinPanelAPIService.GetRefreshInfo(MyItem);
                if (MyCustomResponse.HttpResponseCode == 200) AssignTextboxes(JsonConvert.DeserializeObject<GetRefreshInfoResponse>(MyCustomResponse.Data));
                else
                {
                    string ErrorMsg = "";
                    if (MyCustomResponse.Data.Length > 0)
                    {
                        ErrorResponse MyErrorResponse = JsonConvert.DeserializeObject<ErrorResponse>(MyCustomResponse.Data);
                        ErrorMsg = MyErrorResponse.Error;
                    }
                    if (ErrorMsg.Contains("time") || ErrorMsg.Contains("connection"))
                    {
                        StopTimer();
                        var MyfrmException = new frmException("Connection to server lost. Press Connect to try restoring connection or X to exit the application.").ShowDialog();
                        await RefreshInfo();
                        StartTimer();
                    }
                    else MessageBox.Show(MyCustomResponse.HttpResponseCode.ToString() + " " + ErrorMsg);
                    Log.Error("Dashboard form RefreshInfo error: Cashier " + MyItem.cashierNr + " Host " + MyItem.host + " | " + MyCustomResponse.HttpResponseCode.ToString() + " - " + ErrorMsg, DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Dashboard form RefreshInfo exception:" + ex.Message, DateTime.Now);
                MessageBox.Show(ex.Message);
            }
        }

        private async void txtwaitingCustomersMQ_MouseDown(object sender, MouseEventArgs e)
        {
            if (Convert.ToInt32(txtwaitingCustomersMQ.Text) > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    StopTimer();
                    var MyfrmTickets = new frmTickets(cashierNr, host, 1).ShowDialog();
                    await RefreshInfo();
                    StartTimer();
                }
            }
        }

        private async void txtwaitingCustomersBQ_MouseDown(object sender, MouseEventArgs e)
        {
            if (Convert.ToInt32(txtwaitingCustomersBQ.Text) > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    StopTimer();
                    var MyfrmTickets = new frmTickets(cashierNr, host, 2).ShowDialog();
                    await RefreshInfo();
                    StartTimer();
                }
            }
        }

        private async void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                CommonRequest MyItem = new CommonRequest { cashierNr = cashierNr, host = host };

                CustomResponse MyCustomResponse = await WinPanelAPIService.Stop(MyItem);
                if (MyCustomResponse.HttpResponseCode == 200) AssignTextboxes(JsonConvert.DeserializeObject<GetRefreshInfoResponse>(MyCustomResponse.Data));
                else
                {
                    string ErrorMsg = "";
                    if (MyCustomResponse.Data.Length > 0)
                    {
                        ErrorResponse MyErrorResponse = JsonConvert.DeserializeObject<ErrorResponse>(MyCustomResponse.Data);
                        ErrorMsg = MyErrorResponse.Error;
                    }
                    MessageBox.Show(MyCustomResponse.HttpResponseCode.ToString() + " " + ErrorMsg);
                    Log.Error("Dashboard form btnStop_Click error: Cashier " + MyItem.cashierNr + " Host " + MyItem.host + " | " + MyCustomResponse.HttpResponseCode.ToString() + " - " + ErrorMsg, DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Dashboard form btnStop_Click exception:" + ex.Message, DateTime.Now);
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                CommonRequest MyItem = new CommonRequest { cashierNr = cashierNr, host = host };

                CustomResponse MyCustomResponse = await WinPanelAPIService.NextTicket(MyItem);
                if (MyCustomResponse.HttpResponseCode == 200) AssignTextboxes(JsonConvert.DeserializeObject<GetRefreshInfoResponse>(MyCustomResponse.Data));
                else
                {
                    string ErrorMsg = "";
                    if (MyCustomResponse.Data.Length > 0)
                    {
                        ErrorResponse MyErrorResponse = JsonConvert.DeserializeObject<ErrorResponse>(MyCustomResponse.Data);
                        ErrorMsg = MyErrorResponse.Error;
                    }
                    MessageBox.Show(MyCustomResponse.HttpResponseCode.ToString() + " " + ErrorMsg);
                    Log.Error("Dashboard form btnNext_Click error:: Cashier " + MyItem.cashierNr + " Host " + MyItem.host + " | " + MyCustomResponse.HttpResponseCode.ToString() + " - " + ErrorMsg, DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Dashboard form btnNext_Click exception:" + ex.Message, DateTime.Now);
                MessageBox.Show(ex.Message);
            }
        }

        private void AssignTextboxes(GetRefreshInfoResponse MyGetRefreshInfoResponse)
        {
            try
            {
                switch (MyGetRefreshInfoResponse.queue)
                {
                    case 0:
                        txtwaitingCustomersMQ.BackColor = Color.Red;
                        txtwaitingCustomersBQ.BackColor = Color.Red;
                        break;
                    case 1:
                        txtwaitingCustomersMQ.BackColor = Color.Green;
                        txtwaitingCustomersBQ.BackColor = Color.Red;
                        break;
                    case 2:
                        txtwaitingCustomersMQ.BackColor = Color.Red;
                        txtwaitingCustomersBQ.BackColor = Color.Green;
                        break;
                }

                ThreadHelperClass.SetText(this, txtCashier, MyGetRefreshInfoResponse.cashierNr);              
                ThreadHelperClass.SetText(this, txtwaitingCustomersMQ, MyGetRefreshInfoResponse.waitingCustomersMQ);
                ThreadHelperClass.SetText(this, txtwaitingCustomersBQ, MyGetRefreshInfoResponse.waitingCustomersBQ);
                ThreadHelperClass.SetText(this, txtServiceName, MyGetRefreshInfoResponse.serviceTypeName);
                ThreadHelperClass.SetText(this, txtQueue, MyGetRefreshInfoResponse.customersInQueue);
                ThreadHelperClass.SetText(this, txtTicketNo, MyGetRefreshInfoResponse.ticketNr);
                ThreadHelperClass.SetText(this, txtCustomerText, MyGetRefreshInfoResponse.customerText);
            }
            catch (Exception ex)
            {
                Log.Error("Dashboard form AssignTextboxes exception:" + ex.Message, DateTime.Now);
            }
        }

        private void prioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopTimer();
            var MyfrmPrio = new frmPrio(cashierNr, host).ShowDialog();
            StartTimer();
        }

        private async void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LogoutRequest MyItem = new LogoutRequest { cashierNr = cashierNr, host = host, windowsUser = windowsUser };

                CustomResponse MyCustomResponse = await WinPanelAPIService.Logout(MyItem);
                if (MyCustomResponse.HttpResponseCode == 200)
                {
                    StopTimer();
                    new frmLogin().Show();
                    this.Hide();
                }
                else
                {
                    string ErrorMsg = "";
                    if (MyCustomResponse.Data.Length > 0)
                    {
                        ErrorResponse MyErrorResponse = JsonConvert.DeserializeObject<ErrorResponse>(MyCustomResponse.Data);
                        ErrorMsg = MyErrorResponse.Error;
                    }
                    MessageBox.Show(MyCustomResponse.HttpResponseCode.ToString() + " " + ErrorMsg);
                    Log.Error("Dashboard form logoutToolStripMenuItem_Click error: Cashier " + MyItem.cashierNr + " Host " + MyItem.host + " | " + MyCustomResponse.HttpResponseCode.ToString() + " - " + ErrorMsg, DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Dashboard form logoutToolStripMenuItem_Click exception:" + ex.Message, DateTime.Now);
                MessageBox.Show(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopTimer();
            Application.Exit();
        }

        private void pnlDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlDashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnlDashboard_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopTimer();
        }
    }
}
