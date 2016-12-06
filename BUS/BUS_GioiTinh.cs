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
    public class BUS_GioiTinh
    {
        DAL_GioiTinh dal = new DAL_GioiTinh();
        public DataTable LoadDataIntoDGVGioiTinh()
        {
            return dal.LoadDataIntoDGVGioiTinh();
        }
    }
}
