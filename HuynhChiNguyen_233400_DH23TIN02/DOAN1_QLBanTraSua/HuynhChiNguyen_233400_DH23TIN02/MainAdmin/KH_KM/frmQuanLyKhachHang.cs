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
    public partial class frmQuanLyKhachHang : Form
    {
        SqlCommand cmd;
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        //Load comboBox Giới tính của khách hàng
        private void LoadCMBGioiTinh()
        {
            cmbGioiTinh.Items.Clear();
            cmbGioiTinh.Items.Add("NAM");
            cmbGioiTinh.Items.Add("NU");

            cmbGioiTinh.SelectedIndex = 0;
        }

        //ComboBox trạng thái khách hàng
        private void LoadCMBTrangThai()
        {
            var dsTrangThai = new List<object>
            {
                new { Text = "HOAT DONG", Value = 1 },
                new { Text = "KHOA", Value = 0 }
            };

            cmbTrangThai.DataSource = dsTrangThai;
            cmbTrangThai.DisplayMember = "Text";
            cmbTrangThai.ValueMember = "Value";
        }

        private void ToMauTrangThai()
        {
            foreach (DataGridViewRow row in dtgvKH.Rows)
            {
                if (row.Cells["TRANGTHAI"].Value == null) continue;

                int trangThai = Convert.ToInt32(row.Cells["TRANGTHAI"].Value);

                row.DefaultCellStyle.ForeColor = Color.Black;

                if (trangThai == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.Honeydew;
                    row.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen;
                }
                else if (trangThai == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Gainsboro;
                    row.DefaultCellStyle.SelectionBackColor = Color.Gray;
                }
            }
        }

        //Load DataGridView
        private void loadDataGridView()
        {
            using(SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();
                string query = "SELECT MAKH, TENKH, GIOITINH, SDT, DIACHI, TRANGTHAI FROM KHACHHANG";

                SqlDataAdapter BoDocGhi = new SqlDataAdapter(query,KN);

                DataSet dsKhachHang = new DataSet();

                BoDocGhi.Fill(dsKhachHang);

                dtgvKH.DataSource = dsKhachHang.Tables[0];

                dtgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgvKH.DefaultCellStyle.ForeColor = Color.Black;
                dtgvKH.DefaultCellStyle.BackColor = Color.White;
                dtgvKH.DefaultCellStyle.SelectionForeColor = Color.White;
                dtgvKH.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;

                dtgvKH.Columns["MAKH"].HeaderText = "Mã khách hàng";
                dtgvKH.Columns["TENKH"].HeaderText = "Tên khách hàng";
                dtgvKH.Columns["GIOITINH"].HeaderText = "Giới tính";
                dtgvKH.Columns["SDT"].HeaderText = "Số điện thoại";
                dtgvKH.Columns["DIACHI"].HeaderText = "Địa chỉ";
                dtgvKH.Columns["TRANGTHAI"].HeaderText = "Trạng thái";

                dtgvKH.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                dtgvKH.ColumnHeadersHeight = 40;

                ToMauTrangThai();
            }
        }
        //ResetForm lại
        private void ResetForm()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            cmbGioiTinh.SelectedIndex = 0;
            txtSDT.Clear();
            txtDiaChi.Clear();
            cmbTrangThai.SelectedIndex = 0;
        }
        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadCMBGioiTinh();
            LoadCMBTrangThai();
            loadDataGridView();

            txtMaKH.Enabled = false;

            cmbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;

            if (dtgvKH.Columns["TRANGTHAI"] is DataGridViewCheckBoxColumn chk)
            {
                chk.TrueValue = 1;
                chk.FalseValue = 0;
                chk.IndeterminateValue = 0;
                chk.ThreeState = false;
            }
        }

        private void dtgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtMaKH.Text = dtgvKH.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKH.Text = dtgvKH.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbGioiTinh.Text = dtgvKH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSDT.Text = dtgvKH.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dtgvKH.Rows[e.RowIndex].Cells[4].Value.ToString();

                object TrangThai = dtgvKH.Rows[e.RowIndex].Cells[5].Value;
                if (TrangThai != null && TrangThai != DBNull.Value)
                {
                    bool TT = Convert.ToBoolean(TrangThai);
                    cmbTrangThai.SelectedValue = TT ? 1 : 0;
                }
            }
        }

        //Nút thêm thông tin
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTenKH.Text) ||
               cmbGioiTinh.SelectedIndex == -1 ||
               string.IsNullOrWhiteSpace(txtSDT.Text) ||
               string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
               cmbTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Khách hàng.", "Thông tin không hợp lệ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sdt = txtSDT.Text.Trim();

            // SĐT phải 10–11 số
            if (sdt.Length < 10 || sdt.Length > 11 || !sdt.All(char.IsDigit))
            {
                MessageBox.Show("SĐT phải gồm 10 hoặc 11 chữ số!","Sai định dạng SĐT",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            try
            {
                using (SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string insert = @"INSERT INTO KHACHHANG (TENKH, GIOITINH, SDT, DIACHI, TRANGTHAI)
                               VALUES (@TENKH, @GIOITINH, @SDT, @DIACHI, @TRANGTHAI)";

                    cmd = new SqlCommand(insert, KN);

                    cmd.Parameters.AddWithValue("@TENKH", txtTenKH.Text);
                    cmd.Parameters.AddWithValue("@GIOITINH", cmbGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text);
                    cmd.Parameters.Add("@TRANGTHAI", SqlDbType.Bit).Value = cmbTrangThai.SelectedValue;

                    cmd.ExecuteNonQuery();   
                }
                MessageBox.Show("Thêm Khách hàng thành công.");
                loadDataGridView();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm khách hàng không thành công!!!" + ex.Message);
            }
        }

        //Nút xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dtgvKH.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Thông tin không hợp lệ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc muốn Xóa tài khoản của khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.No) return;

            try
            {
                using(SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string sql = @"UPDATE KHACHHANG
                                   SET TRANGTHAI = 0
                                   WHERE MAKH = @MAKH";

                    cmd = new SqlCommand(sql,KN);
                    cmd.Parameters.AddWithValue("@MAKH", txtMaKH.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Đã thay đổi trạng thái của tài khoản khách hàng");
                loadDataGridView();
                ResetForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa khách hàng không thành công!!!" + ex.Message);
            }
        }

        //Nút cập nhật
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dtgvKH.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Thông tin không hợp lệ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenKH.Text) ||
               cmbGioiTinh.SelectedIndex == -1 ||
               string.IsNullOrWhiteSpace(txtSDT.Text) ||
               string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
               cmbTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Khách hàng.", "Thông tin không hợp lệ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            DialogResult rs = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin của khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.No) return;

            try
            {
                using(SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string sql = @"UPDATE KHACHHANG
                                   SET TENKH = @TENKH, GIOITINH = @GIOITINH, SDT = @SDT, DIACHI = @DIACHI, TRANGTHAI = @TRANGTHAI
                                   WHERE MAKH = @MAKH";
                                   
                    cmd = new SqlCommand(sql,KN);

                    cmd.Parameters.AddWithValue("@MAKH", txtMaKH.Text);
                    cmd.Parameters.AddWithValue("@TENKH", txtTenKH.Text);
                    cmd.Parameters.AddWithValue("@GIOITINH", cmbGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text);
                    cmd.Parameters.Add("@TRANGTHAI", SqlDbType.Bit).Value = cmbTrangThai.SelectedValue;

                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Cập nhật thông tin khách hàng thành công");
                loadDataGridView();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thông tin khách hàng không thành công!!!" + ex.Message);
            }
        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyKhachHang_Activated(object sender, EventArgs e)
        {
            loadDataGridView();
        }
    }
}
