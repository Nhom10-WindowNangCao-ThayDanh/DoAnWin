﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace nha_tro
{
    public class CauHinh
    {
        public int Check_Config()
        {
            if (Properties.Settings.Default.QUANLINHATROConnectionString == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.QUANLINHATROConnectionString);
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
            SqlDataAdapter daUser = new SqlDataAdapter("select * from NguoiDung where tendangnhap='" + pUser + "' and matkhau ='" + pPass + "'", Properties.Settings.Default.QUANLINHATROConnectionString);
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
        //

        
        public DataTable GetServerName()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = SqlDataSourceEnumerator.Instance.GetDataSources();
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
            string conStr = "Data Source=" + pServerName + ";Initial Catalog=" + pDataBase + ";User ID=" + pUser + ";Password = " + pPass + "";
            nha_tro.Properties.Settings.Default.KetnoiSQL = conStr;
            Properties.Settings.Default.Save();
        }

        public List<string> GetMaNhomNguoiDung(string tendangnhap)
        {
            List<string> nhomND = new List<string>();
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(string.Format("select MaNhom from NguoiDungNhomNguoiDung where tendangnhap = '{0}'  ", tendangnhap), Properties.Settings.Default.QUANLINHATROConnectionString);
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                nhomND.Add(dt.Rows[i][0].ToString());
                string a = dt.Rows[i][0].ToString();
            }
            return nhomND;
        }

        List<string> MaManHinh = new List<string>();
        DataTable dtMaMH = new DataTable();
        public List<string> GetMaManHinh(string MaNhom)
        {
            SqlDataAdapter da = new SqlDataAdapter(string.Format("select MaManHinh from PhanQuyen where MaNhom = '{0}'  ", MaNhom), Properties.Settings.Default.QUANLINHATROConnectionString);
            da.Fill(dtMaMH);
            if (dtMaMH.Rows.Count != 0)
            {
                for (int i = 0; i < dtMaMH.Rows.Count; i++)
                {
                    MaManHinh.Add(dtMaMH.Rows[i][0].ToString());
                    string a = dtMaMH.Rows[i][0].ToString();
                }
                return MaManHinh;
            }
            else
            {
                MaManHinh.Add("0");
                return MaManHinh;
            }
        }



        List<string> CoQuyen = new List<string>();
        DataTable dtCoQuyen = new DataTable();             
        public List<string> GetCoQuyen(string MaNhom)
        {
            SqlDataAdapter da = new SqlDataAdapter(string.Format("select CoQuyen from PhanQuyen where MaNhom = '{0}'  ", MaNhom), Properties.Settings.Default.QUANLINHATROConnectionString);
            da.Fill(dtCoQuyen);


            if (dtCoQuyen.Rows.Count != 0)
            {
                for (int i = 0; i < dtCoQuyen.Rows.Count; i++)
                {
                    CoQuyen.Add(dtCoQuyen.Rows[i][0].ToString());
                    string a = dtCoQuyen.Rows[i][0].ToString();
                }
                return CoQuyen;
            }
            else
            {
                CoQuyen.Add("0");
                return CoQuyen;
            }
        }

    }
}
