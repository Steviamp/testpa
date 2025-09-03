namespace QWinpanel
{
    public partial class frmConfirmDialog : Form
    {
        public bool Accepted { get; private set; } = false;
        private System.Windows.Forms.Timer autoCloseTimer;
        private int countdown = 10;

        public frmConfirmDialog(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;

            autoCloseTimer = new System.Windows.Forms.Timer();
            autoCloseTimer.Interval = 1000; // 1 δευτερόλεπτο
            autoCloseTimer.Tick += AutoCloseTimer_Tick;
            autoCloseTimer.Start();
        }

        private void AutoCloseTimer_Tick(object? sender, EventArgs e)
        {
            countdown--;

            if (countdown <= 0)
            {
                autoCloseTimer.Stop();
                Accepted = false;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
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
