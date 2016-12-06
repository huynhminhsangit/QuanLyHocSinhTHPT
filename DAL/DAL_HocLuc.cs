using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_HocLuc : DB_Connection
    {
        // Hàm Load dữ liệu lên DataGridView_HocLuc
        public DataTable LoadDataIntoDGVHocLuc()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From HOCLUC", connectionsql);
            DataSet ds = new DataSet();
            da.Fill(ds, "HOCLUC");
            return ds.Tables["HOCLUC"];
        }
        // Hàm thực hiện Insert, Update, Delete
        public bool Update_All(DataTable dt)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From HOCLUC", connectionsql);

                SqlCommandBuilder cmBuilder = new SqlCommandBuilder(da);

                da.Update(dt);

                return true;
            }
            catch
            {
                return false;
            }
        }    
    }
}
