using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DB_Connection
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable table;

        public SqlConnection connectionsql;
        public DB_Connection()
        {
            connectionsql = new SqlConnection(@"Data Source=.; Initial Catalog = DB_QLHOCSINH_THPT; Integrated Security = True");
        }
        // Mở kết nối
        protected void OpenConnect()
        {
            try
            {
                if (connectionsql != null)
                    if (connectionsql.State == ConnectionState.Closed)
                        connectionsql.Open();
            }
            catch
            {
                return;
            }
        }
        // Đóng kết nối
        protected void CloseConnect()
        {
            if (connectionsql != null)
                if (connectionsql.State == ConnectionState.Open)
                    connectionsql.Close();
        }
        // Thực thi câu lệnh SQL Insert, Update, Delete
        protected int ExecuteQuery(string sql)
        {
            int numRecords = 0;
            SqlTransaction sqlTran = null;
            try
            {
                // Mở kết nối
                OpenConnect();
                // Mở Transaction
                sqlTran = connectionsql.BeginTransaction();
                var sqlComm = new SqlCommand(sql, connectionsql) { Transaction = sqlTran };
                numRecords = sqlComm.ExecuteNonQuery();
                // Thực thi
                sqlTran.Commit();
            }
            catch
            {
                // Roolback data
                if (sqlTran != null)
                    sqlTran.Rollback();               
            }
            finally
            {
                // Đóng kn
                CloseConnect();
            }
            // Trả về số record thực thi
            return numRecords;
        }
        protected DataTable GetTable(string sql, bool setPropertiesDataTable = false)
        {
            try
            {
                if (setPropertiesDataTable)
                {
                    // Tạo dataApdapter vai trò như 1 ống hút thực hiện query đổ vào Datatable
                    da = new SqlDataAdapter(sql, connectionsql);
                    table = new DataTable();
                    // Đổ vào database
                    da.Fill(table);
                    return table;
                }
                var ap = new SqlDataAdapter(sql, connectionsql);
                var tb = new DataTable();
                ap.Fill(tb);
                return tb;
            }
            catch
            {              
                return null;
            }
        }
        // Đọc dữ liệu
        protected SqlDataReader ExecuteReader(string sql)
        {
            try
            {
                var command = new SqlCommand(sql, connectionsql);
                return command.ExecuteReader();
            }
            catch
            {
                return null;
            }
        }
        protected object ExecuteScalar(string sql)
        {
            try
            {
                OpenConnect();
                cmd = new SqlCommand(sql, connectionsql);
                return cmd.ExecuteScalar();
            }
            catch
            {
                return null;
            }
            finally
            {
                CloseConnect();
            }
        }
    }
}
