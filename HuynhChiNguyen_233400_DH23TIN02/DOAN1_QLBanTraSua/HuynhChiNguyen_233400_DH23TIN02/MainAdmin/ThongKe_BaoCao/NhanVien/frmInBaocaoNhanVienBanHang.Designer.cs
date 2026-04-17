namespace HuynhChiNguyen_233400_DH23TIN02
{
    partial class frmInBaocaoNhanVienBanHang
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
            this.lbThoat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTenNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnXemBC = new Guna.UI2.WinForms.Guna2Button();
            this.rpvNV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // lbThoat
            // 
            this.lbThoat.AutoSize = true;
            this.lbThoat.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoat.ForeColor = System.Drawing.Color.Red;
            this.lbThoat.Location = new System.Drawing.Point(1485, 9);
            this.lbThoat.Name = "lbThoat";
            this.lbThoat.Size = new System.Drawing.Size(41, 37);
            this.lbThoat.TabIndex = 0;
            this.lbThoat.Text = "X";
            this.lbThoat.Click += new System.EventHandler(this.lbThoat_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(218, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1129, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "IN BÁO CÁO NHÂN VIÊN BÁN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn nhân viên:";
            // 
            // cmbTenNV
            // 
            this.cmbTenNV.BackColor = System.Drawing.Color.Transparent;
            this.cmbTenNV.BorderRadius = 10;
            this.cmbTenNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenNV.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenNV.ForeColor = System.Drawing.Color.Black;
            this.cmbTenNV.ItemHeight = 30;
            this.cmbTenNV.Location = new System.Drawing.Point(358, 172);
            this.cmbTenNV.Name = "cmbTenNV";
            this.cmbTenNV.Size = new System.Drawing.Size(282, 36);
            this.cmbTenNV.TabIndex = 3;
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
            this.btnXemBC.Location = new System.Drawing.Point(787, 163);
            this.btnXemBC.Name = "btnXemBC";
            this.btnXemBC.Size = new System.Drawing.Size(294, 45);
            this.btnXemBC.TabIndex = 4;
            this.btnXemBC.Text = "XEM BÁO CÁO";
            this.btnXemBC.Click += new System.EventHandler(this.btnXemBC_Click);
            // 
            // rpvNV
            // 
            this.rpvNV.Location = new System.Drawing.Point(116, 285);
            this.rpvNV.Name = "rpvNV";
            this.rpvNV.ServerReport.BearerToken = null;
            this.rpvNV.Size = new System.Drawing.Size(1307, 509);
            this.rpvNV.TabIndex = 5;
            // 
            // frmInBaocaoNhanVienBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1539, 821);
            this.Controls.Add(this.rpvNV);
            this.Controls.Add(this.btnXemBC);
            this.Controls.Add(this.cmbTenNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbThoat);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmInBaocaoNhanVienBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In báo cáo nhân viên bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInBaocaoNhanVienBanHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTenNV;
        private Guna.UI2.WinForms.Guna2Button btnXemBC;
        private Microsoft.Reporting.WinForms.ReportViewer rpvNV;
    }
}