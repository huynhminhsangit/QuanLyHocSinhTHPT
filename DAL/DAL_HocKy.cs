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
    public class DAL_HocKy : DB_Connection
    {
       // Hàm Load dữ liệu lên DataGridView_NamHoc
        public DataTable LoadDataIntoDGVHocKy()
        {
            SqlDataAdapter da_HocKy = new SqlDataAdapter("Select * From HOCKY", connectionsql);
            DataSet ds = new DataSet();
            da_HocKy.Fill(ds, "HOCKY");
            return ds.Tables["HOCKY"];
        }
        // Hàm thực hiện Insert, Update, Delete
        public bool Update_All(DataTable dt)
        {
            try
            {
                SqlDataAdapter da_HocKy = new SqlDataAdapter("Select * From HOCKY", connectionsql);

                SqlCommandBuilder cmBuilder = new SqlCommandBuilder(da_HocKy);

                da_HocKy.Update(dt);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }    
    }
}
