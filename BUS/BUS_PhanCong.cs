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
    public class BUS_PhanCong
    {
        DAL_PhanCong dal = new DAL_PhanCong();
        // Load dữ liệu lên DataGridView_NamHoc
        public DataTable LoadDataInto_DGVPhanCong()
        {
            return dal.LoadDataIntoDGVPhanCong();
        }
        public bool Update_All(DataTable dt)
        {
            return dal.Update_All(dt);
        }
        public void Them(DTO_PhanCong pkphancong)
        {
            dal.them(pkphancong);
        }  
        public bool KT_KhoaChinh(string pkphancong)
        {
            return dal.KT_KhoaChinh(pkphancong);
        }
        
    }
}
