namespace HuynhChiNguyen_233400_DH23TIN02
{
    partial class frmQuanLyTraSua
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
            this.dtgvTS = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbLoaiTS = new Guna.UI2.WinForms.Guna2ComboBox();
            this.grbTraSua = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtDonGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenTS = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaTS = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbThoat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTS)).BeginInit();
            this.grbTraSua.SuspendLayout();
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
            this.btnXoa.Location = new System.Drawing.Point(1152, 289);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(324, 64);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa trà sữa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 10;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(1152, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(324, 64);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm trà sữa";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgvTS
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvTS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTS.ColumnHeadersHeight = 30;
            this.dtgvTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTS.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvTS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvTS.Location = new System.Drawing.Point(157, 460);
            this.dtgvTS.Name = "dtgvTS";
            this.dtgvTS.RowHeadersVisible = false;
            this.dtgvTS.RowHeadersWidth = 51;
            this.dtgvTS.RowTemplate.Height = 24;
            this.dtgvTS.Size = new System.Drawing.Size(1219, 337);
            this.dtgvTS.TabIndex = 22;
            this.dtgvTS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvTS.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvTS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvTS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvTS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvTS.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvTS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvTS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvTS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvTS.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvTS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvTS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvTS.ThemeStyle.HeaderStyle.Height = 30;
            this.dtgvTS.ThemeStyle.ReadOnly = false;
            this.dtgvTS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvTS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvTS.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvTS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvTS.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvTS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvTS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvTS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTS_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(586, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Loại trà sữa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(586, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên trà sữa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã trà sữa:";
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
            this.cmbTrangThai.Location = new System.Drawing.Point(734, 154);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(261, 36);
            this.cmbTrangThai.TabIndex = 16;
            // 
            // cmbLoaiTS
            // 
            this.cmbLoaiTS.BackColor = System.Drawing.Color.Transparent;
            this.cmbLoaiTS.BorderRadius = 10;
            this.cmbLoaiTS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoaiTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiTS.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiTS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiTS.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiTS.ForeColor = System.Drawing.Color.Black;
            this.cmbLoaiTS.ItemHeight = 30;
            this.cmbLoaiTS.Location = new System.Drawing.Point(734, 84);
            this.cmbLoaiTS.Name = "cmbLoaiTS";
            this.cmbLoaiTS.Size = new System.Drawing.Size(261, 36);
            this.cmbLoaiTS.TabIndex = 17;
            // 
            // grbTraSua
            // 
            this.grbTraSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grbTraSua.BorderRadius = 10;
            this.grbTraSua.Controls.Add(this.txtDonGia);
            this.grbTraSua.Controls.Add(this.label5);
            this.grbTraSua.Controls.Add(this.label4);
            this.grbTraSua.Controls.Add(this.label3);
            this.grbTraSua.Controls.Add(this.label2);
            this.grbTraSua.Controls.Add(this.label1);
            this.grbTraSua.Controls.Add(this.cmbTrangThai);
            this.grbTraSua.Controls.Add(this.cmbLoaiTS);
            this.grbTraSua.Controls.Add(this.txtTenTS);
            this.grbTraSua.Controls.Add(this.txtMaTS);
            this.grbTraSua.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grbTraSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grbTraSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTraSua.ForeColor = System.Drawing.Color.White;
            this.grbTraSua.Location = new System.Drawing.Point(65, 116);
            this.grbTraSua.Name = "grbTraSua";
            this.grbTraSua.Size = new System.Drawing.Size(1027, 327);
            this.grbTraSua.TabIndex = 21;
            this.grbTraSua.Text = "Thông tin trà sữa";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtDonGia.BorderRadius = 10;
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.DefaultText = "";
            this.txtDonGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDonGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDonGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.Black;
            this.txtDonGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.Location = new System.Drawing.Point(183, 218);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.SelectedText = "";
            this.txtDonGia.Size = new System.Drawing.Size(318, 48);
            this.txtDonGia.TabIndex = 23;
            // 
            // txtTenTS
            // 
            this.txtTenTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtTenTS.BorderRadius = 10;
            this.txtTenTS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTS.DefaultText = "";
            this.txtTenTS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenTS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenTS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTS.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTS.ForeColor = System.Drawing.Color.Black;
            this.txtTenTS.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTS.Location = new System.Drawing.Point(183, 150);
            this.txtTenTS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTS.Name = "txtTenTS";
            this.txtTenTS.PlaceholderText = "";
            this.txtTenTS.SelectedText = "";
            this.txtTenTS.Size = new System.Drawing.Size(318, 48);
            this.txtTenTS.TabIndex = 10;
            // 
            // txtMaTS
            // 
            this.txtMaTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtMaTS.BorderRadius = 10;
            this.txtMaTS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTS.DefaultText = "";
            this.txtMaTS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaTS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaTS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTS.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTS.ForeColor = System.Drawing.Color.Black;
            this.txtMaTS.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTS.Location = new System.Drawing.Point(183, 79);
            this.txtMaTS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaTS.Name = "txtMaTS";
            this.txtMaTS.PlaceholderText = "";
            this.txtMaTS.SelectedText = "";
            this.txtMaTS.Size = new System.Drawing.Size(318, 48);
            this.txtMaTS.TabIndex = 11;
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
            this.btnCapNhat.Location = new System.Drawing.Point(1152, 381);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(324, 62);
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
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(157, 25);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(1219, 58);
            this.guna2HtmlLabel5.TabIndex = 20;
            this.guna2HtmlLabel5.Text = "QUẢN LÝ SẢN PHẨM TRÀ SỮA";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbThoat
            // 
            this.lbThoat.AutoSize = true;
            this.lbThoat.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoat.ForeColor = System.Drawing.Color.Red;
            this.lbThoat.Location = new System.Drawing.Point(1484, 9);
            this.lbThoat.Name = "lbThoat";
            this.lbThoat.Size = new System.Drawing.Size(41, 37);
            this.lbThoat.TabIndex = 28;
            this.lbThoat.Text = "X";
            this.lbThoat.Click += new System.EventHandler(this.lbThoat_Click);
            // 
            // frmQuanLyTraSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1538, 841);
            this.Controls.Add(this.lbThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgvTS);
            this.Controls.Add(this.grbTraSua);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQuanLyTraSua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyTraSua";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmQuanLyTraSua_Activated);
            this.Load += new System.EventHandler(this.frmQuanLyTraSua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTS)).EndInit();
            this.grbTraSua.ResumeLayout(false);
            this.grbTraSua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvTS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTrangThai;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLoaiTS;
        private Guna.UI2.WinForms.Guna2GroupBox grbTraSua;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTS;
        private Guna.UI2.WinForms.Guna2TextBox txtMaTS;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtDonGia;
        private System.Windows.Forms.Label lbThoat;
    }
}