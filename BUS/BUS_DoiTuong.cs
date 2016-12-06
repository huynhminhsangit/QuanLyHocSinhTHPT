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
    public class BUS_DoiTuong
    {
        DAL_DoiTuong dal = new DAL_DoiTuong();
        // Load dữ liệu lên DataGridView_DoiTuong
        public DataTable LoadDataInto_DGVDoiTuong()
        {
            return dal.LoadDataIntoDGVDoiTuong();
        }
        public bool Update_All(DataTable dt)
        {
            return dal.Update_All(dt);
        }
    }
}
