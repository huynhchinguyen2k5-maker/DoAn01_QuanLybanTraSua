using System;
using System.Collections;
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
    public partial class frmQLChiTietHoaDon : Form
    {
        SqlCommand cmd;
        public frmQLChiTietHoaDon()
        {
            InitializeComponent();
        }

        //Phuong thức Load ComboBox
        private void LoadCMB(ComboBox cmb, string SELECT, string displayMember, string valueMember)
        {
            using (SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                SqlDataAdapter da = new SqlDataAdapter(SELECT, KN);
                DataSet ds = new DataSet();
                da.Fill(ds);


                cmb.DataSource = ds.Tables[0];
                cmb.DisplayMember = displayMember;
                cmb.ValueMember = valueMember;
                cmb.SelectedIndex = -1;

                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        //phuong thức Load DataGridView
        private void LoadDTGV()
        {
           
            using (SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                string query = "SELECT MAHD, MATS, SOLUONG, DONGIA, THANHTIEN FROM CHITIETHOADON";

                SqlDataAdapter BoDocGhi = new SqlDataAdapter(query, KN);

                DataSet dsCTHD  = new DataSet();

                BoDocGhi.Fill(dsCTHD);

                dtgvCTHD.DataSource = dsCTHD.Tables[0];

                dtgvCTHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dtgvCTHD.DefaultCellStyle.ForeColor = Color.Black;
                dtgvCTHD.DefaultCellStyle.BackColor = Color.White;
                dtgvCTHD.DefaultCellStyle.SelectionForeColor = Color.White;
                dtgvCTHD.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;

                dtgvCTHD.Columns["MAHD"].HeaderText = "Mã hóa đơn";
                dtgvCTHD.Columns["MATS"].HeaderText = "Mã trà sữa";
                dtgvCTHD.Columns["SOLUONG"].HeaderText = "Số lượng";
                dtgvCTHD.Columns["DONGIA"].HeaderText = "Đơn giá";
                dtgvCTHD.Columns["THANHTIEN"].HeaderText = "Thành tiền";

                dtgvCTHD.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                dtgvCTHD.ColumnHeadersHeight = 40;
            }
        }
        //Kiểm tra 
        private bool HoaDonHopLe(SqlConnection KN, int mahd)
        {
            string sql = "SELECT TRANGTHAI FROM HOADON WHERE MAHD = @MAHD";
            using (SqlCommand cmd = new SqlCommand(sql, KN))
            {
                cmd.Parameters.AddWithValue("@MAHD", mahd);
                string tt = cmd.ExecuteScalar()?.ToString();

                if (tt == null)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn!");
                    return false;
                }

                if (tt == "DA THANH TOAN" || tt == "HUY")
                {
                    MessageBox.Show("Hóa đơn đã " + tt + " nên không thể thao tác!");
                    return false;
                }
            }
            return true;
        }

        private bool MonDangBan(SqlConnection KN, string mats)
        {
            string sql = "SELECT TRANGTHAI FROM TRASUA WHERE MATS = @MATS";
            using (SqlCommand cmd = new SqlCommand(sql, KN))
            {
                cmd.Parameters.AddWithValue("@MATS", mats);
                object kq = cmd.ExecuteScalar();

                if (kq == null || Convert.ToInt32(kq) == 0)
                {
                    MessageBox.Show("Món này đã ngừng bán!");
                    return false;
                }
            }
            return true;
        }

        //Phuong ResetForm
        private void ResetForm()
        {
            cmbHD.SelectedIndex = -1;
            cmbTS.SelectedIndex = -1;

            nupSL.Value = 0;

            txtDonGia.Clear();
            txtThanhTien.Clear();

        }
        private void frmQLChiTietHoaDon_Load(object sender, EventArgs e)
        {
            LoadCMB(cmbHD, "SELECT MAHD FROM HOADON WHERE TRANGTHAI = N'CHUA THANH TOAN'", "MAHD", "MAHD");
            LoadCMB(cmbTS, "SELECT MATS, TENTS FROM TRASUA WHERE TRANGTHAI = 1", "TENTS", "MATS");

            LoadDTGV();

            txtDonGia.ReadOnly = true;
            txtThanhTien.ReadOnly = true;

        }

        private void dtgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || dtgvCTHD.Rows[e.RowIndex].IsNewRow) return;

            var row = dtgvCTHD.Rows[e.RowIndex];

            // ComboBox Hóa Đơn 

            if (row.Cells["MAHD"].Value != DBNull.Value)
            {
                int mahd = Convert.ToInt32(row.Cells["MAHD"].Value);

                for (int i = 0; i < cmbHD.Items.Count; i++)
                {
                    DataRowView drv = (DataRowView)cmbHD.Items[i];
                    if (Convert.ToInt32(drv["MAHD"]) == mahd)
                    {
                        cmbHD.SelectedIndex = i;
                        break;
                    }
                }
            }

            // ComboBox Trà Sữa

            if (row.Cells["MATS"].Value != DBNull.Value)
            {
                string mats = row.Cells["MATS"].Value.ToString();

                for (int i = 0; i < cmbTS.Items.Count; i++)
                {
                    DataRowView drv = (DataRowView)cmbTS.Items[i];
                    if (drv["MATS"].ToString() == mats)
                    {
                        cmbTS.SelectedIndex = i;
                        break;
                    }
                }
            }

            // Số lượng

            if (row.Cells["SOLUONG"].Value != DBNull.Value)
                nupSL.Value = Convert.ToInt32(row.Cells["SOLUONG"].Value);
            else nupSL.Value = 0;

            // Đơn giá 

            if (row.Cells["DONGIA"].Value != DBNull.Value)
                txtDonGia.Text = Convert.ToDecimal(row.Cells["DONGIA"].Value).ToString("N0");
            else txtDonGia.Clear();

            // Thành tiền 

            if (row.Cells["THANHTIEN"].Value != DBNull.Value)
                txtThanhTien.Text = Convert.ToDecimal(row.Cells["THANHTIEN"].Value).ToString("N0");
            else txtThanhTien.Clear();
        }



        //Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbHD.SelectedIndex == -1 || cmbTS.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn và trà sữa!");
                return;
            }

            if (nupSL.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!");
                return;
            }

            int mahd = Convert.ToInt32(cmbHD.SelectedValue);
            string mats = cmbTS.SelectedValue.ToString();
            int soluong = (int)nupSL.Value;

            using (SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                if (!HoaDonHopLe(KN, mahd)) return;
                if (!MonDangBan(KN, mats)) return;

                string check = "SELECT COUNT(*) FROM CHITIETHOADON WHERE MAHD=@MAHD AND MATS=@MATS";
                using (SqlCommand cmdCheck = new SqlCommand(check, KN))
                {
                    cmdCheck.Parameters.AddWithValue("@MAHD", mahd);
                    cmdCheck.Parameters.AddWithValue("@MATS", mats);

                    if ((int)cmdCheck.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Món này đã tồn tại trong hóa đơn!");
                        return;
                    }
                }

                string insert = @"INSERT INTO CHITIETHOADON(MAHD,MATS,SOLUONG)
                                         VALUES(@MAHD,@MATS,@SOLUONG)";
                using (SqlCommand cmd = new SqlCommand(insert, KN))
                {
                    cmd.Parameters.AddWithValue("@MAHD", mahd);
                    cmd.Parameters.AddWithValue("@MATS", mats);
                    cmd.Parameters.AddWithValue("@SOLUONG", soluong);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thêm thành công!");
                LoadDTGV();
                ResetForm();
            }
        }

        //Nút xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvCTHD.CurrentRow == null || dtgvCTHD.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn chi tiết cần xóa!");
                return;
            }

            int mahd = Convert.ToInt32(dtgvCTHD.CurrentRow.Cells["MAHD"].Value);
            string mats = dtgvCTHD.CurrentRow.Cells["MATS"].Value.ToString();

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            using (SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();
                if (!HoaDonHopLe(KN, mahd)) return;

                string delete = "DELETE FROM CHITIETHOADON WHERE MAHD=@MAHD AND MATS=@MATS";
                using (SqlCommand cmd = new SqlCommand(delete, KN))
                {
                    cmd.Parameters.AddWithValue("@MAHD", mahd);
                    cmd.Parameters.AddWithValue("@MATS", mats);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Xóa thành công!");
                LoadDTGV();
                ResetForm();
            }
        }
        //Nút cập nhật
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dtgvCTHD.CurrentRow == null || dtgvCTHD.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn dòng cần cập nhật!");
                return;
            }

            if (nupSL.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!");
                return;
            }

            int mahd = Convert.ToInt32(dtgvCTHD.CurrentRow.Cells["MAHD"].Value);
            string matsCu = dtgvCTHD.CurrentRow.Cells["MATS"].Value.ToString();
            string matsMoi = cmbTS.SelectedValue.ToString();
            int soluong = (int)nupSL.Value;

            using (SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                if (!HoaDonHopLe(KN, mahd)) return;
                if (!MonDangBan(KN, matsMoi)) return;

                // Nếu đổi sang món khác thì phải kiểm tra trùng
                if (matsMoi != matsCu)
                {
                    string checkTrung = @"SELECT COUNT(*) FROM CHITIETHOADON 
                          WHERE MAHD=@MAHD AND MATS=@MATS";
                    using (SqlCommand cmdCheck = new SqlCommand(checkTrung, KN))
                    {
                        cmdCheck.Parameters.AddWithValue("@MAHD", mahd);
                        cmdCheck.Parameters.AddWithValue("@MATS", matsMoi);

                        if ((int)cmdCheck.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Hóa đơn này đã có món đó rồi!");
                            return;
                        }
                    }
                }


                string update = @"UPDATE CHITIETHOADON
                                  SET MATS=@MATS_MOI, SOLUONG=@SOLUONG
                                  WHERE MAHD=@MAHD AND MATS=@MATS_CU";

                using (SqlCommand cmd = new SqlCommand(update, KN))
                {
                    cmd.Parameters.AddWithValue("@MATS_MOI", matsMoi);
                    cmd.Parameters.AddWithValue("@SOLUONG", soluong);
                    cmd.Parameters.AddWithValue("@MAHD", mahd);
                    cmd.Parameters.AddWithValue("@MATS_CU", matsCu);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cập nhật thành công!");
                LoadDTGV();
                ResetForm();
            }
        }
        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQLChiTietHoaDon_Activated(object sender, EventArgs e)
        {
            LoadDTGV();
        }

        private void cmbTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTS.SelectedIndex == -1) return;

            using (SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                string sql = "SELECT DONGIA FROM TRASUA WHERE MATS = @MATS";

                using (SqlCommand cmd = new SqlCommand(sql, KN))
                {
                    cmd.Parameters.AddWithValue("@MATS", cmbTS.SelectedValue.ToString());

                    object kq = cmd.ExecuteScalar();

                    if (kq != null)
                    {
                        txtDonGia.Text = Convert.ToDecimal(kq).ToString("N0");
                    }
                }
            }
        }
    }
}
