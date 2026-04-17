using Microsoft.Reporting.WinForms;
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
using TheArtOfDevHtmlRenderer.Adapters;

namespace HuynhChiNguyen_233400_DH23TIN02
{
    public partial class frmInBaoCaoKhachHang : Form
    {
        public frmInBaoCaoKhachHang()
        {
            InitializeComponent();
        }

        //ComboBox khách hàng
        private void CMBKhachHang()
        {
            using (SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();
                string query = "SELECT MAKH, TENKH FROM KHACHHANG WHERE TRANGTHAI = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, KN);
                DataTable tb = new DataTable();
                da.Fill(tb);

                cmbTenKH.DataSource = tb;
                cmbTenKH.DisplayMember = "TENKH";
                cmbTenKH.ValueMember = "MAKH";

                cmbTenKH.SelectedIndex = -1;

            }
        }

        private void frmInBaoCaoKhachHang_Load(object sender, EventArgs e)
        {
            CMBKhachHang();
            this.rpvKH.RefreshReport();
        }

        private void btnXemBC_Click(object sender, EventArgs e)
        {
            if (cmbTenKH.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maKH = cmbTenKH.SelectedValue.ToString();

            using (SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                string query = @"SELECT KH.MAKH, KH.TENKH, KH.GIOITINH, KH.SDT, HD.MAHD, HD.NGAYLAP, 
                                        TS.TENTS, CTHD.SOLUONG, CTHD.DONGIA, HD.THANHTOAN
                                 FROM KHACHHANG KH
                                 JOIN HOADON HD ON KH.MAKH = HD.MAKH
                                 JOIN CHITIETHOADON CTHD ON HD.MAHD = CTHD.MAHD
                                 JOIN TRASUA TS ON CTHD.MATS = TS.MATS
                                 WHERE HD.TRANGTHAI = N'DA THANH TOAN'  AND KH.MAKH = @MaKH
                                 ORDER BY HD.NGAYLAP DESC;";

                SqlCommand cmd = new SqlCommand(query, KN);
                cmd.Parameters.AddWithValue("@MaKH", maKH);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                rpvKH.LocalReport.ReportPath = "rptBaoCaoKhachHang.rdlc";
                rpvKH.LocalReport.DataSources.Clear();

                ReportDataSource rds = new ReportDataSource("dsBCKH", dt);
                rpvKH.LocalReport.DataSources.Add(rds);

                rpvKH.RefreshReport();
                rpvKH.ZoomMode = ZoomMode.PageWidth;
            }
        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
