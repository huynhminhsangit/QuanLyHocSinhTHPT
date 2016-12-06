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
    public class DAL_KetQuaHocTap : DB_Connection
    {
        // Hàm Load dữ liệu lên DataGridView_NamHoc
        public DataTable LoadDataIntoDGVKetQuaHocTap()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From KETQUA", connectionsql);
            DataSet ds = new DataSet();
            da.Fill(ds, "KETQUA");
            return ds.Tables["KETQUA"];
        }
        // Hàm thực hiện Insert, Update, Delete
        public bool Update_All(DataTable dt)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From KETQUA", connectionsql);

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
