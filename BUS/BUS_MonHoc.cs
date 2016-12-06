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
    public class BUS_MonHoc
    {
        DAL_MonHoc dal = new DAL_MonHoc();
        // Load dữ liệu lên DataGridView_MonHoc
        public DataTable LoadDataInto_DGVMonHoc()
        {
            return dal.LoadDataIntoDGVMonHoc();
        }
        public bool Update_All(DataTable dt)
        {
            return dal.Update_All(dt);
        }
	public DataTable timkiem_monday(string pMamonhoc)
        {
            return dal.Timkiem_mamonhoc(pMamonhoc);
        }
    }
}
