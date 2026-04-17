using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HuynhChiNguyen_233400_DH23TIN02
{
    public partial class frmMatKhau : Form
    {
        public frmMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string mkCu = txtMKcu.Text.Trim();
            string mkMoi = txtMk.Text.Trim();
            string nhapLai = txtNhapLai.Text.Trim();

            if (mkCu == "" || mkMoi == "" || nhapLai == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (mkMoi.Length < 4)
            {
                MessageBox.Show("Mật khẩu mới phải từ 4 ký tự trở lên!");
                return;
            }

            if (mkMoi == mkCu)
            {
                MessageBox.Show("Mật khẩu mới không được trùng mật khẩu cũ!");
                return;
            }

            if (mkMoi != nhapLai)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn đổi mật khẩu?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;

            try
            {
                using (SqlConnection conn = ChuoiKN.GetConnection())
                {
                    conn.Open();

                    string sql = @"UPDATE TAIKHOAN 
                           SET MATKHAU = @mkMoi
                           WHERE TENTK = @tk AND MATKHAU = @mkCu";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@mkMoi", mkMoi);
                    cmd.Parameters.AddWithValue("@mkCu", mkCu);
                    cmd.Parameters.AddWithValue("@tk", frmDangNhap.TenDangNhap);

                    int kq = cmd.ExecuteNonQuery();

                    if (kq > 0)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!");

                        txtMKcu.Clear();
                        txtMk.Clear();
                        txtNhapLai.Clear();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMatKhau_Load(object sender, EventArgs e)
        {
        }
    }
}
