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
using System.Windows.Forms.DataVisualization.Charting;
namespace HuynhChiNguyen_233400_DH23TIN02
{
    public partial class frmThongkeDoanhThu : Form
    {
        public frmThongkeDoanhThu()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Cài đặt biểu đồ
        private void CaiDatBieuDoDep()
        {
            chartThongKe.Series.Clear();
            chartThongKe.ChartAreas.Clear();
            chartThongKe.Titles.Clear();
            chartThongKe.Legends.Clear();

            ChartArea area = new ChartArea("AreaDoanhThu");
            area.BackColor = Color.White;

            area.AxisX.Title = "Thời gian";
            area.AxisY.Title = "Doanh thu (VNĐ)";

            area.AxisX.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);
            area.AxisY.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);

            area.AxisX.LabelStyle.Font = new Font("Times New Roman", 10);
            area.AxisY.LabelStyle.Font = new Font("Times New Roman", 10);
            area.AxisY.LabelStyle.Format = "N0";

            area.AxisY.MajorGrid.LineColor = Color.Gainsboro;
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            area.AxisX.MajorGrid.Enabled = false;

            chartThongKe.ChartAreas.Add(area);

            // ===== TIÊU ĐỀ =====
            Title title = new Title("BÁO CÁO DOANH THU");
            title.Font = new Font("Times New Roman", 16, FontStyle.Bold);
            title.ForeColor = Color.Black;
            chartThongKe.Titles.Add(title);

            // ===== SERIES CỘT =====
            Series columnSeries = new Series("Doanh thu");
            columnSeries.ChartType = SeriesChartType.Column;
            columnSeries.Color = Color.FromArgb(52, 152, 219);
            columnSeries["PointWidth"] = "0.6";
            columnSeries.IsValueShownAsLabel = true;
            columnSeries.LabelFormat = "N0";

            // ===== SERIES ĐƯỜNG XU HƯỚNG =====
            Series lineSeries = new Series("Xu hướng");
            lineSeries.ChartType = SeriesChartType.Line;
            lineSeries.Color = Color.FromArgb(231, 76, 60);
            lineSeries.BorderWidth = 3;
            lineSeries.MarkerStyle = MarkerStyle.Circle;
            lineSeries.MarkerSize = 7;

            chartThongKe.Series.Add(columnSeries);
            chartThongKe.Series.Add(lineSeries);

