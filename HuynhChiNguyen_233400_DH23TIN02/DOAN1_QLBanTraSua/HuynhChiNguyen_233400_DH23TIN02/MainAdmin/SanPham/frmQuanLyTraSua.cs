using HuynhChiNguyen_233400_DH23TIN02.MainAdmin;
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
    public partial class frmQuanLyTraSua : Form
    {
        SqlCommand cmd;

        public frmQuanLyTraSua()
        {
            InitializeComponent();
        }

        //Phuong thức Load combobox Loại trà sữa

        private void LoadCMBLTS()
        {
            using(SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                string query = @"SELECT MALOAITS, TENLOAI FROM LOAITRASUA WHERE TRANGTHAI = 1";

                SqlDataAdapter da = new SqlDataAdapter(query, KN);

                DataSet dsLTS = new DataSet();

                da.Fill(dsLTS);

                cmbLoaiTS.DataSource = dsLTS.Tables[0];
                cmbLoaiTS.DisplayMember = "TENLOAI";
                cmbLoaiTS.ValueMember = "MALOAITS";

            }
        }

        //Phuong thức load ComboBox Trạng Thái của  trà sữa
        private void LoadCMBTrangThai()
        {
            var dsTrangThai = new List<object>
            {
                new { Text = "CÒN BÁN", Value = 1 },
                new { Text = "NGỪNG BÁN", Value = 0 }
            };

            cmbTrangThai.DataSource = dsTrangThai;
            cmbTrangThai.DisplayMember = "Text";
            cmbTrangThai.ValueMember = "Value";
        }

        private void ToMauTrangThai()
        {
            foreach (DataGridViewRow row in dtgvTS.Rows)
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

        //Phuong thức load DataGridView
        private void LoadDTGV()
        {
            using (SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                string query = @"SELECT MATS, TENTS, DONGIA, MALOAITS, TRANGTHAI FROM TRASUA";

                SqlDataAdapter BoDocGhi = new SqlDataAdapter(query, KN);

                DataSet dsTS = new DataSet();

                BoDocGhi.Fill(dsTS);

                dtgvTS.DataSource = dsTS.Tables[0];

                dtgvTS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dtgvTS.DefaultCellStyle.ForeColor = Color.Black;
                dtgvTS.DefaultCellStyle.BackColor = Color.White;
                dtgvTS.DefaultCellStyle.SelectionForeColor = Color.White;
                dtgvTS.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;

                dtgvTS.Columns["MATS"].HeaderText = "Mã trà sữa";
                dtgvTS.Columns["TENTS"].HeaderText = "Tên trà sữa";
                dtgvTS.Columns["DONGIA"].HeaderText = "Đơn giá";
                dtgvTS.Columns["MALOAITS"].HeaderText = "Loại trà sữa";
                dtgvTS.Columns["TRANGTHAI"].HeaderText = "Trạng thái";

                dtgvTS.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                dtgvTS.ColumnHeadersHeight = 40;

                ToMauTrangThai();
            }
        }

        //Phuong thức ResetForm
        private void ResetForm()
        {
            txtMaTS.Clear();
            txtTenTS.Clear();
            txtDonGia.Clear();
            cmbLoaiTS.SelectedIndex = -1;
            cmbTrangThai.SelectedIndex = -1;
        }
        private void frmQuanLyTraSua_Load(object sender, EventArgs e)
        {
            LoadCMBLTS();
            LoadCMBTrangThai();
            LoadDTGV();

            if (dtgvTS.Columns["TRANGTHAI"] is DataGridViewCheckBoxColumn chk)
            {
                chk.TrueValue = 1;
                chk.FalseValue = 0;
                chk.IndeterminateValue = 0;
                chk.ThreeState = false;
            }

            cmbLoaiTS.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;

            txtMaTS.Enabled = false;
        }

        private void dtgvTS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtMaTS.Text = dtgvTS.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenTS.Text = dtgvTS.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDonGia.Text = dtgvTS.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbLoaiTS.SelectedValue = dtgvTS.Rows[e.RowIndex].Cells[3].Value.ToString();

                object TrangThai = dtgvTS.Rows[e.RowIndex].Cells[4].Value;
                if (TrangThai != null && TrangThai != DBNull.Value)
                {
                    bool TT = Convert.ToBoolean(TrangThai);
                    cmbTrangThai.SelectedValue = TT ? 1 : 0;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra thông tin nhập vào có rỗng hay không

            if(string.IsNullOrWhiteSpace(txtTenTS.Text) ||
               string.IsNullOrWhiteSpace(txtDonGia.Text) ||
               cmbLoaiTS.SelectedIndex == -1 ||
               cmbTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông tin không hợp lệ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal donGia;

            // 2. Kiểm tra đơn giá có phải số không
            if (!decimal.TryParse(txtDonGia.Text, out  donGia))
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ!","Sai định dạng",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            // 3. Kiểm tra đơn giá > 0
            if (donGia <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0!","Sai giá trị",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            try
            {
                using(SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string query = @"INSERT INTO TRASUA (TENTS, DONGIA, MALOAITS, TRANGTHAI)
                                     VALUES (@TENTS, @DONGIA, @MALOAITS, @TRANGTHAI)";

                    cmd = new SqlCommand(query,KN);

                    cmd.Parameters.AddWithValue("@TENTS", txtTenTS.Text);

                    var p = cmd.Parameters.Add("@DONGIA", SqlDbType.Decimal);
                    p.Precision = 18;
                    p.Scale = 2;
                    p.Value = donGia;

                    cmd.Parameters.AddWithValue("@MALOAITS", cmbLoaiTS.SelectedValue);
                    cmd.Parameters.Add("@TRANGTHAI", SqlDbType.Bit).Value = cmbTrangThai.SelectedValue;

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Thêm thông tin thành công.");
                LoadDTGV();
                ResetForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm thông tin không thành công." + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dtgvTS.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin cần xóa.","Thông tin không hợp lệ",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn ngừng bán món trà sữa này không?","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            try
            {
                using(SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string sql = @"UPDATE TRASUA
                                   SET TRANGTHAI = 0
                                   WHERE MATS = @MATS";
                    cmd = new SqlCommand(sql, KN);

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MATS", txtMaTS.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Trạng thái của trà sữa đã được thay đổi");
                LoadDTGV();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thông tin không thành công" + ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
            if (dtgvTS.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin cần cập nhật.", "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenTS.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text) ||
                cmbLoaiTS.SelectedIndex == -1 ||
                cmbTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn cập nhật thông tin cho món trà sữa này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            decimal donGia;

            // 2. Kiểm tra đơn giá có phải số không
            if (!decimal.TryParse(txtDonGia.Text, out donGia))
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ!", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            // 3. Kiểm tra đơn giá > 0
            if (donGia <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0!", "Sai giá trị", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            try
            {
                using (SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string sql = @"UPDATE TRASUA
                                   SET TENTS = @TENTS, DONGIA = @DONGIA, MALOAITS = @MALOAITS, TRANGTHAI = @TRANGTHAI
                                   WHERE MATS = @MATS";
                    cmd = new SqlCommand(sql, KN);

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MATS", txtMaTS.Text);
                    cmd.Parameters.AddWithValue("@TENTS", txtTenTS.Text);

                    var p = cmd.Parameters.Add("@DONGIA", SqlDbType.Decimal);
                    p.Precision = 18;
                    p.Scale = 2;
                    p.Value = donGia;

                    cmd.Parameters.AddWithValue("@MALOAITS", cmbLoaiTS.SelectedValue);
                    cmd.Parameters.Add("@TRANGTHAI", SqlDbType.Bit).Value = cmbTrangThai.SelectedValue;

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cập nhật thông tin thành công");
                LoadDTGV();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thông tin không thành công" + ex.Message);
            }
        }
        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyTraSua_Activated(object sender, EventArgs e)
        {
            LoadDTGV();
        }
    }
}
