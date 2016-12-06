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
    public class DAL_MonHoc : DB_Connection
    {
        // Hàm Load dữ liệu lên DataGridView_NamHoc
        public DataTable LoadDataIntoDGVMonHoc()
        {
            SqlDataAdapter da_GiaoVien = new SqlDataAdapter("Select * From MONHOC", connectionsql);
            DataSet ds = new DataSet();
            da_GiaoVien.Fill(ds, "MONHOC");
            return ds.Tables["MONHOC"];
        }
        // Hàm thực hiện Insert, Update, Delete
        public bool Update_All(DataTable dt)
        {
            try
            {
                SqlDataAdapter da_GiaoVien = new SqlDataAdapter("Select * From MONHOC", connectionsql);

                SqlCommandBuilder cmBuilder = new SqlCommandBuilder(da_GiaoVien);

                da_GiaoVien.Update(dt);

                return true;
            }
            catch
            {
                return false;
            }
        }
	    public DataTable Timkiem_mamonhoc(string pMamonhoc)
        {
            //B1
            string selectstring = "select MAGIAOVIEN, TENGIAOVIEN, GT.TENGIOITINH, DIACHI, DIENTHOAI from GIAOVIEN GV, GIOITINH GT where GV.MAGIOITINH=GT.MAGIOITINH AND MAMONHOC='" + pMamonhoc + "'";
            //b3
            SqlDataAdapter da = new SqlDataAdapter(selectstring, connectionsql);
            //b4
            DataSet ds = new DataSet();
            da.Fill(ds, "GIAOVIEN");
            //b5
            return ds.Tables["GIAOVIEN"];
            //b6

        }
        // Lấy danh sách môn học
        public List<DTO_MonHoc> LayList_MonHoc(bool chiLayCacMonDangHoc = true)
        {
            string  sql = string.Format("SELECT MaMonHoc, TenMonHoc, SoTiet, HeSo FROM MONHOC");
            // Mở kết nối
            OpenConnect();
            var listMonHocDTO = new List<DTO_MonHoc>();
            DTO_MonHoc monhocDTO;
            SqlDataReader dr = ExecuteReader(sql);
            while (dr.Read())
            {
                monhocDTO = new DTO_MonHoc();
                monhocDTO.MaMonHoc = Convert.ToString(dr["MaMonHoc"]);
                monhocDTO.TenMonHoc = Convert.ToString(dr["TenMonHoc"]);
                monhocDTO.SoTiet = Convert.ToInt16(dr["SoTiet"]);
                monhocDTO.HeSo = Convert.ToInt16(dr["HeSo"]);
                listMonHocDTO.Add(monhocDTO);
            }
            // Thực thi xong, đóng kết nối
            CloseConnect();
            return listMonHocDTO;
        }
        // Lấy hệ số môn học
        public DTO_MonHoc_HeSo LayDTO_HeSoMonHoc()
        {
            string sql = "SELECT MaMonHoc, HeSo FROM MONHOC";
            // Mở kết nối
            OpenConnect();
            SqlDataReader dr = ExecuteReader(sql);
            var dsHeSo = new DTO_MonHoc_HeSo();
            while (dr.Read())
            {
                double heso = Convert.ToDouble(dr["HeSo"]);
                switch (dr["MaMonHoc"].ToString())
                {
                    case "MH01":
                        dsHeSo.Toan = heso;
                        break;
                    case "MH02":
                        dsHeSo.VatLy = heso;
                        break;
                    case "MH03":
                        dsHeSo.HoaHoc = heso;
                        break;
                    case "MH04":
                        dsHeSo.SinhHoc = heso;
                        break;
                    case "MH05":
                        dsHeSo.NguVan = heso;
                        break;
                    case "MH06":
                        dsHeSo.LichSu = heso;
                        break;
                    case "MH07":
                        dsHeSo.DiaLy = heso;
                        break;
                    case "MH08":
                        dsHeSo.NgoaiNgu = heso;
                        break;
                    case "MH09":
                        dsHeSo.GDCDan = heso;
                        break;
                    case "MH10":
                        dsHeSo.TinHoc = heso;
                        break;
                    case "MH11":
                        dsHeSo.TheDuc = heso;
                        break;
                    case "MH12":
                        dsHeSo.QuocPhong = heso;
                        break;
                    case "MH13":
                        dsHeSo.CongNghe = heso;
                        break;
                }
            }
            // Đóng kết nối
            CloseConnect();
            return dsHeSo;
        }
    }
}
