using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HuynhChiNguyen_233400_DH23TIN02
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        SqlDataAdapter BoDocGhi;
        DataSet dsTaiKhoan;

        string tenTK_Goc = "";
        public frmQuanLyTaiKhoan()
        {
            
            InitializeComponent();
            
        }

        //Phương thức ComboBox Vai Trò
        private void LoadCMBVaiTro()
        {
            cmbVaiTro.Items.Clear();
            cmbVaiTro.Items.Add("ADMIN");
            cmbVaiTro.Items.Add("NHANVIEN");

            cmbVaiTro.SelectedIndex = 1;

        }

        //Phuong thức ComboBox Đăng Nhập
        private void LoadCMBDangNhap()
        {
            var dsDangNhap = new List<object>
            {
                new { Text = "ONLINE", Value = 1 },
                new { Text = "OFFLINE", Value = 0 }
            };

            cmbDangNhap.DataSource = dsDangNhap;
            cmbDangNhap.DisplayMember = "Text";
            cmbDangNhap.ValueMember = "Value";

        }

        //Phuong thức ComboBox Trạng thái
        private void LoadCMBTrangThai()
        {
            cmbTrangThai.Items.Clear();
            cmbTrangThai.Items.Add("HOAT DONG");
            cmbTrangThai.Items.Add("KHOA");

            cmbTrangThai.SelectedIndex = 0;
        }


        private void ToMauTrangThai()
        {
            foreach (DataGridViewRow row in dtgvTK.Rows)
            {
                if (row.Cells["TRANGTHAI"].Value == null) continue;

                string trangThai = row.Cells["TRANGTHAI"].Value.ToString().Trim().ToUpper();

                row.DefaultCellStyle.ForeColor = Color.Black;

                if (trangThai == "HOAT DONG")
                {
                    row.DefaultCellStyle.BackColor = Color.Honeydew;
                    row.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen;
                }
                else if (trangThai == "KHOA")
                {
                    row.DefaultCellStyle.BackColor = Color.Gainsboro;
                    row.DefaultCellStyle.SelectionBackColor = Color.Gray;
                }
                
            }
        }

        //Phuong thức DataGridView

        private void LoadDataGridView()
        {
            using(SqlConnection KN = ChuoiKN.GetConnection())
            {
                KN.Open();

                string query = "SELECT TENTK, MATKHAU, VAITRO, DANGNHAP, TRANGTHAI FROM TAIKHOAN";

                BoDocGhi = new SqlDataAdapter(query,KN);

                dsTaiKhoan = new DataSet("dsTaiKhoan");

                BoDocGhi.Fill(dsTaiKhoan);

                dsTaiKhoan.Tables[0].PrimaryKey = new DataColumn[]
                {
                    dsTaiKhoan.Tables[0].Columns["TENTK"]
                };

                dtgvTK.DataSource = dsTaiKhoan.Tables[0];
                dtgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dtgvTK.DefaultCellStyle.ForeColor = Color.Black;
                dtgvTK.DefaultCellStyle.BackColor = Color.White;
                dtgvTK.DefaultCellStyle.SelectionForeColor = Color.White;
                dtgvTK.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;

                dtgvTK.Columns["TENTK"].HeaderText = "Tên tài khoản";
                dtgvTK.Columns["MATKHAU"].HeaderText = "Mật khẩu";
                dtgvTK.Columns["VAITRO"].HeaderText = "Vai trò";
                dtgvTK.Columns["DANGNHAP"].HeaderText = "Đăng nhập";
                dtgvTK.Columns["TRANGTHAI"].HeaderText = "Trạng thái";
                

                dtgvTK.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                dtgvTK.ColumnHeadersHeight = 40;

                ToMauTrangThai();
            }

        }

        //Phuong thức ResetForm

        private void ResetForm()
        {
            txtTenTK.Clear();
            txtMatKhau.Clear();
            cmbVaiTro.SelectedIndex = 1;
            cmbDangNhap.Enabled = false;
            cmbTrangThai.SelectedIndex = 0;
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadCMBVaiTro();
            LoadCMBDangNhap();
            LoadCMBTrangThai();
            LoadDataGridView();

            if (dtgvTK.Columns["DANGNHAP"] is DataGridViewCheckBoxColumn chk)
            {
                chk.TrueValue = 1;
                chk.FalseValue = 0;
                chk.IndeterminateValue = 0;
                chk.ThreeState = false;
            }

            cmbVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDangNhap.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        //NÚt Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
           
            try
            {
                using (SqlConnection KN = ChuoiKN.GetConnection())
                {

                    //Kiểm tra Thông tin không nhập đầy đủ
                    if (string.IsNullOrWhiteSpace(txtTenTK.Text) ||
                       string.IsNullOrWhiteSpace(txtMatKhau.Text) ||
                       cmbVaiTro.SelectedIndex == -1 ||
                       cmbTrangThai.SelectedIndex == -1)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông tin không hợp lệ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    //Kiểm tra khóa chính có bị trùng hay không
                    if (dsTaiKhoan.Tables[0].Rows.Find(txtTenTK.Text) != null)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại.", "Vui lòng nhập lại tài khoản cần thêm!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    KN.Open();

                    string insertQuery = @"INSERT INTO TAIKHOAN (TENTK, MATKHAU, VAITRO, DANGNHAP, TRANGTHAI)
                                           VALUES (@TENTK, @MATKHAU, @VAITRO, 0, @TRANGTHAI)";

                    SqlCommand cmd = new SqlCommand(insertQuery, KN);

                    cmd.Parameters.AddWithValue("@TENTK", txtTenTK.Text);
                    cmd.Parameters.AddWithValue("@MATKHAU", txtMatKhau.Text);
                    cmd.Parameters.AddWithValue("@VAITRO", cmbVaiTro.Text);
                    cmd.Parameters.AddWithValue("@TRANGTHAI", cmbTrangThai.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm tài khoản thành công.");
                    LoadDataGridView();
                    ResetForm();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công: " + ex.Message);
            }

        }

        //Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenTK.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần khóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult rs = MessageBox.Show("Khóa tài khoản này sẽ khiến nhân viên nghỉ việc.\nBạn có chắc không?","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs != DialogResult.Yes) return;

            bool dangNhap = Convert.ToBoolean(cmbDangNhap.SelectedValue);

            if (dangNhap)
            {
                MessageBox.Show("Không thể khóa tài khoản đang đăng nhập!");
                return;
            }

            try
            {
                using (SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();
                    SqlTransaction tran = KN.BeginTransaction();

                    try
                    {
                        string sqlCheckRole = "SELECT VAITRO FROM TAIKHOAN WHERE TENTK = @TENTK";
                        SqlCommand cmdRole = new SqlCommand(sqlCheckRole, KN, tran);
                        cmdRole.Parameters.AddWithValue("@TENTK", txtTenTK.Text);

                        string vaiTro = cmdRole.ExecuteScalar()?.ToString();

                        if (vaiTro == "ADMIN")
                        {
                            MessageBox.Show("Không được khóa tài khoản ADMIN!","Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tran.Rollback();
                            return;
                        }

                        // 1. Khóa tài khoản
                        string sqlTK = @"UPDATE TAIKHOAN
                                            SET TRANGTHAI = N'KHOA',
                                                DANGNHAP = 0
                                         WHERE TENTK = @TENTK";

                        SqlCommand cmdTK = new SqlCommand(sqlTK, KN, tran);
                        cmdTK.Parameters.AddWithValue("@TENTK", txtTenTK.Text);
                        cmdTK.ExecuteNonQuery();

                        // 2. Chuyển nhân viên sang nghỉ việc

                        string sqlNV = @"UPDATE NHANVIEN
                                         SET TRANGTHAI = N'NGHI VIEC'
                                         WHERE TENTK = @TENTK";

                        SqlCommand cmdNV = new SqlCommand(sqlNV, KN, tran);
                        cmdNV.Parameters.AddWithValue("@TENTK", txtTenTK.Text);
                        cmdNV.ExecuteNonQuery();

                        int soDong = cmdNV.ExecuteNonQuery();

                        if (soDong == 0)
                        {
                            MessageBox.Show("Không tìm thấy nhân viên gắn với tài khoản này!");
                        }

                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }

                MessageBox.Show("Đã khóa tài khoản và cập nhật trạng thái nhân viên.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDataGridView();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khóa tài khoản: " + ex.Message);
            }
        }

        //Nút Cập Nhật
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dtgvTK.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần cập nhật.","Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Kiểm tra Thông tin không nhập đầy đủ
            if (string.IsNullOrWhiteSpace(txtTenTK.Text) ||
               string.IsNullOrWhiteSpace(txtMatKhau.Text) ||
               cmbVaiTro.SelectedIndex == -1 ||
               cmbDangNhap.SelectedIndex == -1 ||
               cmbTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông tin không hợp lệ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc muốn cập nhật tài khoản này?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (rs != DialogResult.Yes) return;

            // Nếu sửa khóa chính → thông báo 

            if (txtTenTK.Text.Trim() != tenTK_Goc)
            {
                MessageBox.Show("Vui lòng không cập nhật Tên tài khoản.","Không hợp lệ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection KN = ChuoiKN.GetConnection())
                {
                    KN.Open();

                    string sqlCheckTrangThai = "SELECT TRANGTHAI FROM TAIKHOAN WHERE TENTK = @TENTK";
                    SqlCommand cmdCheckTT = new SqlCommand(sqlCheckTrangThai, KN);
                    cmdCheckTT.Parameters.AddWithValue("@TENTK", txtTenTK.Text);

                    string trangThaiDB = cmdCheckTT.ExecuteScalar()?.ToString();

                    if (trangThaiDB == "KHOA")
                    {
                        MessageBox.Show("Tài khoản đã bị khóa, không thể cập nhật!","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }

                    // ====== CHẶN 2 ADMIN ONLINE CÙNG LÚC ======

                    if (cmbVaiTro.Text == "ADMIN" && (int)cmbDangNhap.SelectedValue == 1)
                    {
                        string sqlCheckAdmin = @"SELECT COUNT(*) 
                                                 FROM TAIKHOAN
                                                 WHERE VAITRO = 'ADMIN' AND DANGNHAP = 1 AND TENTK <> @TENTK";

                        SqlCommand cmdCheck = new SqlCommand(sqlCheckAdmin, KN);
                        cmdCheck.Parameters.AddWithValue("@TENTK", txtTenTK.Text);

                        int dem = (int)cmdCheck.ExecuteScalar();

                        if (dem > 0)
                        {
                            MessageBox.Show("Đã có ADMIN đang đăng nhập.\nKhông thể đăng nhập thêm ADMIN khác!",
                                            "Cảnh báo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string updateQuery = @"UPDATE TAIKHOAN
                                         SET MATKHAU = @MATKHAU,
                                         VAITRO = @VAITRO,
                                         DANGNHAP = @DANGNHAP,
                                         TRANGTHAI = @TRANGTHAI
                                         WHERE TENTK = @TENTK";

                    SqlCommand cmd = new SqlCommand(updateQuery, KN);

                    cmd.Parameters.AddWithValue("@TENTK", txtTenTK.Text);
                    cmd.Parameters.AddWithValue("@MATKHAU", txtMatKhau.Text);
                    cmd.Parameters.AddWithValue("@VAITRO", cmbVaiTro.Text);
                    cmd.Parameters.Add("@DANGNHAP", SqlDbType.Bit).Value = cmbDangNhap.SelectedValue;
                    cmd.Parameters.AddWithValue("@TRANGTHAI", cmbTrangThai.Text);

                    int kq = cmd.ExecuteNonQuery();

                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        LoadDataGridView();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản để cập nhật.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        private void dtgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtTenTK.Text = dtgvTK.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMatKhau.Text = dtgvTK.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbVaiTro.Text = dtgvTK.Rows[e.RowIndex].Cells[2].Value.ToString();

                object DangNhap = dtgvTK.Rows[e.RowIndex].Cells[3].Value;
                if (DangNhap != null && DangNhap != DBNull.Value)
                {
                    bool DN = Convert.ToBoolean(DangNhap);
                    cmbDangNhap.SelectedValue = DN ? 1 : 0;
                }

                cmbTrangThai.Text = dtgvTK.Rows[e.RowIndex].Cells[4].Value.ToString();

                tenTK_Goc = txtTenTK.Text;

                // ===== CHẶN CẬP NHẬT KHI TK ĐÃ BỊ KHÓA =====

                if (cmbTrangThai.Text == "KHOA")
                {
                    txtMatKhau.Enabled = false;
                    cmbVaiTro.Enabled = false;
                    cmbDangNhap.Enabled = false;
                    cmbTrangThai.Enabled = false;
                }
                else
                {
                    // mở lại khi chọn TK hoạt động
                    txtMatKhau.Enabled = true;
                    cmbVaiTro.Enabled = true;
                    cmbDangNhap.Enabled = true;
                    cmbTrangThai.Enabled = true;
                }
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmQuanLyNhanVien)
                {
                    f.Activate();
                    return;
                }
            }

            frmQuanLyNhanVien frm = new frmQuanLyNhanVien();
            frm.Show();

        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyTaiKhoan_Activated(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
