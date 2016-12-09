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
    public class BUS_KQHKTheoLop
    {
        DAL_KQHKTheoLop dal = new DAL_KQHKTheoLop();
        DAL_DiemSo dalDiemSo = new DAL_DiemSo();
        DAL_HocSinh dalHocSinh = new DAL_HocSinh();
        public DataTable LayBangDiemHocKy_TheoLop(string maLop, string maHocKy)
        {
            return dal.LayBangDiemHocKyTheoLop(maLop, maHocKy);
        }
        public DataTable LayDSHocSinhChuaCoDTB_TheoLop(string maLop, string maHocKy)
        {
            return dal.LayDSHocSinhChuaCoDTBTheoLop(maLop, maHocKy);
        }
        public bool LuuBangDiem_HocSinh_HocKy(DTO_KetQuaHocKy kqhk)
        {
            return dal.LuuBangDiemHocSinhHocKy(kqhk);
        }
        public List<DTO_BangDiemCaNam> LayBangDiemTB_Lop_HocKy(string maLop, string maHocKy)
        {
            var bangDiemHocKy = new List<DTO_BangDiemCaNam>();
            // Lấy ds học sinh của lớp
            List<DTO_HocSinh> dsHocsinh = dalHocSinh.LayDSHocSinh_LopHoc(maLop);
            DTO_HocKy_HeSo dsHeSoHocKy = new DTO_HocKy_HeSo();
            foreach (DTO_HocSinh hocsinh in dsHocsinh)
            {
                var bangDiemCaNhan = new DTO_BangDiemCaNam
                {
                    MaHocSinh = hocsinh.MaHocSinh,
                    HoTenHocSinh = hocsinh.HoTenHocSinh
                };
                // Tính điểm trung bình học kỳ
                DataTable dtBangDiem = dalDiemSo.LayBangDiemTBHocSinhTheoHocKy(maLop, hocsinh.MaHocSinh, maHocKy);
                int soHocKy = dtBangDiem.Rows.Count;
                int soHocKyDuDTB = 0;
                double tongDTB = 0;
                double tongHeSo = 0;
                double heso = 0;
                foreach (DataRow dr in dtBangDiem.Rows)
                {
                    object dtb;
                    if (dr["DTB"] is DBNull)
                        dtb = "_";
                    else
                        dtb = dr["DTB"];

                    switch (Convert.ToString(dr["MaHocKy"]))
                    {
                        case "HK1":
                            bangDiemCaNhan.DTBHocKy1 = dtb;
                            heso = dsHeSoHocKy.HocKy_1;
                            break;
                        case "HK2":
                            bangDiemCaNhan.DTBHocKy2 = dtb;
                            heso = dsHeSoHocKy.HocKy_2;
                            break;                       
                    }
                    if (!Convert.ToString(dtb).Equals("_"))
                    {
                        tongDTB += heso * Convert.ToDouble(dtb);
                        tongHeSo += heso;
                        soHocKyDuDTB++;
                    }
                }
                if (soHocKyDuDTB == soHocKy)
                {
                    bangDiemCaNhan.DTBCaNam = Math.Round(tongDTB / tongHeSo, 2);
                }
                else
                    bangDiemCaNhan.DTBCaNam = "";

                bangDiemHocKy.Add(bangDiemCaNhan);
            }

            return bangDiemHocKy;
        }
    }
}
