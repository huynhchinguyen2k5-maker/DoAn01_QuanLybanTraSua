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

namespace HuynhChiNguyen_233400_DH23TIN02
{
    public partial class frmInBaoCao : Form
    {
        public frmInBaoCao()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmInBaoCao_Load(object sender, EventArgs e)
        {

            this.rptIn.RefreshReport();

            DataTable dt = new DataTable();

            using (SqlConnection con = ChuoiKN.GetConnection())
            {
                string sql = @"SELECT HD.MAHD, HD.NGAYLAP, NV.TENNV, KH.TENKH,
                              TS.TENTS,
                              KM.TENKM,
                              HD.GIAMGIA, HD.TONGTIEN, HD.THANHTOAN, HD.TRANGTHAI,
                              CT.SOLUONG, CT.DONGIA
                       FROM HOADON HD
                       LEFT JOIN NHANVIEN NV ON HD.MANV = NV.MANV
                       LEFT JOIN KHACHHANG KH ON HD.MAKH = KH.MAKH
                       LEFT JOIN KHUYENMAI KM ON HD.MAKM = KM.MAKM
                       JOIN CHITIETHOADON CT ON HD.MAHD = CT.MAHD
                       JOIN TRASUA TS ON CT.MATS = TS.MATS
                       WHERE HD.TRANGTHAI IN (N'CHUA THANH TOAN', N'DA THANH TOAN')
                       ORDER BY HD.MAHD DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }

            rptIn.LocalReport.ReportPath = "rpThongKeHoaDon.rdlc";
            rptIn.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("dsTKHD", dt);
            rptIn.LocalReport.DataSources.Add(rds);

            rptIn.RefreshReport();

            rptIn.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;

        }
    }
}
