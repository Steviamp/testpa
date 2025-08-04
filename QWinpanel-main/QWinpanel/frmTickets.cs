using Newtonsoft.Json;
using QWinpanel.services.Requests;
using QWinpanel.services.Responses;
using QWinpanel.services;
using QWinpanel.Services.Responses;
using QWinpanel.Services.Requests;
using Serilog;

namespace Login_and_Register
{
    public partial class frmTickets : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public string cashierNr = "";
        public string host = "";
        public int queue = 0;

        public frmTickets(string MycashierNr, string Myhost, int Myqueue)
        {
            cashierNr = MycashierNr;
            host = Myhost;
            queue = Myqueue;
            InitializeComponent();
        }
        private async void frmTickets_Load(object sender, EventArgs e)
        {
            await InitPage();
        }

        private async Task InitPage()
        {
            try
            {
                GetTicketsRequest MyItem = new GetTicketsRequest { cashierNr = cashierNr, host = host, queue = queue };

                CustomResponse MyCustomResponse = await WinPanelAPIService.GetTickets(MyItem);
                if (MyCustomResponse.HttpResponseCode == 200)
                {
                    List<GetTicketsResponse> MyGetTicketsResponse = JsonConvert.DeserializeObject<List<GetTicketsResponse>>(MyCustomResponse.Data);
                    GridTickets.AutoGenerateColumns = false;
                    GridTickets.DataSource = MyGetTicketsResponse;
                    GridTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                    Log.Error("Tickets form InitPage error: Cashier " + MyItem.cashierNr + " Host " + MyItem.host + " | " + MyCustomResponse.HttpResponseCode.ToString() + " - " + ErrorMsg, DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Tickets form InitPage exception:" + ex.Message, DateTime.Now);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            bool CloseForm = false;

            try
            {
                if (GridTickets.SelectedRows.Count == 1)
                {
                    CallTicketRequest MyItem = new CallTicketRequest { cashierNr = cashierNr, host = host, ticketTrack = (int)GridTickets.SelectedRows[0].Cells[0].Value };
                    CustomResponse MyCustomResponse = await WinPanelAPIService.CallTicket(MyItem);
                    if (MyCustomResponse.HttpResponseCode == 200) CloseForm = true;
                    else
                    {
                        string ErrorMsg = "";
                        if (MyCustomResponse.Data.Length > 0)
                        {
                            ErrorResponse MyErrorResponse = JsonConvert.DeserializeObject<ErrorResponse>(MyCustomResponse.Data);
                            ErrorMsg = MyErrorResponse.Error;
                        }
                        MessageBox.Show(MyCustomResponse.HttpResponseCode.ToString() + " " + ErrorMsg);
                        Log.Error("Tickets form btnSave_Click error: Cashier " + MyItem.cashierNr + " Host " + MyItem.host + " | " + MyCustomResponse.HttpResponseCode.ToString() + " - " + ErrorMsg, DateTime.Now);
                    }
                }
                else CloseForm = true;
            }
            catch (Exception ex) { 
                CloseForm = true;
                Log.Error("Tickets form btnSave_Click exception:" + ex.Message, DateTime.Now);
            }

            if (CloseForm)
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pnlPrio_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlPrio_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnlPrio_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }        
    }
}
