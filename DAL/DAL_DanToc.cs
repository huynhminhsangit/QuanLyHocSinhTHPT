using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_DanToc : DB_Connection
    {
        // Hàm Load dữ liệu lên DataGridView_DanToc
        public DataTable LoadDataIntoDGVDanToc()
        {
            SqlDataAdapter da_DanToc = new SqlDataAdapter("Select * From DANTOC", connectionsql);
            DataSet ds = new DataSet();
            da_DanToc.Fill(ds, "DANTOC");
            return ds.Tables["DANTOC"];
        }
        // Hàm thực hiện Insert, Update, Delete
        public bool Update_All(DataTable dt)
        {
            try
            {
                SqlDataAdapter da_DanToc = new SqlDataAdapter("Select * From DANTOC", connectionsql);

                SqlCommandBuilder cmBuilder = new SqlCommandBuilder(da_DanToc);

                da_DanToc.Update(dt);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
