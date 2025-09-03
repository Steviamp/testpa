namespace QWinpanel
{
    partial class frmConfirmDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private Label lblMessage;
        private Button btnAccept;
        private Button btnReject;
        private void InitializeComponent()
        {
            lblMessage = new Label();
            btnAccept = new Button();
            btnReject = new Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = false;
            lblMessage.Location = new Point(20, 20);
            lblMessage.MaximumSize = Size.Empty;
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(600, 28);
            lblMessage.TabIndex = 0;
            lblMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(360, 100);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(110, 32);
            btnAccept.TabIndex = 1;
            btnAccept.Text = "Αποδοχή";
            btnAccept.Click += btnAccept_Click;
            // 
            // btnReject
            // 
            btnReject.Location = new Point(480, 100);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(110, 32);
            btnReject.TabIndex = 2;
            btnReject.Text = "Απόρριψη";
            btnReject.Click += btnReject_Click;
            // 
            // frmConfirmDialog
            // 
            ClientSize = new Size(650, 160);
            Controls.Add(lblMessage);
            Controls.Add(btnAccept);
            Controls.Add(btnReject);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmConfirmDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Confirmation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


    }
}