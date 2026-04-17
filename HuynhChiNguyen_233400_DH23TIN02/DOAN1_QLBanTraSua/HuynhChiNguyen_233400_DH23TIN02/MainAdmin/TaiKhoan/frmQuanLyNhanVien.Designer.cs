namespace HuynhChiNguyen_233400_DH23TIN02
{
    partial class frmQuanLyNhanVien
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
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.grbThongTinNV = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbTenTK = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpkNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbThoat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).BeginInit();
            this.grbThongTinNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1167, 285);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(321, 64);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa nhân viên";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnThem.BorderRadius = 10;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(1167, 195);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(321, 64);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm nhân viên";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgvNV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvNV.ColumnHeadersHeight = 30;
            this.dtgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvNV.Location = new System.Drawing.Point(140, 474);
            this.dtgvNV.Name = "dtgvNV";
            this.dtgvNV.RowHeadersVisible = false;
            this.dtgvNV.RowHeadersWidth = 51;
            this.dtgvNV.RowTemplate.Height = 24;
            this.dtgvNV.Size = new System.Drawing.Size(1262, 319);
            this.dtgvNV.TabIndex = 22;
            this.dtgvNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvNV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvNV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvNV.ThemeStyle.HeaderStyle.Height = 30;
            this.dtgvNV.ThemeStyle.ReadOnly = false;
            this.dtgvNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvNV.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNV_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(592, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(592, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã nhân viên:";
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
            this.cmbTrangThai.Location = new System.Drawing.Point(759, 204);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(259, 36);
            this.cmbTrangThai.TabIndex = 16;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cmbGioiTinh.BorderRadius = 10;
            this.cmbGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.cmbGioiTinh.ItemHeight = 30;
            this.cmbGioiTinh.Location = new System.Drawing.Point(193, 204);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(210, 36);
            this.cmbGioiTinh.TabIndex = 15;
            // 
            // grbThongTinNV
            // 
            this.grbThongTinNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grbThongTinNV.BorderRadius = 10;
            this.grbThongTinNV.Controls.Add(this.txtSDT);
            this.grbThongTinNV.Controls.Add(this.cmbTenTK);
            this.grbThongTinNV.Controls.Add(this.dtpkNgaySinh);
            this.grbThongTinNV.Controls.Add(this.label7);
            this.grbThongTinNV.Controls.Add(this.label6);
            this.grbThongTinNV.Controls.Add(this.label5);
            this.grbThongTinNV.Controls.Add(this.label4);
            this.grbThongTinNV.Controls.Add(this.label3);
            this.grbThongTinNV.Controls.Add(this.label2);
            this.grbThongTinNV.Controls.Add(this.label1);
            this.grbThongTinNV.Controls.Add(this.cmbTrangThai);
            this.grbThongTinNV.Controls.Add(this.cmbGioiTinh);
            this.grbThongTinNV.Controls.Add(this.txtTenNV);
            this.grbThongTinNV.Controls.Add(this.txtMaNV);
            this.grbThongTinNV.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grbThongTinNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grbThongTinNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinNV.ForeColor = System.Drawing.Color.White;
            this.grbThongTinNV.Location = new System.Drawing.Point(58, 104);
            this.grbThongTinNV.Name = "grbThongTinNV";
            this.grbThongTinNV.Size = new System.Drawing.Size(1042, 333);
            this.grbThongTinNV.TabIndex = 21;
            this.grbThongTinNV.Text = "Thông tin nhân viên";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtSDT.BorderRadius = 10;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(759, 62);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(259, 48);
            this.txtSDT.TabIndex = 27;
            // 
            // cmbTenTK
            // 
            this.cmbTenTK.BackColor = System.Drawing.Color.Transparent;
            this.cmbTenTK.BorderRadius = 10;
            this.cmbTenTK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenTK.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenTK.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenTK.ForeColor = System.Drawing.Color.Black;
            this.cmbTenTK.ItemHeight = 30;
            this.cmbTenTK.Location = new System.Drawing.Point(759, 136);
            this.cmbTenTK.Name = "cmbTenTK";
            this.cmbTenTK.Size = new System.Drawing.Size(259, 36);
            this.cmbTenTK.TabIndex = 26;
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.BorderRadius = 10;
            this.dtpkNgaySinh.Checked = true;
            this.dtpkNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtpkNgaySinh.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.dtpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkNgaySinh.Location = new System.Drawing.Point(193, 261);
            this.dtpkNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(332, 36);
            this.dtpkNgaySinh.TabIndex = 25;
            this.dtpkNgaySinh.Value = new System.DateTime(2026, 1, 24, 15, 44, 53, 658);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(592, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tên tài khoản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày sinh:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtTenNV.BorderRadius = 10;
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNV.DefaultText = "";
            this.txtTenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.Black;
            this.txtTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Location = new System.Drawing.Point(193, 132);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PlaceholderText = "";
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.Size = new System.Drawing.Size(311, 48);
            this.txtTenNV.TabIndex = 10;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtMaNV.BorderRadius = 10;
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNV.DefaultText = "";
            this.txtMaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.Black;
            this.txtMaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.Location = new System.Drawing.Point(193, 62);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PlaceholderText = "";
            this.txtMaNV.SelectedText = "";
            this.txtMaNV.Size = new System.Drawing.Size(311, 48);
            this.txtMaNV.TabIndex = 11;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BorderRadius = 10;
            this.btnCapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(1167, 375);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(321, 62);
            this.btnCapNhat.TabIndex = 25;
            this.btnCapNhat.Text = "Cập nhật thông tin";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(140, 22);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(1262, 58);
            this.guna2HtmlLabel5.TabIndex = 20;
            this.guna2HtmlLabel5.Text = "QUẢN LÝ THÔNG TIN NHÂN VIÊN";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbThoat
            // 
            this.lbThoat.AutoSize = true;
            this.lbThoat.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoat.ForeColor = System.Drawing.Color.Red;
            this.lbThoat.Location = new System.Drawing.Point(1486, 9);
            this.lbThoat.Name = "lbThoat";
            this.lbThoat.Size = new System.Drawing.Size(41, 37);
            this.lbThoat.TabIndex = 29;
            this.lbThoat.Text = "X";
            this.lbThoat.Click += new System.EventHandler(this.lbThoat_Click);
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1540, 824);
            this.Controls.Add(this.lbThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgvNV);
            this.Controls.Add(this.grbThongTinNV);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmQuanLyNhanVien_Activated);
            this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).EndInit();
            this.grbThongTinNV.ResumeLayout(false);
            this.grbThongTinNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTrangThai;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGioiTinh;
        private Guna.UI2.WinForms.Guna2GroupBox grbThongTinNV;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNV;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNV;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTenTK;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private System.Windows.Forms.Label lbThoat;
    }
}