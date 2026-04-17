namespace HuynhChiNguyen_233400_DH23TIN02
{
    partial class frmThongkeDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkNgayBD = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpkNgayKT = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnXem = new Guna.UI2.WinForms.Guna2Button();
            this.grbTT = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbChuaTT = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbThanhToan = new System.Windows.Forms.Label();
            this.lbHoaDon = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.btnInBaoCao = new Guna.UI2.WinForms.Guna2Button();
            this.btnThangNay = new Guna.UI2.WinForms.Guna2Button();
            this.btnNamNay = new Guna.UI2.WinForms.Guna2Button();
            this.btnHomNay = new Guna.UI2.WinForms.Guna2Button();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grbTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1488, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(598, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "BÁO CÁO - THỐNG KÊ DOANH THU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpkNgayBD
            // 
            this.dtpkNgayBD.BorderRadius = 10;
            this.dtpkNgayBD.Checked = true;
            this.dtpkNgayBD.FillColor = System.Drawing.Color.BlueViolet;
            this.dtpkNgayBD.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkNgayBD.Location = new System.Drawing.Point(181, 144);
            this.dtpkNgayBD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkNgayBD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkNgayBD.Name = "dtpkNgayBD";
            this.dtpkNgayBD.Size = new System.Drawing.Size(335, 36);
            this.dtpkNgayBD.TabIndex = 2;
            this.dtpkNgayBD.Value = new System.DateTime(2026, 2, 5, 15, 24, 17, 318);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đến ngày:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Từ ngày:";
            // 
            // dtpkNgayKT
            // 
            this.dtpkNgayKT.BorderRadius = 10;
            this.dtpkNgayKT.Checked = true;
            this.dtpkNgayKT.FillColor = System.Drawing.Color.Salmon;
            this.dtpkNgayKT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkNgayKT.Location = new System.Drawing.Point(181, 217);
            this.dtpkNgayKT.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkNgayKT.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkNgayKT.Name = "dtpkNgayKT";
            this.dtpkNgayKT.Size = new System.Drawing.Size(335, 36);
            this.dtpkNgayKT.TabIndex = 7;
            this.dtpkNgayKT.Value = new System.DateTime(2026, 2, 5, 15, 24, 17, 318);
            // 
            // btnXem
            // 
            this.btnXem.BorderRadius = 10;
            this.btnXem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(181, 277);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(240, 47);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "Xem doanh thu";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // grbTT
            // 
            this.grbTT.BorderRadius = 10;
            this.grbTT.Controls.Add(this.lbChuaTT);
            this.grbTT.Controls.Add(this.label7);
            this.grbTT.Controls.Add(this.lbThanhToan);
            this.grbTT.Controls.Add(this.lbHoaDon);
            this.grbTT.Controls.Add(this.label12);
            this.grbTT.Controls.Add(this.label11);
            this.grbTT.Controls.Add(this.label10);
            this.grbTT.Controls.Add(this.lbTongTien);
            this.grbTT.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grbTT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grbTT.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTT.ForeColor = System.Drawing.Color.White;
            this.grbTT.Location = new System.Drawing.Point(34, 356);
            this.grbTT.Name = "grbTT";
            this.grbTT.Size = new System.Drawing.Size(712, 291);
            this.grbTT.TabIndex = 9;
            this.grbTT.Text = "Tổng doanh thu";
            // 
            // lbChuaTT
            // 
            this.lbChuaTT.AutoSize = true;
            this.lbChuaTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbChuaTT.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChuaTT.Location = new System.Drawing.Point(361, 166);
            this.lbChuaTT.Name = "lbChuaTT";
            this.lbChuaTT.Size = new System.Drawing.Size(55, 29);
            this.lbChuaTT.TabIndex = 22;
            this.lbChuaTT.Text = ".......";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "Hóa đơn chưa thanh toán:";
            // 
            // lbThanhToan
            // 
            this.lbThanhToan.AutoSize = true;
            this.lbThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbThanhToan.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhToan.Location = new System.Drawing.Point(361, 120);
            this.lbThanhToan.Name = "lbThanhToan";
            this.lbThanhToan.Size = new System.Drawing.Size(55, 29);
            this.lbThanhToan.TabIndex = 20;
            this.lbThanhToan.Text = ".......";
            // 
            // lbHoaDon
            // 
            this.lbHoaDon.AutoSize = true;
            this.lbHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbHoaDon.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoaDon.Location = new System.Drawing.Point(361, 70);
            this.lbHoaDon.Name = "lbHoaDon";
            this.lbHoaDon.Size = new System.Drawing.Size(55, 29);
            this.lbHoaDon.TabIndex = 19;
            this.lbHoaDon.Text = ".......";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(60, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 29);
            this.label12.TabIndex = 17;
            this.label12.Text = "Tổng doanh thu:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(60, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 29);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tổng số hóa đơn:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(60, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 29);
            this.label10.TabIndex = 15;
            this.label10.Text = "Hóa đơn đã thanh toán:";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbTongTien.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(361, 216);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(55, 29);
            this.lbTongTien.TabIndex = 14;
            this.lbTongTien.Text = ".......";
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.BorderRadius = 10;
            this.btnInBaoCao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInBaoCao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInBaoCao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInBaoCao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInBaoCao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnInBaoCao.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnInBaoCao.Location = new System.Drawing.Point(245, 687);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(227, 80);
            this.btnInBaoCao.TabIndex = 16;
            this.btnInBaoCao.Text = "IN BÁO CÁO";
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // btnThangNay
            // 
            this.btnThangNay.BorderRadius = 10;
            this.btnThangNay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThangNay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThangNay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThangNay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThangNay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThangNay.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThangNay.ForeColor = System.Drawing.Color.White;
            this.btnThangNay.Location = new System.Drawing.Point(547, 209);
            this.btnThangNay.Name = "btnThangNay";
            this.btnThangNay.Size = new System.Drawing.Size(199, 47);
            this.btnThangNay.TabIndex = 19;
            this.btnThangNay.Text = "Tháng này";
            this.btnThangNay.Click += new System.EventHandler(this.btnThangNay_Click);
            // 
            // btnNamNay
            // 
            this.btnNamNay.BorderRadius = 10;
            this.btnNamNay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNamNay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNamNay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNamNay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNamNay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNamNay.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNamNay.ForeColor = System.Drawing.Color.White;
            this.btnNamNay.Location = new System.Drawing.Point(547, 277);
            this.btnNamNay.Name = "btnNamNay";
            this.btnNamNay.Size = new System.Drawing.Size(199, 47);
            this.btnNamNay.TabIndex = 20;
            this.btnNamNay.Text = "Năm nay";
            this.btnNamNay.Click += new System.EventHandler(this.btnNamNay_Click);
            // 
            // btnHomNay
            // 
            this.btnHomNay.BorderRadius = 10;
            this.btnHomNay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHomNay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHomNay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHomNay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHomNay.FillColor = System.Drawing.Color.MediumPurple;
            this.btnHomNay.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomNay.ForeColor = System.Drawing.Color.White;
            this.btnHomNay.Location = new System.Drawing.Point(547, 143);
            this.btnHomNay.Name = "btnHomNay";
            this.btnHomNay.Size = new System.Drawing.Size(199, 47);
            this.btnHomNay.TabIndex = 21;
            this.btnHomNay.Text = "Hôm nay";
            this.btnHomNay.Click += new System.EventHandler(this.btnHomNay_Click);
            // 
            // chartThongKe
            // 
            chartArea1.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend1);
            this.chartThongKe.Location = new System.Drawing.Point(790, 143);
            this.chartThongKe.Name = "chartThongKe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartThongKe.Series.Add(series1);
            this.chartThongKe.Size = new System.Drawing.Size(709, 624);
            this.chartThongKe.TabIndex = 24;
            this.chartThongKe.Text = "Biểu đồ thống kê";
            // 
            // frmThongkeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1542, 788);
            this.Controls.Add(this.chartThongKe);
            this.Controls.Add(this.btnHomNay);
            this.Controls.Add(this.btnNamNay);
            this.Controls.Add(this.btnThangNay);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.grbTT);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dtpkNgayKT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpkNgayBD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThongkeDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doang thu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThongkeDoanhThu_Load);
            this.grbTT.ResumeLayout(false);
            this.grbTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkNgayBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkNgayKT;
        private Guna.UI2.WinForms.Guna2Button btnXem;
        private Guna.UI2.WinForms.Guna2GroupBox grbTT;
        private Guna.UI2.WinForms.Guna2Button btnInBaoCao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbThanhToan;
        private System.Windows.Forms.Label lbHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnThangNay;
        private Guna.UI2.WinForms.Guna2Button btnNamNay;
        private Guna.UI2.WinForms.Guna2Button btnHomNay;
        private System.Windows.Forms.Label lbChuaTT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
    }
}