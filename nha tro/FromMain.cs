using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
namespace nha_tro
{
    public partial class FromMain : DevExpress.XtraEditors.XtraForm
    {
        public FromMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemNguoiDung ThemNguoiDung = new ThemNguoiDung();
            ThemNguoiDung.MdiParent = this;
            ThemNguoiDung.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemNguoiDungVaoNhom ThemNguoiDungVaoNhom = new ThemNguoiDungVaoNhom();
            ThemNguoiDungVaoNhom.MdiParent = this;
            ThemNguoiDungVaoNhom.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhanQuyen PhanQuyen = new PhanQuyen();
            PhanQuyen.MdiParent = this;
            PhanQuyen.Show();
        }
        CauHinh CauHinh = new CauHinh();

        //====nhan ten dang nhap tu form dang nhap
        private string tendn;
        public FromMain(string Message): this()
        {
            tendn = Message;
        }
        //=============================================
        private void FromMain_Load(object sender, EventArgs e)
        {
            //====nhan ten dang nhap tu form dang nhap

            //====================================
            List<string> nhomND = CauHinh.GetMaNhomNguoiDung(tendn); // lay gia tri ma nhom nguoi dung          
            //dung` ma nhom nguoi dun(nhomND) lay ra ma~ man` hinh,CoQuyen
            for (int i = 0; i < nhomND.Count; i++)
            {
                List<string> MaMH = CauHinh.GetMaManHinh(nhomND[i]);
                List<string> CoQuyen = CauHinh.GetCoQuyen(nhomND[i]);
                //dung ma man hinh va` co quyen de bat visible cho cac control

                for (int j = 0; j < MaMH.Count; j++)
                {
                    if (CoQuyen[j] == true.ToString())
                    {
                        string maMH = MaMH[j].ToString();
                        getAlwayBarButton(maMH);
                    }
                }
            }
            
        }
        public void getAlwayBarButton(string nameBarbtn)
        {
            foreach (RibbonPage rPage in ribbonPage1.Collection)
            {
                foreach (RibbonPageGroup rpg in rPage.Groups)
                {
                    foreach (var btn in rpg.Ribbon.Items)
                    {
                        if (btn is BarButtonItem)
                        {
                            BarButtonItem btnBar = btn as BarButtonItem;
                            if (btnBar.Name.ToString() == nameBarbtn)
                            {
                                btnBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                            }
                        }
                    }
                }
            }
        }
    }

}