using Guna.Charts.WinForms;
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
using static System.Collections.Specialized.BitVector32;

namespace HuynhChiNguyen_233400_DH23TIN02
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        //Phương thức Load DataGridView
        private void LoadDTGV()
        {
            using (SqlConnection KN = ChuoiKN.GetConnection())
            {

                string Query = @"SELECT HD.MAHD, HD.NGAYLAP, HD.MANV, KH.TENKH, KM.TENKM, TS.TENTS, CT.DONGIA, CT.SOLUONG, HD.GIAMGIA, HD.TONGTIEN, HD.THANHTOAN, HD.TRANGTHAI
                                 FROM HOADON HD
                                 LEFT JOIN KHUYENMAI KM ON HD.MAKM = KM.MAKM
                                 JOIN CHITIETHOADON CT ON HD.MAHD = CT.MAHD
                                 JOIN KHACHHANG KH ON HD.MAKH = KH.MAKH
                                 JOIN TRASUA TS ON CT.MATS = TS.MATS
                                 WHERE HD.MANV = @MANV AND HD.TRANGTHAI = N'DA THANH TOAN'
                                 ORDER BY HD.MAHD DESC";

                SqlDataAdapter BoDocGhi = new SqlDataAdapter(Query, KN);

                BoDocGhi.SelectCommand.Parameters.AddWithValue("@MANV", frmDangNhap.MaNhanVienDangNhap);

                DataSet dsHD = new DataSet();

                BoDocGhi.Fill(dsHD);

                dtgvHD.DataSource = dsHD.Tables[0];
                dtgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dtgvHD.DefaultCellStyle.ForeColor = Color.Black;
                dtgvHD.DefaultCellStyle.BackColor = Color.White;
                dtgvHD.DefaultCellStyle.SelectionForeColor = Color.White;
                dtgvHD.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;

                dtgvHD.Columns["DONGIA"].DefaultCellStyle.Format = "N0";
                dtgvHD.Columns["GIAMGIA"].DefaultCellStyle.Format = "N0";
                dtgvHD.Columns["TONGTIEN"].DefaultCellStyle.Format = "N0";
                dtgvHD.Columns["THANHTOAN"].DefaultCellStyle.Format = "N0";


                dtgvHD.Columns["MAHD"].HeaderText = "Mã hóa đơn";
                dtgvHD.Columns["NGAYLAP"].HeaderText = "Ngày lập";
                dtgvHD.Columns["MANV"].HeaderText = "Mã nhân viên";
                dtgvHD.Columns["TENKH"].HeaderText = "Tên khách hàng";
                dtgvHD.Columns["TENKM"].HeaderText = "Tên khuyến mãi";
                dtgvHD.Columns["TENTS"].HeaderText = "Tên trà sữa";
                dtgvHD.Columns["DONGIA"].HeaderText = "Đơn giá";
                dtgvHD.Columns["SOLUONG"].HeaderText = "Số lượng";
                dtgvHD.Columns["GIAMGIA"].HeaderText = "Giảm giá";
                dtgvHD.Columns["TONGTIEN"].HeaderText = "Tổng tiền";
                dtgvHD.Columns["THANHTOAN"].HeaderText = "Thanh toán";
                dtgvHD.Columns["TRANGTHAI"].HeaderText = "Trạng thái";

                dtgvHD.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
                dtgvHD.ColumnHeadersHeight = 40;

            }
        }

        //Khóa nút
        private void KhoaNut()
        {
            txtMaHD.ReadOnly = true;
            txtNhanVien.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            txtTenKM.ReadOnly = true;
            dtpkNgayLap.Enabled = false;
            txtTenTS.ReadOnly = true;
            nupSL.Enabled = false;
            txtDonGia.ReadOnly = true;
            txtGiamGia.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtThanhToan.ReadOnly = true;
            txtTrangThai.ReadOnly = true;
        }

        //Timg HD
        private void TimHoaDon(string tukhoa, string phamvi)
        {
            using (SqlConnection KN = ChuoiKN.GetConnection())
            {

                string dk = "";

                if (phamvi == "Tên khách hàng")
                    dk = "AND KH.TENKH LIKE @kw";

                else if (phamvi == "Tên trà sữa")
                    dk = "AND TS.TENTS LIKE @kw";

                else if (phamvi == "Tên khuyến mãi")
                    dk = "AND KM.TENKM LIKE @kw";

                else if (phamvi == "Số lượng")
                    dk = "AND CT.SOLUONG = @sl";

                else if (phamvi == "Ngày lập")
                    dk = "AND CONVERT(date, HD.NGAYLAP) = @ngay";

                string query = $@"SELECT HD.MAHD, HD.NGAYLAP, HD.MANV, KH.TENKH, KM.TENKM,
                                         TS.TENTS, CT.DONGIA, CT.SOLUONG,
                                         HD.GIAMGIA, HD.TONGTIEN, HD.THANHTOAN, HD.TRANGTHAI
                                   FROM HOADON HD
                                   LEFT JOIN KHUYENMAI KM ON HD.MAKM = KM.MAKM
                                   JOIN CHITIETHOADON CT ON HD.MAHD = CT.MAHD
                                   JOIN KHACHHANG KH ON HD.MAKH = KH.MAKH
                                   JOIN TRASUA TS ON CT.MATS = TS.MATS
                                   WHERE HD.MANV = @MANV AND HD.TRANGTHAI = N'DA THANH TOAN'
                                   {dk}
                                   ORDER BY HD.MAHD DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, KN);
                da.SelectCommand.Parameters.AddWithValue("@MANV", frmDangNhap.MaNhanVienDangNhap);

                // Gán tham số theo loại tìm
                if (phamvi == "Số lượng")
                {
                    if (int.TryParse(tukhoa, out int sl))
                        da.SelectCommand.Parameters.AddWithValue("@sl", sl);
                    else
                    {
                        MessageBox.Show("Số lượng phải là số!");
                        return;
                    }
                }
                else if (phamvi == "Ngày lập")
                {
                    if (DateTime.TryParse(tukhoa, out DateTime ngay))
                        da.SelectCommand.Parameters.AddWithValue("@ngay", ngay.Date);
                    else
                    {
                        MessageBox.Show("Ngày lập không hợp lệ! (vd: 03/02/2026)");
                        return;
                    }
                }
                else
                {
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" + tukhoa + "%");
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgvHD.DataSource = dt;
            }
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadDTGV();
            KhoaNut();
        }

        private void dtgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dtgvHD.Rows[e.RowIndex];

            txtMaHD.Text = Convert.ToString(row.Cells["MAHD"].Value);
            txtNhanVien.Text = Convert.ToString(row.Cells["MANV"].Value);
            txtTenKH.Text = Convert.ToString(row.Cells["TENKH"].Value);
            txtTenKM.Text = Convert.ToString(row.Cells["TENKM"].Value);
            txtTenTS.Text = Convert.ToString(row.Cells["TENTS"].Value);
            txtDonGia.Text = row.Cells["DONGIA"].Value == DBNull.Value ? "" : string.Format("{0:N0}", row.Cells["DONGIA"].Value);
            txtGiamGia.Text = row.Cells["GIAMGIA"].Value == DBNull.Value ? "" : string.Format("{0:N0}", row.Cells["GIAMGIA"].Value);
            txtTongTien.Text = row.Cells["TONGTIEN"].Value == DBNull.Value ? "" : string.Format("{0:N0}", row.Cells["TONGTIEN"].Value);
            txtThanhToan.Text = row.Cells["THANHTOAN"].Value == DBNull.Value ? "" : string.Format("{0:N0}", row.Cells["THANHTOAN"].Value);

            txtTrangThai.Text = Convert.ToString(row.Cells["TRANGTHAI"].Value);

            dtpkNgayLap.Value = row.Cells["NGAYLAP"].Value == DBNull.Value? DateTime.Now:Convert.ToDateTime(row.Cells["NGAYLAP"].Value);

            nupSL.Value = row.Cells["SOLUONG"].Value == DBNull.Value? 0: Convert.ToDecimal(row.Cells["SOLUONG"].Value);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (btnTim.Text == "Xem tất cả")
            {
                LoadDTGV();
                btnTim.Text = "Tìm kiếm";
                return;
            }

            frmTimHD frm = new frmTimHD();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                TimHoaDon(frm.TuKhoa, frm.PhamVi);
                btnTim.Text = "Xem tất cả";
            }
        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
