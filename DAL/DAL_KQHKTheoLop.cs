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
    public class DAL_KQHKTheoLop : DB_Connection
    {
        // Thêm dữ liệu vào bảng KETQUAHOCKY
        public DataTable LayBangDiemHocKyTheoLop(string maLop, string maHocKy)
        {
            if (maLop == "" || maHocKy == "")
                return null;
            // Trước khi lấy, kiểm tra xem đã khởi tạo hay chưa? Nếu chưa thì khởi tạo
            string sql = string.Format("INSERT INTO KETQUAHOCKY(MaHocSinh, MaHocKy, MaLop)"
                                       + "SELECT distinct bd.MaHocSinh, bd.MaHocKy, bd.MaLop "
                                       + "FROM DIEMSO bd LEFT JOIN KETQUAHOCKY kq ON bd.MaLop = bd.MaLop  "
                                       + "WHERE bd.MaLop = '" + maLop + "' AND bd.MaHocKy = '" + maHocKy + "'");
            ExecuteQuery(sql);
            // Lấy bảng điểm
            sql = "\nSELECT DISTINCT kq.MAHOCSINH, hs.HoTenHocSinh "
                  + "FROM DIEMSO bd, HOCSINH hs, KETQUAHOCKY kq "
                  + "WHERE hs.MaHocSinh = kq.MAHOCSINH AND kq.MAHOCSINH = bd.MAHOCSINH "
                  + "AND kq.MaLop = '" + maLop + "' AND kq.MaHocKy='" + maHocKy + "'";
            return GetTable(sql);
        }
        // Lấy danh sách học sinh chưa có đtb, chuẩn bị cập nhật
        public DataTable LayDSHocSinhChuaCoDTBTheoLop(string maLop, string maHocKy)
        {
            if (maLop == "" || maHocKy == "")
                return null;
            // Lấy bảng điểm
            string sql = string.Format("SELECT DISTINCT kq.MAHOCSINH, hs.HoTenHocSinh, kq.DTB  "
                                      + "FROM DIEMSO bd, HOCSINH hs, KETQUAHOCKY kq "
                                      + "WHERE hs.MaHocSinh = kq.MAHOCSINH AND kq.MAHOCSINH = bd.MAHOCSINH "
                                      + "AND kq.MaLop = '" + maLop + "' AND kq.MaHocKy='" + maHocKy + "'");

            SqlDataAdapter da = new SqlDataAdapter(sql, connectionsql);
            DataSet ds = new DataSet();
            da.Fill(ds, "KETQUAHOCKYTHEOLOP");

            return ds.Tables["KETQUAHOCKYTHEOLOP"];
        }
        // Cập nhật điểm trung bình
        public bool LuuBangDiemHocSinhHocKy(DTO_KetQuaHocKy kqhk)
        {
            const int diemNull = -1;
            string sql = string.Format("UPDATE KETQUAHOCKY SET DTB = {3}"
                                       + "WHERE MAHOCSINH = '{0}' AND MAHOCKY = '{1}' AND MALOP= '{2}'",
                                       kqhk.MaHocSinh, kqhk.MaHocKy, kqhk.MaLop,
                                       (kqhk.DiemTrungBinh == diemNull) ? "NULL" : kqhk.DiemTrungBinh.ToString() );
            return ExecuteQuery(sql) > 0;
        }
    }
}
