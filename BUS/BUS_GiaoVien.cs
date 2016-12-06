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
    public class BUS_GiaoVien
    {
        DAL_GiaoVien dal = new DAL_GiaoVien();
        // Load dữ liệu lên DataGridView_NamHoc
        public DataTable LoadDataInto_DGVGiaoVien()
        {
            return dal.LoadDataIntoDGVGiaoVien();
        }
        public bool Update_All(DataTable dt)
        {
            return dal.Update_All(dt);
        }
        public void them(DTO_Giaovien pkgiaovien)
        {
            dal.them(pkgiaovien);
        }
	public DataTable TimKiem_TheoMaGV(string pMaGV)
        {
            return dal.TimKiemTheoMaGV(pMaGV);
        }
    }
}
