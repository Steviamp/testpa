
namespace Login_and_Register
{
    partial class frmDashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            btnStop = new Button();
            txtServiceName = new TextBox();
            pnlDashboard = new Panel();
            txtwaitingCustomersBQ = new TextBox();
            txtwaitingCustomersMQ = new TextBox();
            imgCashier = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            prioToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            txtCashierImg = new TextBox();
            txtCashier = new TextBox();
            btnNext = new Button();
            txtCustomerText = new TextBox();
            txtTicketNo = new TextBox();
            txtQueue = new TextBox();
            pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgCashier).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Red;
            btnStop.Cursor = Cursors.Hand;
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatStyle = FlatStyle.Popup;
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(721, 11);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(99, 63);
            btnStop.TabIndex = 15;
            btnStop.Text = "STOP";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // txtServiceName
            // 
            txtServiceName.BackColor = Color.FromArgb(230, 231, 233);
            txtServiceName.BorderStyle = BorderStyle.FixedSingle;
            txtServiceName.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtServiceName.Location = new Point(163, 11);
            txtServiceName.Multiline = true;
            txtServiceName.Name = "txtServiceName";
            txtServiceName.ReadOnly = true;
            txtServiceName.Size = new Size(425, 28);
            txtServiceName.TabIndex = 12;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BorderStyle = BorderStyle.FixedSingle;
            pnlDashboard.Controls.Add(txtwaitingCustomersBQ);
            pnlDashboard.Controls.Add(txtwaitingCustomersMQ);
            pnlDashboard.Controls.Add(imgCashier);
            pnlDashboard.Controls.Add(txtCashierImg);
            pnlDashboard.Controls.Add(txtCashier);
            pnlDashboard.Controls.Add(btnNext);
            pnlDashboard.Controls.Add(txtCustomerText);
            pnlDashboard.Controls.Add(txtTicketNo);
            pnlDashboard.Controls.Add(txtQueue);
            pnlDashboard.Controls.Add(txtServiceName);
            pnlDashboard.Controls.Add(btnStop);
            pnlDashboard.Location = new Point(0, 0);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(938, 84);
            pnlDashboard.TabIndex = 22;
            pnlDashboard.MouseDown += pnlDashboard_MouseDown;
            pnlDashboard.MouseMove += pnlDashboard_MouseMove;
            pnlDashboard.MouseUp += pnlDashboard_MouseUp;
            // 
            // txtwaitingCustomersBQ
            // 
            txtwaitingCustomersBQ.BackColor = Color.FromArgb(230, 231, 233);
            txtwaitingCustomersBQ.BorderStyle = BorderStyle.FixedSingle;
            txtwaitingCustomersBQ.Cursor = Cursors.Hand;
            txtwaitingCustomersBQ.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtwaitingCustomersBQ.Location = new Point(117, 11);
            txtwaitingCustomersBQ.Multiline = true;
            txtwaitingCustomersBQ.Name = "txtwaitingCustomersBQ";
            txtwaitingCustomersBQ.ReadOnly = true;
            txtwaitingCustomersBQ.Size = new Size(40, 28);
            txtwaitingCustomersBQ.TabIndex = 29;
            txtwaitingCustomersBQ.TextAlign = HorizontalAlignment.Center;
            txtwaitingCustomersBQ.MouseDown += txtwaitingCustomersBQ_MouseDown;
            // 
            // txtwaitingCustomersMQ
            // 
            txtwaitingCustomersMQ.BackColor = Color.FromArgb(230, 231, 233);
            txtwaitingCustomersMQ.BorderStyle = BorderStyle.FixedSingle;
            txtwaitingCustomersMQ.Cursor = Cursors.Hand;
            txtwaitingCustomersMQ.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtwaitingCustomersMQ.Location = new Point(71, 11);
            txtwaitingCustomersMQ.Multiline = true;
            txtwaitingCustomersMQ.Name = "txtwaitingCustomersMQ";
            txtwaitingCustomersMQ.ReadOnly = true;
            txtwaitingCustomersMQ.Size = new Size(40, 28);
            txtwaitingCustomersMQ.TabIndex = 28;
            txtwaitingCustomersMQ.TextAlign = HorizontalAlignment.Center;
            txtwaitingCustomersMQ.MouseDown += txtwaitingCustomersMQ_MouseDown;
            // 
            // imgCashier
            // 
            imgCashier.BackColor = Color.FromArgb(230, 231, 233);
            imgCashier.ContextMenuStrip = contextMenuStrip1;
            imgCashier.Cursor = Cursors.Hand;
            imgCashier.Image = QWinpanel.Properties.Resources.cashier;
            imgCashier.Location = new Point(10, 12);
            imgCashier.Name = "imgCashier";
            imgCashier.Size = new Size(28, 28);
            imgCashier.TabIndex = 22;
            imgCashier.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { prioToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(113, 70);
            // 
            // prioToolStripMenuItem
            // 
            prioToolStripMenuItem.Name = "prioToolStripMenuItem";
            prioToolStripMenuItem.Size = new Size(112, 22);
            prioToolStripMenuItem.Text = "Prio";
            prioToolStripMenuItem.Click += prioToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(112, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(112, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // txtCashierImg
            // 
            txtCashierImg.BackColor = Color.White;
            txtCashierImg.BorderStyle = BorderStyle.FixedSingle;
            txtCashierImg.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCashierImg.Location = new Point(10, 11);
            txtCashierImg.Multiline = true;
            txtCashierImg.Name = "txtCashierImg";
            txtCashierImg.RightToLeft = RightToLeft.Yes;
            txtCashierImg.Size = new Size(28, 28);
            txtCashierImg.TabIndex = 23;
            // 
            // txtCashier
            // 
            txtCashier.BackColor = Color.FromArgb(230, 231, 233);
            txtCashier.BorderStyle = BorderStyle.FixedSingle;
            txtCashier.ContextMenuStrip = contextMenuStrip1;
            txtCashier.Cursor = Cursors.Hand;
            txtCashier.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCashier.Location = new Point(37, 11);
            txtCashier.Multiline = true;
            txtCashier.Name = "txtCashier";
            txtCashier.ReadOnly = true;
            txtCashier.RightToLeft = RightToLeft.Yes;
            txtCashier.Size = new Size(28, 28);
            txtCashier.TabIndex = 21;
            txtCashier.TextAlign = HorizontalAlignment.Center;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.ForestGreen;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(826, 11);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(99, 63);
            btnNext.TabIndex = 18;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // txtCustomerText
            // 
            txtCustomerText.BackColor = Color.FromArgb(230, 231, 233);
            txtCustomerText.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerText.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCustomerText.Location = new Point(9, 46);
            txtCustomerText.Multiline = true;
            txtCustomerText.Name = "txtCustomerText";
            txtCustomerText.ReadOnly = true;
            txtCustomerText.Size = new Size(706, 28);
            txtCustomerText.TabIndex = 17;
            // 
            // txtTicketNo
            // 
            txtTicketNo.BackColor = Color.FromArgb(230, 231, 233);
            txtTicketNo.BorderStyle = BorderStyle.FixedSingle;
            txtTicketNo.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTicketNo.Location = new Point(659, 11);
            txtTicketNo.Multiline = true;
            txtTicketNo.Name = "txtTicketNo";
            txtTicketNo.ReadOnly = true;
            txtTicketNo.Size = new Size(56, 28);
            txtTicketNo.TabIndex = 16;
            txtTicketNo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtQueue
            // 
            txtQueue.BackColor = Color.FromArgb(230, 231, 233);
            txtQueue.BorderStyle = BorderStyle.FixedSingle;
            txtQueue.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQueue.Location = new Point(594, 11);
            txtQueue.Multiline = true;
            txtQueue.Name = "txtQueue";
            txtQueue.ReadOnly = true;
            txtQueue.Size = new Size(59, 28);
            txtQueue.TabIndex = 15;
            txtQueue.TextAlign = HorizontalAlignment.Center;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(938, 84);
            Controls.Add(pnlDashboard);
            Cursor = Cursors.SizeAll;
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QWinpanel";
            FormClosed += frmDashboard_FormClosed;
            Load += frmDashboard_Load;
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgCashier).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtServiceName;
        private Panel pnlDashboard;
        private Button btnNext;
        private TextBox txtCustomerText;
        private TextBox txtTicketNo;
        private TextBox txtQueue;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem prioToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TextBox txtCashier;
        private PictureBox imgCashier;
        private TextBox txtCashierImg;
        private TextBox txtwaitingCustomersBQ;
        private TextBox txtwaitingCustomersMQ;
    }
}