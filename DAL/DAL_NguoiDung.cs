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
    public class DAL_NguoiDung : DB_Connection
    {
        public DataTable LoadUserNamePassWord(string username, string password)
        {
            //connectionsql.Close();
            SqlDataAdapter da_dangnhap = new SqlDataAdapter("Select TENDANGNHAP, MATKHAU From NGUOIDUNG Where TENDANGNHAP ='" + username + "' and MATKHAU = '" + password + "' ", connectionsql);
            DataSet ds = new DataSet();
            da_dangnhap.Fill(ds, "NGUOIDUNG");
            return ds.Tables["NGUOIDUNG"];
        }
        public int LoadCapDoQuanLy(string userName, string passWord)
        {
            connectionsql.Open(); // Mở kết nối

            SqlCommand cmd = new SqlCommand("Select CAPDOQUANLY From NGUOIDUNG Where TENDANGNHAP ='" + userName + "' and MATKHAU = '" + passWord + "' ", connectionsql);
            cmd.Parameters.Add(new SqlParameter("USERNAME", userName));
            cmd.Parameters.Add(new SqlParameter("PASS", passWord));

            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr["CAPDOQUANLY"].ToString() == "1")
                return 1;
            else
                return 0;
        }
    }
}
