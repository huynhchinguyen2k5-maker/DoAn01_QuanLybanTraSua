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
    public partial class frmQLHoaDon : Form
    {
        
        
        SqlCommand cmd;

        public frmQLHoaDon()
        {
            InitializeComponent();
        }

        //Phương thức Load CMB Mã Nhân Viên
        private void LoadComboBox(ComboBox cmb, string query, string displayMember, string valueMember)
        {
            using (SqlConnection conn = ChuoiKN.GetConnection())
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);


                cmb.DataSource = ds.Tables[0];
                cmb.DisplayMember = displayMember; 
                cmb.ValueMember = valueMember;     
                cmb.SelectedIndex = -1;

                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }


        //Phương thức Load CMB Khuyến mãi
        private void LoadComboBoxKhuyenmai()
        {
            using (SqlConnection conn = ChuoiKN.GetConnection())
            {
                conn.Open();

                string query = "SELECT MAKM, TENKM FROM KHUYENMAI WHERE TRANGTHAI = N'HOAT DONG' AND GETDATE() BETWEEN NGAYBATDAU AND NGAYKETTHUC";

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
                
                cmbKM.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        //Phương thức Load CMB Trạng thái
        private void LoadCMBtrangThai()
        {
            cmbTrangThai.Items.Clear();
            cmbTrangThai.Items.Add("CHUA THANH TOAN");
            cmbTrangThai.Items.Add("DA THANH TOAN");
            cmbTrangThai.Items.Add("HUY");

            cmbTrangThai.SelectedIndex = 0;

            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ToMauTrangThaiHoaDon()
        {
            foreach (DataGridViewRow row in dtgvHD.Rows)
            {
                if (row.Cells["TRANGTHAI"].Value == null) continue;

                string trangThai = row.Cells["TRANGTHAI"].Value.ToString().Trim().ToUpper();

                row.DefaultCellStyle.ForeColor = Color.Black;

                if (trangThai == "DA THANH TOAN")
                {
                    row.DefaultCellStyle.BackColor = Color.Honeydew;
                    row.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen;
                }
                else if (trangThai == "HUY")
                {
                    row.DefaultCellStyle.BackColor = Color.Gainsboro;
                    row.DefaultCellStyle.SelectionBackColor = Color.Gray;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LemonChiffon;
                    row.DefaultCellStyle.SelectionBackColor = Color.Goldenrod;
                }
            }
        }

        //Phương thức Load DataGridView
        private void LoadDTGV()
        {
            using (SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                string Query = "SELECT MAHD, NGAYLAP, MANV, MAKH, MAKM, GIAMGIA, TONGTIEN, THANHTOAN, TRANGTHAI FROM HOADON";

                SqlDataAdapter BoDocGhi = new SqlDataAdapter(Query, KN);

                DataSet dsHD = new DataSet();

                BoDocGhi.Fill(dsHD);

                dtgvHD.DataSource = dsHD.Tables[0];
                dtgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dtgvHD.DefaultCellStyle.ForeColor = Color.Black;
                dtgvHD.DefaultCellStyle.BackColor = Color.White;
                dtgvHD.DefaultCellStyle.SelectionForeColor = Color.White;
                dtgvHD.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;

                dtgvHD.Columns["MAHD"].HeaderText = "Mã hóa đơn";
                dtgvHD.Columns["NGAYLAP"].HeaderText = "Ngày lập";
                dtgvHD.Columns["MANV"].HeaderText = "Mã nhân viên";
                dtgvHD.Columns["MAKH"].HeaderText = "Mã khách hàng";
                dtgvHD.Columns["MAKM"].HeaderText = "Mã khuyến mãi";
                dtgvHD.Columns["GIAMGIA"].HeaderText = "Giảm giá";
                dtgvHD.Columns["TONGTIEN"].HeaderText = "Tổng tiền";
                dtgvHD.Columns["THANHTOAN"].HeaderText = "Thành tiền";
                dtgvHD.Columns["TRANGTHAI"].HeaderText = "Trạng thái";

                dtgvHD.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                dtgvHD.ColumnHeadersHeight = 40;

                ToMauTrangThaiHoaDon();
            }
        }


        //Phương thức ResetForm
        private void ResetForm()
        {
            txtMaHD.Clear();
            dtpkNgayLap.Value = DateTime.Now;
            cmbNV.SelectedIndex = -1;
            cmbKH.SelectedIndex = -1;
            cmbKM.SelectedIndex = 0;
            txtGiamGia.Clear();
            txtTongTien.Clear();
            txtThanhToan.Clear();
            cmbTrangThai.SelectedItem = "CHUA THANH TOAN";

        }
        private void frmQLHoaDon_Load(object sender, EventArgs e)
        {
            LoadComboBox(cmbNV,"SELECT MANV, TENNV FROM NHANVIEN WHERE TRANGTHAI = N'DANG LAM' ","TENNV","MANV");

            LoadComboBox(cmbKH,"SELECT MAKH, TENKH FROM KHACHHANG WHERE TRANGTHAI = 1","TENKH","MAKH");

            LoadComboBoxKhuyenmai();

            LoadCMBtrangThai();
            LoadDTGV();

            dtpkNgayLap.Enabled = false;
            txtMaHD.Enabled = false;

            txtGiamGia.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtThanhToan.ReadOnly = true;

            cmbTrangThai.Enabled = false;
        }

        private void dtgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtMaHD.Text = dtgvHD.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (dtgvHD.Rows[e.RowIndex].Cells[1].Value != null && dtgvHD.Rows[e.RowIndex].Cells[1].Value != DBNull.Value)

                    dtpkNgayLap.Value = Convert.ToDateTime(dtgvHD.Rows[e.RowIndex].Cells[1].Value);

                else  dtpkNgayLap.Value = DateTime.Now;

                cmbNV.SelectedValue = dtgvHD.Rows[e.RowIndex].Cells["MANV"].Value;
                cmbKH.SelectedValue = dtgvHD.Rows[e.RowIndex].Cells["MAKH"].Value;

                object makm = dtgvHD.Rows[e.RowIndex].Cells["MAKM"].Value;

                if (makm == null || makm == DBNull.Value)
                    cmbKM.SelectedIndex = 0;
                else
                    cmbKM.SelectedValue = makm;

                txtGiamGia.Text = dtgvHD.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtTongTien.Text = dtgvHD.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtThanhToan.Text = dtgvHD.Rows[e.RowIndex].Cells[7].Value.ToString();

                cmbTrangThai.Text = dtgvHD.Rows[e.RowIndex].Cells[8].Value.ToString();



                string trangThai = cmbTrangThai.Text.Trim().ToUpper();

                bool khoa = (trangThai == "DA THANH TOAN" || trangThai == "HUY");

                cmbKM.Enabled = !khoa;
                btnCapNhat.Enabled = !khoa;
                btnXoa.Enabled = !khoa;

                // Chỉ cho thanh toán khi chưa thanh toán

                btnThanhToan.Enabled = (trangThai == "CHUA THANH TOAN");
                cmbNV.Enabled = !khoa;
                cmbKH.Enabled = !khoa;

            }
        }

        //Nút thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(cmbNV.SelectedIndex == -1 ||
               cmbKH.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào hóa đơn.", "Thông tin không hợp lệ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using(SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string SQL = @"INSERT INTO HOADON (NGAYLAP, MANV, MAKH, MAKM, TRANGTHAI)
                                   VALUES (@NGAYLAP, @MANV, @MAKH, @MAKM, N'CHUA THANH TOAN')";

                    cmd = new SqlCommand(SQL, KN);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@NGAYLAP", DateTime.Now);
                    cmd.Parameters.AddWithValue("@MANV", cmbNV.SelectedValue);
                    cmd.Parameters.AddWithValue("@MAKH", cmbKH.SelectedValue);

                    if (cmbKM.SelectedValue == DBNull.Value)
                        cmd.Parameters.AddWithValue("@MAKM", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@MAKM", cmbKM.SelectedValue);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Tạo hóa đơn thành công.");
                LoadDTGV();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Hóa đơn không thành công." + ex.Message);
            }
            
        }

        //Nút xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dtgvHD.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa.","Thông báo!!!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string trangThai = cmbTrangThai.Text;

            // Không cho xử lý nếu DA THANH TOAN hoặc HUY
            if (trangThai == "DA THANH TOAN" || trangThai == "HUY")
            {
                MessageBox.Show("Hóa đơn này không thể xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show("YES: Xóa vĩnh viễn\nNO: Chuyển trạng thái thành HỦY","Chọn cách xử lý hóa đơn",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                //  XÓA TRỰC TIẾP
                try
                {
                    using (SqlConnection KN = ChuoiKN.GetConnection())
                    {
                        KN.Open();

                        string sql = "DELETE FROM HOADON WHERE MAHD = @MAHD";

                        SqlCommand cmd = new SqlCommand(sql, KN);
                        cmd.Parameters.AddWithValue("@MAHD", txtMaHD.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã xóa hóa đơn khỏi hệ thống!");
                    LoadDTGV();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại!\n" + ex.Message);
                }
            }
            else if (kq == DialogResult.No)
            {
                //  CHỈ HỦY HÓA ĐƠN
                try
                {
                    using (SqlConnection KN = ChuoiKN.GetConnection())
                    {
                        KN.Open();

                        string sql = @"UPDATE HOADON 
                               SET TRANGTHAI = N'HUY'
                               WHERE MAHD = @MAHD";

                        SqlCommand cmd = new SqlCommand(sql, KN);
                        cmd.Parameters.AddWithValue("@MAHD", txtMaHD.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Hóa đơn đã được chuyển sang trạng thái HỦY!");
                    LoadDTGV();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật trạng thái thất bại!\n" + ex.Message);
                }
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(dtgvHD.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string trangThaiCu = dtgvHD.CurrentRow.Cells["TRANGTHAI"].Value.ToString();
            string trangThaiMoi = cmbTrangThai.Text;

            // Không cho sửa nếu đã thanh toán hoặc đã hủy
            if (trangThaiCu == "DA THANH TOAN" || trangThaiCu == "HUY")
            {
                MessageBox.Show("Hóa đơn này không thể chỉnh sửa!");
                return;
            }

            // Không cho quay ngược từ đã thanh toán về chưa thanh toán
            if (trangThaiCu == "DA THANH TOAN" && trangThaiMoi == "CHUA THANH TOAN")
            {
                MessageBox.Show("Không thể chuyển về trạng thái chưa thanh toán!");
                return;
            }

            try
            {
                using (SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string sql = @"UPDATE HOADON
                                   SET MAKM = @MAKM,
                                       MANV = @MANV,
                                       MAKH = @MAKH,
                                       TRANGTHAI = @TRANGTHAI
                                   WHERE MAHD = @MAHD";

                    SqlCommand cmd = new SqlCommand(sql, KN);

                    cmd.Parameters.AddWithValue("@MAHD", txtMaHD.Text);
                    cmd.Parameters.AddWithValue("@MANV", cmbNV.SelectedValue);
                    cmd.Parameters.AddWithValue("@MAKH", cmbKH.SelectedValue);
                    if (cmbKM.SelectedValue == DBNull.Value)
                        cmd.Parameters.AddWithValue("@MAKM", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@MAKM", cmbKM.SelectedValue);

                    cmd.Parameters.AddWithValue("@TRANGTHAI", trangThaiMoi);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cập nhật hóa đơn thành công!");
                LoadDTGV();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại!\n" + ex.Message);
            }
        }

        //Nút thanh toán
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dtgvHD.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tongTien = Convert.ToDecimal(dtgvHD.CurrentRow.Cells["TONGTIEN"].Value);

            if (tongTien <= 0)
            {
                MessageBox.Show("Hóa đơn chưa có món, không thể thanh toán!");
                return;
            }
            // Lấy trạng thái hiện tại từ DataGirdView

            string trangThai = dtgvHD.CurrentRow.Cells["TRANGTHAI"].Value.ToString();

            if (trangThai != "CHUA THANH TOAN")
            {
                MessageBox.Show("Chỉ hóa đơn CHƯA THANH TOÁN mới được thanh toán!");
                return;
            }

            DialogResult kq = MessageBox.Show("Xác nhận thanh toán hóa đơn này?","Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq != DialogResult.Yes) return;

            try
            {
                using (SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string sql = @"UPDATE HOADON
                                   SET TRANGTHAI = N'DA THANH TOAN'
                                   WHERE MAHD = @MAHD";

                    SqlCommand cmd = new SqlCommand(sql, KN);
                    cmd.Parameters.AddWithValue("@MAHD", txtMaHD.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thanh toán thành công!");
                LoadDTGV();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thanh toán thất bại!\n" + ex.Message);
            }
        }

        private void btnChiTirtHD_Click(object sender, EventArgs e)
        {
            foreach(Form f in Application.OpenForms)
            {
                if (f is frmQLChiTietHoaDon)
                {
                    f.Activate();
                    return;
                }
            }

            frmQLChiTietHoaDon frm = new frmQLChiTietHoaDon();
            frm.Show();
        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQLHoaDon_Activated(object sender, EventArgs e)
        {
            LoadDTGV();
        }
    }
}