            // ===== LEGEND =====
            Legend legend = new Legend();
            legend.Font = new Font("Times New Roman", 10);
            legend.Docking = Docking.Top;
            chartThongKe.Legends.Add(legend);
        }

        //Vẽ biểu đồ Hôm nay

        private void VeBieuDoHomNay(DataTable dt)
        {
            chartThongKe.Series.Clear();
            chartThongKe.Titles.Clear();

            chartThongKe.Titles.Add("DOANH THU HÔM NAY");

            var chartArea = chartThongKe.ChartAreas[0];
            chartArea.AxisX.Title = "Giờ trong ngày";
            chartArea.AxisY.Title = "Doanh thu (VNĐ)";
            chartArea.AxisX.Interval = 1;

            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.MediumSeaGreen;
            series.IsValueShownAsLabel = true;
            series.Font = new Font("Times New Roman", 10, FontStyle.Bold);

            foreach (DataRow row in dt.Rows)
            {
                string gio = row["Gio"].ToString() + "h";
                double doanhThu = Convert.ToDouble(row["DoanhThu"]);

                series.Points.AddXY(gio, doanhThu);
            }

            chartThongKe.Series.Add(series);
        }

        //vẽ biểu đồ theo ngày
        private void VeBieuDoTheoNgay(DataTable dt)
        {
            chartThongKe.Series.Clear();
            chartThongKe.Titles.Clear();

            chartThongKe.Titles.Add("DOANH THU THEO KHOẢNG NGÀY");

            var area = chartThongKe.ChartAreas[0];
            area.AxisX.Title = "Ngày";
            area.AxisY.Title = "Doanh thu (VNĐ)";
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Angle = -45;

            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.Font = new Font("Times New Roman", 9, FontStyle.Bold);
            series.Color = Color.MediumSeaGreen;

            foreach (DataRow row in dt.Rows)
            {
                DateTime ngay = Convert.ToDateTime(row["Ngay"]);
                double doanhThu = Convert.ToDouble(row["DoanhThu"]);

                series.Points.AddXY(ngay.ToString("dd/MM"), doanhThu);
            }

            chartThongKe.Series.Add(series);
        }


        //vẽ biểu đồ năm nay theo tháng trong năm
        private DataTable LayDoanhThuTheoThangNamNay()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = ChuoiKN.GetConnection())
            {
                string sql = @"SELECT MONTH(NGAYLAP) AS Thang, SUM(THANHTOAN) AS DoanhThu
                                FROM HOADON
                                WHERE YEAR(NGAYLAP) = YEAR(GETDATE()) AND TRANGTHAI = N'DA THANH TOAN'
                                GROUP BY MONTH(NGAYLAP)
                                ORDER BY Thang";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }

            return dt;
        }
        private void VeBieuDoTheoThang(DataTable dt)
        {
            chartThongKe.Series.Clear();
            chartThongKe.Titles.Clear();

            chartThongKe.Titles.Add("DOANH THU THEO THÁNG - NĂM NAY");

            var area = chartThongKe.ChartAreas[0];
            area.AxisX.Title = "Tháng";
            area.AxisY.Title = "Doanh thu (VNĐ)";
            area.AxisX.Interval = 1;

            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.Font = new Font("Times New Roman", 9, FontStyle.Bold);
            series.Color = Color.MediumSeaGreen;

            foreach (DataRow row in dt.Rows)
            {
                int thang = Convert.ToInt32(row["Thang"]);
                double doanhThu = Convert.ToDouble(row["DoanhThu"]);

                series.Points.AddXY("Tháng " + thang, doanhThu);
            }

            chartThongKe.Series.Add(series);
        }


        //Vẽ biểu đồ Tháng này
        private DataTable LayDoanhThuThangNay()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = ChuoiKN.GetConnection())
            {
                string sql = @"SELECT DAY(NGAYLAP) AS Ngay, SUM(THANHTOAN) AS DoanhThu
                                FROM HOADON
                                WHERE MONTH(NGAYLAP) = MONTH(GETDATE()) AND YEAR(NGAYLAP) = YEAR(GETDATE()) AND TRANGTHAI = N'DA THANH TOAN'
                                GROUP BY DAY(NGAYLAP)
                                ORDER BY Ngay";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }

            return dt;
        }
        private void VeBieuDoTheoNgayTrongThang(DataTable dt)
        {
            chartThongKe.Series.Clear();
            chartThongKe.Titles.Clear();

            chartThongKe.Titles.Add("DOANH THU THEO NGÀY - THÁNG NÀY");

            var area = chartThongKe.ChartAreas[0];
            area.AxisX.Title = "Ngày trong tháng";
            area.AxisY.Title = "Doanh thu (VNĐ)";
            area.AxisX.Interval = 1;

            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.Font = new Font("Times New Roman", 9, FontStyle.Bold);
            series.Color = Color.MediumSeaGreen;

            foreach (DataRow row in dt.Rows)
            {
                int ngay = Convert.ToInt32(row["Ngay"]);
                double doanhThu = Convert.ToDouble(row["DoanhThu"]);

                series.Points.AddXY("Ngày " + ngay, doanhThu);
            }

            chartThongKe.Series.Add(series);
        }


        //Thống kê tổng hóa đơn
        private DataTable LayThongKeTong(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = ChuoiKN.GetConnection())
            {
                string sql = @"SELECT COUNT(*) AS TongHoaDon,
                                        SUM(CASE WHEN TRANGTHAI = N'DA THANH TOAN' THEN 1 ELSE 0 END) AS HoaDonDaTT,
                                        SUM(CASE WHEN TRANGTHAI != N'DA THANH TOAN' THEN 1 ELSE 0 END) AS HoaDonChuaTT,
                                        SUM(CASE WHEN TRANGTHAI = N'DA THANH TOAN' THEN THANHTOAN ELSE 0 END) AS TongDoanhThu
                                    FROM HOADON
                                    WHERE NGAYLAP BETWEEN @TuNgay AND @DenNgay";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay.Date);
                cmd.Parameters.AddWithValue("@DenNgay", denNgay.Date.AddDays(1).AddSeconds(-1));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        //Láy Doanh thu để vẽ biểu đồ
        private DataTable LayDoanhThuBieuDo(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = ChuoiKN.GetConnection())
            {
                string sql = @"SELECT CONVERT(date, NGAYLAP) AS Ngay,
                                       SUM(THANHTOAN) AS DoanhThu
                                FROM HOADON
                                WHERE TRANGTHAI = N'DA THANH TOAN'
                                  AND NGAYLAP BETWEEN @TuNgay AND @DenNgay
                                GROUP BY CONVERT(date, NGAYLAP)
                                ORDER BY Ngay";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay.Date);
                cmd.Parameters.AddWithValue("@DenNgay", denNgay.Date.AddDays(1).AddSeconds(-1));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
        //Hiện Dl lên groubox
        private void HienThongKeTong(DataTable dt)
        {
            if (dt.Rows.Count == 0) return;

            DataRow r = dt.Rows[0];

            lbHoaDon.Text = r["TongHoaDon"].ToString();
            lbThanhToan.Text = r["HoaDonDaTT"].ToString();
            lbChuaTT.Text = r["HoaDonChuaTT"].ToString();

            double tongTien = r["TongDoanhThu"] == DBNull.Value ? 0 : Convert.ToDouble(r["TongDoanhThu"]);
            lbTongTien.Text = tongTien.ToString("N0") + " VNĐ";
        }
        //Đổi tiêu đề 
        private void DoiTieuDeBieuDo(string tieuDe)
        {
            chartThongKe.Titles.Clear();

            Title title = new Title();
            title.Text = tieuDe;
            title.Font = new Font("Times New Roman", 16, FontStyle.Bold);
            title.ForeColor = Color.Black;
            title.Alignment = ContentAlignment.TopCenter;

            chartThongKe.Titles.Add(title);
        }

        private void frmThongkeDoanhThu_Load(object sender, EventArgs e)
        {
            CaiDatBieuDoDep();
            //grbTT.Visible = false;
        }

        //Mở form frmInBaocao
        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            frmInBaoCao frm = new frmInBaoCao();
            frm.ShowDialog();
        }

        //Nút vẽ biểu đồ hôm nay
        private void btnHomNay_Click(object sender, EventArgs e)
        {
            grbTT.Visible = true;

            DateTime homNay = DateTime.Today;
            DateTime cuoiNgay = homNay.AddDays(1).AddSeconds(-1);

            // ===== GROUPBOX =====
            DataTable dtTong = LayThongKeTong(homNay, cuoiNgay);
            HienThongKeTong(dtTong);

            DataTable dt = new DataTable();

            using (SqlConnection con = ChuoiKN.GetConnection())
            {
                string sql = @"SELECT DATEPART(HOUR, NGAYLAP) AS Gio, SUM(THANHTOAN) AS DoanhThu
                                FROM HOADON
                                WHERE CAST(NGAYLAP AS DATE) = CAST(GETDATE() AS DATE) AND TRANGTHAI = N'DA THANH TOAN'
                                GROUP BY DATEPART(HOUR, NGAYLAP)
                                ORDER BY Gio";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }

            VeBieuDoHomNay(dt);

            DoiTieuDeBieuDo("Doanh thu hôm nay (" + DateTime.Now.ToString("dd/MM/yyyy") + ")");
        }

        //Vẽ biểu đồ theo tháng
        private void btnThangNay_Click(object sender, EventArgs e)
        {
            grbTT.Visible = true;

            DateTime now = DateTime.Now;
            DateTime dauThang = new DateTime(now.Year, now.Month, 1);
            DateTime cuoiThang = dauThang.AddMonths(1).AddSeconds(-1);

            // ===== GROUPBOX =====

            DataTable dtTong = LayThongKeTong(dauThang, cuoiThang);
            HienThongKeTong(dtTong);

            // ===== BIỂU ĐỒ =====

            DataTable dt = LayDoanhThuThangNay();
            VeBieuDoTheoNgayTrongThang(dt);

            DoiTieuDeBieuDo("Doanh thu tháng " + now.Month + "/" + now.Year);
        }

        //Vẽ biểu đồ theo năm
        private void btnNamNay_Click(object sender, EventArgs e)
        {
            grbTT.Visible = true;

            DateTime now = DateTime.Now;
            DateTime dauNam = new DateTime(now.Year, 1, 1);
            DateTime cuoiNam = dauNam.AddYears(1).AddSeconds(-1);

            // ===== GROUPBOX =====
            DataTable dtTong = LayThongKeTong(dauNam, cuoiNam);
            HienThongKeTong(dtTong);

            // ===== BIỂU ĐỒ =====
            DataTable dt = LayDoanhThuTheoThangNamNay();
            VeBieuDoTheoThang(dt);

            DoiTieuDeBieuDo("Doanh thu năm " + now.Year);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            grbTT.Visible = true;

            DateTime tuNgay = dtpkNgayBD.Value.Date;
            DateTime denNgay = dtpkNgayKT.Value.Date.AddDays(1).AddSeconds(-1);

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Từ ngày không được lớn hơn Đến ngày!");
                return;
            }

            DataTable dtTong = LayThongKeTong(tuNgay, denNgay);
            HienThongKeTong(dtTong);

            DataTable dtBieuDo = LayDoanhThuBieuDo(tuNgay, denNgay);
            VeBieuDoTheoNgay(dtBieuDo);

            DoiTieuDeBieuDo("Doanh thu từ ngày " + tuNgay.ToString("dd/MM/yyyy") + " đến ngày " + dtpkNgayKT.Value.ToString("dd/MM/yyyy"));
        }
    }
}
