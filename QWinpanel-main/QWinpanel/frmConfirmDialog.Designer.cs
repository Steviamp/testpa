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
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(50, 50);
            lblMessage.MaximumSize = new Size(260, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(109, 20);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Υπάρχει διαθέσιμο ραντεβού για το χρονικό διάστημα";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(150, 120);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(100, 28);
            btnAccept.TabIndex = 1;
            btnAccept.Text = "Αποδοχή";
            btnAccept.Click += btnAccept_Click;
            // 
            // btnReject
            // 
            btnReject.Location = new Point(280, 120);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(100, 28);
            btnReject.TabIndex = 2;
            btnReject.Text = "Απόρριψη";
            btnReject.Click += btnReject_Click;
            // 
            // frmConfirmDialog
            // 
            ClientSize = new Size(500, 200);
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