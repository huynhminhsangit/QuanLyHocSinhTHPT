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
    public class DAL_NamHoc : DB_Connection
    {
       // Hàm Load dữ liệu lên DataGridView_NamHoc
        public DataTable LoadDataIntoDGVNamHoc()
        {
            SqlDataAdapter da_NamHoc = new SqlDataAdapter("Select * From NAMHOC", connectionsql);
            DataSet ds = new DataSet();
            da_NamHoc.Fill(ds, "NAMHOC");
            return ds.Tables["NAMHOC"];
        }
        // Hàm thực hiện Insert, Update, Delete
        public bool Update_All(DataTable dt)
        {
            try
            {
                SqlDataAdapter da_NamHoc = new SqlDataAdapter("Select * From NAMHOC", connectionsql);

                SqlCommandBuilder cmBuilder = new SqlCommandBuilder(da_NamHoc);

                da_NamHoc.Update(dt);

                return true;
            }
            catch
            {
                return false;
            }
        }    
    }
}
