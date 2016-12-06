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
    public class DAL_HanhKiem : DB_Connection
    {
        // Hàm Load dữ liệu lên DataGridView_NamHoc
        public DataTable LoadDataIntoDGVHanhKiem()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From HANHKIEM", connectionsql);
            DataSet ds = new DataSet();
            da.Fill(ds, "HANHKIEM");
            return ds.Tables["HANHKIEM"];
        }
        // Hàm thực hiện Insert, Update, Delete
        public bool Update_All(DataTable dt)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From HANHKIEM", connectionsql);

                SqlCommandBuilder cmBuilder = new SqlCommandBuilder(da);

                da.Update(dt);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }    
    }
}
