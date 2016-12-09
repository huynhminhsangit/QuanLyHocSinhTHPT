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
       // Hàm Load dữ liệu lên DataGridView_HocKy
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
            catch
            {
                return false;
            }
        }
        // Lấy hệ số học kỳ
        public DTO_HocKy_HeSo LayHeSo_HocKy()
        {
            string sql = "SELECT MAHOCKY, HeSo FROM HOCKY";
            // Mở kết nối
            OpenConnect();
            SqlDataReader dr = ExecuteReader(sql);
            var dsHeSoHocKy = new DTO_HocKy_HeSo();
            while (dr.Read())
            {
                double heso = Convert.ToDouble(dr["HeSo"]);
                switch (dr["MaHocKy"].ToString())
                {
                    case "HK1":
                        dsHeSoHocKy.HocKy_1 = heso;
                        break;
                    case "HK2":
                        dsHeSoHocKy.HocKy_2 = heso;
                        break;                  
                }
            }
            // Đóng kết nối
            CloseConnect();
            return dsHeSoHocKy;
        }
        // Lấy List các học kỳ
        public List<DTO_HocKy> LayList_HocKy()
        {
            string sql = string.Format("SELECT * FROM HOCKY");
            // Mở kết nối
            OpenConnect();
            var listHocKy = new List<DTO_HocKy>();
            DTO_HocKy hocKy;
            SqlDataReader dr = ExecuteReader(sql);
            while (dr.Read())
            {
                hocKy = new DTO_HocKy();
                hocKy.MaHocKy = Convert.ToString(dr["MaHocKy"]);
                hocKy.TenHocKy = Convert.ToString(dr["TenHocKy"]);
                hocKy.HeSo = Convert.ToInt16(dr["HeSo"]);
                listHocKy.Add(hocKy);
            }
            // Thực thi xong, đóng kết nối
            CloseConnect();
            return listHocKy;
        }
    }
}
