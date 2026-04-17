using Microsoft.Reporting.WinForms;
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
    public partial class frmInChiTietHoaDon : Form
    {
        int mahd;
        public frmInChiTietHoaDon(int _mahd)
        {
            InitializeComponent();
            mahd = _mahd;
        }

        private void frmInChiTietHoaDon_Load(object sender, EventArgs e)
        {

            this.rpvInHD.RefreshReport();

            DataTable dt = new DataTable();

            using (SqlConnection con = ChuoiKN.GetConnection())
            {
                con.Open();

                string sql = @"SELECT H.MAHD, H.NGAYLAP, KH.TENKH,
                                      TS.TENTS, CT.SOLUONG, CT.DONGIA,
                                      H.TONGTIEN, H.GIAMGIA, H.THANHTOAN
                                FROM HOADON H
                                JOIN KHACHHANG KH ON H.MAKH = KH.MAKH
                                JOIN CHITIETHOADON CT ON H.MAHD = CT.MAHD
                                JOIN TRASUA TS ON CT.MATS = TS.MATS
                                WHERE H.MAHD = @MAHD";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MAHD", mahd);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            rpvInHD.LocalReport.ReportPath = "rptInHoaDon.rdlc";
            rpvInHD.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("dsCTHD",dt);
            rpvInHD.LocalReport.DataSources.Add(rds);

            rpvInHD.RefreshReport();

            rpvInHD.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;

        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
