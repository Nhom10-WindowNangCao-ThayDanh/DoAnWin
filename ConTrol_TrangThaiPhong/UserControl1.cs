using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConTrol_TrangThaiPhong
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            //lay so luong phong
            dataPhong_LinQDataContext data_phongtro = new dataPhong_LinQDataContext();
            var phong = (from p in data_phongtro.PHONGTROs select p).Count();
            int slphong = phong;
            taoControldong(slphong);  
        }
        string chuoihinh_dangthue = "C:/Users/lythi/OneDrive/Desktop/DoAnWin/hinh/house-48.ico";
        string chuoihinh_chuathue = "C:/Users/lythi/OneDrive/Desktop/DoAnWin/hinh/house-49.ico";

        private void bt_Click(object sender, EventArgs e)
        {
        }
        public string kt_trangthaithue(int sophong)
        {
            dataPhong_LinQDataContext dataphong = new dataPhong_LinQDataContext();
            if (sophong <= 9)
            {
                var tt_phong = from p in dataphong.PHONGTROs where p.MaPT == "PT00" + sophong select new { p.TrangThaiThue };
                foreach (var TT in tt_phong)
                {
                    string x = TT.TrangThaiThue.ToString();
                    return x;
                }
                return "";
            }
            else
            {
                var tt_phong = from p in dataphong.PHONGTROs where p.MaPT == "PT0" + sophong select new { p.TrangThaiThue };
                foreach (var TT in tt_phong)
                {
                    string x = TT.TrangThaiThue.ToString();
                    return x;
                }
                return "";
            }
        }
        public void taoControldong(int x)
        {
            int kc = 100;
            int xuongdong = 10;
            int sophong = 0;
            if (x <= 3)
            {
                for (int i = 1; i <= x; i++)
                {
                    sophong++;
                    Button b = new Button();
                    b.Name = "b1" + kc.ToString();
                    b.Size = new Size(100, 100);
                    b.Left = kc;
                    b.Top = 30 + xuongdong;
                    //set hinh
                    if (string.Compare(kt_trangthaithue(sophong), "True") == 0)
                    {
                        b.Image = Image.FromFile(chuoihinh_dangthue);
                        b.ImageAlign = ContentAlignment.MiddleCenter;
                        b.TextAlign = ContentAlignment.BottomCenter;
                        b.Text = "Phòng " + sophong;
                    }
                    else
                    {
                        b.Image = Image.FromFile(chuoihinh_chuathue);
                        b.ImageAlign = ContentAlignment.MiddleCenter;
                        b.TextAlign = ContentAlignment.BottomCenter;
                        b.Text = "Phòng " + sophong;
                    }
                    //=================
                    kc += 100;
                    this.Controls.Add(b);
                    b.Click += new System.EventHandler(bt_Click);
                }
            }
            else
            {
                int tong = x;
                int dem = 0;
                while (tong != dem)
                {
                    dem = dem + 6;
                    if (dem <= tong)
                    {
                        for (int i = 1; i <= 6; i++)
                        {
                            sophong++;
                            Button b = new Button();
                            b.Name = "b1" + kc.ToString();
                            b.Size = new Size(100, 100);
                            b.Left = kc;
                            b.Top = 30 + xuongdong;
                            //set hinh
                            if (string.Compare(kt_trangthaithue(sophong), "True") == 0)
                            {
                                b.Image = Image.FromFile(chuoihinh_dangthue);
                                b.ImageAlign = ContentAlignment.MiddleCenter;
                                b.TextAlign = ContentAlignment.BottomCenter;
                                b.Text = "Phòng " + sophong;
                            }
                            else
                            {
                                b.Image = Image.FromFile(chuoihinh_chuathue);
                                b.ImageAlign = ContentAlignment.MiddleCenter;
                                b.TextAlign = ContentAlignment.BottomCenter;
                                b.Text = "Phòng " + sophong;
                            }
                            //=================
                            kc += 100;
                            this.Controls.Add(b);
                            b.Click += new System.EventHandler(bt_Click);
                        }
                    }
                    else
                    {
                        int SoHinh = tong - (dem - 6);
                        for (int i = 1; i <= SoHinh; i++)
                        {
                            sophong++;
                            Button b = new Button();
                            b.Name = "b1" + kc.ToString();
                            b.Size = new Size(100, 100);
                            b.Left = kc;
                            b.Top = 30 + xuongdong;
                            //set hinh
                            if (string.Compare(kt_trangthaithue(sophong), "True") == 0)
                            {
                                b.Image = Image.FromFile(chuoihinh_dangthue);
                                b.ImageAlign = ContentAlignment.MiddleCenter;
                                b.TextAlign = ContentAlignment.BottomCenter;
                                b.Text = "Phòng " + sophong;
                            }
                            else
                            {
                                b.Image = Image.FromFile(chuoihinh_chuathue);
                                b.ImageAlign = ContentAlignment.MiddleCenter;
                                b.TextAlign = ContentAlignment.BottomCenter;
                                b.Text = "Phòng " + sophong;
                            }
                            //=================
                            //================
                            kc += 100;
                            this.Controls.Add(b);
                            b.Click += new System.EventHandler(bt_Click);
                        }
                        dem = tong;
                    }
                    xuongdong += 100;
                    kc = 100;
                }
            }
        }

        private void thêmPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemPhong x = new ThemPhong();
            x.ShowDialog();
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            //lay so luong phong
            dataPhong_LinQDataContext data_phongtro = new dataPhong_LinQDataContext();
            var phong = (from p in data_phongtro.PHONGTROs select p).Count();
            int slphong = phong;
            taoControldong(slphong);  
        }











    }
}
