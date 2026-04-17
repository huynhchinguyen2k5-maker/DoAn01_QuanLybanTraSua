namespace HuynhChiNguyen_233400_DH23TIN02
{
    partial class frmInBaoCaoKhachHang
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
            this.rpvKH = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnXemBC = new Guna.UI2.WinForms.Guna2Button();
            this.cmbTenKH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbThoat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rpvKH
            // 
            this.rpvKH.Location = new System.Drawing.Point(114, 307);
            this.rpvKH.Name = "rpvKH";
            this.rpvKH.ServerReport.BearerToken = null;
            this.rpvKH.Size = new System.Drawing.Size(1307, 509);
            this.rpvKH.TabIndex = 11;
            // 
            // btnXemBC
            // 
            this.btnXemBC.BorderRadius = 10;
            this.btnXemBC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXemBC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXemBC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemBC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXemBC.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnXemBC.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBC.ForeColor = System.Drawing.Color.White;
            this.btnXemBC.Location = new System.Drawing.Point(862, 185);
            this.btnXemBC.Name = "btnXemBC";
            this.btnXemBC.Size = new System.Drawing.Size(294, 45);
            this.btnXemBC.TabIndex = 10;
            this.btnXemBC.Text = "XEM BÁO CÁO";
            this.btnXemBC.Click += new System.EventHandler(this.btnXemBC_Click);
            // 
            // cmbTenKH
            // 
            this.cmbTenKH.BackColor = System.Drawing.Color.Transparent;
            this.cmbTenKH.BorderRadius = 10;
            this.cmbTenKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenKH.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTenKH.ItemHeight = 30;
            this.cmbTenKH.Location = new System.Drawing.Point(356, 194);
            this.cmbTenKH.Name = "cmbTenKH";
            this.cmbTenKH.Size = new System.Drawing.Size(282, 36);
            this.cmbTenKH.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chọn khách hàng:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(216, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1129, 69);
            this.label1.TabIndex = 7;
            this.label1.Text = "IN BÁO CÁO KHÁCH HÀNG CHI TIÊU TẠI CỬA HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbThoat
            // 
            this.lbThoat.AutoSize = true;
            this.lbThoat.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoat.ForeColor = System.Drawing.Color.Red;
            this.lbThoat.Location = new System.Drawing.Point(1492, 9);
            this.lbThoat.Name = "lbThoat";
            this.lbThoat.Size = new System.Drawing.Size(41, 37);
            this.lbThoat.TabIndex = 6;
            this.lbThoat.Text = "X";
            this.lbThoat.Click += new System.EventHandler(this.lbThoat_Click);
            // 
            // frmInBaoCaoKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1545, 846);
            this.Controls.Add(this.rpvKH);
            this.Controls.Add(this.btnXemBC);
            this.Controls.Add(this.cmbTenKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbThoat);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmInBaoCaoKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In báo cáo khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInBaoCaoKhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvKH;
        private Guna.UI2.WinForms.Guna2Button btnXemBC;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbThoat;
    }
}