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
    public class BUS_PhanLop
    {
        DAL_PhanLop dal = new DAL_PhanLop();
        // Load dữ liệu lên DataGridView_DoiTuong
        public DataTable LoadDataInto_DGVPhanLop()
        {
            return dal.LoadDataIntoDGVPhanLop();
        }
        // Hàm Insert, Update, Delete dựa vào lưới
        public bool Update_All(DataTable dt)
        {
            return dal.Update_All(dt);
        }
        public DataTable LayDSHocSinhTheoMaLopMaKhoiMaNH(string pMaLop)
        {
            return dal.TimkiemThongTinHocSinhTheoLop_Khoi_NamHoc(pMaLop);
        }
    }
}
