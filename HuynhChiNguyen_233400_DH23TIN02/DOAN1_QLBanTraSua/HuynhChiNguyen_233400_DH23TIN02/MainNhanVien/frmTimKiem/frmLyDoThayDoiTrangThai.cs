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
using static System.Net.Mime.MediaTypeNames;

namespace HuynhChiNguyen_233400_DH23TIN02
{
    public partial class frmLyDoThayDoiTrangThai : Form
    {

        string maTS, tenTS;
        bool moBanLai; // true = bán lại, false = ngừng bán
        public frmLyDoThayDoiTrangThai(string mats, string tents, bool moBanLai)
        {
            InitializeComponent();
            maTS = mats;
            tenTS = tents;
            this.moBanLai = moBanLai;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtLyDo.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập lý do!");
                return;
            }

            using (SqlConnection kn = ChuoiKN.GetConnection())
            {
                kn.Open();

                // 1️⃣ Cập nhật trạng thái trà sữa
                string update = "UPDATE TRASUA SET TRANGTHAI = @tt WHERE MATS = @mats";
                SqlCommand cmd = new SqlCommand(update, kn);
                cmd.Parameters.AddWithValue("@tt", moBanLai ? 1 : 0);
                cmd.Parameters.AddWithValue("@mats", maTS);
                cmd.ExecuteNonQuery();

                // 2️⃣ Ghi vào NHATKY
                string log = @"INSERT INTO NHATKY(TENTK, PHANLOAI, HANHDONG)
                           VALUES(@tentk, N'SANPHAM', @hanhdong)";
                SqlCommand cmdLog = new SqlCommand(log, kn);

                cmdLog.Parameters.AddWithValue("@tentk", frmDangNhap.TenDangNhap); // tài khoản đang login

                string hanhDong = moBanLai
                    ? $"Mở bán lại {tenTS} – Lý do: {txtLyDo.Text}"
                    : $"Ngừng bán {tenTS} – Lý do: {txtLyDo.Text}";

                cmdLog.Parameters.AddWithValue("@hanhdong", hanhDong);

                cmdLog.ExecuteNonQuery();
            }

            MessageBox.Show("Cập nhật trạng thái thành công!");
            this.Close();
        }

        private void frmLyDoThayDoiTrangThai_Load(object sender, EventArgs e)
        {

        }
    }
}
