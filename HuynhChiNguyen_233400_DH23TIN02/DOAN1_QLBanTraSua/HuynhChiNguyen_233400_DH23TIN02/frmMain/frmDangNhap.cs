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
    public partial class frmDangNhap : Form
    {
        public static string TenNhanVienDangNhap;
        public static string MaNhanVienDangNhap;
        public static string TenDangNhap;
        public static string VaiTroNguoiDung;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tentk = txtUsername.Text.Trim();
            string matkhau = txtPassword.Text.Trim();

            if (tentk == "" || matkhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            using (SqlConnection conn = ChuoiKN.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT TK.VAITRO, NV.TENNV, NV.MANV
                               FROM TAIKHOAN TK
                               JOIN NHANVIEN NV ON TK.TENTK = NV.TENTK
                               WHERE TK.TENTK = @tentk AND TK.MATKHAU = @mk
                               AND TK.TRANGTHAI = N'HOAT DONG'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tentk", tentk);
                cmd.Parameters.AddWithValue("@mk", matkhau);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    string vaiTro = rd["VAITRO"].ToString();
                    string tenHienThi = rd["TENNV"].ToString();
                    string maNV = rd["MANV"].ToString();

                    TenDangNhap = tentk;
                    VaiTroNguoiDung = vaiTro;
                    TenNhanVienDangNhap = tenHienThi;
                    MaNhanVienDangNhap = maNV;

                    rd.Close();

                    // Nếu là ADMIN → cho tất cả ADMIN khác OFFLINE
                    if (vaiTro == "ADMIN")
                    {
                        string sqlOfflineAdmin = @"UPDATE TAIKHOAN
                               SET DANGNHAP = 0
                               WHERE VAITRO = 'ADMIN'";

                        SqlCommand cmdOff = new SqlCommand(sqlOfflineAdmin, conn);
                        cmdOff.ExecuteNonQuery();
                    }

                    // Set ONLINE cho tài khoản đang đăng nhập
                    string sqlOnline = @"UPDATE TAIKHOAN
                     SET DANGNHAP = 1
                     WHERE TENTK = @tentk";

                    SqlCommand cmdOnline = new SqlCommand(sqlOnline, conn);
                    cmdOnline.Parameters.AddWithValue("@tentk", tentk);
                    cmdOnline.ExecuteNonQuery();


                    this.Hide();

                    if (vaiTro == "ADMIN")
                    {
                        frmMainAdmin frm = new frmMainAdmin(tenHienThi, vaiTro);
                        frm.Show();
                    }
                    else
                    {
                        frmMainNhanVien frm = new frmMainNhanVien(tenHienThi, vaiTro);
                        frm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
            }
        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
