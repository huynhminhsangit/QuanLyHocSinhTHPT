﻿using System;
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
    public class BUS_PhuHuynh
    {
        DAL_PhuHuynh dal = new DAL_PhuHuynh();
        // Load dữ liệu lên DataGridView_NamHoc
        public DataTable LoadDataInto_DGVPhuHuynh()
        {
            return dal.LoadDataIntoDGVPhuHuynh();
        }
        public bool Update_All(DataTable dt)
        {
            return dal.Update_All(dt);
        }
    }
}
