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
    public partial class frmThongKeKhachHang : Form
    {
        public frmThongKeKhachHang()
        {
            InitializeComponent();
        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Load CMB Thơi gian
        private void CMBThoiGian()
        {
            cmbThoiGianNhanh.Items.Clear();
            cmbThoiGianNhanh.Items.Add("Hôm nay");
            cmbThoiGianNhanh.Items.Add("Tuần này");
            cmbThoiGianNhanh.Items.Add("Tháng này");
            cmbThoiGianNhanh.Items.Add("Năm nay");

            cmbThoiGianNhanh.SelectedIndex = 0;
        }

        //ComboBox Loại Biểu đô
        private void CMBBieuDo()
        {
            cmbLoaiBD.Items.Clear();
            cmbLoaiBD.Items.Add("Biểu đồ tròn");
            cmbLoaiBD.Items.Add("Biểu đồ cột");
            cmbLoaiBD.Items.Add("Biểu đồ đường");

            cmbLoaiBD.SelectedIndex = 1;
        }

        //Lấy khoảng thời gian trong CMB chọn nhanh
        private void LayKhoangThoiGian(out DateTime tuNgay, out DateTime denNgay)
        {
            if (radioChoNhanh.Checked)
            {
                DateTime now = DateTime.Today;

                switch (cmbThoiGianNhanh.Text)
                {
                    case "Hôm nay":
                        tuNgay = now;
                        denNgay = now.AddDays(1).AddSeconds(-1);
                        break;

                    case "Tuần này":
                        int dayOfWeek = (int)now.DayOfWeek;
                        if (dayOfWeek == 0) dayOfWeek = 7;

                        tuNgay = now.AddDays(-(dayOfWeek - 1));
                        denNgay = tuNgay.AddDays(7).AddSeconds(-1);
                        break;

                    case "Tháng này":
                        tuNgay = new DateTime(now.Year, now.Month, 1);
                        denNgay = tuNgay.AddMonths(1).AddSeconds(-1);
                        break;

                    case "Năm nay":
                        tuNgay = new DateTime(now.Year, 1, 1);
                        denNgay = tuNgay.AddYears(1).AddSeconds(-1);
                        break;

                    default:
                        tuNgay = now;
                        denNgay = now.AddDays(1).AddSeconds(-1);
                        break;
                }
            }
            else
            {
                tuNgay = dtpkNBD.Value.Date;
                denNgay = dtpkNKT.Value.Date.AddDays(1).AddSeconds(-1);
            }
        }

        //Hàm truy vấn DL
        private DataTable LayDuLieuThongKeKhachHang()
        {
            try
            {
                DateTime tuNgay, denNgay;
                LayKhoangThoiGian(out tuNgay, out denNgay);

                string sql = @"SELECT KH.TENKH, SUM(H.THANHTOAN) AS TONGCHI
                               FROM HOADON H
                               JOIN KHACHHANG KH ON H.MAKH = KH.MAKH
                               WHERE H.TRANGTHAI = N'DA THANH TOAN' AND H.NGAYLAP BETWEEN @TuNgay AND @DenNgay
                               GROUP BY KH.TENKH
                               ORDER BY TONGCHI DESC";

                using (SqlConnection conn = ChuoiKN.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@TuNgay", SqlDbType.DateTime).Value = tuNgay;
                        cmd.Parameters.Add("@DenNgay", SqlDbType.DateTime).Value = denNgay;

                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        return dt;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!\n" + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi!\n" + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        //Hàm vẽ biểu đồ
        private void VeBieuDo(DataTable dt)
        {
            chartBD.Series.Clear();
            chartBD.Titles.Clear();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DateTime tuNgay, denNgay;
            LayKhoangThoiGian(out tuNgay, out denNgay);

            Series series = new Series("ChiTieu");
            series.IsValueShownAsLabel = true;
            series.BorderWidth = 2;

            switch (cmbLoaiBD.SelectedIndex)
            {
                case 0: series.ChartType = SeriesChartType.Pie; break;
                case 1: series.ChartType = SeriesChartType.Column; break;
                case 2: series.ChartType = SeriesChartType.Line; break;
            }

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(
                    row["TENKH"].ToString(),
                    Convert.ToDouble(row["TONGCHI"])
                );
            }

            chartBD.Series.Add(series);

            chartBD.Titles.Add($"KHÁCH HÀNG CHI TIÊU TỪ {tuNgay:dd/MM/yyyy} ĐẾN {denNgay:dd/MM/yyyy}"
            );
        }

        //Hàm tổng quan
        private void HienTongQuan(DataTable dt)
        {
            if (dt.Rows.Count == 0)
            {
                lbTongDT.Text = "0 đ";
                lbKhachHangCaoNhat.Text = "---";
                lbKhachHangThapNhat.Text = "---";
                return;
            }

            double tong = 0;

            foreach (DataRow row in dt.Rows)
                tong += Convert.ToDouble(row["TONGCHI"]);

            lbTongDT.Text = tong.ToString("N0") + " đ";
            lbKhachHangCaoNhat.Text = dt.Rows[0]["TENKH"].ToString();
            lbKhachHangThapNhat.Text = dt.Rows[dt.Rows.Count - 1]["TENKH"].ToString();
        }

        //Top 5 khách hàng chi tiêu nhiều nhất
        private void HienTop5KhachHang(DataTable dt)
        {
            lbTop1.Text = "1. ---";
            lbTop2.Text = "2. ---";
            lbTop3.Text = "3. ---";
            lbTop4.Text = "4. ---";
            lbTop5.Text = "5. ---";

            for (int i = 0; i < dt.Rows.Count && i < 5; i++)
            {
                string ten = dt.Rows[i]["TENKH"].ToString();
                double tien = Convert.ToDouble(dt.Rows[i]["TONGCHI"]);

                string text = (i + 1) + ". " + ten +
                              " (" + tien.ToString("N0") + " đ)";

                if (i == 0)
                {
                    lbTop1.Text = "🏆 " + text;
                    lbTop1.ForeColor = Color.Red;
                    lbTop1.Font = new Font(lbTop1.Font, FontStyle.Bold);
                }
                if (i == 1) lbTop2.Text = text;
                if (i == 2) lbTop3.Text = text;
                if (i == 3) lbTop4.Text = text;
                if (i == 4) lbTop5.Text = text;
            }
        }
        private void frmThongKeKhachHang_Load(object sender, EventArgs e)
        {
            CMBThoiGian();
            CMBBieuDo();

            radioChoNhanh.Checked = true;
            cmbThoiGianNhanh.SelectedIndex = 0;

            dtpkNBD.Enabled = false;
            dtpkNKT.Enabled = false;

            cmbLoaiBD.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbThoiGianNhanh.DropDownStyle = ComboBoxStyle.DropDownList;
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
        //Nút Xem thống kê
        private void btnThongke_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbLoaiBD.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn loại biểu đồ!");
                    return;
                }

                if (radioChoNhanh.Checked && cmbThoiGianNhanh.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn thời gian!");
                    return;
                }

                if (radioLocTG.Checked)
                {
                    if (dtpkNKT.Value.Date < dtpkNBD.Value.Date)
                    {
                        MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu!");
                        return;
                    }
                }

                DataTable dt = LayDuLieuThongKeKhachHang();

                VeBieuDo(dt);
                HienTongQuan(dt);
                HienTop5KhachHang(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thống kê!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInBaocao_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmInBaoCaoKhachHang)
                {
                    f.Activate();
                    return;
                }
            }

            frmInBaoCaoKhachHang frm = new frmInBaoCaoKhachHang();
            frm.Show();
        }
    }
}
