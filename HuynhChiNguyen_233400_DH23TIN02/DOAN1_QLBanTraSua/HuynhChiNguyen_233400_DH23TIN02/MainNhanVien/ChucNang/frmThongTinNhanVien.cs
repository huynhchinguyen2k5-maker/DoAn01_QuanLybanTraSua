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
    public partial class frmThongTinNhanVien : Form
    {
        SqlCommand cm;
        public frmThongTinNhanVien()
        {
            InitializeComponent();
        }
        private void loadGioiTinh()
        {
            cmbGioiTinh.Items.Clear();
            cmbGioiTinh.Items.Add("NAM");
            cmbGioiTinh.Items.Add("NU");

            cmbGioiTinh.SelectedIndex = 0;
        }

        private void LoadThongTinNhanVien(string taikhoan)
        {
            try
            {
                using (SqlConnection kn = ChuoiKN.GetConnection())
                {
                    string query = @"SELECT NV.MANV, NV.TENNV, NV.GIOITINH, NV.NGAYSINH, NV.SDT, NV.TENTK, NV.TRANGTHAI
                             FROM NHANVIEN NV
                             WHERE NV.TENTK = @tk";

                    SqlDataAdapter da = new SqlDataAdapter(query, kn);
                    da.SelectCommand.Parameters.AddWithValue("@tk", taikhoan);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgvTTNV.DataSource = dt;

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("Không tìm thấy thông tin nhân viên!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void StyleDataGridView()
        {
            dtgvTTNV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvTTNV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgvTTNV.BackgroundColor = Color.White;
            dtgvTTNV.BorderStyle = BorderStyle.None;
            dtgvTTNV.EnableHeadersVisualStyles = false;

            // Header
            dtgvTTNV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dtgvTTNV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgvTTNV.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            dtgvTTNV.ColumnHeadersHeight = 35;

            // Dòng dữ liệu
            dtgvTTNV.DefaultCellStyle.Font = new Font("Times New Roman", 14, FontStyle.Regular);
            dtgvTTNV.DefaultCellStyle.ForeColor = Color.Black;
            dtgvTTNV.DefaultCellStyle.BackColor = Color.White;
            dtgvTTNV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 250, 255);

            dtgvTTNV.RowTemplate.Height = 32;

            // Khi chọn
            dtgvTTNV.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 153, 188);
            dtgvTTNV.DefaultCellStyle.SelectionForeColor = Color.White;

            // Viền & layout
            dtgvTTNV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgvTTNV.RowHeadersVisible = false;
            dtgvTTNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            loadGioiTinh();
            LoadThongTinNhanVien(frmDangNhap.TenDangNhap);
            StyleDataGridView();

            txtMaNV.ReadOnly = true;
            txtTaiKhoan.ReadOnly = true;
            txtTrangThai.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtSDT.ReadOnly = true;
            cmbGioiTinh.Enabled = false;
            dtpkNgaySinh.Enabled = false;

        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvTTNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtMaNV.Text = dtgvTTNV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNV.Text = dtgvTTNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbGioiTinh.Text = dtgvTTNV.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (dtgvTTNV.Rows[e.RowIndex].Cells[3].Value == null || dtgvTTNV.Rows[e.RowIndex].Cells[3].Value == DBNull.Value)
                    dtpkNgaySinh.Value = DateTime.Now;
                else
                    dtpkNgaySinh.Value = Convert.ToDateTime(dtgvTTNV.Rows[e.RowIndex].Cells[3].Value);

                txtSDT.Text = dtgvTTNV.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTaiKhoan.Text = dtgvTTNV.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtTrangThai.Text = dtgvTTNV.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private bool dangSua = false;
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Nếu chưa ở chế độ sửa → chuyển sang chế độ sửa
            if (!dangSua)
            {

                txtTenNV.ReadOnly = false;
                txtSDT.ReadOnly = false;
                cmbGioiTinh.Enabled = true;
                dtpkNgaySinh.Enabled = true;

                txtMaNV.Enabled = false;
                txtTaiKhoan.Enabled = false;
                txtTrangThai.Enabled = false;

                btnCapNhat.Text = "LƯU THÔNG TIN";
                dangSua = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                       cmbGioiTinh.SelectedIndex == -1 ||
                       string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thêm.", "Thông tin không hợp lệ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sdt = txtSDT.Text.Trim();

            // Kiểm tra độ dài trước
            if (sdt.Length < 10 || sdt.Length > 11)
            {
                MessageBox.Show("SĐT phải có 10 hoặc 11 số!");
                txtSDT.Focus();
                return;
            }

            // Kiểm tra có phải toàn số không
            if (!sdt.All(char.IsDigit))
            {
                MessageBox.Show("SĐT chỉ được chứa chữ số!");
                txtSDT.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            try
            {

                using (SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string query = @"UPDATE NHANVIEN
                                     SET TENNV = @TENNV,
                                         GIOITINH = @GIOITINH,
                                         NGAYSINH = @NGAYSINH,
                                         SDT = @SDT
                                     WHERE MANV = @MANV";

                    cm = new SqlCommand(query, KN);

                    cm.Parameters.AddWithValue("@MANV", txtMaNV.Text);
                    cm.Parameters.AddWithValue("@TENNV", txtTenNV.Text);
                    cm.Parameters.AddWithValue("@GIOITINH", cmbGioiTinh.Text);
                    cm.Parameters.AddWithValue("@NGAYSINH", dtpkNgaySinh.Value);
                    cm.Parameters.AddWithValue("@SDT", txtSDT.Text);

                    int kq = cm.ExecuteNonQuery();

                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        LoadThongTinNhanVien(frmDangNhap.TenDangNhap);


                        txtMaNV.ReadOnly = true;
                        txtTaiKhoan.ReadOnly = true;
                        txtTrangThai.ReadOnly = true;

                        txtTenNV.ReadOnly = true;
                        txtSDT.ReadOnly = true;
                        cmbGioiTinh.Enabled = false;
                        dtpkNgaySinh.Enabled = false;

                        btnCapNhat.Text = "CẬP NHẬT THÔNG TIN";
                        dangSua = false;

                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin để cập nhật.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thông tin không thành công!!!" + ex.Message);
            }
        }

        private void btnMatKhau_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmMatKhau)
                {
                    f.Activate();
                    return;
                }
            }

            frmMatKhau frmMK = new frmMatKhau();
            frmMK.Show();
        }
    }
    
}
