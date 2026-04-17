namespace HuynhChiNguyen_233400_DH23TIN02
{
    partial class frmInChiTietHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.rpvInHD = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbThoat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1325, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rpvInHD
            // 
            this.rpvInHD.Location = new System.Drawing.Point(106, 188);
            this.rpvInHD.Name = "rpvInHD";
            this.rpvInHD.ServerReport.BearerToken = null;
            this.rpvInHD.Size = new System.Drawing.Size(1332, 589);
            this.rpvInHD.TabIndex = 1;
            // 
            // lbThoat
            // 
            this.lbThoat.AutoSize = true;
            this.lbThoat.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoat.ForeColor = System.Drawing.Color.Red;
            this.lbThoat.Location = new System.Drawing.Point(1486, 18);
            this.lbThoat.Name = "lbThoat";
            this.lbThoat.Size = new System.Drawing.Size(42, 38);
            this.lbThoat.TabIndex = 2;
            this.lbThoat.Text = "X";
            this.lbThoat.Click += new System.EventHandler(this.lbThoat_Click);
            // 
            // frmInChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1540, 816);
            this.Controls.Add(this.lbThoat);
            this.Controls.Add(this.rpvInHD);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In hóa đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInChiTietHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvInHD;
        private System.Windows.Forms.Label lbThoat;
    }
}