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
    public class DAL_Lop : DB_Connection
    {
        // Hàm Load dữ liệu lên DataGridView_Lop
        public DataTable LoadDataIntoDGVLop()
        {
            SqlDataAdapter da_Lop = new SqlDataAdapter("Select * From LOP", connectionsql);
            DataSet ds = new DataSet();
            da_Lop.Fill(ds, "LOP");
            return ds.Tables["LOP"];
        }
        // Hàm lọc danh sách lớp theo năm học
        public DataTable LayDSLopTheoNamHoc(string pMaNamHoc)
        {
            SqlDataAdapter da_Lop = new SqlDataAdapter("Select MALOP, TENLOP From LOP WHERE MANAMHOC = '" + pMaNamHoc + "' ", connectionsql);
            DataSet ds = new DataSet();
            da_Lop.Fill(ds, "DSLOP");
            return ds.Tables["DSLOP"];
        }
        // Hàm lọc danh sách lớp theo năm, theo khối
        public DataTable LayDSLopTheoNamHoc_Khoi(string pMaNamHoc, string pMakhoi)
        {
            SqlDataAdapter da_Lop = new SqlDataAdapter("Select MALOP, TENLOP From LOP WHERE MANAMHOC = '" + pMaNamHoc + "' and MAKHOI = '"+pMakhoi+"' " , connectionsql);
            DataSet ds = new DataSet();
            da_Lop.Fill(ds, "DSLOP");
            return ds.Tables["DSLOP"];
        }
        // Hàm thực hiện Insert, Update, Delete
        public bool Update_All(DataTable dt)
        {
            try
            {
                SqlDataAdapter da_Lop = new SqlDataAdapter("Select * From LOP", connectionsql);

                SqlCommandBuilder cmBuilder = new SqlCommandBuilder(da_Lop);

                da_Lop.Update(dt);

                return true;
            }
            catch
            {
                return false;
            }
        }
        // Hàm thêm bằng DTO
        public void Them(DTO_Lop pLop)
        {

            string s = "select * from LOP";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(s, connectionsql);
            da.Fill(ds, "LOP");

            DataColumn[] pk = new DataColumn[1];
            pk[0] = ds.Tables["LOP"].Columns[0];
            ds.Tables["LOP"].PrimaryKey = pk;

            DataRow newrow = ds.Tables["LOP"].NewRow();
            newrow["MALOP"] = pLop.MaLop;
            newrow["TENLOP"] = pLop.TenLop;
            newrow["MAKHOI"] = pLop.Khoi;
            newrow["MANAMHOC"] = pLop.NamHoc;
            newrow["SISO"] = pLop.SiSoLop;
            newrow["MAGIAOVIENCHUNHIEM"] = pLop.GiaoVienCN;
            ds.Tables["LOP"].Rows.Add(newrow);

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "LOP");

        }
        // Hàm kiểm tra khóa chính
        public bool KT_KhoaChinh(String pMaLop)
        {
            //b1
            if (connectionsql.State == ConnectionState.Closed)
            {
                connectionsql.Open();
            }
            //b2
            string selectString = "select * from LOP where Malop='" + pMaLop + "'";
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
	    // Hàm tìm kiếm theo mã lớp
        public DataTable TimKiemTheoMaLop(string pMalop)
        {
            //B1
            string selectstring = "select MALOP, TENLOP, TENKHOILOP, TENNAMHOC, SISO, TENGIAOVIEN from LOP , KHOILOP , NAMHOC ,  GIAOVIEN where LOP.MAKHOI = KHOILOP.MAKHOI AND "
            + "NAMHOC.MANAMHOC = LOP.MANAMHOC AND LOP.MAGIAOVIENCHUNHIEM = GIAOVIEN.MAGIAOVIEN AND MALOP = '" + pMalop + "'";
          
          
            //b3
            SqlDataAdapter da_khoa = new SqlDataAdapter(selectstring, connectionsql);
            //b4
            DataSet ds = new DataSet();
            da_khoa.Fill(ds, "LOP");
            //b5
            return ds.Tables["LOP"];
            //b6

        }
        // Hàm lấy tên giáo viên chủ nhiệm theo mã lớp
        public string LayTenGiaoVienChuNhiemTheoLop(string pMaLop)
        {
            string sql = "SELECT gv.TenGiaoVien FROM GIAOVIEN gv, LOP l "
                         + "WHERE gv.MaGiaoVien = l.MaGiaoVienChuNhiem AND l.Malop ='" + pMaLop + "'";
            return Convert.ToString(ExecuteScalar(sql));
        }
    }
}
