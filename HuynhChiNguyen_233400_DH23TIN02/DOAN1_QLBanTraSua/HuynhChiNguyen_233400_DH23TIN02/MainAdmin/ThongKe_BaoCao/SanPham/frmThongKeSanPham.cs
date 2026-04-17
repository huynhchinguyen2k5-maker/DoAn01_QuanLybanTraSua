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
    public partial class frmThongKeSanPham : Form
    {
        DataTable dtThongKe;
        public frmThongKeSanPham()
        {
            InitializeComponent();
        }

        //Load CMB Thơi gian
        private void CMBThoiGian()
        {
            cmbThoiGianNhanh.Items.Clear();
            cmbThoiGianNhanh.Items.Add("Hôm nay");
            cmbThoiGianNhanh.Items.Add("Tuần này");
            cmbThoiGianNhanh.Items.Add("Tháng này");
            cmbThoiGianNhanh.Items.Add("Năm nay");

            cmbThoiGianNhanh.SelectedIndex = -1;
        }

        //Load CMB Loại thống kê
        private void CMBLoaiTK()
        {
            cmbLoaiTK.Items.Clear();
            cmbLoaiTK.Items.Add("Doanh thu");
            cmbLoaiTK.Items.Add("Số lượng");

            cmbThoiGianNhanh.SelectedIndex = -1;
        }

        //Load CMB Loại biểu đồ
        private void CMBLoaiBD()
        {
            cmbLoaiBD.Items.Clear();
            cmbLoaiBD.Items.Add("Biểu đồ Tròn");
            cmbLoaiBD.Items.Add("Biểu đồ Cột");
            cmbLoaiBD.Items.Add("Biểu đồ Line");

            cmbLoaiBD.SelectedIndex = -1;
        }

        //Lấy khoảng thời gian trong CMB chọn nhanh
        private void LayKhoangThoiGian(out DateTime tuNgay,out DateTime denNgay)
        {
            if (radioChoNhanh.Checked)
            {
                DateTime now = DateTime.Now;

                switch (cmbThoiGianNhanh.Text)
                {
                    case "Hôm nay":
                        tuNgay = now.Date;
                        denNgay = now.Date.AddDays(1).AddSeconds(-1);
                        break;

                    case "Tuần này":
                        int diff = (7 + (now.DayOfWeek - DayOfWeek.Monday)) % 7;
                        tuNgay = now.Date.AddDays(-diff);
                        denNgay = tuNgay.AddDays(7).AddSeconds(-1);
                        break;

                    case "Tháng này":
                        tuNgay = new DateTime(now.Year, now.Month, 1);
                        denNgay = tuNgay.AddMonths(1).AddSeconds(-1);
                        break;

                    case "Năm nay":
                        tuNgay = new DateTime(now.Year, 1, 1);
                        denNgay = new DateTime(now.Year, 12, 31, 23, 59, 59);
                        break;

                    default:
                        tuNgay = now.Date;
                        denNgay = now.Date.AddDays(1).AddSeconds(-1);
                        break;
                }
            }
            else
            {
                tuNgay = dtpkNBD.Value.Date;
                denNgay = dtpkNKT.Value.Date.AddDays(1).AddSeconds(-1);
            }
        }
        //Vẽ biểu đồ
        private void VeBieuDo()
        {
            DateTime tuNgay, denNgay;
            LayKhoangThoiGian(out tuNgay, out denNgay);

            int loaiTK = cmbLoaiTK.Text == "Doanh thu" ? 1 : 0;

            string sql = @"SELECT TS.TENTS,
                               ISNULL(SUM(
                                    CASE 
                                        WHEN HD.NGAYLAP BETWEEN @TuNgay AND @DenNgay
                                        THEN CASE 
                                            WHEN @LoaiTK = 1 THEN CT.SOLUONG * CT.DONGIA
                                            ELSE CT.SOLUONG
                                        END
                                        ELSE 0
                                    END), 0) AS GIATRI
                            FROM TRASUA TS
                            LEFT JOIN CHITIETHOADON CT ON TS.MATS = CT.MATS
                            LEFT JOIN HOADON HD ON CT.MAHD = HD.MAHD 
                                 AND HD.TRANGTHAI = N'DA THANH TOAN'
                            GROUP BY TS.TENTS";

            SqlDataAdapter da = new SqlDataAdapter(sql, ChuoiKN.GetConnection());
            da.SelectCommand.Parameters.AddWithValue("@TuNgay", tuNgay);
            da.SelectCommand.Parameters.AddWithValue("@DenNgay", denNgay);
            da.SelectCommand.Parameters.AddWithValue("@LoaiTK", loaiTK);

            dtThongKe = new DataTable();
            da.Fill(dtThongKe);

            // ===== RESET CHART =====
            chartBD.Series.Clear();
            chartBD.ChartAreas.Clear();
            chartBD.Legends.Clear();
            chartBD.Titles.Clear();

            ChartArea area = new ChartArea();
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Angle = -45;
            chartBD.ChartAreas.Add(area);

            Legend lg = new Legend();
            lg.Docking = Docking.Right;
            chartBD.Legends.Add(lg);

            // ===== LOẠI BIỂU ĐỒ =====
            SeriesChartType type =
                cmbLoaiBD.Text == "Biểu đồ Cột" ? SeriesChartType.Column :
                cmbLoaiBD.Text == "Biểu đồ Tròn" ? SeriesChartType.Pie :
                SeriesChartType.Line;

            Series s = new Series("Thống kê");
            s.ChartType = type;
            s.IsValueShownAsLabel = true;

            if (type == SeriesChartType.Pie)
            {
                s.Label = "#PERCENT{P1}%";
                s.LegendText = "#VALX";
            }

            // ===== ĐỔ DỮ LIỆU =====
            foreach (DataRow r in dtThongKe.Rows)
            {
                double giaTri = Convert.ToDouble(r["GIATRI"]);

                // 👉 BIỂU ĐỒ TRÒN: bỏ món = 0
                if (type == SeriesChartType.Pie && giaTri <= 0)
                    continue;

                s.Points.AddXY(r["TENTS"].ToString(), giaTri);
            }

            chartBD.Series.Add(s);
            chartBD.Titles.Add($"{cmbLoaiTK.Text} ({tuNgay:dd/MM/yyyy} - {denNgay:dd/MM/yyyy})");
        }

        //Hiện trên grb tổng quan
        void HienTongQuan()
        {
            if (dtThongKe == null || dtThongKe.Rows.Count == 0)
            {
                lbTongDT.Text = "0";
                lbTongSP.Text = "0";
                lbSQBCN.Text = "Không có";
                lbSPBanChamNhat.Text = "Không có";
                lbTLBanChay.Text = "0%";
                return;
            }

            decimal tong = dtThongKe.AsEnumerable().Sum(r => Convert.ToDecimal(r["GIATRI"]));

            DataRow max = dtThongKe.AsEnumerable().OrderByDescending(r => Convert.ToDecimal(r["GIATRI"])).First();

            DataRow min = dtThongKe.AsEnumerable().OrderBy(r => Convert.ToDecimal(r["GIATRI"])).First();

            lbSQBCN.Text = max["TENTS"].ToString();
            lbSPBanChamNhat.Text = min["TENTS"].ToString();

            if (cmbLoaiTK.Text == "Doanh thu")
            {
                lbTongDT.Text = tong.ToString("N0") + " đ";
                lbTongSP.Text = "—";
                lbTLBanChay.Text = "—";
            }
            else
            {
                lbTongSP.Text = tong.ToString();
                lbTongDT.Text = "—";

                decimal tiLe = tong > 0 ? Convert.ToDecimal(max["GIATRI"]) / tong * 100 : 0;

                lbTLBanChay.Text = tiLe.ToString("0.##") + "%";
            }
        }
        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {
            CMBThoiGian();
            CMBLoaiTK();
            CMBLoaiBD();

            dtpkNBD.Enabled = false;
            dtpkNKT.Enabled = false;
            cmbThoiGianNhanh.Enabled = false;
        }

        private void radioLocTG_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLocTG.Checked)
            {
                dtpkNBD.Enabled = true;
                dtpkNKT.Enabled = true;

                cmbThoiGianNhanh.Enabled = false;
                cmbThoiGianNhanh.SelectedIndex = -1;
            }
        }

        private void radioChoNhanh_CheckedChanged(object sender, EventArgs e)
        {
            if (radioChoNhanh.Checked)
            {
                cmbThoiGianNhanh.Enabled = true;

                dtpkNBD.Enabled = false;
                dtpkNKT.Enabled = false;
            }
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            if (cmbLoaiTK.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại thống kê!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbLoaiBD.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại biểu đồ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (radioChoNhanh.Checked && cmbThoiGianNhanh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn thời gian nhanh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            VeBieuDo();

            HienTongQuan();
        }
    }
}
