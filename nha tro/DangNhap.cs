using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace nha_tro
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        CauHinh CauHinh = new CauHinh();
        public void ProcessLogin()
        {
            int kq;
            kq = CauHinh.Check_User(textBox1.Text, textBox2.Text);
            // Wrong username or pass
            if (kq == 0)
            {
                MessageBox.Show("Sai " + label1.Text + " Hoặc " + label2.Text);
                return;
            }
            // Account had been disabled
            else if (kq == 1)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            
            this.Visible = false;
            mainForm frmmain = new mainForm();
            frmmain.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + textBox1.Text.ToLower());
                this.textBox1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.textBox2.Text))
            {
                MessageBox.Show("Không được bỏ trống" + textBox2.Text.ToLower());
                this.textBox2.Focus();
                return;
            }

            int kq = CauHinh.Check_Config();
            if (kq == 0)
            {

                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }

            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                ProcessConfig();
            }
        }
        public void ProcessConfig()
        {
            CauHinhSQL CauHinhSQL = new CauHinhSQL();
            CauHinhSQL.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void DangNhap_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            
        }
    }
}
