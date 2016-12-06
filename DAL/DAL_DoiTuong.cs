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
    public class DAL_DoiTuong : DB_Connection
    {
        // Hàm Load dữ liệu lên DataGridView_DanToc
        public DataTable LoadDataIntoDGVDoiTuong()
        {
            SqlDataAdapter da_DoiTuong = new SqlDataAdapter("Select * From DOITUONG", connectionsql);
            DataSet ds = new DataSet();
            da_DoiTuong.Fill(ds, "DOITUONG");
            return ds.Tables["DOITUONG"];
        }
        // Hàm thực hiện Insert, Update, Delete
        public bool Update_All(DataTable dt)
        {
            try
            {
                SqlDataAdapter da_DoiTuong = new SqlDataAdapter("Select * From DOITUONG", connectionsql);

                SqlCommandBuilder cmBuilder = new SqlCommandBuilder(da_DoiTuong);

                da_DoiTuong.Update(dt);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
