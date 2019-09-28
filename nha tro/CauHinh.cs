using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nha_tro
{
    public class CauHinh
    {
        string conStr = ConfigurationManager.ConnectionStrings["KetnoiSQL"].ToString();
        public int Check_Config()
        {
            if (conStr == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            SqlConnection _Sqlconn = new SqlConnection(conStr);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }
        public int Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from NguoiDung where tendangnhap='" + pUser + "' and matkhau ='" + pPass + "'", conStr);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 0;// User không tồn tại
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            {
                return 1;// Không hoạt động
            }
            return 2;// Đăng nhập thành công
        }
        public DataTable GetServerName()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            return table;
        }
        public List<string> GetDatabaseName(string pServerName, string pUser, string pPass)
        {
            List<string> _list = new List<string>();
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM sys.databases", "Data Source=" + pServerName + ";Initial Catalog=" + "master" + ";User ID=" + pUser + ";pwd = " + pPass + "");
                da.Fill(dt);
                foreach (System.Data.DataRow row in dt.Rows)
                {
                    foreach (System.Data.DataColumn col in dt.Columns)
                    {
                        _list.Add(row[col].ToString());
                    }
                }
            }
            catch
            {
                return null;
            }
            return _list;
        }
        public void ChangeConnectionString(string pServerName, string pDataBase, string pUser, string pPass)
        {
            nha_tro.Properties.Settings.Default.KetnoiSQL = "Data Source=" + pServerName + ";Initial Catalog=" + pDataBase + ";User ID=" + pUser + ";pwd = " + pPass + "";
            Properties.Settings.Default.Save();
        }


    }
}
