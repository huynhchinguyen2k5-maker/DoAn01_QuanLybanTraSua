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
    public partial class frmNhatKy : Form
    {
        public frmNhatKy()
        {
            InitializeComponent();
        }

        //comboBox TenTK
        private void CMBTenTk()
        {
            using (SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                string query = "SELECT TENTK FROM TAIKHOAN WHERE TRANGTHAI = N'HOAT DONG'";

                SqlDataAdapter da = new SqlDataAdapter(query, KN);

                DataTable dsNV = new DataTable();

                da.Fill(dsNV);

                cmbTenTK.DataSource = dsNV;
                cmbTenTK.DisplayMember = "TENTK";
                cmbTenTK.ValueMember = "TENTK";

                cmbTenTK.SelectedIndex = -1;
            }
        }

        //ComboBox Phan loại Nhật ký
        private void CMBLoaiNhatKy()
        {
            cmbPhanLoai.Items.Clear();
            cmbPhanLoai.Items.Add("LOGIN");
            cmbPhanLoai.Items.Add("TAIKHOAN");
            cmbPhanLoai.Items.Add("NHANVIEN");
            cmbPhanLoai.Items.Add("KHACHHANG");
            cmbPhanLoai.Items.Add("SANPHAM");
            cmbPhanLoai.Items.Add("KHUYENMAI");
            cmbPhanLoai.Items.Add("HOADON");
            cmbPhanLoai.Items.Add("BANHANG");

            cmbPhanLoai.SelectedIndex = -1;

        }
        //Load Nhật Ký
        private void LoadNhatKy()
        {
            using (SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                string query = @"SELECT ID, THOIGIAN, TENTK, PHANLOAI, HANHDONG
                                 FROM NHATKY
                                 ORDER BY THOIGIAN DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, KN);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dtgvNhatKy.DataSource = dt;

                dtgvNhatKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dtgvNhatKy.DefaultCellStyle.ForeColor = Color.Black;
                dtgvNhatKy.DefaultCellStyle.BackColor = Color.White;
                dtgvNhatKy.DefaultCellStyle.SelectionForeColor = Color.White;
                dtgvNhatKy.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;

                dtgvNhatKy.Columns["ID"].HeaderText = "ID";
                dtgvNhatKy.Columns["THOIGIAN"].HeaderText = "Thời gian";
                dtgvNhatKy.Columns["TENTK"].HeaderText = "Tên tài khoản";
                dtgvNhatKy.Columns["HANHDONG"].HeaderText = "Hành động";
                dtgvNhatKy.Columns["PHANLOAI"].HeaderText = "Phân loại";

                dtgvNhatKy.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                dtgvNhatKy.ColumnHeadersHeight = 40;
            }
        }

        //Phuonh thức tìm kiếm KH
        void TimKiemNhatKy(string phanloai)
        {
            string query = @"SELECT ID, THOIGIAN, TENTK, PHANLOAI, HANHDONG
                     FROM NHATKY
                     WHERE PHANLOAI = @pl
                     ORDER BY THOIGIAN DESC";

            using (SqlConnection kn = ChuoiKN.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, kn);
                da.SelectCommand.Parameters.AddWithValue("@pl", phanloai);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dtgvNhatKy.DataSource = dt;
            }
        }
        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhatKy_Load(object sender, EventArgs e)
        {
            CMBTenTk();
            CMBLoaiNhatKy();
            LoadNhatKy();

            txtID.ReadOnly = true;
            dtpkThoiGian.Enabled = false;
            txthanhDong.ReadOnly = true;
            cmbTenTK.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPhanLoai.DropDownStyle = ComboBoxStyle.DropDownList;

            txthanhDong.Multiline = true;
            txthanhDong.AutoSize = false;
            txthanhDong.ScrollBars = ScrollBars.Vertical;
        }

        private void dtgvNhatKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtID.Text = dtgvNhatKy.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                if (dtgvNhatKy.Rows[e.RowIndex].Cells["THOIGIAN"].Value == null || dtgvNhatKy.Rows[e.RowIndex].Cells["THOIGIAN"].Value == DBNull.Value)
                    dtpkThoiGian.Value = DateTime.Now;
                else
                    dtpkThoiGian.Value = Convert.ToDateTime(dtgvNhatKy.Rows[e.RowIndex].Cells["THOIGIAN"].Value);

                cmbTenTK.SelectedValue = dtgvNhatKy.Rows[e.RowIndex].Cells["TENTK"].Value.ToString();

                object hd = dtgvNhatKy.Rows[e.RowIndex].Cells["HANHDONG"].Value;

                if (hd == null || hd == DBNull.Value)
                    txthanhDong.Text = "";
                else
                    txthanhDong.Text = hd.ToString();

                cmbPhanLoai.Text = dtgvNhatKy.Rows[e.RowIndex].Cells["PHANLOAI"].Value.ToString();

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (btnTimKiem.Text == "Xem tất cả")
            {
                LoadNhatKy();
                btnTimKiem.Text = "Tìm kiếm";
                return;
            }

            frmTKNhatKy frm = new frmTKNhatKy();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                TimKiemNhatKy(frm.PhamVi);
                btnTimKiem.Text = "Xem tất cả";
            }
        }
    }
}
