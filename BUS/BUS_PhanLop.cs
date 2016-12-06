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
        public bool Update_All(DataTable dt)
        {
            return dal.Update_All(dt);
        }
        public DataTable Timkiem_phanlop(string pMaLOP)
        {
            return dal.Timkiem_phanlop(pMaLOP);
        }
        public DataTable Xemketqua_theolop(string pMaLOP)
        {
            return dal.Xemketqua_theolop(pMaLOP);
        }
    }
}
