using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace nha_tro
{
    public partial class CauHinhSQL : Form
    {
        public CauHinhSQL()
        {
            InitializeComponent();
        }
        
        private void cboServer_DropDown(object sender, EventArgs e)
        {
            CauHinh CauHinh = new CauHinh();
            DataTable dt = CauHinh.GetServerName();
            cboServer.Items.Clear();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                foreach (System.Data.DataColumn col in dt.Columns)
                {
                    cboServer.Items.Add(row[col]);
                }
            }
        }
        //public bool CheckedBeforSearchNameDB()
        //{
        //    // ket noi thu bang ten sv do nguoi dung chon
        //    SqlConnection conn = new SqlConnection("Data Source=" + cboServer.Text + ";Initial Catalog=" + cboDataBase.Text + ";User ID=" + txtUsername.Text + ";pwd = " + txtPassword.Text + "");
            
        //    return true;
        //}
        private void cboDataBase_DropDown(object sender, EventArgs e)
        {
            CauHinh CauHinh = new CauHinh();
            //if (CheckedBeforSearchNameDB())
            //{
                cboDataBase.Items.Clear();
                List<string> _list = CauHinh.GetDatabaseName(cboServer.Text,txtUsername.Text, txtPassword.Text);
                if (_list == null)
                {
                    MessageBox.Show("Thông tin cấu hình chưa chính xác");
                    return;
                }
                foreach (string item in _list)
                {
                    cboDataBase.Items.Add(item);
                }
            //}
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CauHinh CauHinh = new CauHinh();
            CauHinh.ChangeConnectionString(cboServer.Text, cboDataBase.Text,txtUsername.Text, txtPassword.Text);
            this.Close();
        }

        private void CauHinhSQL_Load(object sender, EventArgs e)
        {
            cboServer_DropDown(sender, e); 
        }
    }
}
