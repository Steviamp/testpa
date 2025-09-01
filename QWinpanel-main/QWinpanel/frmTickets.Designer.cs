
namespace Login_and_Register
{
    partial class frmTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTickets));
            btnSave = new Button();
            btnClose = new Label();
            pnlTickets = new Panel();
            GridTickets = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColTicket = new DataGridViewTextBoxColumn();
            pnlTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridTickets).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Black;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(131, 322);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(216, 35);
            btnSave.TabIndex = 15;
            btnSave.Text = "CALL TICKET";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(446, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(29, 25);
            btnClose.TabIndex = 18;
            btnClose.Text = "✕";
            btnClose.Click += btnClose_Click;
            // 
            // pnlTickets
            // 
            pnlTickets.BorderStyle = BorderStyle.FixedSingle;
            pnlTickets.Controls.Add(GridTickets);
            pnlTickets.Location = new Point(0, 0);
            pnlTickets.Name = "pnlTickets";
            pnlTickets.Size = new Size(482, 364);
            pnlTickets.TabIndex = 22;
            pnlTickets.MouseDown += pnlPrio_MouseDown;
            pnlTickets.MouseMove += pnlPrio_MouseMove;
            pnlTickets.MouseUp += pnlPrio_MouseUp;
            // 
            // GridTickets
            // 
            GridTickets.AllowUserToAddRows = false;
            GridTickets.AllowUserToDeleteRows = false;
            GridTickets.BorderStyle = BorderStyle.None;
            GridTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridTickets.Columns.AddRange(new DataGridViewColumn[] { ColId, ColTicket });
            GridTickets.Cursor = Cursors.Hand;
            GridTickets.Location = new Point(3, 37);
            GridTickets.Name = "GridTickets";
            GridTickets.ReadOnly = true;
            GridTickets.Size = new Size(472, 274);
            GridTickets.TabIndex = 0;
            // 
            // ColId
            // 
            ColId.DataPropertyName = "ticketTrack";
            ColId.HeaderText = "Id";
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Visible = false;
            ColId.Width = 50;
            // 
            // ColTicket
            // 
            ColTicket.DataPropertyName = "ticketNr";
            ColTicket.HeaderText = "Tickets";
            ColTicket.Name = "ColTicket";
            ColTicket.ReadOnly = true;
            ColTicket.Width = 400;
            // 
            // frmTickets
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 364);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(pnlTickets);
            Cursor = Cursors.SizeAll;
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmTickets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QWinpanel tickets";
            Load += frmTickets_Load;
            pnlTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label btnClose;
        private Panel pnlTickets;
        private DataGridView GridTickets;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColTicket;
    }
}