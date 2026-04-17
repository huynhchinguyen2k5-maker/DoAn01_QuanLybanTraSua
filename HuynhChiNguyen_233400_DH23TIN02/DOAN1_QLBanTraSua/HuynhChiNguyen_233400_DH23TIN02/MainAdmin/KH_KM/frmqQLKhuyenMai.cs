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
    public partial class frmqQLKhuyenMai : Form
    {
        SqlCommand cmd;
        public frmqQLKhuyenMai()
        {
            InitializeComponent();
        }

        // Phuong thức Load CMB trạng thái của Khuyến mãi
        private void LoadCMBKM()
        {
            cmbTrangThai.Items.Clear();
            cmbTrangThai.Items.Add("HOAT DONG");
            cmbTrangThai.Items.Add("HET HAN");
            cmbTrangThai.Items.Add("TAM DUNG");

        }

        private void ToMauTrangThai()
        {
            foreach (DataGridViewRow row in dtgvKM.Rows)
            {
                if (row.Cells["TRANGTHAI"].Value == null) continue;

                string trangThai = row.Cells["TRANGTHAI"].Value.ToString().Trim().ToUpper();

                row.DefaultCellStyle.ForeColor = Color.Black;

                if (trangThai == "HOAT DONG")
                {
                    row.DefaultCellStyle.BackColor = Color.Honeydew;
                    row.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen;
                }
                else if (trangThai == "TAM NGUNG")
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

        //Phuong thức Load DataGridView
        private void LoadDTGV()
        {
            using(SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                string sql = @"SELECT MAKM, TENKM, PHANTRAMGIAM, NGAYBATDAU, NGAYKETTHUC, TRANGTHAI FROM KHUYENMAI";

                SqlDataAdapter BoDocGhi = new SqlDataAdapter(sql,KN);
                DataSet dsKM = new DataSet();

                BoDocGhi.Fill(dsKM);

                dtgvKM.DataSource = dsKM.Tables[0];
                dtgvKM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dtgvKM.DefaultCellStyle.ForeColor = Color.Black;
                dtgvKM.DefaultCellStyle.BackColor = Color.White;
                dtgvKM.DefaultCellStyle.SelectionForeColor = Color.White;
                dtgvKM.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;

                dtgvKM.Columns["MAKM"].HeaderText = "Mã khuyến mãi";
                dtgvKM.Columns["TENKM"].HeaderText = "Tên khuyến mãi";
                dtgvKM.Columns["PHANTRAMGIAM"].HeaderText = "Phần trăm giảm";
                dtgvKM.Columns["NGAYBATDAU"].HeaderText = "Ngày bắt đầu";
                dtgvKM.Columns["NGAYKETTHUC"].HeaderText = "Ngày kết thúc";
                dtgvKM.Columns["TRANGTHAI"].HeaderText = "Trạng thái";

                dtgvKM.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                dtgvKM.ColumnHeadersHeight = 40;

                ToMauTrangThai();
            }
        }

        //Phuong thức REsetForm
        private void ResetForm()
        {
            txtMaKM.Clear();
            txtTenKM.Clear();
            nupKM.Value = 0;
            dtpkNBD.Value = DateTime.Today;
            dtpkNKT.Value = DateTime.Today;
            cmbTrangThai.SelectedIndex = -1;

        }
        //Phuong thức tự chạy trạng thái khuyến mãi
        private string TinhTrangThai(DateTime bd, DateTime kt)
        {
            DateTime today = DateTime.Today;

            if (today < bd) return "TAM DUNG";
            if (today > kt) return "HET HAN";
            return "HOAT DONG";
        }

        //Cập nhật trạng thái tự động
        private void CapNhatTrangThaiTuDong()
        {
            using (SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();
                string sql = @"UPDATE KHUYENMAI
                               SET TRANGTHAI =
                               CASE
                                    WHEN GETDATE() < NGAYBATDAU THEN N'TAM DUNG'
                                    WHEN GETDATE() > NGAYKETTHUC THEN N'HET HAN'
                                    ELSE N'HOAT DONG'
                               END";

                cmd = new SqlCommand(sql, KN);
                cmd.ExecuteNonQuery();
            }
        }

        private void frmqQLKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadCMBKM();
            CapNhatTrangThaiTuDong();
            LoadDTGV();


            txtMaKM.Enabled = false;
            cmbTrangThai.Enabled = false;
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void dtgvKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtMaKM.Text = dtgvKM.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKM.Text = dtgvKM.Rows[e.RowIndex].Cells[1].Value.ToString();

                //Phần trăm giảm

                if (dtgvKM.Rows[e.RowIndex].Cells[2].Value != null && int.TryParse(dtgvKM.Rows[e.RowIndex].Cells[2].Value.ToString(), out int soLuong))
                {
                    if (soLuong < nupKM.Minimum)
                        soLuong = (int)nupKM.Minimum;
                    if (soLuong > nupKM.Maximum)
                        soLuong = (int)nupKM.Maximum;

                    nupKM.Value = soLuong;
                }
                else
                {
                    nupKM.Value = nupKM.Minimum;
                }

                //Ngày bắt đầu

                if (dtgvKM.Rows[e.RowIndex].Cells[3].Value == null || dtgvKM.Rows[e.RowIndex].Cells[3].Value == DBNull.Value)
                    dtpkNBD.Value = DateTime.Today;
                else
                    dtpkNBD.Value = Convert.ToDateTime(dtgvKM.Rows[e.RowIndex].Cells[3].Value);

                //Ngày kết thúc

                if (dtgvKM.Rows[e.RowIndex].Cells[4].Value == null || dtgvKM.Rows[e.RowIndex].Cells[4].Value == DBNull.Value)
                    dtpkNKT.Value = DateTime.Today;
                else
                    dtpkNKT.Value = Convert.ToDateTime(dtgvKM.Rows[e.RowIndex].Cells[4].Value);

                // Trạng thái

                cmbTrangThai.Text = dtgvKM.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            //Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txtTenKM.Text) || nupKM.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khuyến mãi!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Ngày kết thức phải lớn hơn ngày bắt đầu
            if (dtpkNKT.Value < dtpkNBD.Value)
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu!", "Lỗi ngày",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // % giảm không đc quá 100
            if (nupKM.Value > 100)
            {
                MessageBox.Show("Phần trăm giảm không được lớn hơn 100%!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using(SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string sql = @"INSERT INTO KHUYENMAI (TENKM, PHANTRAMGIAM, NGAYBATDAU, NGAYKETTHUC, TRANGTHAI)
                                   VALUES (@TENKM, @PHANTRAMGIAM, @NGAYBATDAU, @NGAYKETTHUC, @TRANGTHAI)";

                    cmd = new SqlCommand(sql,KN);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@TENKM", SqlDbType.NVarChar, 100).Value = txtTenKM.Text.Trim();
                    cmd.Parameters.Add("@PHANTRAMGIAM", SqlDbType.Int).Value = (int)nupKM.Value;
                    cmd.Parameters.Add("@NGAYBATDAU", SqlDbType.Date).Value = dtpkNBD.Value.Date;
                    cmd.Parameters.Add("@NGAYKETTHUC", SqlDbType.Date).Value = dtpkNKT.Value.Date;

                    string trangThai = TinhTrangThai(dtpkNBD.Value.Date, dtpkNKT.Value.Date);
                    cmd.Parameters.Add("@TRANGTHAI", SqlDbType.NVarChar, 20).Value = trangThai;

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Thêm khuyến mãi mới thành công.");
                LoadDTGV();
                ResetForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm khuyến mãi mới không thành công." + ex.Message);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvKM.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin khuyến mãi cần Xóa.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn Xóa khuyến mãi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.No) return;

            try
            {
                using (SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string query = @"UPDATE KHUYENMAI
                                     SET TRANGTHAI = N'TAM DUNG' 
                                     WHERE MAKM = @MAKM";

                    cmd = new SqlCommand(query, KN);
                    cmd.Parameters.Add("@MAKM", SqlDbType.VarChar, 10).Value = txtMaKM.Text;
                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Đã thay đổi trạng thái của khuyến mãi.");
                LoadDTGV();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thay đổi trang thái của khuyến mãi không thành công!!!" + ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            if (dtgvKM.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin khuyến mãi cần cập nhật.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txtTenKM.Text) || nupKM.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khuyến mãi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Ngày kết thức phải lớn hơn ngày bắt đầu
            if (dtpkNKT.Value < dtpkNBD.Value)
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu!", "Lỗi ngày", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // % giảm không đc quá 100
            if (nupKM.Value > 100)
            {
                MessageBox.Show("Phần trăm giảm không được lớn hơn 100%!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc muốn cập nhật khuyến mãi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.No) return;

            try
            {
                using (SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string sql = @"UPDATE KHUYENMAI
                                   SET  TENKM = @TENKM, 
                                        PHANTRAMGIAM = @PHANTRAMGIAM,
                                        NGAYBATDAU = @NGAYBATDAU, 
                                        NGAYKETTHUC = @NGAYKETTHUC, 
                                        TRANGTHAI = @TRANGTHAI
                                   WHERE MAKM =@MAKM";

                    cmd = new SqlCommand(sql, KN);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@MAKM", SqlDbType.VarChar,10).Value = txtMaKM.Text;
                    cmd.Parameters.Add("@TENKM", SqlDbType.NVarChar, 100).Value = txtTenKM.Text.Trim();
                    cmd.Parameters.Add("@PHANTRAMGIAM", SqlDbType.Int).Value = (int)nupKM.Value;
                    cmd.Parameters.Add("@NGAYBATDAU", SqlDbType.Date).Value = dtpkNBD.Value.Date;
                    cmd.Parameters.Add("@NGAYKETTHUC", SqlDbType.Date).Value = dtpkNKT.Value.Date;

                    string trangThai = TinhTrangThai(dtpkNBD.Value.Date, dtpkNKT.Value.Date);
                    cmd.Parameters.Add("@TRANGTHAI", SqlDbType.NVarChar, 20).Value = trangThai;

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Cập nhật thông tin khuyến mãi thành công.");
                LoadDTGV();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("cập nhật thông tin khuyến mãi không thành công." + ex.Message);
            }
        }
        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmqQLKhuyenMai_Activated(object sender, EventArgs e)
        {
            LoadDTGV();
        }
    }
}
