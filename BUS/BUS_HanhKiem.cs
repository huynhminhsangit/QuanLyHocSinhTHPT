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
    public class BUS_HanhKiem
    {
        DAL_HanhKiem dal = new DAL_HanhKiem();
        // Load dữ liệu lên DataGridView_HanhKiem
        public DataTable LoadDataInto_DGVHanhKiem()
        {
            return dal.LoadDataIntoDGVHanhKiem();
        }
        public bool Update_All(DataTable dt)
        {
            return dal.Update_All(dt);
        }
    }
}
