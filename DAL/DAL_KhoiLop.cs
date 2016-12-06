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
    public class DAL_KhoiLop : DB_Connection
    {
        // Hàm Load dữ liệu lên DataGridView_NamHoc
        public DataTable LoadDataIntoDGVKhoiLop()
        {
            SqlDataAdapter da_KhoiLop = new SqlDataAdapter("Select * From KHOILOP", connectionsql);
            DataSet ds = new DataSet();
            da_KhoiLop.Fill(ds, "KHOILOP");
            return ds.Tables["KHOILOP"];
        }
        // Hàm thực hiện Insert, Update, Delete
        public bool Update_All(DataTable dt)
        {
            try
            {
                SqlDataAdapter da_KhoiLop = new SqlDataAdapter("Select * From KHOILOP", connectionsql);

                SqlCommandBuilder cmBuilder = new SqlCommandBuilder(da_KhoiLop);

                da_KhoiLop.Update(dt);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
	public DataTable Timkiem_makhoi(string pMakhoi)
        {
            //B1
            string selectstring = "select * from LOP where MAKHOI='" + pMakhoi + "'";
            //b3
            SqlDataAdapter da_khoa = new SqlDataAdapter(selectstring, connectionsql);
            //b4
            DataSet ds = new DataSet();
            da_khoa.Fill(ds, "LOP");
            //b5
            return ds.Tables["LOP"];
            //b6

        }

    public DataTable Laylop_trongkhoi(string pMakhoi, string pNamhoc)
    {
        //B1
        string selectstring = "select TENLOP from LOP where MAKHOI='" + pMakhoi + "' AND MANAMHOC = '" + pNamhoc + "'" ;
        //b3
        SqlDataAdapter da_khoa = new SqlDataAdapter(selectstring, connectionsql);
        //b4
        DataSet ds = new DataSet();
        da_khoa.Fill(ds, "LOP");
        //b5
        return ds.Tables["LOP"];
        //b6

    }   
 
    }
}
