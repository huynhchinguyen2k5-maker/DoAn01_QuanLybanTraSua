using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuynhChiNguyen_233400_DH23TIN02
{
    public partial class frmInBaocaoNhanVienBanHang : Form
    {
        public frmInBaocaoNhanVienBanHang()
        {
            InitializeComponent();
        }

        //ComboBox Nhan Viên
        private void CMBNhanVien()
        {
            using(SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();
                string query = "SELECT MANV, TENNV FROM NHANVIEN WHERE TRANGTHAI = N'DANG LAM' ";
                SqlDataAdapter da = new SqlDataAdapter(query, KN);
                DataTable tb = new DataTable();
                da.Fill(tb);

                cmbTenNV.DataSource = tb;
                cmbTenNV.DisplayMember = "TENNV";
                cmbTenNV.ValueMember= "MANV";

                cmbTenNV.SelectedIndex = -1;

            }
        }
        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInBaocaoNhanVienBanHang_Load(object sender, EventArgs e)
        {
            CMBNhanVien();

            this.rpvNV.RefreshReport();
        }

        private void btnXemBC_Click(object sender, EventArgs e)
        {
            if (cmbTenNV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!");
                return;
            }

            string maNV = cmbTenNV.SelectedValue.ToString();

            using (SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                // 🔥 QUERY KHỚP dsBCNhanVien
                string query = @"SELECT NV.MANV, NV.TENNV,NV.GIOITINH, NV.TENTK, H.MAHD, H.NGAYLAP, TS.TENTS, C.SOLUONG, H.GIAMGIA, H.TONGTIEN, H.THANHTOAN
                                FROM HOADON H
                                JOIN NHANVIEN NV ON H.MANV = NV.MANV
                                JOIN CHITIETHOADON C ON H.MAHD = C.MAHD
                                JOIN TRASUA TS ON C.MATS = TS.MATS
                                WHERE H.TRANGTHAI = N'DA THANH TOAN' AND NV.MANV = @Manv
                                ORDER BY H.MAHD";

                SqlCommand cmd = new SqlCommand(query, KN);
                cmd.Parameters.AddWithValue("@Manv", maNV);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Load report
                rpvNV.LocalReport.ReportPath = "rptInBaoCaoNhanVien.rdlc";
                rpvNV.LocalReport.DataSources.Clear();

                ReportDataSource rds = new ReportDataSource("dsBCNV", dt);
                rpvNV.LocalReport.DataSources.Add(rds);

                rpvNV.RefreshReport();
                rpvNV.ZoomMode = ZoomMode.PageWidth;
            }
        }
    }
}
