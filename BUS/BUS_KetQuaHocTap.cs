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
    public class BUS_KetQuaHocTap
    {
        DAL_KetQuaHocTap dal = new DAL_KetQuaHocTap();
        // Load dữ liệu lên DataGridView_KetQuaHocTap
        public DataTable LoadDataInto_DGVKetQuaHocTap()
        {
            return dal.LoadDataIntoDGVKetQuaHocTap();
        }
        public bool Update_All(DataTable dt)
        {
            return dal.Update_All(dt);
        }
    }
}
