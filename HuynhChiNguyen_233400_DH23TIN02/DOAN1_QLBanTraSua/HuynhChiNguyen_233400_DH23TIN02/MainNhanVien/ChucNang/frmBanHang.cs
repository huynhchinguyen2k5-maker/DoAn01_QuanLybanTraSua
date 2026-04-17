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
    public partial class frmBanHang : Form
    {
        int maHoaDonMoi = -1;
        int maHoaDonDaThanhToan = -1;

        string maTSChon = "";
        public frmBanHang()
        {
            InitializeComponent();
        }

        //Phương thức Load CMB Khuyến mãi
        private void LoadComboBoxKhuyenmai()
        {
            using (SqlConnection conn = ChuoiKN.GetConnection())
            {
                conn.Open();

                string query = "SELECT MAKM, TENKM FROM KHUYENMAI WHERE TRANGTHAI = N'HOAT DONG' AND GETDATE() BETWEEN NGAYBATDAU AND NGAYKETTHUC ";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                // Thêm dòng "Không khuyến mãi"

                DataRow row = ds.Tables[0].NewRow();
                row["MAKM"] = DBNull.Value;
                row["TENKM"] = "Không áp dụng";
                ds.Tables[0].Rows.InsertAt(row, 0);

                cmbKM.DataSource = ds.Tables[0];
                cmbKM.DisplayMember = "TENKM";
                cmbKM.ValueMember = "MAKM";

                cmbKM.SelectedIndex = 0;
                cmbKM.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        //Phương thức Load CMB Khuyến mãi
        private void LoadComboBoxKH()
        {
            using (SqlConnection conn = ChuoiKN.GetConnection())
            {
                conn.Open();

                string query = "SELECT MAKH, TENKH FROM KHACHHANG";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                cmbKH.DataSource = ds.Tables[0];
                cmbKH.DisplayMember = "TENKH";
                cmbKH.ValueMember = "MAKH";

                cmbKH.SelectedIndex = -1;
                cmbKH.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        //Load menu trà sữa
        private void LoadMenuTraSua(string tukhoa = "")
        {
            using (SqlConnection conn = ChuoiKN.GetConnection())
            {
                string sql = @"SELECT MATS, TENTS, DONGIA 
                       FROM TRASUA
                       WHERE TENTS LIKE @kw";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@kw", "%" + tukhoa + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dtgvMenuTS.DataSource = dt;
            }

            dtgvMenuTS.DefaultCellStyle.ForeColor = Color.Black;
            dtgvMenuTS.DefaultCellStyle.BackColor = Color.White;
            dtgvMenuTS.DefaultCellStyle.SelectionForeColor = Color.White;
            dtgvMenuTS.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;

            dtgvMenuTS.Columns["MATS"].HeaderText = "Mã trà sữa";
            dtgvMenuTS.Columns["TENTS"].HeaderText = "Tên trà sữa";
            dtgvMenuTS.Columns["DONGIA"].HeaderText = "Đơn giá";

            dtgvMenuTS.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14, FontStyle.Bold);
        }

        //Hiển thị Tổng tiền
        private void LoadTongTien()
        {
            if (maHoaDonMoi == -1) return;

            using (SqlConnection conn = ChuoiKN.GetConnection())
            {
                conn.Open();
                string sql = "SELECT TONGTIEN, GIAMGIA, THANHTOAN FROM HOADON WHERE MAHD=@mahd";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@mahd", maHoaDonMoi);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        txtTongTien.Text = rd["TONGTIEN"].ToString();
                        txtGiamGia.Text = rd["GIAMGIA"].ToString();
                        txtThanhTien.Text = rd["THANHTOAN"].ToString();
                    }
                }
            }
        }

        //Load Chi tiết hóa đơn
        private void LoadChiTietHoaDon()
        {
            using (SqlConnection conn = ChuoiKN.GetConnection())
            {
                string sql = @"SELECT CT.MATS, TS.TENTS, CT.SOLUONG, CT.DONGIA, CT.THANHTIEN
                                   FROM CHITIETHOADON CT
                                   JOIN TRASUA TS ON CT.MATS = TS.MATS
                                   WHERE CT.MAHD = @mahd";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@mahd", maHoaDonMoi);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgvCTHD.DataSource = dt;
            }
            dtgvCTHD.DefaultCellStyle.ForeColor = Color.Black;
            dtgvCTHD.DefaultCellStyle.BackColor = Color.White;
            dtgvCTHD.DefaultCellStyle.SelectionForeColor = Color.White;
            dtgvCTHD.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;

            dtgvCTHD.Columns["MATS"].HeaderText = "Mã trà sữa";
            dtgvCTHD.Columns["TENTS"].HeaderText = "Tên trà sữa";
            dtgvCTHD.Columns["SOLUONG"].HeaderText = "Số lượng";
            dtgvCTHD.Columns["DONGIA"].HeaderText = "Đơn giá";
            dtgvCTHD.Columns["THANHTIEN"].HeaderText = "Thành tiền";

            dtgvCTHD.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            LoadTongTien();
            CapNhatTrangThaiThanhToan();
        }
        //Reset Hóa  Đơn
        private void ResetHoaDon()
        {
            maHoaDonMoi = -1;

            cmbKH.Enabled = true;
            cmbKM.Enabled = true;
            cmbKH.SelectedIndex = -1;
            cmbKM.SelectedIndex = -1;

            btnThemhoaDon.Enabled = true;
            grbMeNuMon.Enabled = false;

            dtgvCTHD.DataSource = null;
            txtTongTien.Clear();
            txtGiamGia.Clear();
            txtThanhTien.Clear();
            txtTS.Clear();
            txtDonGia.Clear();
            nupSoluong.Value = 1;
            txtMaHD.Text = "0";

            maTSChon = "";
            CapNhatTrangThaiThanhToan();
        }
        //Trạng thái các nút 

        private void TrangThaiBanDau()
        {
            btnThemhoaDon.Enabled = true;
            btnThem.Enabled = false;
            btnCapNhat.Enabled = false; // nút Xóa/Cập nhật
            btnThanhToan.Enabled = false;
            btnINHD.Enabled = false;
            btnhuy.Enabled = true;
        }

        private void TrangThaiSauKhiTaoHoaDon()
        {
            btnThemhoaDon.Enabled = false;
            btnThem.Enabled = true;
            btnCapNhat.Enabled = true;
            btnThanhToan.Enabled = false;
            btnhuy.Enabled = true;
        }

        private void CapNhatTrangThaiThanhToan()
        {
            btnThanhToan.Enabled = (maHoaDonMoi != -1) && dtgvCTHD.Rows.Count > 0;
        }

        private void dtgvMenuTS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTS.Text = dtgvMenuTS.Rows[e.RowIndex].Cells["TENTS"].Value.ToString();
                txtDonGia.Text = dtgvMenuTS.Rows[e.RowIndex].Cells["DONGIA"].Value.ToString();
            }

        }

        private void dtgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maTSChon = dtgvCTHD.Rows[e.RowIndex].Cells["MATS"].Value.ToString();

                if (dtgvCTHD.Rows[e.RowIndex].Cells["SOLUONG"].Value != null && dtgvCTHD.Rows[e.RowIndex].Cells["SOLUONG"].Value != DBNull.Value)
                    nupSoluong.Value = Convert.ToInt32(dtgvCTHD.Rows[e.RowIndex].Cells["SOLUONG"].Value);
                else
                    nupSoluong.Value = 0;
            }    
        }

        //Thêm hóa đơn
        private void btnThemhoaDon_Click(object sender, EventArgs e)
        {
            if (cmbKH.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                return;
            }

            if (string.IsNullOrEmpty(frmDangNhap.MaNhanVienDangNhap))
            {
                MessageBox.Show("Không xác định được nhân viên đăng nhập!");
                return;
            }
            try
            {
                string manv = frmDangNhap.MaNhanVienDangNhap;
                string makh = cmbKH.SelectedValue.ToString();
                object makm = DBNull.Value;
                if (cmbKM.SelectedIndex != -1 && cmbKM.SelectedValue != null)
                    makm = cmbKM.SelectedValue;

                using (SqlConnection conn = ChuoiKN.GetConnection())
                {
                    conn.Open();

                    string sql = @"INSERT INTO HOADON (MANV, MAKH, MAKM)
                                    VALUES (@manv, @makh, @makm);
                                    SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@manv", manv);
                        cmd.Parameters.AddWithValue("@makh", makh);
                        cmd.Parameters.AddWithValue("@makm", makm);

                        maHoaDonMoi = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                txtMaHD.Text = maHoaDonMoi.ToString();
                MessageBox.Show("Tạo hóa đơn thành công!\nMã HĐ: " + maHoaDonMoi);

                cmbKH.Enabled = false;
                cmbKM.Enabled = false;
                btnThemhoaDon.Enabled = false;
                grbMeNuMon.Enabled = true; // mở phần thêm món

                LoadChiTietHoaDon();
                TrangThaiSauKhiTaoHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo hóa đơn!\n" + ex.Message);
            }
        }

        //Thêm trà sữa và hóa đơn
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (maHoaDonMoi == -1)
            {
                MessageBox.Show("Vui lòng tạo hóa đơn trước!");
                return;
            }

            if (dtgvMenuTS.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn món!");
                return;
            }

            int soLuong = (int)nupSoluong.Value;
            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                return;
            }

            try
            {
                string maTS = dtgvMenuTS.CurrentRow.Cells["MATS"].Value.ToString();

                using (SqlConnection conn = ChuoiKN.GetConnection())
                {
                    conn.Open();

                    string sql = @"INSERT INTO CHITIETHOADON(MAHD, MATS, SOLUONG)
                       VALUES (@mahd, @mats, @sl)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@mahd", maHoaDonMoi);
                        cmd.Parameters.AddWithValue("@mats", maTS);
                        cmd.Parameters.AddWithValue("@sl", soLuong);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadChiTietHoaDon();
                CapNhatTrangThaiThanhToan();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (maHoaDonMoi == -1)
            {
                MessageBox.Show("Chưa có hóa đơn!");
                return;
            }

            if (string.IsNullOrEmpty(maTSChon))
            {
                MessageBox.Show("Vui lòng chọn món cần cập nhật!");
                return;
            }

            int soLuongMoi = (int)nupSoluong.Value;

            if (soLuongMoi <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!");
                return;
            }

            using (SqlConnection conn = ChuoiKN.GetConnection())
            {
                conn.Open();

                string sql = @"UPDATE CHITIETHOADON
                       SET SOLUONG = @sl
                       WHERE MAHD = @mahd AND MATS = @mats";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@sl", soLuongMoi);
                    cmd.Parameters.AddWithValue("@mahd", maHoaDonMoi);
                    cmd.Parameters.AddWithValue("@mats", maTSChon);
                    cmd.ExecuteNonQuery();
                }
            }

            maTSChon = "";
            nupSoluong.Value = 1; 

            LoadChiTietHoaDon();

            CapNhatTrangThaiThanhToan();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (maHoaDonMoi == -1) return;

                using (SqlConnection conn = ChuoiKN.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE HOADON SET TRANGTHAI = N'DA THANH TOAN' WHERE MAHD=@mahd";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@mahd", maHoaDonMoi);
                        cmd.ExecuteNonQuery();
                    }
                }

                maHoaDonDaThanhToan = maHoaDonMoi;

                MessageBox.Show("Thanh toán thành công!");

                btnINHD.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (maHoaDonMoi == -1) return;

                using (SqlConnection conn = ChuoiKN.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE HOADON SET TRANGTHAI = N'HUY' WHERE MAHD=@mahd";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@mahd", maHoaDonMoi);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Đã hủy hóa đơn!");
                ResetHoaDon();
                TrangThaiBanDau();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            LoadComboBoxKhuyenmai();
            LoadComboBoxKH();

            LoadMenuTraSua();

            txtNhanVien.Text = frmDangNhap.TenNhanVienDangNhap;
            txtNhanVien.ReadOnly = true;

            txtMaHD.ReadOnly = true;

            dtpkNgayLap.Enabled = false;

            TrangThaiBanDau();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            LoadMenuTraSua(txtNhap.Text.Trim());
        }

        private void btnINHD_Click(object sender, EventArgs e)
        {
            if (maHoaDonDaThanhToan == -1)
            {
                MessageBox.Show("Chưa có hóa đơn đã thanh toán để in!");
                return;
            }

            frmInChiTietHoaDon frm = new frmInChiTietHoaDon(maHoaDonDaThanhToan);
            frm.ShowDialog();

            ResetHoaDon();
            TrangThaiBanDau();
        }
    }
}
