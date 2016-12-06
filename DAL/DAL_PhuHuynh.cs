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
    public class DAL_PhuHuynh : DB_Connection
    {
        // Hàm Load dữ liệu lên DataGridView_PhuHuynh
        public DataTable LoadDataIntoDGVPhuHuynh()
        {
            SqlDataAdapter da_PhuHuynh = new SqlDataAdapter("Select * From PHUHUYNH", connectionsql);
            DataSet ds = new DataSet();
            da_PhuHuynh.Fill(ds, "PHUHUYNH");
            return ds.Tables["PHUHUYNH"];
        }
        // Hàm thực hiện Insert, Update, Delete
        public bool Update_All(DataTable dt)
        {
            try
            {
                SqlDataAdapter da_PhuHuynh = new SqlDataAdapter("Select * From PHUHUYNH", connectionsql);

                SqlCommandBuilder cmBuilder = new SqlCommandBuilder(da_PhuHuynh);

                da_PhuHuynh.Update(dt);

                return true;
            }
            catch
            {
                return false;
            }
        }    
    }
}
