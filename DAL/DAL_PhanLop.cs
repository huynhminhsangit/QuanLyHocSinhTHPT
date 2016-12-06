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
    public class DAL_PhanLop : DB_Connection
    {
        // Hàm Load dữ liệu lên DataGridView_DanToc
        public DataTable LoadDataIntoDGVPhanLop()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From PHANLOP", connectionsql);
            DataSet ds = new DataSet();
            da.Fill(ds, "PHANLOP");
            return ds.Tables["PHANLOP"];
        }
        // Hàm thực hiện Insert, Update, Delete
        public bool Update_All(DataTable dt)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From PHANLOP", connectionsql);

                SqlCommandBuilder cmBuilder = new SqlCommandBuilder(da);

                da.Update(dt);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DataTable Timkiem_phanlop(string pMaLOP)
        {
            //B1
            string selectstring = "SELECT MAHOCSINH, HOTENHOCSINH, TENGIOITINH, NGAYSINH, NOISINH, TENDANTOC, TENTONGIAO, TENDOITUONG, HOTENPHUHUYNH "
                                + "FROM HOCSINH hs,  GIOITINH gt, DANTOC dt, TONGIAO tg ,DOITUONG dtg, PHUHUYNH ph "
                                + "WHERE  hs.MAGIOITINH = gt.MAGIOITINH AND hs.MADANTOC = dt.MADANTOC "
                                + "AND hs.MATONGIAO = tg.MATONGIAO AND hs.MADOITUONG = dtg.MADOITUONG "
                                + "AND PH.MAPHUHUYNH = HS.MAPHUHUYNH "
                                + "AND hs.MAHOCSINH IN (SELECT MAHOCSINH FROM PHANLOP  WHERE MALOP='" + pMaLOP + "')";
            //b3
            SqlDataAdapter da_khoa = new SqlDataAdapter(selectstring, connectionsql);
            //b4
            DataSet ds = new DataSet();
            da_khoa.Fill(ds, "TTHOCSINH");
            //b5
            return ds.Tables["TTHOCSINH"];
            //b6

        }

        public DataTable Xemketqua_theolop(string pMaLOP)
        {
            //B1
            string selectstring = "SELECT * from DIEMSO ML where ML.MALOP in(select MALOP from PHANLOP  where MALOP='" + pMaLOP + "')";
            //b3
            SqlDataAdapter da_khoa = new SqlDataAdapter(selectstring, connectionsql);
            //b4
            DataSet ds = new DataSet();
            da_khoa.Fill(ds, "KQDIEMSO");
            //b5
            return ds.Tables["KQDIEMSO"];
            //b6

        }
    }
}
