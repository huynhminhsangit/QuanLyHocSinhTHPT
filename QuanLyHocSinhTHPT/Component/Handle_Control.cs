using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using DevComponents.DotNetBar;
using BUS;
using DTO;

namespace QuanLyHocSinhTHPT.Component
{
    public static class ShowForm
    {  
        #region Tên Form
        public static Form_Main frmMain = null;
        public static Form_QuyDinh                      frmQuyDinh              = null;
        public static Form_ThongTinChuongTrinh          frmThongTinChTrinh      = null;
        public static Form_TTTruongHoc                  frmThongTinTruongHoc    = null;
        public static Form_HuongDanSuDung               frmHuongDanSuDung       = null;
        public static Form_DoiMatKhau                   frmDoiMatKhau           = null;
        public static Form_NamHoc                       frmNamHoc               = null;
        public static Form_KhoiLop                      frmKhoiLop              = null;
        public static Form_Lop                          frmLop                  = null;
        public static Form_HocKy                        frmHocKy                = null;
        public static Form_GiaoVien                     frmGiaoVien             = null;
        public static Form_PhanCong                     frmPhanCong             = null;
        public static Form_PhuHuynh                     frmPhuHuynh             = null;
        public static Form_DanToc                       frmDanToc               = null;
        public static Form_TonGiao                      frmTonGiao              = null;
        public static Form_DoiTuong                     frmDoiTuong             = null;
        public static Form_HocSinh                      frmHocSinh              = null;
        public static Form_PhanLop                      frmPhanLop              = null;
        public static Form_MonHoc                       frmMonHoc               = null;
        public static Form_DiemSo                       frmDiemSo               = null;
        public static Form_KetQuaHocTap                 frmKetQuaHocTap         = null;
        public static Form_HanhKiem                     frmHanhKiem             = null;
        public static Form_HocLuc                       frmHocLuc               = null;
        public static Form_KQHK                  frmKQHKTheoLop          = null;
        public static Form_KQCN                  frmKQCNTheoLop          = null;
        public static Form_DanhSachGiaoVien             frmDSGiaoVien           = null;
        public static Form_DanhSachHocSinh              frmDSHocSinh            = null;
        public static Form_DanhSachLopHoc               frmDSLopHoc             = null;
        public static Form_TraCuuGiaoVien               frmTCGiaoVien           = null;
        public static Form_TraCuuHocSinh                frmTCHocSinh            = null;
 
