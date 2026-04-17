namespace HuynhChiNguyen_233400_DH23TIN02
{
    partial class frmQLHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvHD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.txtMaHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbKH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpkNgayLap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbKM = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtGiamGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.grbThongTinHD = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtThanhToan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTongTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.btnChiTirtHD = new Guna.UI2.WinForms.Guna2Button();
            this.lbThoat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHD)).BeginInit();
            this.grbThongTinHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(212, 22);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(1090, 58);
            this.guna2HtmlLabel5.TabIndex = 27;
            this.guna2HtmlLabel5.Text = "QUẢN LÝ THÔNG TIN HÓA ĐƠN";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThem
            // 
            this.btnThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnThem.BorderRadius = 10;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(1177, 108);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(321, 64);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Tạo hóa đơn";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgvHD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvHD.ColumnHeadersHeight = 30;
            this.dtgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvHD.Location = new System.Drawing.Point(40, 537);
            this.dtgvHD.Name = "dtgvHD";
            this.dtgvHD.RowHeadersVisible = false;
            this.dtgvHD.RowHeadersWidth = 51;
            this.dtgvHD.RowTemplate.Height = 24;
            this.dtgvHD.Size = new System.Drawing.Size(1458, 337);
            this.dtgvHD.TabIndex = 29;
            this.dtgvHD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvHD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvHD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvHD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvHD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvHD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvHD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvHD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvHD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvHD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvHD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvHD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvHD.ThemeStyle.HeaderStyle.Height = 30;
            this.dtgvHD.ThemeStyle.ReadOnly = false;
            this.dtgvHD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvHD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvHD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvHD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvHD.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvHD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvHD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHD_CellClick);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BorderRadius = 10;
            this.btnCapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(1177, 269);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(321, 62);
            this.btnCapNhat.TabIndex = 32;
            this.btnCapNhat.Text = "Cập nhật thông tin";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1177, 187);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(321, 64);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "Hủy hóa đơn";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaHD
            // 
            this.txtMaHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtMaHD.BorderRadius = 10;
            this.txtMaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHD.DefaultText = "";
            this.txtMaHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.ForeColor = System.Drawing.Color.Black;
            this.txtMaHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.Location = new System.Drawing.Point(220, 62);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.PlaceholderText = "";
            this.txtMaHD.SelectedText = "";
            this.txtMaHD.Size = new System.Drawing.Size(261, 48);
            this.txtMaHD.TabIndex = 11;
            // 
            // cmbNV
            // 
            this.cmbNV.BackColor = System.Drawing.Color.Transparent;
            this.cmbNV.BorderRadius = 10;
            this.cmbNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNV.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNV.ForeColor = System.Drawing.Color.Black;
            this.cmbNV.ItemHeight = 30;
            this.cmbNV.Location = new System.Drawing.Point(220, 193);
            this.cmbNV.Name = "cmbNV";
            this.cmbNV.Size = new System.Drawing.Size(261, 36);
            this.cmbNV.TabIndex = 15;
            // 
            // cmbKH
            // 
            this.cmbKH.BackColor = System.Drawing.Color.Transparent;
            this.cmbKH.BorderRadius = 10;
            this.cmbKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbKH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKH.ForeColor = System.Drawing.Color.Black;
            this.cmbKH.ItemHeight = 30;
            this.cmbKH.Location = new System.Drawing.Point(220, 250);
            this.cmbKH.Name = "cmbKH";
            this.cmbKH.Size = new System.Drawing.Size(261, 36);
            this.cmbKH.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ngày lập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(640, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(640, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Giảm giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tên khách hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tên khuyến mãi:";
            // 
            // dtpkNgayLap
            // 
            this.dtpkNgayLap.BorderRadius = 10;
            this.dtpkNgayLap.Checked = true;
            this.dtpkNgayLap.FillColor = System.Drawing.Color.White;
            this.dtpkNgayLap.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayLap.ForeColor = System.Drawing.Color.Black;
            this.dtpkNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkNgayLap.Location = new System.Drawing.Point(220, 133);
            this.dtpkNgayLap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkNgayLap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkNgayLap.Name = "dtpkNgayLap";
            this.dtpkNgayLap.Size = new System.Drawing.Size(325, 36);
            this.dtpkNgayLap.TabIndex = 25;
            this.dtpkNgayLap.Value = new System.DateTime(2026, 1, 24, 15, 44, 53, 658);
            // 
            // cmbKM
            // 
            this.cmbKM.BackColor = System.Drawing.Color.Transparent;
            this.cmbKM.BorderRadius = 10;
            this.cmbKM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKM.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbKM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbKM.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKM.ForeColor = System.Drawing.Color.Black;
            this.cmbKM.ItemHeight = 30;
            this.cmbKM.Location = new System.Drawing.Point(220, 310);
            this.cmbKM.Name = "cmbKM";
            this.cmbKM.Size = new System.Drawing.Size(261, 36);
            this.cmbKM.TabIndex = 26;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtGiamGia.BorderRadius = 10;
            this.txtGiamGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiamGia.DefaultText = "";
            this.txtGiamGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiamGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiamGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiamGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiamGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiamGia.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamGia.ForeColor = System.Drawing.Color.Black;
            this.txtGiamGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiamGia.Location = new System.Drawing.Point(783, 62);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.PlaceholderText = "";
            this.txtGiamGia.SelectedText = "";
            this.txtGiamGia.Size = new System.Drawing.Size(259, 48);
            this.txtGiamGia.TabIndex = 27;
            // 
            // grbThongTinHD
            // 
            this.grbThongTinHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grbThongTinHD.BorderRadius = 10;
            this.grbThongTinHD.Controls.Add(this.cmbTrangThai);
            this.grbThongTinHD.Controls.Add(this.txtThanhToan);
            this.grbThongTinHD.Controls.Add(this.txtTongTien);
            this.grbThongTinHD.Controls.Add(this.label10);
            this.grbThongTinHD.Controls.Add(this.label9);
            this.grbThongTinHD.Controls.Add(this.txtGiamGia);
            this.grbThongTinHD.Controls.Add(this.cmbKM);
            this.grbThongTinHD.Controls.Add(this.dtpkNgayLap);
            this.grbThongTinHD.Controls.Add(this.label7);
            this.grbThongTinHD.Controls.Add(this.label6);
            this.grbThongTinHD.Controls.Add(this.label5);
            this.grbThongTinHD.Controls.Add(this.label4);
            this.grbThongTinHD.Controls.Add(this.label3);
            this.grbThongTinHD.Controls.Add(this.label2);
            this.grbThongTinHD.Controls.Add(this.label1);
            this.grbThongTinHD.Controls.Add(this.cmbKH);
            this.grbThongTinHD.Controls.Add(this.cmbNV);
            this.grbThongTinHD.Controls.Add(this.txtMaHD);
            this.grbThongTinHD.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grbThongTinHD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grbThongTinHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinHD.ForeColor = System.Drawing.Color.White;
            this.grbThongTinHD.Location = new System.Drawing.Point(40, 108);
            this.grbThongTinHD.Name = "grbThongTinHD";
            this.grbThongTinHD.Size = new System.Drawing.Size(1089, 384);
            this.grbThongTinHD.TabIndex = 28;
            this.grbThongTinHD.Text = "Thông tin hóa đơn:";
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cmbTrangThai.BorderRadius = 10;
            this.cmbTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTrangThai.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrangThai.ForeColor = System.Drawing.Color.Black;
            this.cmbTrangThai.ItemHeight = 30;
            this.cmbTrangThai.Location = new System.Drawing.Point(783, 249);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(261, 36);
            this.cmbTrangThai.TabIndex = 33;
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtThanhToan.BorderRadius = 10;
            this.txtThanhToan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhToan.DefaultText = "";
            this.txtThanhToan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhToan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhToan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhToan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhToan.ForeColor = System.Drawing.Color.Black;
            this.txtThanhToan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhToan.Location = new System.Drawing.Point(783, 186);
            this.txtThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.PlaceholderText = "";
            this.txtThanhToan.SelectedText = "";
            this.txtThanhToan.Size = new System.Drawing.Size(259, 48);
            this.txtThanhToan.TabIndex = 32;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtTongTien.BorderRadius = 10;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.DefaultText = "";
            this.txtTongTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Black;
            this.txtTongTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTien.Location = new System.Drawing.Point(783, 124);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PlaceholderText = "";
            this.txtTongTien.SelectedText = "";
            this.txtTongTien.Size = new System.Drawing.Size(259, 48);
            this.txtTongTien.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(640, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "Thanh toán:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(640, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Trạng thái:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BorderRadius = 10;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.FillColor = System.Drawing.Color.YellowGreen;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(1177, 349);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(321, 62);
            this.btnThanhToan.TabIndex = 34;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnChiTirtHD
            // 
            this.btnChiTirtHD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnChiTirtHD.BorderRadius = 10;
            this.btnChiTirtHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTirtHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTirtHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChiTirtHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChiTirtHD.FillColor = System.Drawing.Color.BlueViolet;
            this.btnChiTirtHD.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTirtHD.ForeColor = System.Drawing.Color.White;
            this.btnChiTirtHD.Location = new System.Drawing.Point(1177, 428);
            this.btnChiTirtHD.Name = "btnChiTirtHD";
            this.btnChiTirtHD.Size = new System.Drawing.Size(321, 64);
            this.btnChiTirtHD.TabIndex = 35;
            this.btnChiTirtHD.Text = "Chi tiết hóa đơn";
            this.btnChiTirtHD.Click += new System.EventHandler(this.btnChiTirtHD_Click);
            // 
            // lbThoat
            // 
            this.lbThoat.AutoSize = true;
            this.lbThoat.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoat.ForeColor = System.Drawing.Color.Red;
            this.lbThoat.Location = new System.Drawing.Point(1481, 12);
            this.lbThoat.Name = "lbThoat";
            this.lbThoat.Size = new System.Drawing.Size(41, 37);
            this.lbThoat.TabIndex = 36;
            this.lbThoat.Text = "X";
            this.lbThoat.Click += new System.EventHandler(this.lbThoat_Click);
            // 
            // frmQLHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1535, 911);
            this.Controls.Add(this.lbThoat);
            this.Controls.Add(this.btnChiTirtHD);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgvHD);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grbThongTinHD);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQLHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLHoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmQLHoaDon_Activated);
            this.Load += new System.EventHandler(this.frmQLHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHD)).EndInit();
            this.grbThongTinHD.ResumeLayout(false);
            this.grbThongTinHD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvHD;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHD;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNV;
        private Guna.UI2.WinForms.Guna2ComboBox cmbKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkNgayLap;
        private Guna.UI2.WinForms.Guna2ComboBox cmbKM;
        private Guna.UI2.WinForms.Guna2TextBox txtGiamGia;
        private Guna.UI2.WinForms.Guna2GroupBox grbThongTinHD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTrangThai;
        private Guna.UI2.WinForms.Guna2TextBox txtThanhToan;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTien;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private Guna.UI2.WinForms.Guna2Button btnChiTirtHD;
        private System.Windows.Forms.Label lbThoat;
    }
}