using Guna.Charts.WinForms;
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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        //Phuong thức CMB Loại Trà sữa
        private void LoadCMBLTS()
        {
            using (SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                string query = @"SELECT TENLOAI FROM LOAITRASUA WHERE TRANGTHAI = 1";

                SqlDataAdapter da = new SqlDataAdapter(query, KN);

                DataSet dsLTS = new DataSet();

                da.Fill(dsLTS);

                cmbLoaiTS.DataSource = dsLTS.Tables[0];
                cmbLoaiTS.DisplayMember = "TENLOAI";
                cmbLoaiTS.ValueMember = "TENLOAI";

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

        //Phuong thức load DataGridView
        private void LoadDTGV()
        {
            using (SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                string query = @"SELECT TS.MATS, TS.TENTS, TS.DONGIA, LTS.TENLOAI, TS.TRANGTHAI
                                  FROM TRASUA TS
                                  JOIN LOAITRASUA LTS ON TS.MALOAITS = LTS.MALOAITS";

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
                dtgvTS.Columns["TENLOAI"].HeaderText = "Loại trà sữa";
                dtgvTS.Columns["TRANGTHAI"].HeaderText = "Trạng thái";

                dtgvTS.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                dtgvTS.ColumnHeadersHeight = 40;

            }
        }
        void TimKiemTraSua(string tukhoa, string phamvi)
        {
            string query = "";

            if (phamvi == "Tên trà sữa")
                query = @"SELECT TS.MATS, TS.TENTS, TS.DONGIA, LTS.TENLOAI, TS.TRANGTHAI
                          FROM TRASUA TS
                          JOIN LOAITRASUA LTS ON TS.MALOAITS = LTS.MALOAITS
                          WHERE TS.TENTS LIKE @kw";

            else if (phamvi == "Loại trà sữa")
                query = @"SELECT TS.MATS, TS.TENTS, TS.DONGIA, LTS.TENLOAI, TS.TRANGTHAI
                          FROM TRASUA TS
                          JOIN LOAITRASUA LTS ON TS.MALOAITS = LTS.MALOAITS
                          WHERE LTS.TENLOAI LIKE @kw";

            else if (phamvi == "Đơn giá")
                query = @"SELECT TS.MATS, TS.TENTS, TS.DONGIA, LTS.TENLOAI, TS.TRANGTHAI
                          FROM TRASUA TS
                          JOIN LOAITRASUA LTS ON TS.MALOAITS = LTS.MALOAITS
                          WHERE CAST(TS.DONGIA AS NVARCHAR) LIKE @kw";

            else
                query = @"SELECT TS.MATS, TS.TENTS, TS.DONGIA, LTS.TENLOAI, TS.TRANGTHAI
                          FROM TRASUA TS
                          JOIN LOAITRASUA LTS ON TS.MALOAITS = LTS.MALOAITS
                          WHERE TS.MATS LIKE @kw";

            using (SqlConnection kn = ChuoiKN.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, kn);
                da.SelectCommand.Parameters.AddWithValue("@kw", "%" + tukhoa + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgvTS.DataSource = dt;
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
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadCMBLTS();
            LoadCMBTrangThai();

            LoadDTGV();

            cmbLoaiTS.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;

            txtMaTS.ReadOnly = true;
            txtTenTS.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            cmbTrangThai.Enabled = false;
            cmbLoaiTS.Enabled = false;
        }

        private void dtgvTS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (btnTimkiem.Text == "Xem tất cả")
            {
                LoadDTGV();
                ResetForm();
                btnTimkiem.Text = "Tìm kiếm";
                return;
            }

            frmTimKiemSanPham frm = new frmTimKiemSanPham();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                TimKiemTraSua(frm.TuKhoa, frm.PhamVi);
                btnTimkiem.Text = "Xem tất cả";
            }
        }

        private void btnMoBan_Click(object sender, EventArgs e)
        {
            if (txtMaTS.Text == "")
            {
                MessageBox.Show("Vui lòng chọn món!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Xác nhận mở bán lại món này?",
                "Bán lại",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (rs == DialogResult.OK)
            {
                frmLyDoThayDoiTrangThai f = new frmLyDoThayDoiTrangThai(txtMaTS.Text, txtTenTS.Text, true);
                f.ShowDialog();
                LoadDTGV();
            }
        }

        private void btnHetMon_Click(object sender, EventArgs e)
        {
            if (txtMaTS.Text == "")
            {
                MessageBox.Show("Vui lòng chọn món!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Xác nhận món này đã HẾT và chuyển sang NGỪNG BÁN?",
                "Hết món",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (rs == DialogResult.OK)
            {
                frmLyDoThayDoiTrangThai f = new frmLyDoThayDoiTrangThai(txtMaTS.Text, txtTenTS.Text, false);
                f.ShowDialog();
                LoadDTGV();
            }
        }

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmBanHang)
                {
                    f.Activate();
                    return;
                }
            }

            frmBanHang frm = new frmBanHang();
            frm.Show();
        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSanPham_Activated(object sender, EventArgs e)
        {
            LoadDTGV();
        }
    }
}
