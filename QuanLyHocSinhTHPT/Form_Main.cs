using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyHocSinhTHPT.Component;
using BUS;
using DTO;

namespace QuanLyHocSinhTHPT
{
    public partial class Form_Main : Office2007RibbonForm
    {
        #region Toàn cục
        public static string userName = string.Empty;
        Form_DangNhap frmDangNhap = null;
        #endregion
        #region Load DateTime Now
        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_time.Text = dt.ToString();
        }
        #endregion
        #region Form Load
        public Form_Main()
        {
            InitializeComponent();
            timer.Start();
        }
        // Constructor DangNhap
        public void DangNhap()
        {
            if (frmDangNhap == null || frmDangNhap.IsDisposed)
            {
                frmDangNhap = new Form_DangNhap();
                frmDangNhap.ShowDialog();
            }
            // Hiển thị người dùng nào đang Login??
            if (string.IsNullOrEmpty(userName) == false)
            {
                if (userName == "admin")
                    GuiAdmin();
                if (userName == "giaovu")
                    GuiGiaoVu();
                if (userName == "giaovien")
                    GuiGiaoVien();
                lbl_usernamelogin.Text = userName;
                // Đăng nhập thành công thì
                btn_dangxuat.Enabled = true;
                btn_dangnhap.Enabled = false;
            }
            else
                GuiDefault();
                
        }
        // Giao diện Mặc định
        public void GuiDefault()
        {
            // Các control được sử dụng
            btn_dangnhap.Enabled = true;
            btn_dangnhapcontext.Enabled = true;
            btn_thoat.Enabled = true;
            btn_thoatcontext.Enabled = true;
            rbb_thongtin.Enabled = true;
            // Các control không được sử dụng
            btn_dangxuat.Enabled = false;
            btn_dangxuatcontext.Enabled = false;
            btn_qlnguoidung.Enabled = false;
            btn_doimatkhau.Enabled = false;
            btn_doimatkhaucontext.Enabled = false;
            rbb_danhsach.Enabled = false;
            rbb_giaovien.Enabled = false;
            rbb_hocsinh.Enabled = false;
            rbb_ketquahoctap.Enabled = false;
            rbb_khoilop.Enabled = false;
            rbb_kqcanam.Enabled = false;
            rbb_kqhocky.Enabled = false;
            rbb_monhoc.Enabled = false;
            rbb_namhochocky.Enabled = false;
            rbb_quydinh.Enabled = false;
            rbb_tracuu.Enabled = false;     
        }
        // Giao diện ADMIN
        public void GuiAdmin()
        {
            // Các control được sử dụng
            btn_dangnhap.Enabled = true;
            btn_dangnhapcontext.Enabled = true;
            btn_thoat.Enabled = true;
            btn_thoatcontext.Enabled = true;
            rbb_thongtin.Enabled = true;
            btn_dangxuat.Enabled = true;
            btn_dangxuatcontext.Enabled = true;
            btn_qlnguoidung.Enabled = true;
            btn_doimatkhau.Enabled = true;
            btn_doimatkhaucontext.Enabled = true;
            rbb_danhsach.Enabled = true;
            rbb_giaovien.Enabled = true;
            rbb_hocsinh.Enabled = true;
            rbb_ketquahoctap.Enabled = true;
            rbb_khoilop.Enabled = true;
            rbb_kqcanam.Enabled = true;
            rbb_kqhocky.Enabled = true;
            rbb_monhoc.Enabled = true;
            rbb_namhochocky.Enabled = true;
            rbb_quydinh.Enabled = true;
            rbb_tracuu.Enabled = true;
        }
        // Giao diện Giáo vụ
        public void GuiGiaoVu()
        {
            // Các control được sử dụng
            btn_dangnhap.Enabled = true;
            btn_dangnhapcontext.Enabled = true;
            btn_thoat.Enabled = true;
            btn_thoatcontext.Enabled = true;
            rbb_thongtin.Enabled = true;
            rbb_giaovien.Enabled = true;
            rbb_hocsinh.Enabled = true;
            rbb_quydinh.Enabled = true;
            rbb_tracuu.Enabled = true;
            rbb_monhoc.Enabled = true;
            rbb_danhsach.Enabled = true; 
            // Các control không được sử dụng
            btn_dangxuat.Enabled = false;
            btn_dangxuatcontext.Enabled = false;
            btn_qlnguoidung.Enabled = false;
            btn_doimatkhau.Enabled = false;
            btn_doimatkhaucontext.Enabled = false;
            rbb_ketquahoctap.Enabled = false;
            rbb_khoilop.Enabled = false;
            rbb_kqcanam.Enabled = false;
            rbb_kqhocky.Enabled = false;      
            rbb_namhochocky.Enabled = false;
            btn_diemso.Enabled = false;
        }
        // Giao diện Giáo viên
        public void GuiGiaoVien()
        {
            // Các control được sử dụng
            btn_dangnhap.Enabled = true;
            btn_dangnhapcontext.Enabled = true;
            btn_thoat.Enabled = true;
            btn_thoatcontext.Enabled = true;
            rbb_thongtin.Enabled = true;        
            rbb_quydinh.Enabled = true;
            rbb_tracuu.Enabled = true;
            rbb_danhsach.Enabled = true;
            rbb_monhoc.Enabled = true;
            // Các control không được sử dụng
            btn_dangxuat.Enabled = false;
            btn_dangxuatcontext.Enabled = false;
            btn_qlnguoidung.Enabled = false;
            btn_doimatkhau.Enabled = false;
            btn_doimatkhaucontext.Enabled = false;
            rbb_ketquahoctap.Enabled = false;
            rbb_khoilop.Enabled = false;
            rbb_kqcanam.Enabled = false;
            rbb_kqhocky.Enabled = false;
            rbb_namhochocky.Enabled = false;
            rbb_giaovien.Enabled = false;      
            rbb_hocsinh.Enabled = false;
            btn_monhoc.Enabled = false;
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            lbl_dayofweek.Text = "Today is: " + DateTime.Now.DayOfWeek.ToString(); // Ngày giờ hiện tại
            // 
            GuiDefault();
            // Gọi Form Login bắt người dùng Login
            DangNhap();
             
        }
        #endregion
        #region Menu Start
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (frmDangNhap == null || frmDangNhap.IsDisposed)
                frmDangNhap = new Form_DangNhap();
            frmDangNhap.ShowDialog();    
            DangNhap();
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.lbl_usernamelogin.Text = "Không có";
            GuiDefault();
        }

        private void btn_qlnguoidung_Click(object sender, EventArgs e)
        {

        }

        private void btn_saoluucsdl_Click(object sender, EventArgs e)
        {

        }

        private void btn_phuchoicsdl_Click(object sender, EventArgs e)
        {

        }

        private void btn_dongchuongtrinh_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                return;
            else
                Application.Exit();         
        }
        #endregion
        #region Menu Quản lý
        private void btn_namhoc_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormNamHoc();
        }
        private void btn_hocky_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormHocKy();
        }

        private void btn_khoi_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormKhoiLop();
        }

        private void btn_lop_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormLop();
        }

        private void btn_giaovien_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormGiaoVien();
        }

        private void btn_phancong_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormPhanCong();
        }

        private void btn_phuhuynh_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormPhuHuynh();
        }

        private void btn_dantoc_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormDanToc();
        }

        private void btn_tongiao_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormTonGiao();
        }
        private void btn_doituong_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormDoiTuong();
        }
        private void btn_hocsinh_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormHocSinh();
        }

        private void btn_phanlop_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormPhanLop();
        }

        private void btn_monhoc_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormMonHoc();
        }

        private void btn_diemso_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormDiemSo();
        }

        private void btn_ketqua_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormKetQuaHocTap();
        }

        private void btn_hanhkiem_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormHanhKiem();
        }

        private void btn_hocluc_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormHocLuc();
        }
        #endregion
        #region Menu Thống kê

        private void btn_kqhktheolop_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormKQHKTheoLop();
        }

        private void btn_kqcntheolop_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormKQCNTheoLop();
        }

        private void btn_dsgiaovien_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormDanhSachGiaoVien();
        }

        private void btn_dshocsinh_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormDanhSachHocSinh();
        }

        private void btn_dslophoc_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormDanhSachLopHoc();
        }
        #endregion
        #region Menu Tra cứu
        private void btn_tracuugiaovien_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormTraCuuGiaoVien();
        }

        private void btn_tracuuhocsinh_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormTraCuuHocSinh();
        }
        #endregion
        #region Menu Quy định
        private void btn_quydinhdotuoi_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormQuyDinh();
        }

        private void btn_quydinhsiso_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormQuyDinh();
        }

        private void btn_quydinhthangdiem_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormQuyDinh();
        }
        #endregion
        #region Menu Thông tin
        private void btn_thongtintruonghoc_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormThongTinTruongHoc();
        }

        private void btn_huongdansudung_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormHuongDanSuDung();
        }

        private void btn_thongtinphanmem_Click(object sender, EventArgs e)
        {
            ShowForm.ShowFormThongTinChuongTrinh();
        }
        #endregion     
    }
}
