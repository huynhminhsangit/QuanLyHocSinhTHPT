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
    public class DAL_TonGiao : DB_Connection
    {
        // Hàm Load dữ liệu lên DataGridView_TonGiao
        public DataTable LoadDataIntoDGVTonGiao()
        {
            SqlDataAdapter da_TonGiao = new SqlDataAdapter("Select * From TONGIAO", connectionsql);
            DataSet ds = new DataSet();
            da_TonGiao.Fill(ds, "TONGIAO");
            return ds.Tables["TONGIAO"];
        }
        // Hàm thực hiện Insert, Update, Delete
        public bool Update_All(DataTable dt)
        {
            try
            {
                SqlDataAdapter da_TonGiao = new SqlDataAdapter("Select * From TONGIAO", connectionsql);

                SqlCommandBuilder cmBuilder = new SqlCommandBuilder(da_TonGiao);

                da_TonGiao.Update(dt);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