        #endregion
        #region Hiện Form
        #region Menu Quản Lý
        public static void ShowFormNamHoc()
        {
            if (frmNamHoc == null || frmNamHoc.IsDisposed)
            {
                frmNamHoc = new Form_NamHoc();
                frmNamHoc.MdiParent = Form_Main.ActiveForm;
                frmNamHoc.Show();
            }
            else
                frmNamHoc.Activate();
        }
        public static void ShowFormHocKy()
        {
            if (frmHocKy == null || frmHocKy.IsDisposed)
            {
                frmHocKy = new Form_HocKy();
                frmHocKy.MdiParent = Form_Main.ActiveForm;
                frmHocKy.Show();
            }
            else
                frmHocKy.Activate();
        }
        public static void ShowFormKhoiLop()
        {
            if (frmKhoiLop == null || frmKhoiLop.IsDisposed)
            {
                frmKhoiLop = new Form_KhoiLop();
                frmKhoiLop.MdiParent = Form_Main.ActiveForm;
                frmKhoiLop.Show();
            }
            else
                frmKhoiLop.Activate();
        }
        public static void ShowFormLop()
        {
            if (frmLop == null || frmLop.IsDisposed)
            {
                frmLop = new Form_Lop();
                frmLop.MdiParent = Form_Main.ActiveForm;
                frmLop.Show();
            }
            else
                frmLop.Activate();
        }  
        public static void ShowFormGiaoVien()
        {
            if (frmGiaoVien == null || frmGiaoVien.IsDisposed)
            {
                frmGiaoVien = new Form_GiaoVien();
                frmGiaoVien.MdiParent = Form_Main.ActiveForm;
                frmGiaoVien.Show();
            }
            else
                frmGiaoVien.Activate();
        }
        public static void ShowFormPhanCong()
        {
            if (frmPhanCong == null || frmPhanCong.IsDisposed)
            {
                frmPhanCong = new Form_PhanCong();
                frmPhanCong.MdiParent = Form_Main.ActiveForm;
                frmPhanCong.Show();
            }
            else
                frmPhanCong.Activate();
        }
        public static void ShowFormPhuHuynh()
        {
            if (frmPhuHuynh == null || frmPhuHuynh.IsDisposed)
            {
                frmPhuHuynh = new Form_PhuHuynh();
                frmPhuHuynh.MdiParent = Form_Main.ActiveForm;
                frmPhuHuynh.Show();
            }
            else
                frmPhuHuynh.Activate();
        }
        public static void ShowFormDanToc()
        {
            if (frmDanToc == null || frmDanToc.IsDisposed)
            {
                frmDanToc = new Form_DanToc();
                frmDanToc.MdiParent = Form_Main.ActiveForm;
                frmDanToc.Show();
            }
            else
                frmDanToc.Activate();
        }
        public static void ShowFormTonGiao()
        {
            if (frmTonGiao == null || frmTonGiao.IsDisposed)
            {
                frmTonGiao = new Form_TonGiao();
                frmTonGiao.MdiParent = Form_Main.ActiveForm;
                frmTonGiao.Show();
            }
            else
                frmTonGiao.Activate();
        }
        public static void ShowFormDoiTuong()
        {
            if (frmDoiTuong == null || frmDoiTuong.IsDisposed)
            {
                frmDoiTuong = new Form_DoiTuong();
                frmDoiTuong.MdiParent = Form_Main.ActiveForm;
                frmDoiTuong.Show();
            }
            else
                frmDoiTuong.Activate();
        }
        public static void ShowFormHocSinh()
        {
            if (frmHocSinh == null || frmHocSinh.IsDisposed)
            {
                frmHocSinh = new Form_HocSinh();
                frmHocSinh.MdiParent = Form_Main.ActiveForm;
                frmHocSinh.Show();
            }
            else
                frmHocSinh.Activate();
        }
        public static void ShowFormPhanLop()
        {
            if (frmPhanLop == null || frmPhanLop.IsDisposed)
            {
                frmPhanLop = new Form_PhanLop();
                frmPhanLop.MdiParent = Form_Main.ActiveForm;
                frmPhanLop.Show();
            }
            else
                frmPhanLop.Activate();
        }
        public static void ShowFormMonHoc()
        {
            if (frmMonHoc == null || frmMonHoc.IsDisposed)
            {
                frmMonHoc = new Form_MonHoc();
                frmMonHoc.MdiParent = Form_Main.ActiveForm;
                frmMonHoc.Show();
            }
            else
                frmMonHoc.Activate();
        }
        public static void ShowFormDiemSo()
        {
            if (frmDiemSo == null || frmDiemSo.IsDisposed)
            {
                frmDiemSo = new Form_DiemSo();
                frmDiemSo.MdiParent = Form_Main.ActiveForm;
                frmDiemSo.Show();
            }
            else
                frmDiemSo.Activate();
        }
        public static void ShowFormKetQuaHocTap()
        {
            if (frmKetQuaHocTap == null || frmKetQuaHocTap.IsDisposed)
            {
                frmKetQuaHocTap = new Form_KetQuaHocTap();
                frmKetQuaHocTap.MdiParent = Form_Main.ActiveForm;
                frmKetQuaHocTap.Show();
            }
            else
                frmKetQuaHocTap.Activate();
        }
        public static void ShowFormHanhKiem()
        {
            if (frmHanhKiem == null || frmHanhKiem.IsDisposed)
            {
                frmHanhKiem = new Form_HanhKiem();
                frmHanhKiem.MdiParent = Form_Main.ActiveForm;
                frmHanhKiem.Show();
            }
            else
                frmHanhKiem.Activate();
        }
        public static void ShowFormHocLuc()
        {
            if (frmHocLuc == null || frmHocLuc.IsDisposed)
            {
                frmHocLuc = new Form_HocLuc();
                frmHocLuc.MdiParent = Form_Main.ActiveForm;
                frmHocLuc.Show();
            }
            else
                frmHocLuc.Activate();
        }
        #endregion
        #region Menu Thống kê
        public static void ShowFormKQHKTheoLop()
        {
            if (frmKQHKTheoLop == null || frmKQHKTheoLop.IsDisposed)
            {
                frmKQHKTheoLop = new Form_KQHK();
                frmKQHKTheoLop.MdiParent = Form_Main.ActiveForm;
                frmKQHKTheoLop.Show();
            }
            else
                frmKQHKTheoLop.Activate();
        }
        public static void ShowFormKQCNTheoLop()
        {
            if (frmKQCNTheoLop == null || frmKQCNTheoLop.IsDisposed)
            {
                frmKQCNTheoLop = new Form_KQCN();
                frmKQCNTheoLop.MdiParent = Form_Main.ActiveForm;
                frmKQCNTheoLop.Show();
            }
            else
                frmKQCNTheoLop.Activate();
        }
        public static void ShowFormDanhSachGiaoVien()
        {
            if (frmDSGiaoVien == null || frmDSGiaoVien.IsDisposed)
            {
                frmDSGiaoVien = new Form_DanhSachGiaoVien();
                frmDSGiaoVien.MdiParent = Form_Main.ActiveForm;
                frmDSGiaoVien.Show();
            }
            else
                frmDSGiaoVien.Activate();
        }
        public static void ShowFormDanhSachHocSinh()
        {
            if (frmDSHocSinh == null || frmDSHocSinh.IsDisposed)
            {
                frmDSHocSinh = new Form_DanhSachHocSinh();
                frmDSHocSinh.MdiParent = Form_Main.ActiveForm;
                frmDSHocSinh.Show();
            }
            else
                frmDSHocSinh.Activate();
        }
        public static void ShowFormDanhSachLopHoc()
        {
            if (frmDSLopHoc == null || frmDSLopHoc.IsDisposed)
            {
                frmDSLopHoc = new Form_DanhSachLopHoc();
                frmDSLopHoc.MdiParent = Form_Main.ActiveForm;
                frmDSLopHoc.Show();
            }
            else
                frmDSLopHoc.Activate();
        }
        #endregion
        #region Menu Tra cứu
        public static void ShowFormTraCuuGiaoVien()
        {
            if (frmTCGiaoVien == null || frmTCGiaoVien.IsDisposed)
            {
                frmTCGiaoVien = new Form_TraCuuGiaoVien();
                frmTCGiaoVien.MdiParent = Form_Main.ActiveForm;
                frmTCGiaoVien.Show();
            }
            else
                frmTCGiaoVien.Activate();
        }
        public static void ShowFormTraCuuHocSinh()
        {
            if (frmTCHocSinh == null || frmTCHocSinh.IsDisposed)
            {
                frmTCHocSinh = new Form_TraCuuHocSinh();
                frmTCHocSinh.MdiParent = Form_Main.ActiveForm;
                frmTCHocSinh.Show();
            }
            else
                frmTCHocSinh.Activate();
        }
        #endregion
        #region Menu Quy định
        public static void ShowFormQuyDinh()
        {
            if (frmQuyDinh == null || frmQuyDinh.IsDisposed)
            {
                frmQuyDinh = new Form_QuyDinh();
                frmQuyDinh.MdiParent = Form_Main.ActiveForm;
                frmQuyDinh.Show();
            }
            else
                frmQuyDinh.Activate();
        }
        #endregion
        #region Menu Thông tin
        public static void ShowFormThongTinTruongHoc()
        {
            if (frmThongTinTruongHoc == null || frmThongTinTruongHoc.IsDisposed)
            {
                frmThongTinTruongHoc = new Form_TTTruongHoc();
                frmThongTinTruongHoc.ShowDialog();
            }
            else
                frmThongTinTruongHoc.Activate();
        }
        public static void ShowFormHuongDanSuDung()
        {
            if (frmHuongDanSuDung == null || frmHuongDanSuDung.IsDisposed)
            {
                frmHuongDanSuDung = new Form_HuongDanSuDung();
                frmHuongDanSuDung.ShowDialog();
            }
            else
                frmHuongDanSuDung.Activate();
        }
        public static void ShowFormThongTinChuongTrinh()
        {
            if (frmThongTinChTrinh == null || frmThongTinChTrinh.IsDisposed)
            {
                frmThongTinChTrinh = new Form_ThongTinChuongTrinh();
                frmThongTinChTrinh.ShowDialog();
            }
            else
                frmThongTinChTrinh.Activate();
        }
        #endregion
        #endregion
    }
}
