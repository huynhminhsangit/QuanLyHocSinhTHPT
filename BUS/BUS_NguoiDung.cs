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
    public class BUS_NguoiDung
    {
        DAL_NguoiDung dal = new DAL_NguoiDung();
        public DataTable ReadUserName_PassWord(string username, string password)
        {
            return dal.LoadUserNamePassWord(username, password);
        }
        //public int ReadData_UserLogin(string username, string password)
        //{
        //     dal.LoadFullNameUserLogin(username, password);
        //}
    }
}
