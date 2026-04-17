using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuynhChiNguyen_233400_DH23TIN02
{
    public partial class frmTimHD : Form
    {
        public string TuKhoa { get; private set; }
        public string PhamVi { get; private set; }
        public frmTimHD()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
                return;
            }

            TuKhoa = txtNhap.Text.Trim();
            PhamVi = cmbLoai.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmTimHD_Load(object sender, EventArgs e)
        {
            cmbLoai.Items.Add("Tên khách hàng");
            cmbLoai.Items.Add("Tên trà sữa");
            cmbLoai.Items.Add("Tên khuyến mãi");
            cmbLoai.Items.Add("Số lượng");
            cmbLoai.Items.Add("Ngày lập");

            cmbLoai.SelectedIndex = -1;

            txtNhap.Focus();
        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
