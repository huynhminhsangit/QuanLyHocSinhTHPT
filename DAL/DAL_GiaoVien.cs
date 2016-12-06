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
    public class DAL_GiaoVien : DB_Connection
    {
        // Hàm Load dữ liệu lên DataGridView_GiaoVien
        public DataTable LoadDataIntoDGVGiaoVien()
        {
            SqlDataAdapter da_GiaoVien = new SqlDataAdapter("Select * From GIAOVIEN", connectionsql);
            DataSet ds = new DataSet();
            da_GiaoVien.Fill(ds, "GIAOVIEN");
            return ds.Tables["GIAOVIEN"];
        }
        // Hàm thực hiện Insert, Update, Delete
        public bool Update_All(DataTable dt)
        {
            try
            {
                SqlDataAdapter da_GiaoVien = new SqlDataAdapter("Select * From GIAOVIEN", connectionsql);

                SqlCommandBuilder cmBuilder = new SqlCommandBuilder(da_GiaoVien);

                da_GiaoVien.Update(dt);

                return true;
            }
            catch
            {
                return false;
            }
        }
        // Hàm Thêm bằng DTO
        public void Them(DTO_Giaovien pGiaoVien)
        {
            string s = "select * from GIAOVIEN";
            DataSet ds_giaovien = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(s, connectionsql);
            da.Fill(ds_giaovien, "GIAOVIEN");

            DataRow newrow = ds_giaovien.Tables["GIAOVIEN"].NewRow();
            newrow["MAGIAOVIEN"] = pGiaoVien.MaGiaoVien;
            newrow["TENGIAOVIEN"] = pGiaoVien.HoTen;
            newrow["MAGIOITINH"] = pGiaoVien.GioiTinh;
            newrow["DIACHI"] = pGiaoVien.DiaChi;
            newrow["DIENTHOAI"] = pGiaoVien.SoDienThoai;
            newrow["MAMONHOC"] = pGiaoVien.MonHoc;
            ds_giaovien.Tables["GIAOVIEN"].Rows.Add(newrow);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds_giaovien, "GIAOVIEN");

        }
        // Hàm tìm kiếm theo mã giáo viên
        public DataTable TimKiemTheoMaGV(string pMaGV)
        {
            //B1
            string selectstring = "select * from GIAOVIEN where MAGIAOVIEN = '" + pMaGV + "' ";
            //b3
            SqlDataAdapter da= new SqlDataAdapter(selectstring, connectionsql);
            //b4
            DataSet ds = new DataSet();
            da.Fill(ds, "GIAOVIEN");
            //b5
            return ds.Tables["GIAOVIEN"];
            //b6

        }
    }
}
