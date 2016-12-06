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
    public class DAL_PhanCong :DB_Connection
    {
        // Hàm Load dữ liệu lên DataGridView_PhanCong
        public DataTable LoadDataIntoDGVPhanCong()
        {
            SqlDataAdapter da_PhanCong = new SqlDataAdapter("Select * From PHANCONG", connectionsql);
            DataSet ds = new DataSet();
            da_PhanCong.Fill(ds, "PHANCONG");
            return ds.Tables["PHANCONG"];
        }
        // Hàm thực hiện Insert, Update, Delete
        public bool Update_All(DataTable dt)
        {
            try
            {
                SqlDataAdapter da_PhanCong = new SqlDataAdapter("Select * From PHANCONG", connectionsql);

                SqlCommandBuilder cmBuilder = new SqlCommandBuilder(da_PhanCong);

                da_PhanCong.Update(dt);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void them(DTO_PhanCong pkphancong)
        {
            string s = "select * from PHANCONG";
            DataSet ds_phancong = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(s, connectionsql);
            da.Fill(ds_phancong, "PHANCONG");

            DataColumn[] pk = new DataColumn[1];
            pk[0] = ds_phancong.Tables["PHANCONG"].Columns[0];
            ds_phancong.Tables["PHANCONG"].PrimaryKey = pk;

            DataRow newrow = ds_phancong.Tables["PHANCONG"].NewRow();
            newrow["STT"] = pkphancong.Stt;
            newrow["MANAMHOC"] = pkphancong.NamHoc;
            newrow["MALOP"] = pkphancong.Lop;
            newrow["MAMONHOC"] = pkphancong.MaMonHoc;
            newrow["MAGIAOVIEN"] = pkphancong.Giaovien;
            ds_phancong.Tables["PHANCONG"].Rows.Add(newrow);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds_phancong, "PHANCONG");

        }
        public bool KT_KhoaChinh(String pMa)
        {
            //b1
            if (connectionsql.State == ConnectionState.Closed)
            {
                connectionsql.Open();
            }
            //b2
            string selectString = "select * from PHANCONG where STT='" + pMa + "'";
            //b3
            SqlCommand cmd = new SqlCommand(selectString, connectionsql);
            //b4
            SqlDataReader rdr = cmd.ExecuteReader();
            //b5
            //process
            if (rdr.HasRows)
            {
                rdr.Close();
                connectionsql.Close();
                return false;
            }
            else
            {
                rdr.Close();
                connectionsql.Close();
                return true;

            }
        }
    }
}
