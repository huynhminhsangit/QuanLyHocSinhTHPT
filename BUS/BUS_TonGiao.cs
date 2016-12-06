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
    public class BUS_TonGiao
    {
        DAL_TonGiao dal = new DAL_TonGiao();
        // Load dữ liệu lên DataGridView_TonGiao
        public DataTable LoadDataInto_DGVTonGiao()
        {
            return dal.LoadDataIntoDGVTonGiao();
        }
        public bool Update_All(DataTable dt)
        {
            return dal.Update_All(dt);
        }
    }
}
