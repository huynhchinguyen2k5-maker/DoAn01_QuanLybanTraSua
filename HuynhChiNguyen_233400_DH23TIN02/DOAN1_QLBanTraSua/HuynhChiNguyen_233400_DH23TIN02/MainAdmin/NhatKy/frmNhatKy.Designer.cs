namespace HuynhChiNguyen_233400_DH23TIN02
{
    partial class frmNhatKy
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
            this.lbThoat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbNhatKy = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmbTenTK = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbPhanLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txthanhDong = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpkThoiGian = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbHD = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvNhatKy = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.grbNhatKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhatKy)).BeginInit();
            this.SuspendLayout();
            // 
            // lbThoat
            // 
            this.lbThoat.AutoSize = true;
            this.lbThoat.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoat.ForeColor = System.Drawing.Color.Red;
            this.lbThoat.Location = new System.Drawing.Point(1492, 9);
            this.lbThoat.Name = "lbThoat";
            this.lbThoat.Size = new System.Drawing.Size(41, 37);
            this.lbThoat.TabIndex = 0;
            this.lbThoat.Text = "X";
            this.lbThoat.Click += new System.EventHandler(this.lbThoat_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1400, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "NHẬT KÝ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbNhatKy
            // 
            this.grbNhatKy.BorderRadius = 10;
            this.grbNhatKy.Controls.Add(this.cmbTenTK);
            this.grbNhatKy.Controls.Add(this.cmbPhanLoai);
            this.grbNhatKy.Controls.Add(this.txthanhDong);
            this.grbNhatKy.Controls.Add(this.dtpkThoiGian);
            this.grbNhatKy.Controls.Add(this.txtID);
            this.grbNhatKy.Controls.Add(this.label6);
            this.grbNhatKy.Controls.Add(this.lbHD);
            this.grbNhatKy.Controls.Add(this.label4);
            this.grbNhatKy.Controls.Add(this.label3);
            this.grbNhatKy.Controls.Add(this.label2);
            this.grbNhatKy.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grbNhatKy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grbNhatKy.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhatKy.ForeColor = System.Drawing.Color.White;
            this.grbNhatKy.Location = new System.Drawing.Point(45, 137);
            this.grbNhatKy.Name = "grbNhatKy";
            this.grbNhatKy.Size = new System.Drawing.Size(1173, 278);
            this.grbNhatKy.TabIndex = 2;
            this.grbNhatKy.Text = "Thông tin nhật ký";
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
            this.cmbTenTK.Location = new System.Drawing.Point(166, 190);
            this.cmbTenTK.Name = "cmbTenTK";
            this.cmbTenTK.Size = new System.Drawing.Size(250, 36);
            this.cmbTenTK.TabIndex = 10;
            // 
            // cmbPhanLoai
            // 
            this.cmbPhanLoai.BackColor = System.Drawing.Color.Transparent;
            this.cmbPhanLoai.BorderRadius = 10;
            this.cmbPhanLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPhanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhanLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPhanLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPhanLoai.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPhanLoai.ForeColor = System.Drawing.Color.Black;
            this.cmbPhanLoai.ItemHeight = 30;
            this.cmbPhanLoai.Location = new System.Drawing.Point(697, 151);
            this.cmbPhanLoai.Name = "cmbPhanLoai";
            this.cmbPhanLoai.Size = new System.Drawing.Size(254, 36);
            this.cmbPhanLoai.TabIndex = 9;
            // 
            // txthanhDong
            // 
            this.txthanhDong.BorderRadius = 10;
            this.txthanhDong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthanhDong.DefaultText = "";
            this.txthanhDong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txthanhDong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txthanhDong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthanhDong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthanhDong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txthanhDong.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthanhDong.ForeColor = System.Drawing.Color.Black;
            this.txthanhDong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txthanhDong.Location = new System.Drawing.Point(697, 54);
            this.txthanhDong.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txthanhDong.Name = "txthanhDong";
            this.txthanhDong.PlaceholderForeColor = System.Drawing.Color.White;
            this.txthanhDong.PlaceholderText = "";
            this.txthanhDong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txthanhDong.SelectedText = "";
            this.txthanhDong.Size = new System.Drawing.Size(446, 69);
            this.txthanhDong.TabIndex = 8;
            // 
            // dtpkThoiGian
            // 
            this.dtpkThoiGian.BorderRadius = 10;
            this.dtpkThoiGian.Checked = true;
            this.dtpkThoiGian.FillColor = System.Drawing.Color.CornflowerBlue;
            this.dtpkThoiGian.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkThoiGian.Location = new System.Drawing.Point(166, 128);
            this.dtpkThoiGian.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkThoiGian.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkThoiGian.Name = "dtpkThoiGian";
            this.dtpkThoiGian.Size = new System.Drawing.Size(342, 36);
            this.dtpkThoiGian.TabIndex = 6;
            this.dtpkThoiGian.Value = new System.DateTime(2026, 2, 26, 19, 1, 26, 675);
            // 
            // txtID
            // 
            this.txtID.BorderRadius = 10;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(166, 54);
            this.txtID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtID.Name = "txtID";
            this.txtID.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(250, 45);
            this.txtID.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(566, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phân loại:";
            // 
            // lbHD
            // 
            this.lbHD.AutoSize = true;
            this.lbHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbHD.Location = new System.Drawing.Point(566, 66);
            this.lbHD.Name = "lbHD";
            this.lbHD.Size = new System.Drawing.Size(123, 25);
            this.lbHD.TabIndex = 3;
            this.lbHD.Text = "Hành động:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(44, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên TK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(44, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thời gian:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(44, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // dtgvNhatKy
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvNhatKy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvNhatKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvNhatKy.ColumnHeadersHeight = 4;
            this.dtgvNhatKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvNhatKy.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvNhatKy.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvNhatKy.Location = new System.Drawing.Point(45, 466);
            this.dtgvNhatKy.Name = "dtgvNhatKy";
            this.dtgvNhatKy.RowHeadersVisible = false;
            this.dtgvNhatKy.RowHeadersWidth = 51;
            this.dtgvNhatKy.RowTemplate.Height = 24;
            this.dtgvNhatKy.Size = new System.Drawing.Size(1456, 332);
            this.dtgvNhatKy.TabIndex = 3;
            this.dtgvNhatKy.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvNhatKy.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvNhatKy.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvNhatKy.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvNhatKy.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvNhatKy.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvNhatKy.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvNhatKy.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvNhatKy.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvNhatKy.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvNhatKy.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvNhatKy.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvNhatKy.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvNhatKy.ThemeStyle.ReadOnly = false;
            this.dtgvNhatKy.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvNhatKy.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvNhatKy.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvNhatKy.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvNhatKy.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvNhatKy.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvNhatKy.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvNhatKy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNhatKy_CellClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BorderRadius = 10;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(1254, 250);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(217, 67);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmNhatKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1545, 822);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dtgvNhatKy);
            this.Controls.Add(this.grbNhatKy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbThoat);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNhatKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhật ký";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhatKy_Load);
            this.grbNhatKy.ResumeLayout(false);
            this.grbNhatKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhatKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbThoat;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox grbNhatKy;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvNhatKy;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPhanLoai;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkThoiGian;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTenTK;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txthanhDong;
    }
}