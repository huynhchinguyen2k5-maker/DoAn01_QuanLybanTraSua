using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuynhChiNguyen_233400_DH23TIN02
{
    public partial class frmMainNhanVien : Form
    {
        string _ten;
        string _quyen;
        public frmMainNhanVien(string ten, string quyen)
        {
            InitializeComponent();
            _ten = ten;
            _quyen = quyen;
        }
        public frmMainNhanVien()
        {
            InitializeComponent();
        }

        private void frmMainNhanVien_Load(object sender, EventArgs e)
        {
            lbQuyen.Text = _quyen;
            lbTen.Text = _ten;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDN = new frmDangNhap();
            frmDN.Show();
            this.Hide();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)

                if (f.Name == "frmThongTinNhanVien")
                {
                    f.Activate();
                    return;
                }
            frmThongTinNhanVien frmTTNV = new frmThongTinNhanVien();
            frmTTNV.MdiParent = this.MdiParent;
            frmTTNV.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)

                if (f.Name == "frmKhachHang")
                {
                    f.Activate();
                    return;
                }
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.MdiParent = this.MdiParent;
            frmKH.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)

                if (f.Name == "frmSanPham")
                {
                    f.Activate();
                    return;
                }
            frmSanPham frmKH = new frmSanPham();
            frmKH.MdiParent = this.MdiParent;
            frmKH.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)

                if (f.Name == "frmBanHang")
                {
                    f.Activate();
                    return;
                }
            frmBanHang frmKH = new frmBanHang();
            frmKH.MdiParent = this.MdiParent;
            frmKH.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)

                if (f.Name == "frmHoaDon")
                {
                    f.Activate();
                    return;
                }
            frmHoaDon frmKH = new frmHoaDon();
            frmKH.MdiParent = this.MdiParent;
            frmKH.Show();
        }

        private void frmMainNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (SqlConnection conn = ChuoiKN.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE TAIKHOAN SET DANGNHAP = 0 WHERE TENTK = @tentk";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tentk", frmDangNhap.TenDangNhap);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
