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
    public class BUS_KhoiLop
    {
        DAL_KhoiLop dal = new DAL_KhoiLop();
        // Load dữ liệu lên DataGridView_NamHoc
        public DataTable LoadDataInto_DGVKhoiLop()
        {
            return dal.LoadDataIntoDGVKhoiLop();
        }
        public bool Update_All(DataTable dt)
        {
            return dal.Update_All(dt);
        }
	public DataTable timkiem_makhoi(string pMakhoi)
        {
            return dal.Timkiem_makhoi(pMakhoi);
        }
    public DataTable Laylop_trongkhoi(string pMakhoi, string pNamhoc)
    {
        return dal.Laylop_trongkhoi(pMakhoi, pNamhoc);
    }
    }
}
