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

namespace HuynhChiNguyen_233400_DH23TIN02.MainAdmin
{
    public partial class frmQuanLyPhanLoaiTraSua : Form
    {
        SqlCommand cmd;
        public frmQuanLyPhanLoaiTraSua()
        {
            InitializeComponent();
        }

        //Phuong thức load ComboBox Trạng Thái của phân loại trà sữa
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
            foreach (DataGridViewRow row in dtgvLTS.Rows)
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
        private void LoadDataGridView()
        {
            using(SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                string sql = "SELECT MALOAITS, TENLOAI, TRANGTHAI FROM LOAITRASUA";

                SqlDataAdapter BoDocghi = new SqlDataAdapter(sql,KN);

                DataSet dsLTS = new DataSet();

                BoDocghi.Fill(dsLTS);

                dtgvLTS.DataSource = dsLTS.Tables[0];
                dtgvLTS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dtgvLTS.DefaultCellStyle.ForeColor = Color.Black;
                dtgvLTS.DefaultCellStyle.BackColor = Color.White;
                dtgvLTS.DefaultCellStyle.SelectionForeColor = Color.White;
                dtgvLTS.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;

                dtgvLTS.Columns["MALOAITS"].HeaderText = "Mã loại trà sữa";
                dtgvLTS.Columns["TENLOAI"].HeaderText = "Tên loại trà sữa";
                dtgvLTS.Columns["TRANGTHAI"].HeaderText = "Trạng thái";

                dtgvLTS.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                dtgvLTS.ColumnHeadersHeight = 40;

                ToMauTrangThai();
            }
        }

        //Phuong thức ResetForm
        private void ResetForm()
        {
            txtMaLTS.Clear();
            txtTenLTS.Clear();
            cmbTrangThai.SelectedIndex = 0;
        }

        private void frmQuanLyPhanLoaiTraSua_Load(object sender, EventArgs e)
        {

            LoadCMBTrangThai();
            LoadDataGridView();

            if (dtgvLTS.Columns["TRANGTHAI"] is DataGridViewCheckBoxColumn chk)
            {
                chk.TrueValue = 1;
                chk.FalseValue = 0;
                chk.IndeterminateValue = 0;
                chk.ThreeState = false;
            }

            
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            txtMaLTS.Enabled = false;
        }

        private void dtgvLTS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtMaLTS.Text = dtgvLTS.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenLTS.Text = dtgvLTS.Rows[e.RowIndex].Cells[1].Value.ToString();

                object TrangThai = dtgvLTS.Rows[e.RowIndex].Cells[2].Value;
                if (TrangThai != null && TrangThai != DBNull.Value)
                {
                    bool TT = Convert.ToBoolean(TrangThai);
                    cmbTrangThai.SelectedValue = TT ? 1 : 0;
                }
            }
        }

        //Nút Xóa thông tin
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dtgvLTS.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin cần xóa.", "Thông tin không hợp lệ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn chắc chắc muốn xóa Loại trà sữa này.","Xác nhận",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            try
            {
                using(SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string sql = @"UPDATE LOAITRASUA
                                   SET TRANGTHAI = 0
                                   WHERE MALOAITS = @MALOAITS";

                    cmd = new SqlCommand(sql, KN);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MALOAITS", txtMaLTS.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã thay đổi trạng thái của loại trà sữa");
                LoadDataGridView();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thanh công" + ex.Message);
            }
        }

        //Nút cập nhật thông tin
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dtgvLTS.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin cần cập nhật.", "Thông tin không hợp lệ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenLTS.Text) || cmbTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy ddue thông tin cần thêm.", "Thông tin không hợp lệ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn chắc chắc muốn cập nhật thông tin của Loại trà sữa này.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            try
            {
                using (SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string sql = @"UPDATE LOAITRASUA
                                   SET TENLOAI = @TENLOAI, TRANGTHAI = @TRANGTHAI
                                   WHERE MALOAITS = @MALOAITS";

                    cmd = new SqlCommand(sql, KN);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MALOAITS", txtMaLTS.Text);
                    cmd.Parameters.AddWithValue("@TENLOAI", txtTenLTS.Text);
                    cmd.Parameters.Add("@TRANGTHAI", SqlDbType.Bit).Value = cmbTrangThai.SelectedValue;

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã thay đổi trạng thái của loại trà sữa");
                LoadDataGridView();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thanh công" + ex.Message);
            }
        }

        //Nut thêm loại trà sữa mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLTS.Text) || cmbTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy ddue thông tin cần thêm.", "Thông tin không hợp lệ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using(SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string query = @"INSERT INTO LOAITRASUA (TENLOAI, TRANGTHAI)
                                     VALUES (@TENLOAI, @TRANGTHAI)";

                    cmd = new SqlCommand(query,KN);

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@TENLOAI", txtTenLTS.Text);
                    cmd.Parameters.Add("@TRANGTHAI", SqlDbType.Bit).Value = cmbTrangThai.SelectedValue;

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thêm thông tin thành công.");
                LoadDataGridView();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thông tin không thành công!!!" + ex.Message);
            }
        }

        private void btnTraSua_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmQuanLyTraSua)
                {
                    f.Activate();
                    return;
                }
            }

            frmQuanLyTraSua frm = new frmQuanLyTraSua();
            frm.Show();
        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyPhanLoaiTraSua_Activated(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
