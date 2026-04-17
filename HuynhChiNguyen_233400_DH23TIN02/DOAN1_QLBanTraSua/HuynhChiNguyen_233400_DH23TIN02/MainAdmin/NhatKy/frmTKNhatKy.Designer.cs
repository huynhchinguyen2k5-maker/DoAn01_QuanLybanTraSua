namespace HuynhChiNguyen_233400_DH23TIN02
{
    partial class frmTKNhatKy
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
            this.btnTim = new Guna.UI2.WinForms.Guna2Button();
            this.cmbLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbThoat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.BorderRadius = 10;
            this.btnTim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(300, 318);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(209, 62);
            this.btnTim.TabIndex = 14;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cmbLoai
            // 
            this.cmbLoai.BackColor = System.Drawing.Color.Transparent;
            this.cmbLoai.BorderRadius = 10;
            this.cmbLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoai.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoai.ForeColor = System.Drawing.Color.Black;
            this.cmbLoai.ItemHeight = 30;
            this.cmbLoai.Location = new System.Drawing.Point(342, 206);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(295, 36);
            this.cmbLoai.TabIndex = 12;
            // 
            // lbThoat
            // 
            this.lbThoat.AutoSize = true;
            this.lbThoat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoat.ForeColor = System.Drawing.Color.Red;
            this.lbThoat.Location = new System.Drawing.Point(769, 9);
            this.lbThoat.Name = "lbThoat";
            this.lbThoat.Size = new System.Drawing.Size(34, 32);
            this.lbThoat.TabIndex = 11;
            this.lbThoat.Text = "X";
            this.lbThoat.Click += new System.EventHandler(this.lbThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Phạm vi tìm kiếm:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "TÌM KIẾM NHẬT KÝ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTKNhatKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(815, 459);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cmbLoai);
            this.Controls.Add(this.lbThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTKNhatKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTKNhatKy";
            this.Load += new System.EventHandler(this.frmTKNhatKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnTim;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLoai;
        private System.Windows.Forms.Label lbThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}