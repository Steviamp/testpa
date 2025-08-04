
namespace Login_and_Register
{
    partial class frmLogin
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnLogin = new Button();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblLogin = new Label();
            btnClose = new Label();
            btnOtherUser = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblBack = new Label();
            pnlLogin = new Panel();
            lblVersion = new Label();
            lblCopryright = new Label();
            imgCashier = new PictureBox();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgCashier).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(34, 260);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(216, 35);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(34, 137);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 12;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.Gray;
            lblUsername.Location = new Point(31, 108);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(68, 17);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Log on as";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Black;
            lblLogin.Location = new Point(59, 52);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(169, 30);
            lblLogin.TabIndex = 6;
            lblLogin.Text = "Winpanel Login";
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(246, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(29, 25);
            btnClose.TabIndex = 18;
            btnClose.Text = "✕";
            btnClose.Click += btnClose_Click;
            // 
            // btnOtherUser
            // 
            btnOtherUser.BackColor = Color.Silver;
            btnOtherUser.BackgroundImageLayout = ImageLayout.None;
            btnOtherUser.Cursor = Cursors.Hand;
            btnOtherUser.FlatStyle = FlatStyle.Flat;
            btnOtherUser.ForeColor = Color.Black;
            btnOtherUser.Location = new Point(33, 168);
            btnOtherUser.Name = "btnOtherUser";
            btnOtherUser.Size = new Size(216, 35);
            btnOtherUser.TabIndex = 14;
            btnOtherUser.Text = "Other user";
            btnOtherUser.UseVisualStyleBackColor = false;
            btnOtherUser.Click += btnOtherUser_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(34, 205);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 20;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.Gray;
            lblPassword.Location = new Point(32, 178);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(66, 17);
            lblPassword.TabIndex = 19;
            lblPassword.Text = "Password";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Cursor = Cursors.Hand;
            lblBack.FlatStyle = FlatStyle.Flat;
            lblBack.ForeColor = Color.Black;
            lblBack.Location = new Point(123, 302);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(36, 17);
            lblBack.TabIndex = 21;
            lblBack.Text = "Back";
            lblBack.Click += lblBack_Click;
            // 
            // pnlLogin
            // 
            pnlLogin.BorderStyle = BorderStyle.FixedSingle;
            pnlLogin.Controls.Add(lblVersion);
            pnlLogin.Controls.Add(lblCopryright);
            pnlLogin.Controls.Add(imgCashier);
            pnlLogin.Controls.Add(btnOtherUser);
            pnlLogin.Controls.Add(lblLogin);
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(280, 364);
            pnlLogin.TabIndex = 22;
            pnlLogin.MouseDown += pnlLogin_MouseDown;
            pnlLogin.MouseMove += pnlLogin_MouseMove;
            pnlLogin.MouseUp += pnlLogin_MouseUp;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVersion.ForeColor = Color.Black;
            lblVersion.Location = new Point(224, 336);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(13, 13);
            lblVersion.TabIndex = 24;
            lblVersion.Text = "v";
            // 
            // lblCopryright
            // 
            lblCopryright.AutoSize = true;
            lblCopryright.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCopryright.Location = new Point(3, 336);
            lblCopryright.Name = "lblCopryright";
            lblCopryright.Size = new Size(59, 13);
            lblCopryright.TabIndex = 23;
            lblCopryright.Text = "Copyright";
            // 
            // imgCashier
            // 
            imgCashier.Image = QWinpanel.Properties.Resources.logo;
            imgCashier.Location = new Point(31, 52);
            imgCashier.Name = "imgCashier";
            imgCashier.Size = new Size(32, 30);
            imgCashier.TabIndex = 23;
            imgCashier.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(280, 364);
            Controls.Add(lblBack);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(pnlLogin);
            Cursor = Cursors.SizeAll;
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QWinpanel";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgCashier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label btnClose;
        private Button btnOtherUser;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblBack;
        private Panel pnlLogin;
        private PictureBox imgCashier;
        private Label lblCopryright;
        private Label lblVersion;
    }
}