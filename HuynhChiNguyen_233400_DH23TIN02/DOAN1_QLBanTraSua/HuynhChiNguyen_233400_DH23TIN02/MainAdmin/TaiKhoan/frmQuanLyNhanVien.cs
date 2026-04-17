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
    public partial class frmQuanLyNhanVien : Form
    {
        SqlDataAdapter BoDocGhi;

        DataSet dsNhanVien;

        SqlCommand cm;

        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        //phuong thức ComboBox Giới tính
        private void loadGioiTinh()
        {
            cmbGioiTinh.Items.Clear();
            cmbGioiTinh.Items.Add("NAM");
            cmbGioiTinh.Items.Add("NU");

            cmbGioiTinh.SelectedIndex = 0;
        } 

        //Phuong thức ComboBox Trạng Thái
        private void LoadTrangThai()
        {
            cmbTrangThai.Items.Clear();
            cmbTrangThai.Items.Add("DANG LAM");
            cmbTrangThai.Items.Add("NGHI");
            cmbTrangThai.Items.Add("NGHI VIEC");

            cmbTrangThai.SelectedIndex = 0;
        }

        //Phuong thức ComboBox Tên tài khoản
        private void LoadTenTK()
        {
            using(SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                string query = "SELECT TENTK FROM TAIKHOAN WHERE TRANGTHAI = N'HOAT DONG'";

                SqlDataAdapter da = new SqlDataAdapter(query,KN);

                DataSet dsNV = new DataSet();

                da.Fill(dsNV);

                cmbTenTK.DataSource = dsNV.Tables[0];
                cmbTenTK.DisplayMember = "TENTK";
                cmbTenTK.ValueMember = "TENTK";

                cmbTenTK.SelectedIndex = -1;
            }
        }

        private void ToMauTrangThai()
        {
            foreach (DataGridViewRow row in dtgvNV.Rows)
            {
                if (row.Cells["TRANGTHAI"].Value == null) continue;

                string trangThai = row.Cells["TRANGTHAI"].Value.ToString().Trim().ToUpper();

                row.DefaultCellStyle.ForeColor = Color.Black;

                if (trangThai == "DANG LAM")
                {
                    row.DefaultCellStyle.BackColor = Color.Honeydew;
                    row.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen;
                }
                else if (trangThai == "NGHI VIEC")
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
        //Phuong thức load DataGridView
        private void LoadDataGridView()
        {
            using(SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                string sql = "SELECT MANV, TENNV, GIOITINH, NGAYSINH, SDT, TENTK, TRANGTHAI FROM NHANVIEN";

                BoDocGhi = new SqlDataAdapter(sql,KN);

                dsNhanVien = new DataSet();

                BoDocGhi.Fill(dsNhanVien);

                dtgvNV.DataSource = dsNhanVien.Tables[0];
                dtgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dtgvNV.DefaultCellStyle.ForeColor = Color.Black;
                dtgvNV.DefaultCellStyle.BackColor = Color.White;
                dtgvNV.DefaultCellStyle.SelectionForeColor = Color.White;
                dtgvNV.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;

                dtgvNV.Columns["MANV"].HeaderText = "Mã nhân viên";
                dtgvNV.Columns["TENNV"].HeaderText = "Tên nhân viên";
                dtgvNV.Columns["GIOITINH"].HeaderText = "Giới tính";
                dtgvNV.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
                dtgvNV.Columns["SDT"].HeaderText = "Số điện thoại";
                dtgvNV.Columns["TENTK"].HeaderText = "Tên tài khoản";
                dtgvNV.Columns["TRANGTHAI"].HeaderText = "Trạng thái";

                dtgvNV.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                dtgvNV.ColumnHeadersHeight = 40;

                ToMauTrangThai();
            }
        }

        //Phương thức resetForm lại
        private void ResetForm()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            cmbGioiTinh.SelectedIndex = 0;
            cmbTrangThai.SelectedIndex = 0;
            cmbTenTK.SelectedIndex = -1;
            dtpkNgaySinh.Value = DateTime.Now;

        }
        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            loadGioiTinh();
            LoadTrangThai();
            LoadTenTK();
            LoadDataGridView();

            txtMaNV.Enabled = false;

            cmbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTenTK.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //sự kiện của dataGridView
        private void dtgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtMaNV.Text = dtgvNV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNV.Text = dtgvNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbGioiTinh.Text = dtgvNV.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (dtgvNV.Rows[e.RowIndex].Cells[3].Value == null || dtgvNV.Rows[e.RowIndex].Cells[3].Value == DBNull.Value)
                    dtpkNgaySinh.Value = DateTime.Now;
                else
                    dtpkNgaySinh.Value = Convert.ToDateTime(dtgvNV.Rows[e.RowIndex].Cells[3].Value);

                txtSDT.Text = dtgvNV.Rows[e.RowIndex].Cells[4].Value.ToString();

                if (dtgvNV.Rows[e.RowIndex].Cells[5].Value != null)
                    cmbTenTK.SelectedValue = dtgvNV.Rows[e.RowIndex].Cells[5].Value.ToString();
                else
                    cmbTenTK.SelectedIndex = -1;

                cmbTrangThai.Text = dtgvNV.Rows[e.RowIndex].Cells[6].Value.ToString();


                
            }
        }
        //Nút Thêm Nhân viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection KN = ChuoiKN.GetConnection())
                {
                    if(string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                       cmbGioiTinh.SelectedIndex == -1 ||
                       string.IsNullOrWhiteSpace(txtSDT.Text) ||
                       cmbTenTK.SelectedIndex == -1 ||
                       cmbTrangThai.SelectedIndex == -1)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thêm.", "Thông tin không hợp lệ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string sdt = txtSDT.Text.Trim();

                    // SĐT phải 10–11 số
                    if (sdt.Length < 10 || sdt.Length > 11 || !sdt.All(char.IsDigit))
                    {
                        MessageBox.Show("SĐT phải gồm 10 hoặc 11 chữ số!", "Sai định dạng SĐT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSDT.Focus();
                        return;
                    }

                    if (cmbTenTK.SelectedValue == null)
                    {
                        MessageBox.Show("Vui lòng chọn tài khoản!");
                        return;
                    }

                    KN.Open();

                    string checkTK = "SELECT COUNT(*) FROM NHANVIEN WHERE TENTK = @TENTK";
                    SqlCommand cmdCheck = new SqlCommand(checkTK, KN);
                    cmdCheck.Parameters.AddWithValue("@TENTK", cmbTenTK.SelectedValue);

                    int tonTai = (int)cmdCheck.ExecuteScalar();

                    if (tonTai > 0)
                    {
                        MessageBox.Show("Tài khoản này đã được gán cho nhân viên khác!",
                                        "Trùng tài khoản",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;
                    }

                    string insert = @"INSERT INTO NHANVIEN (TENNV, GIOITINH, NGAYSINH, SDT, TENTK, TRANGTHAI)
                                      VALUES (@TENNV, @GIOITINH, @NGAYSINH, @SDT, @TENTK, @TRANGTHAI)";

                    cm = new SqlCommand(insert, KN);

                    cm.Parameters.AddWithValue("@TENNV", txtTenNV.Text);
                    cm.Parameters.AddWithValue("@GIOITINH", cmbGioiTinh.Text);
                    cm.Parameters.AddWithValue("@NGAYSINH", dtpkNgaySinh.Value);
                    cm.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    cm.Parameters.AddWithValue("@TENTK", cmbTenTK.SelectedValue);
                    cm.Parameters.AddWithValue("@TRANGTHAI", cmbTrangThai.Text);

                    cm.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công.");
                    LoadDataGridView();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm nhân viên không thành công!!!" + ex.Message);
            }
        }
        //Nút xóa Nhân viên = thay đổi trạng thái của nhân viên đó
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dtgvNV.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần Xóa.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn Xóa tài khoản của nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.No) return;

            try
            {
                using(SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string query = @"UPDATE NHANVIEN
                                     SET TRANGTHAI = N'NGHI VIEC' 
                                     WHERE MANV = @MANV";

                    cm = new SqlCommand(query, KN);
                    cm.Parameters.AddWithValue("@MANV", txtMaNV.Text);
                    cm.ExecuteNonQuery();

                }
                MessageBox.Show("Đã thay đổi trạng thái của nhân viên.");
                LoadDataGridView();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("thay đổi trang thái nhân viên không thành công!!!" + ex.Message);
            }
        }
        //Nút cập nhật thông tin Nhân viên
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(dtgvNV.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần Cập nhật thông tin.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                       cmbGioiTinh.SelectedIndex == -1 ||
                       string.IsNullOrWhiteSpace(txtSDT.Text) ||
                       cmbTenTK.SelectedIndex == -1 ||
                       cmbTrangThai.SelectedIndex == -1)
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

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin của nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.No) return;

            if (cmbTenTK.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản!");
                return;
            }

            try
            {
                using(SqlConnection KN = ChuoiKN.GetConnection())
                {
                   KN.Open();

                   string checkTK = @"SELECT COUNT(*) 
                   FROM NHANVIEN 
                   WHERE TENTK = @TENTK 
                   AND MANV <> @MANV";

                    SqlCommand cmdCheck = new SqlCommand(checkTK, KN);
                    cmdCheck.Parameters.AddWithValue("@TENTK", cmbTenTK.SelectedValue);
                    cmdCheck.Parameters.AddWithValue("@MANV", txtMaNV.Text);

                    int tonTai = (int)cmdCheck.ExecuteScalar();

                    if (tonTai > 0)
                    {
                        MessageBox.Show("Tài khoản này đã được gán cho nhân viên khác!",
                                        "Trùng tài khoản",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;
                    }

                    string query = @"UPDATE NHANVIEN
                                     SET TENNV = @TENNV,
                                         GIOITINH = @GIOITINH,
                                         NGAYSINH = @NGAYSINH,
                                         SDT = @SDT,
                                         TENTK = @TENTK,
                                         TRANGTHAI = @TRANGTHAI
                                     WHERE MANV = @MANV";

                    cm = new SqlCommand(query, KN);

                    cm.Parameters.AddWithValue("@MANV", txtMaNV.Text);
                    cm.Parameters.AddWithValue("@TENNV", txtTenNV.Text);
                    cm.Parameters.AddWithValue("@GIOITINH", cmbGioiTinh.Text);
                    cm.Parameters.AddWithValue("@NGAYSINH", dtpkNgaySinh.Value);
                    cm.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    cm.Parameters.AddWithValue("@TENTK", cmbTenTK.SelectedValue);
                    cm.Parameters.AddWithValue("@TRANGTHAI", cmbTrangThai.Text);

                    int kq = cm.ExecuteNonQuery();

                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        LoadDataGridView();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin nhân viên để cập nhật.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thông tin nhân viên không thành công!!!" + ex.Message);
            }
        }
        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyNhanVien_Activated(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
