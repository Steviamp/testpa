
namespace Login_and_Register
{
    partial class frmException
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmException));
            btnSave = new Button();
            btnClose = new Label();
            pnlException = new Panel();
            txtError = new TextBox();
            pnlException.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Black;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(131, 149);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(216, 35);
            btnSave.TabIndex = 15;
            btnSave.Text = "CONNECT";
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
            // pnlException
            // 
            pnlException.BorderStyle = BorderStyle.FixedSingle;
            pnlException.Controls.Add(txtError);
            pnlException.Location = new Point(0, 0);
            pnlException.Name = "pnlException";
            pnlException.Size = new Size(482, 208);
            pnlException.TabIndex = 22;
            pnlException.MouseDown += pnlPrio_MouseDown;
            pnlException.MouseMove += pnlPrio_MouseMove;
            pnlException.MouseUp += pnlPrio_MouseUp;
            // 
            // txtError
            // 
            txtError.BackColor = Color.FromArgb(230, 231, 233);
            txtError.BorderStyle = BorderStyle.FixedSingle;
            txtError.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtError.Location = new Point(11, 38);
            txtError.Multiline = true;
            txtError.Name = "txtError";
            txtError.ReadOnly = true;
            txtError.Size = new Size(458, 89);
            txtError.TabIndex = 13;
            // 
            // frmException
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 208);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(pnlException);
            Cursor = Cursors.SizeAll;
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmException";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QWinpanel exception";
            Load += frmException_Load;
            pnlException.ResumeLayout(false);
            pnlException.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label btnClose;
        private Panel pnlException;
        private TextBox txtError;
    }
}