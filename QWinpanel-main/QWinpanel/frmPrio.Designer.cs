
namespace Login_and_Register
{
    partial class frmPrio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrio));
            btnSave = new Button();
            btnClose = new Label();
            pnlPrio = new Panel();
            GridServices = new DataGridView();
            ColSelected = new DataGridViewCheckBoxColumn();
            ColId = new DataGridViewTextBoxColumn();
            ColService = new DataGridViewTextBoxColumn();
            pnlPrio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridServices).BeginInit();
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
            btnSave.Text = "SAVE";
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
            // pnlPrio
            // 
            pnlPrio.BorderStyle = BorderStyle.FixedSingle;
            pnlPrio.Controls.Add(GridServices);
            pnlPrio.Location = new Point(0, 0);
            pnlPrio.Name = "pnlPrio";
            pnlPrio.Size = new Size(482, 364);
            pnlPrio.TabIndex = 22;
            pnlPrio.MouseDown += pnlPrio_MouseDown;
            pnlPrio.MouseMove += pnlPrio_MouseMove;
            pnlPrio.MouseUp += pnlPrio_MouseUp;
            // 
            // GridServices
            // 
            GridServices.AllowUserToAddRows = false;
            GridServices.AllowUserToDeleteRows = false;
            GridServices.BorderStyle = BorderStyle.None;
            GridServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridServices.Columns.AddRange(new DataGridViewColumn[] { ColSelected, ColId, ColService });
            GridServices.Cursor = Cursors.Hand;
            GridServices.Location = new Point(3, 37);
            GridServices.Name = "GridServices";
            GridServices.ReadOnly = true;
            GridServices.Size = new Size(472, 274);
            GridServices.TabIndex = 0;
            // 
            // ColSelected
            // 
            ColSelected.DataPropertyName = "selected";
            ColSelected.HeaderText = "Selected";
            ColSelected.Name = "ColSelected";
            ColSelected.ReadOnly = true;
            ColSelected.Resizable = DataGridViewTriState.True;
            ColSelected.SortMode = DataGridViewColumnSortMode.Automatic;
            ColSelected.Visible = false;
            ColSelected.Width = 70;
            // 
            // ColId
            // 
            ColId.DataPropertyName = "id";
            ColId.HeaderText = "Id";
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Visible = false;
            ColId.Width = 50;
            // 
            // ColService
            // 
            ColService.DataPropertyName = "name";
            ColService.HeaderText = "Service";
            ColService.Name = "ColService";
            ColService.ReadOnly = true;
            ColService.Width = 400;
            // 
            // frmPrio
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 364);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(pnlPrio);
            Cursor = Cursors.SizeAll;
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmPrio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QWinpanel prio";
            Load += frmPrio_Load;
            pnlPrio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label btnClose;
        private Panel pnlPrio;
        private DataGridView GridServices;
        private DataGridViewCheckBoxColumn ColSelected;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColService;
    }
}