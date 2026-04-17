using HuynhChiNguyen_233400_DH23TIN02.MainAdmin;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuynhChiNguyen_233400_DH23TIN02
{
    public partial class frmMainAdmin : Form
    {
        string _ten;
        string _quyen;

        
        public frmMainAdmin(string ten, string quyen)
        {
            InitializeComponent();
            _ten = ten;
            _quyen = quyen;
        }
        public frmMainAdmin()
        {
            InitializeComponent();
        }

        private void frmMainAdmin_Load(object sender, EventArgs e)
        {
            lbQuyen.Text = _quyen;
            lbTen.Text = _ten;

            LoadCMBPhamVi();

            dtgvHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvHienThi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvHienThi.ReadOnly = true;
            dtgvHienThi.AllowUserToAddRows = false;
            dtgvHienThi.RowHeadersVisible = false;

            //MÀU NỀN TỔNG THỂ
            dtgvHienThi.BackgroundColor = Color.FromArgb(245, 247, 250);
            dtgvHienThi.BorderStyle = BorderStyle.None;
            dtgvHienThi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgvHienThi.GridColor = Color.FromArgb(220, 220, 220);

            // ===== FONT =====
            dtgvHienThi.DefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            dtgvHienThi.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);

            // ===== MÀU CHỮ & Ô =====
            dtgvHienThi.DefaultCellStyle.BackColor = Color.White;
            dtgvHienThi.DefaultCellStyle.ForeColor = Color.Black;
            dtgvHienThi.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dtgvHienThi.DefaultCellStyle.SelectionForeColor = Color.White;

            // ===== HEADER =====
            dtgvHienThi.EnableHeadersVisualStyles = false;
            dtgvHienThi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 32, 32);
            dtgvHienThi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgvHienThi.ColumnHeadersHeight = 40;

            // ===== DÒNG =====
            dtgvHienThi.RowTemplate.Height = 32;
            dtgvHienThi.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            
                if(f.Name == "frmQuanLyTaiKhoan")
                {
                    f.Activate();
                    return;
                }
            frmQuanLyTaiKhoan frmQLTK = new frmQuanLyTaiKhoan();
            frmQLTK.MdiParent = this.MdiParent;
            frmQLTK.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmQuanLyNhanVien")
                {
                    f.Activate();
                    f.Show();
                }
            frmQuanLyNhanVien frmKH = new frmQuanLyNhanVien();
            frmKH.MdiParent = this.MdiParent;
            frmKH.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            foreach(Form f in this.MdiChildren)
                if(f.Name == "frmQuanLyKhachHang")
                {
                    f.Activate();
                    f.Show();
                }
            frmQuanLyKhachHang frmKH = new frmQuanLyKhachHang();
            frmKH.MdiParent = this.MdiParent;
            frmKH.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDN = new frmDangNhap();
            frmDN.Show();
            this.Hide();
        }

        private void btnLoaiTraSua_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmQuanLyPhanLoaiTraSua")
                {
                    f.Activate();
                    f.Show();
                }
            frmQuanLyPhanLoaiTraSua frmLTS = new frmQuanLyPhanLoaiTraSua();
            frmLTS.MdiParent = this.MdiParent;
            frmLTS.Show();
        }

        private void btnTraSua_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmQuanLyTraSua")
                {
                    f.Activate();
                    f.Show();
                }
            frmQuanLyTraSua frmTS = new frmQuanLyTraSua();
            frmTS.MdiParent = this.MdiParent;
            frmTS.Show();
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmqQLKhuyenMai")
                {
                    f.Activate();
                    f.Show();
                }
            frmqQLKhuyenMai frmKM = new frmqQLKhuyenMai();
            frmKM.MdiParent = this.MdiParent;
            frmKM.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmQLHoaDon")
                {
                    f.Activate();
                    f.Show();
                }
            frmQLHoaDon frmHD = new frmQLHoaDon();
            frmHD.MdiParent = this.MdiParent;
            frmHD.Show();
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmQLChiTietHoaDon")
                {
                    f.Activate();
                    f.Show();
                }
            frmQLChiTietHoaDon frmCTHD = new frmQLChiTietHoaDon();
            frmCTHD.MdiParent = this.MdiParent;
            frmCTHD.Show();
        }

        //Tạo phương thức Load Phạm vi tìm kiếm
        private void LoadCMBPhamVi()
        {

            cmbPhamVi.Items.Clear();
            cmbPhamVi.Items.Add("Trà sữa");
            cmbPhamVi.Items.Add("Loại trà sữa");
            cmbPhamVi.Items.Add("Khách hàng");
            cmbPhamVi.Items.Add("Nhân viên");
            cmbPhamVi.Items.Add("Hóa đơn");
            cmbPhamVi.Items.Add("Khuyến mãi");
            cmbPhamVi.Items.Add("Nhật ký hoạt động");

            cmbPhamVi.SelectedIndex = -1;
        }

        //Phuong thức loadTimKiem
        private void LoadTimKiem(string query, string tukhoa)
        {
            try
            {
                using (SqlConnection KN = ChuoiKN.GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, KN);
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" + tukhoa + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgvHienThi.DataSource = dt;

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("Không tìm thấy dữ liệu phù hợp!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void ThucHienTimKiem()
        {
            string tukhoa = txtNhap.Text.Trim();
            string loai = cmbPhamVi.Text;
            string query = "";

            if (string.IsNullOrWhiteSpace(tukhoa))
            {
                dtgvHienThi.DataSource = null;
                MessageBox.Show("Vui lòng nhập từ khóa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (loai == "Trà sữa")
            {
                query = @"SELECT TS.MATS, TS.TENTS, TS.DONGIA, L.TENLOAI
                          FROM TRASUA TS
                          JOIN LOAITRASUA L ON TS.MALOAITS = L.MALOAITS
                          WHERE TS.TRANGTHAI = 1 AND TS.TENTS LIKE @kw";
            }
            else if (loai == "Loại trà sữa")
            {
                query = @"SELECT MALOAITS, TENLOAI, TRANGTHAI
                          FROM LOAITRASUA
                          WHERE TRANGTHAI = 1 AND TENLOAI LIKE @kw";
            }
            else if (loai == "Khách hàng")
            {
                query = @"SELECT MAKH, TENKH, SDT, DIACHI
                          FROM KHACHHANG
                          WHERE TRANGTHAI = 1 AND (TENKH LIKE @kw OR SDT LIKE @kw)";
            }
            else if (loai == "Nhân viên")
            {
                query = @"SELECT NV.MANV, NV.TENNV, NV.SDT, TK.VAITRO, NV.TRANGTHAI
                          FROM NHANVIEN NV
                          JOIN TAIKHOAN TK ON NV.TENTK = TK.TENTK
                          WHERE NV.TRANGTHAI = N'DANG LAM'
                          AND NV.TENNV LIKE @kw";
            }
            else if (loai == "Hóa đơn")
            {
                query = @"SELECT MAHD, NGAYLAP, TONGTIEN, GIAMGIA, THANHTOAN, TRANGTHAI
                          FROM HOADON
                          WHERE CAST(MAHD AS NVARCHAR) LIKE @kw 
                             OR TRANGTHAI LIKE @kw";
            }
            else if (loai == "Khuyến mãi")
            {
                query = @"SELECT MAKM, TENKM, PHANTRAMGIAM, NGAYBATDAU, NGAYKETTHUC, TRANGTHAI
                          FROM KHUYENMAI
                          WHERE TRANGTHAI = N'HOAT DONG' AND TENKM LIKE @kw";
            }
            else if (loai == "Nhật ký hoạt động")
            {
                query = @"SELECT THOIGIAN, TENTK, HANHDONG, PHANLOAI
                          FROM NHATKY
                          WHERE HANHDONG LIKE @kw OR PHANLOAI LIKE @kw";
            }

            LoadTimKiem(query, tukhoa);
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            ThucHienTimKiem();
        }

        private void btnBaoCaoThongke_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmChonBaoCao")
                {
                    f.Activate();
                    f.Show();
                }
            frmChonBaoCao frmCTHD = new frmChonBaoCao();
            frmCTHD.MdiParent = this.MdiParent;
            frmCTHD.Show();
        }

        private void frmMainAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (SqlConnection conn = ChuoiKN.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE TAIKHOAN SET DANGNHAP = 0 WHERE TENTK = @tentk";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tentk", frmDangNhap.TenDangNhap);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnNhatKy_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmNhatKy")
                {
                    f.Activate();
                    f.Show();
                }
            frmNhatKy frmHD = new frmNhatKy();
            frmHD.MdiParent = this.MdiParent;
            frmHD.Show();
        }
    }
}
