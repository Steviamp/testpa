namespace QWinpanel
{
    public partial class frmConfirmDialog : Form
    {
        public bool Accepted { get; private set; } = false;

        public frmConfirmDialog(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Accepted = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Accepted = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
