using Newtonsoft.Json;
using QWinpanel.services.Requests;
using QWinpanel.services.Responses;
using QWinpanel.services;
using QWinpanel.Services.Responses;
using QWinpanel.Services.Requests;
using Serilog;

namespace Login_and_Register
{
    public partial class frmPrio : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public string cashierNr = "";
        public string host = "";

        public frmPrio(string MycashierNr, string Myhost)
        {
            cashierNr = MycashierNr;
            host = Myhost;
            InitializeComponent();
        }
        private async void frmPrio_Load(object sender, EventArgs e)
        {
            await InitPage();
        }

        private async Task InitPage()
        {
            try
            {
                CommonRequest MyItem = new CommonRequest { cashierNr = cashierNr, host = host };

                CustomResponse MyCustomResponse = await WinPanelAPIService.GetPriority(MyItem);
                if (MyCustomResponse.HttpResponseCode == 200)
                {
                    List<GetPriorityResponse> MyGetPriorityResponse = JsonConvert.DeserializeObject<List<GetPriorityResponse>>(MyCustomResponse.Data);
                    GridServices.AutoGenerateColumns = false;
                    GridServices.DataSource = MyGetPriorityResponse;
                    GridServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    for (int x = 0; x < GridServices.Rows.Count; x++)
                    {
                        if (Convert.ToBoolean(GridServices.Rows[x].Cells[0].Value))
                        {
                            GridServices.Rows[x].Selected = true;
                            GridServices.CurrentCell = GridServices[2, x];
                        }
                    }
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
                    Log.Error("Prio form InitPage error: Cashier " + MyItem.cashierNr + " Host " + MyItem.host + " | " + MyCustomResponse.HttpResponseCode.ToString() + " - " + ErrorMsg, DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Prio form InitPage exception:" + ex.Message, DateTime.Now);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            bool CloseForm = false;

            try
            {
                if (GridServices.SelectedRows.Count == 1)
                {
                    if (!Convert.ToBoolean(GridServices.SelectedRows[0].Cells[0].Value))
                    {
                        UpdatePriorityRequest MyItem = new UpdatePriorityRequest { cashierNr = cashierNr, host = host, newPriority = (int)GridServices.SelectedRows[0].Cells[1].Value };
                        CustomResponse MyCustomResponse = await WinPanelAPIService.UpdatePriority(MyItem);
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
                            Log.Error("Prio form btnSave_Click error: Cashier " + MyItem.cashierNr + " Host " + MyItem.host + " | " + MyCustomResponse.HttpResponseCode.ToString() + " - " + ErrorMsg, DateTime.Now);
                        }
                    }
                    else CloseForm = true;
                }
                else CloseForm = true;
            }
            catch (Exception ex) { 
                CloseForm = true;
                Log.Error("Prio form btnSave_Click exception:" + ex.Message, DateTime.Now);
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
