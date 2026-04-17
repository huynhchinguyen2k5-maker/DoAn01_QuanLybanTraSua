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
    public partial class frmChonBaoCao : Form
    {
        public frmChonBaoCao()
        {
            InitializeComponent();
        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmThongkeDoanhThu)
                {
                    f.Activate();
                    return;
                }
            }

            frmThongkeDoanhThu frm = new frmThongkeDoanhThu();
            frm.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmThongKeSanPham)
                {
                    f.Activate();
                    return;
                }
            }

            frmThongKeSanPham frm = new frmThongKeSanPham();
            frm.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmThongKeNhanVien)
                {
                    f.Activate();
                    return;
                }
            }

            frmThongKeNhanVien frm = new frmThongKeNhanVien();
            frm.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmThongKeKhachHang)
                {
                    f.Activate();
                    return;
                }
            }

            frmThongKeKhachHang frm = new frmThongKeKhachHang();
            frm.Show();
        }
    }
}
