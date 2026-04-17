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
    public partial class frmTKNhatKy : Form
    {
        public string PhamVi { get; private set; }
        public frmTKNhatKy()
        {
            InitializeComponent();
        }

        private void frmTKNhatKy_Load(object sender, EventArgs e)
        {
            cmbLoai.Items.Add("LOGIN");
            cmbLoai.Items.Add("TAIKHOAN");
            cmbLoai.Items.Add("NHANVIEN");
            cmbLoai.Items.Add("KHACHHANG");
            cmbLoai.Items.Add("SANPHAM");
            cmbLoai.Items.Add("KHUYENMAI");
            cmbLoai.Items.Add("HOADON");
            cmbLoai.Items.Add("BANHANG");

            cmbLoai.SelectedIndex = -1;

        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            PhamVi = cmbLoai.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
