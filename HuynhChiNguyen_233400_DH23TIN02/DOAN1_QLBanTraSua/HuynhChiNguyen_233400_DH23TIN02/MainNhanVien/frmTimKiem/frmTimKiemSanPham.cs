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
    public partial class frmTimKiemSanPham : Form
    {
        public string TuKhoa { get; private set; }
        public string PhamVi { get; private set; }

        public frmTimKiemSanPham()
        {
            InitializeComponent();
        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimKiemSanPham_Load(object sender, EventArgs e)
        {
            cmbLoai.Items.Add("Tên trà sữa");
            cmbLoai.Items.Add("Đơn giá");
            cmbLoai.Items.Add("Loại trà sữa");
            cmbLoai.SelectedIndex = -1;

            txtNhap.Focus();
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
    }
}
