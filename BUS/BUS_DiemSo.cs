using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_DiemSo
    {
        DAL_DiemSo dal = new DAL_DiemSo();
        DAL_HocSinh dalHocSinh = new DAL_HocSinh();
        DAL_MonHoc dalMonHoc = new DAL_MonHoc();
        // Lấy danh sách học sinh theo lớp, học kỳ, môn học
        public DataTable LayBangDiem_Lop_MonHoc_HocKy(string maLop, string maHocKy, string maMonHoc)
        {
            return dal.LayBangDiem_MonHoc_HocKy_Lop(maLop, maHocKy, maMonHoc);
        }
        // Lưu điểm học sinh
        public bool LuuBangDiem_HocSinh_MonHoc_HocKy(DTO_DiemSo bd)
        {
            return dal.LuuBangDiem_MonHoc_HocSinh_HocKy(bd);
        }
        // Lấy danh sách học sinh cb cập nhật
        public DataTable LayDSHocSinhDaCoDiem_TheoMaNamHoc_MaLop_MonHoc_HocKy(string pMaNamHoc, string pMaLop, string pMaMonHoc, string pMaHocKy)
        {
            return dal.LayDSHocSinhChuaCoDiem_TheoNamHoc_Lop_MonHoc_HocKy(pMaNamHoc, pMaLop, pMaMonHoc, pMaHocKy);
        }
        // Load data to dgv
        public DataTable LoadDataInto_DGVDiemSo()
        {
            return dal.LoadDataIntoDGVDiemSo();
        }
        // Insert, update, delele trên lưới
        public bool Update_All(DataTable dt)
        {
            return dal.Update_All(dt);
        }
        // Thêm bằng DTO
        public bool Them(DTO_DiemSo pDiemSo)
        {
            return dal.Them(pDiemSo);
        }
        // Lấy bảng điểm theo lớp, theo kỳ
        public List<DTO_BangDiemHocKy> LayBangDiem_Lop_HocKy(string maLop, string maHocKy)
        {
            var bangDiemHocKy = new List<DTO_BangDiemHocKy>();
            // Lấy ds học sinh của lớp
            List<DTO_HocSinh> dsHocsinh = dalHocSinh.LayDSHocSinh_LopHoc(maLop);
            DTO_MonHoc_HeSo dsHeSoMonHoc = dalMonHoc.LayHeSo_MonHoc();
            foreach (DTO_HocSinh hocsinh in dsHocsinh)
            {
                var bangDiemCaNhan = new DTO_BangDiemHocKy
                {
                    MaHocSinh = hocsinh.MaHocSinh,
                    HoTenHocSinh = hocsinh.HoTenHocSinh
                };
                // Tính điểm trung bình học kỳ
                DataTable dtBangDiem = dal.LayBangDiem_HocKy_HocSinh(maLop, hocsinh.MaHocSinh, maHocKy);
                int soMonHoc = dtBangDiem.Rows.Count;
                int soMonDuDiem = 0;
                double tongDiem = 0;
                double tongHeSo = 0;
                double heso = 0;
                foreach (DataRow dr in dtBangDiem.Rows)
                {
                    object dtb;
                    if (dr["DTB"] is DBNull)
                        dtb = "_";
                    else
                        dtb = dr["DTB"];

                    switch (Convert.ToString(dr["MaMonHoc"]))
                    {
                        case "MH01":
                            bangDiemCaNhan.DiemToan = dtb;
                            heso = dsHeSoMonHoc.Toan;
                            break;
                        case "MH02":
                            bangDiemCaNhan.DiemVatLy = dtb;
                            heso = dsHeSoMonHoc.VatLy;
                            break;
                        case "MH03":
                            bangDiemCaNhan.DiemHoaHoc = dtb;
                            heso = dsHeSoMonHoc.HoaHoc;
                            break;
                        case "MH04":
                            bangDiemCaNhan.DiemSinhHoc = dtb;
                            heso = dsHeSoMonHoc.SinhHoc;
                            break;
                        case "MH05":
                            bangDiemCaNhan.DiemNguVan = dtb;
                            heso = dsHeSoMonHoc.NguVan;
                            break;
                        case "MH06":
                            bangDiemCaNhan.DiemLichSu = dtb;
                            heso = dsHeSoMonHoc.LichSu;
                            break;
                        case "MH07":
                            bangDiemCaNhan.DiemDiaLy = dtb;
                            heso = dsHeSoMonHoc.DiaLy;
                            break;
                        case "MH08":
                            bangDiemCaNhan.DiemNgoaiNgu = dtb;
                            heso = dsHeSoMonHoc.NgoaiNgu;
                            break;
                        case "MH09":
                            bangDiemCaNhan.DiemGDCDan= dtb;
                            heso = dsHeSoMonHoc.GDCDan;
                            break;
                        case "MH10":
                            bangDiemCaNhan.DiemTinHoc= dtb;
                            heso = dsHeSoMonHoc.TinHoc;
                            break;
                        case "MH11":
                            bangDiemCaNhan.DiemTheDuc = dtb;
                            heso = dsHeSoMonHoc.TheDuc;
                            break;
                        case "MH12":
                            bangDiemCaNhan.DiemQuocPhong = dtb;
                            heso = dsHeSoMonHoc.QuocPhong;
                            break;
                        case "MH13":
                            bangDiemCaNhan.DiemCongNghe = dtb;
                            heso = dsHeSoMonHoc.CongNghe;
                            break;
                    }
                    if (!Convert.ToString(dtb).Equals("_"))
                    {
                        tongDiem += heso * Convert.ToDouble(dtb);
                        tongHeSo += heso;
                        soMonDuDiem++;
                    }
                }
                if (soMonDuDiem == soMonHoc)
                {
                    bangDiemCaNhan.DTB = Math.Round(tongDiem / tongHeSo, 2);
                }
                else
                    bangDiemCaNhan.DTB = "";

                bangDiemHocKy.Add(bangDiemCaNhan);
            }

            return bangDiemHocKy;
        }
        public DataTable LayBangDiemTBHocSinhTheoHocKy(string maLop, string maHocSinh)
        {
            return dal.LayBangDiemTBHocSinhTheoHocKy(maLop, maHocSinh);
        }
    }
}
