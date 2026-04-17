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
    public partial class frmKhachHang : Form
    {
        SqlCommand cmd;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        //Phuong thức Load comboBox Giới tính của khách hàng
        private void LoadCMBGioiTinh()
        {
            cmbGioiTinh.Items.Clear();
            cmbGioiTinh.Items.Add("NAM");
            cmbGioiTinh.Items.Add("NU");

            cmbGioiTinh.SelectedIndex = 0;
        }
        //Phuong thức Load DataGridView
        private void loadDataGridView()
        {
            using (SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();
                string query = "SELECT MAKH, TENKH, GIOITINH, SDT, DIACHI FROM KHACHHANG";

                SqlDataAdapter BoDocGhi = new SqlDataAdapter(query, KN);

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
                

                dtgvKH.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                dtgvKH.ColumnHeadersHeight = 40;

            }
        }

        //Phuonh thức tìm kiếm KH
        void TimKiemKhachHang(string tukhoa, string phamvi)
        {
            string query = "";

            if (phamvi == "Tên khách hàng")
                query = "SELECT * FROM KHACHHANG WHERE TENKH LIKE @kw";

            else if (phamvi == "Số điện thoại")
                query = "SELECT * FROM KHACHHANG WHERE SDT LIKE @kw";

            else if (phamvi == "Địa chỉ")
                query = "SELECT * FROM KHACHHANG WHERE DIACHI LIKE @kw";

            else if (phamvi == "Giới tính")
                query = "SELECT * FROM KHACHHANG WHERE GIOITINH LIKE @kw";

            else
                query = "SELECT * FROM KHACHHANG WHERE MAKH LIKE @kw";

            using (SqlConnection kn = ChuoiKN.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, kn);
                da.SelectCommand.Parameters.AddWithValue("@kw", "%" + tukhoa + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgvKH.DataSource = dt;
            }
        }
        //Phương thức resetForm lại
        private void ResetForm()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            cmbGioiTinh.SelectedIndex = -1;
            txtSDT.Clear();
            txtDiaChi.Clear();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadCMBGioiTinh();
            loadDataGridView();

            cmbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;

            txtMaKH.Enabled = false;
        }

        private void dtgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaKH.Text = dtgvKH.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKH.Text = dtgvKH.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbGioiTinh.Text = dtgvKH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSDT.Text = dtgvKH.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dtgvKH.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) ||
               cmbGioiTinh.SelectedIndex == -1 ||
               string.IsNullOrWhiteSpace(txtSDT.Text) ||
               string.IsNullOrWhiteSpace(txtDiaChi.Text))
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

            try
            {
                using (SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string insert = @"INSERT INTO KHACHHANG (TENKH, GIOITINH, SDT, DIACHI)
                                             VALUES (@TENKH, @GIOITINH, @SDT, @DIACHI)";

                    cmd = new SqlCommand(insert, KN);

                    cmd.Parameters.AddWithValue("@TENKH", txtTenKH.Text);
                    cmd.Parameters.AddWithValue("@GIOITINH", cmbGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text);

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
               string.IsNullOrWhiteSpace(txtDiaChi.Text))
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
                using (SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string sql = @"UPDATE KHACHHANG
                                   SET TENKH = @TENKH, GIOITINH = @GIOITINH, SDT = @SDT, DIACHI = @DIACHI
                                   WHERE MAKH = @MAKH";

                    cmd = new SqlCommand(sql, KN);

                    cmd.Parameters.AddWithValue("@MAKH", txtMaKH.Text);
                    cmd.Parameters.AddWithValue("@TENKH", txtTenKH.Text);
                    cmd.Parameters.AddWithValue("@GIOITINH", cmbGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text);

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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (btnTimKiem.Text == "Xem tất cả")
            {
                loadDataGridView();  
                ResetForm();            
                btnTimKiem.Text = "Tìm kiếm";
                return;
            }

            frmTimKiemKhachHang frm = new frmTimKiemKhachHang();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                TimKiemKhachHang(frm.TuKhoa, frm.PhamVi);
                btnTimKiem.Text = "Xem tất cả";
            }
        }

        private void frmKhachHang_Activated(object sender, EventArgs e)
        {
            loadDataGridView();
        }
    }
}
