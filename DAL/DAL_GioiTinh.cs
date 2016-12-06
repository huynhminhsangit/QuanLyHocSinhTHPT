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
    public class DAL_GioiTinh : DB_Connection
    {
        // Hàm Load dữ liệu lên DataGridView_DanToc
        public DataTable LoadDataIntoDGVGioiTinh()
        {
            SqlDataAdapter da_DanToc = new SqlDataAdapter("Select * From GIOITINH", connectionsql);
            DataSet ds = new DataSet();
            da_DanToc.Fill(ds, "GIOITINH");
            return ds.Tables["GIOITINH"];
        }
    }
}
