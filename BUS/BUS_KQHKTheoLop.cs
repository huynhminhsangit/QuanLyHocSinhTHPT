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
    }
}
