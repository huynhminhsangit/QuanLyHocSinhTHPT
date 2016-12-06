using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Lop
    {
        DAL_Lop dal = new DAL_Lop();
        // Load dữ liệu lên DataGridView_NamHoc
        public DataTable LoadDataInto_DGVLop()
        {
            return dal.LoadDataIntoDGVLop();
        }
        // Hàm lấy danh sách lớp theo năm học
        public DataTable LayDSLop_TheoNamHoc(string pMaNamHoc)
        {
            return dal.LayDSLopTheoNamHoc(pMaNamHoc);
        }
        // Hàm lấy danh sách lớp theo năm học va khối
        public DataTable LayDSLop_TheoNamHoc_Khoi(string pMaNamHoc, string pMakhoi)
        {
            return dal.LayDSLopTheoNamHoc_Khoi(pMaNamHoc,pMakhoi);
        }
        // Hàm Insert, Update, Delete bằng lưới
        public bool Update_All(DataTable dt)
        {
            return dal.Update_All(dt);
        }
        // Hàm Thêm bằng DTO
        public void Them(DTO_Lop pLop)
        {
            dal.Them(pLop);
        }
        // Hàm kiểm tra khóa chính
        public bool KT_KhoaChinh(string pMaLop)
        {
            return dal.KT_KhoaChinh(pMaLop);
        }
	    // Hàm tìm kiếm theo mã lớp
        public DataTable TimKiem_TheoMaLop(string pMalop)
        {
            return dal.TimKiemTheoMaLop(pMalop);
        }
        // Hàm lấy tên giáo viên theo mã lớp được chọn
        public string LayTenGiaoVien_TheoMaLop(string maLop)
        {
            return dal.LayTenGiaoVienChuNhiemTheoLop(maLop);
        }
    }
}
