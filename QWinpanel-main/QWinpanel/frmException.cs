using Newtonsoft.Json;
using QWinpanel.services.Requests;
using QWinpanel.services.Responses;
using QWinpanel.services;
using QWinpanel.Services.Responses;
using QWinpanel.Services.Requests;
using Serilog;

namespace Login_and_Register
{
    public partial class frmException : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public string ErrorMsg = "";       

        public frmException(string MyErrorMsg)
        {
            ErrorMsg = MyErrorMsg;
            InitializeComponent();
        }
        private void frmException_Load(object sender, EventArgs e)
        {
            txtError.Text = ErrorMsg;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
