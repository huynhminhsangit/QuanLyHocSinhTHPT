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
    public class DAL_HocSinh : DB_Connection
    {
        // Hàm Load dữ liệu lên DataGridView_HocSinh
        public DataTable LoadDataIntoDGVHocSinh()
        {
            SqlDataAdapter da_HocSinh = new SqlDataAdapter("Select * From HOCSINH", connectionsql);
            DataSet ds = new DataSet();
            da_HocSinh.Fill(ds, "HOCSINH");
            return ds.Tables["HOCSINH"];
        }
        // Hàm thực hiện Insert, Update, Delete
        public bool Update_All(DataTable dt)
        {
            try
            {
                SqlDataAdapter da_HocSinh = new SqlDataAdapter("Select * From HOCSINH", connectionsql);

                SqlCommandBuilder cmBuilder = new SqlCommandBuilder(da_HocSinh);

                da_HocSinh.Update(dt);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }    
        // Hàm lọc danh sách học sinh theo năm học và lớp
        public DataTable LayDSHocSinhTheoLop(string pMalop)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT PL.MAHOCSINH, HS.HOTENHOCSINH" +
                                                   "FROM HOCSINH HS INNER JOIN PHANLOP PL ON HS.MAHOCSINH = PL.MAHOCSINH INNER JOIN LOP L ON L.MALOP = PL.MALOP" +
                                                   "WHERE PL.MALOP = '" + pMalop + "'", connectionsql);
            DataSet ds = new DataSet();
            da.Fill(ds, "HOCSINH");
            return ds.Tables["HOCSINH"];
        }
        public List<DTO_HocSinh> LayList_HocSinh_LopHoc(string maLop)
        {
            string sql = string.Format("SELECT pl.STT, hs.* "
                                       + "FROM PHANLOP pl LEFT JOIN HOCSINH hs ON pl.MaHocSinh = hs.MaHocSinh "
                                       + "WHERE pl.MaLop = '" + maLop + "' ORDER BY pl.STT ASC");
            var listHS = new List<DTO_HocSinh>();
            OpenConnect();
            SqlDataReader reader = ExecuteReader(sql);
            while (reader.Read())
            {
                var hs = new DTO_HocSinh();
                hs.MaHocSinh = Convert.ToString(reader["MaHocSinh"]);
                hs.HoTenHocSinh = Convert.ToString(reader["HoTenHocSinh"]);
                hs.GioiTinh = Convert.ToString(reader["MaGioiTinh"]);
                hs.NoiSinh = Convert.ToString(reader["NoiSinh"]);
                hs.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);              
                listHS.Add(hs);
            }
            CloseConnect();
            return listHS;
        }
        public DataTable LayDsHocSinhTheoMaNamHocMaLop(String pMaNamHoc, String pMaLop)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT hs.HOTENHOCSINH, l.TENLOP" +
                                                   "FROM HOCSINH hs, PHANLOP pl, LOP l, NAMHOC nh" +
                                                   "WHERE hs.MAHOCSINH = pl.MAHOCSINH and pl.MALOP = l.MALOP and pl.MANAMHOC = nh.MANAMHOC" +
                                                   "and pl.MALOP = '" + pMaLop + "' and pl.MANAMHOC = '" + pMaNamHoc + "'", connectionsql);
            DataSet ds = new DataSet();
            da.Fill(ds, "HOCSINH");
            return ds.Tables["HOCSINH"];
        }
        public void Them(DTO_HocSinh pkhocsinh)
        {

            string s = "select * from HOCSINH";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(s, connectionsql);
            da.Fill(ds, "HOCSINH");

            DataColumn[] pk = new DataColumn[1];
            pk[0] = ds.Tables["HOCSINH"].Columns[0];
            ds.Tables["HOCSINH"].PrimaryKey = pk;

            DataRow newrow = ds.Tables["HOCSINH"].NewRow();
            newrow["MAHOCSINH"] = pkhocsinh.MaHocSinh;
            newrow["HOTENHOCSINH"] = pkhocsinh.HoTenHocSinh;
            newrow["MAGIOITINH"] = pkhocsinh.GioiTinh;
            newrow["NGAYSINH"] = pkhocsinh.NgaySinh;
            newrow["NOISINH"] = pkhocsinh.NoiSinh;
            newrow["MADANTOC"] = pkhocsinh.DanToc;
            newrow["MATONGIAO"] = pkhocsinh.TonGiao;
            newrow["MADOITUONG"] = pkhocsinh.DoiTuong;
            newrow["MAPHUHUYNH"] = pkhocsinh.PhuHuynh;
            ds.Tables["HOCSINH"].Rows.Add(newrow);

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "HOCSINH");

        }
        public bool KT_KhoaChinh(String pMa)
        {
            //b1
            if (connectionsql.State == ConnectionState.Closed)
            {
                connectionsql.Open();
            }
            //b2
            string selectString = "SELECT * FROM HOCSINH where MAHOCSINH = '" + pMa + "' ";
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
	    public DataTable TimKiem_HocSinh(string pMaHocSinh)
        {
            //B1
            string selectstring = "SELECT  * FROM HOCSINH WHERE MAHOCSINH = '" + pMaHocSinh + "' ";
            //b3
            SqlDataAdapter da = new SqlDataAdapter(selectstring, connectionsql);
            //b4
            DataSet ds = new DataSet();
            da.Fill(ds, "HOCSINH");
            //b5
            return ds.Tables["HOCSINH"];
            //b6

        }
    }
}
