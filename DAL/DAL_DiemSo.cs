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
    public class DAL_DiemSo : DB_Connection
    {
        DataSet ds = new DataSet();
        DAL_MonHoc dalMonHoc = new DAL_MonHoc();
        // Load data.
        public DataTable LoadDataIntoDGVDiemSo()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select MAHOCSINH, DIEMKTMIENG, DIEMKT15PH, DIEMKT45P, DIEMTHICUOIKY From DIEMSO", connectionsql);
            DataSet ds = new DataSet();
            da.Fill(ds, "DIEMSO");
            return ds.Tables["DIEMSO"];
        }
        // Hàm thực hiện Insert, Update, Delete.
        public bool Update_All(DataTable dt)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From DIEMSO", connectionsql);

                SqlCommandBuilder cmBuilder = new SqlCommandBuilder(da);

                da.Update(dt);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        // Thêm dữ liệu vào bảng DIEMSO.
        public DataTable LayBangDiem_MonHoc_HocKy_Lop(string maLop, string maHocKy, string maMonHoc)
        {
            if (maLop == "" || maHocKy == "" || maMonHoc == "")
                return null;
            // Trước khi lấy, kiểm tra xem đã khởi tạo hay chưa? Nếu chưa thì khởi tạo
            string sql = string.Format("INSERT INTO DIEMSO(MaHocSinh, MaMonHoc, MaHocKy, MaLop)"
                                       + "SELECT distinct pl.MaHocSinh, '{0}' MaHocKy, '{2}' MaMonHoc, pl.MaLop "
                                       + "FROM PHANLOP pl LEFT JOIN DIEMSO bd ON pl.MaLop = bd.MaLop "
                                       + "WHERE pl.MaLop = '{1}' "
                                       + "AND pl.MaHocSinh NOT IN "
                                       + "(select MaHocSinh FROM DIEMSO "
                                       + "WHERE MaLop = '{1}' AND MaHocKy = '{0}' AND MaMonHoc = '{2}')",
                                       maHocKy, maLop, maMonHoc);
            ExecuteQuery(sql);
            // Lấy bảng điểm
            sql = "\nSELECT bd.MAHOCSINH, hs.HoTenHocSinh "
                  + "FROM DIEMSO bd, PHANLOP pl, HOCSINH hs"
                  + "WHERE hs.MaHocSinh = pl.MaHocSinh AND bd.MaHocSinh = pl.MaHocSinh AND pl.MaLop = bd.MaLop "
                  + "AND bd.MaLop = '" + maLop + "' AND bd.MaHocKy='" + maHocKy + "'"
                  + "AND bd.MaMonHoc = '" + maMonHoc + "' ";
            return GetTable(sql);
        }
        // Lấy danh sách học sinh chưa có điểm, chuẩn bị cập nhật.
        public DataTable LayDSHocSinhChuaCoDiem_TheoNamHoc_Lop_MonHoc_HocKy(string maNamHoc, string maLop, string maMonHoc, string maHocKy)
        {
            if (maNamHoc == "" || maLop == "" || maMonHoc == "" || maHocKy == "")
                return null;
            // Lấy bảng điểm
            string sql = string.Format("SELECT bd.MAHOCSINH, hs.HoTenHocSinh, bd.DIEMKTMIENG, bd.DIEMKT15PH, bd.DIEMKT45P, bd.DIEMTHICUOIKY, bd.DTB  "
                  + "FROM DIEMSO bd, PHANLOP pl, HOCSINH hs "
                  + "WHERE hs.MaHocSinh = pl.MaHocSinh AND bd.MaHocSinh = pl.MaHocSinh AND pl.MaLop = bd.MaLop "
                  + "AND bd.MaLop = '" + maLop + "' AND bd.MaHocKy='" + maHocKy + "'"
                  + "AND bd.MaMonHoc = '" + maMonHoc + "' ");

            SqlDataAdapter da = new SqlDataAdapter(sql, connectionsql);
            DataSet ds = new DataSet();
            da.Fill(ds, "DSHOCSINH");

            return ds.Tables["DSHOCSINH"];
        }       
        // Thêm dữ liệu.
        public bool Them(DTO_DiemSo pDiemSo)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From DIEMSO", connectionsql);          
                da.Fill(ds, "DIEMSO");

                DataColumn[] PK = new DataColumn[4];
                PK[0] = ds.Tables["DIEMSO"].Columns[0];
                PK[1] = ds.Tables["DIEMSO"].Columns[1];
                PK[2] = ds.Tables["DIEMSO"].Columns[2];
                PK[3] = ds.Tables["DIEMSO"].Columns[3];
                ds.Tables["DIEMSO"].PrimaryKey = PK;

                DataRow newRow = ds.Tables["DIEMSO"].NewRow();
                newRow["MAHOCSINH"]     = pDiemSo.MaHocSinh;
                newRow["MAMONHOC"]      = pDiemSo.MaMonHoc;
                newRow["MAHOCKY"]       = pDiemSo.MaHocKy;
                newRow["MALOP"]         = pDiemSo.MaLop;
                newRow["DIEMKTMIENG"]   = pDiemSo.DiemMieng;
                newRow["DIEMKT15PH"]    = pDiemSo.Diem15P;
                newRow["DIEMKT45P"]     = pDiemSo.Diem45P;
                newRow["DIEMTHICUOIKY"] = pDiemSo.DiemThi;
                newRow["DTB"]           = pDiemSo.DiemTrungBinh;
                ds.Tables["DIEMSO"].Rows.Add(newRow);

                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
                da.Update(ds, "DIEMSO");
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }     
        // Cập nhật điểm.     
        public bool LuuBangDiem_MonHoc_HocSinh_HocKy(DTO_DiemSo bd)
        {
            string sql = string.Format("UPDATE DIEMSO SET DIEMKTMIENG = '" + bd.DiemMieng + "', DIEMKT15PH = '" + bd.Diem15P + "', DIEMKT45P = '" + bd.Diem45P + "', DIEMTHICUOIKY = '" + bd.DiemThi + "', DTB = '" + bd.DiemTrungBinh + "' "
                                       + "WHERE MaHocSinh = '" + bd.MaHocSinh + "' AND MaHocKy = '" + bd.MaHocKy + "' AND MaLop = '" + bd.MaLop + "' AND MaMonHoc = '" + bd.MaMonHoc + "'");
            return ExecuteQuery(sql) > 0;
        }
        // Lấy bảng điểm tất cả các môn theo học kỳ.
        public DataTable LayBangDiem_HocKy_HocSinh(string maLop, string maHocSinh, string maHocKy)
        {
            List<DTO_MonHoc> listMH = dalMonHoc.LayList_MonHoc();

            string sql = "SELECT bd.*, mh.HeSo FROM MONHOC mh LEFT JOIN DIEMSO bd ON mh.MaMonHoc = bd.MaMonHoc  "
                         + "WHERE bd.MaHocKy = '" + maHocKy + "' "
                         + "AND  bd.MaLop = '" + maLop + "' AND MaHocSinh = '" + maHocSinh + "' ";
            DataTable tbBangDiem = GetTable(sql);

            // Trường hợp bảng điểm đã nhập đủ
            if (tbBangDiem.Rows.Count == listMH.Count)
                return tbBangDiem;
            // Trường hợp bảng điểm chưa đủ ta phải add thêm các môn học còn thiếu
            sql = "SELECT mh.MaMonHoc FROM MONHOC mh  "
                  + "WHERE  mh.MaMonHoc NOT IN "
                  + "(SELECT bd.MaMonHoc FROM DIEMSO bd WHERE bd.MaHocKy = '" + maHocKy + "' "
                  + "AND bd.MaLop = '" + maLop + "' AND bd.MaHocSinh = '" + maHocSinh + "')";
            var listMaMHBoSung = new List<string>();
            OpenConnect();
            SqlDataReader dr = ExecuteReader(sql);
            while (dr.Read())
            {
                listMaMHBoSung.Add(dr["MaMonHoc"].ToString());
            }
            CloseConnect();

            foreach (string bDiemMH in listMaMHBoSung)
            {
                DataRow drbDiemBsung = tbBangDiem.NewRow();
                drbDiemBsung["MaHocSinh"] = maHocSinh;
                drbDiemBsung["MaMonHoc"] = bDiemMH;
                drbDiemBsung["MaHocKy"] = maHocKy;
                drbDiemBsung["MaLop"] = maLop;

                tbBangDiem.Rows.Add(drbDiemBsung);
            }
            return tbBangDiem;
        }      
    }
}
