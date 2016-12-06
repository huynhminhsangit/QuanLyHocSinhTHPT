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
        // Hàm Load dữ liệu lên DataGridView_PhanLop
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
            catch
            {
                return false;
            }
        }
        // Hàm lấy thông tin học sinh dựa vào lớp, khối, năm học
        public DataTable TimkiemThongTinHocSinhTheoLop_Khoi_NamHoc(string pMaLOP)
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
    }
}
