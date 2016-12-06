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
    public class BUS_HocSinh
    {
        DAL_HocSinh dal = new DAL_HocSinh();
        // Load dữ liệu lên DataGridView_HocSinh
        public DataTable LoadDataInto_DGVHocSinh()
        {
            return dal.LoadDataIntoDGVHocSinh();
        }
        public bool Update_All(DataTable dt)
        {
            return dal.Update_All(dt);
        }
        public DataTable LayDSHocSinh_TheoLop(string pLop)
        {
            return dal.LayDSHocSinhTheoLop(pLop);
        }
        public DataTable LayDSHocSinh_TheoMaNamHoc_MaLop(string pMaNamHoc, string pMaLop)
        {
            return dal.LayDsHocSinhTheoMaNamHocMaLop(pMaNamHoc, pMaLop);
        }
        public void Them(DTO_HocSinh pkhocsinh)
        {
            dal.Them(pkhocsinh);
        }
        public bool KT_KhoaChinh(string pkhocsinh)
        {
            return dal.KT_KhoaChinh(pkhocsinh);
        }
 	public DataTable timkiem_hocsinh(string pMa)
        {
            return dal.TimKiem_HocSinh(pMa);
        }
    }
}
