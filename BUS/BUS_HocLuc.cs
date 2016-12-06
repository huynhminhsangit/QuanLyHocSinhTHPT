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
    public class BUS_HocLuc
    {
        DAL_HocLuc dal = new DAL_HocLuc();
        // Load dữ liệu lên DataGridView_HocLuc
        public DataTable LoadDataInto_DGVHocLuc()
        {
            return dal.LoadDataIntoDGVHocLuc();
        }
        public bool Update_All(DataTable dt)
        {
            return dal.Update_All(dt);
        }
    }
}
