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
using System.Windows.Controls.Ribbon;
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

        private void FromMain_Load(object sender, EventArgs e)
        {
            List<string> nhomND = CauHinh.GetMaNhomNguoiDung("user");
            foreach (string item in nhomND)
            {
                DataTable dsQuyen = CauHinh.GetMaManHinh(item);
                foreach (DataRow mh in dsQuyen.Rows)
                {
                    FindMenuPhanQuyen(this.ribbonControl1, mh[0].ToString(), Convert.ToBoolean(mh[1].ToString()));
                }
            }
        }
        private void FindMenuPhanQuyen(DevExpress.XtraBars.Ribbon.RibbonControl mnuItems, string pScreenName, bool pEnable)
        {
            foreach (DevExpress.XtraBars.Ribbon.RibbonControl menu in mnuItems)
            {
                if (menu is DevExpress.XtraBars.Ribbon.RibbonControl && ((DevExpress.XtraBars.Ribbon.RibbonControl)(menu)).barButtonItem1.Count > 0)
                {
                    FindMenuPhanQuyen(((DevExpress.XtraBars.Ribbon.RibbonControl)(menu)).DropDownItems,pScreenName, pEnable);
                    menu.Enabled =
                    CheckAllMenuChildVisible(((DevExpress.XtraBars.Ribbon.RibbonControl)(menu)).DropDownItems);
                    menu.Visible = menu.Enabled;
                }
                else if (string.Equals(pScreenName, menu.Tag))
                {
                    menu.Enabled = pEnable;
                    menu.Visible = pEnable;
                }
            }
        }
        private bool CheckAllMenuChildVisible(ToolStripItemCollection mnuItems)
        {
            foreach (ToolStripItem menuItem in mnuItems)
            {
                if (menuItem is ToolStripMenuItem && menuItem.Enabled)
                {
                    return true;
                }
                else if (menuItem is ToolStripSeparator)
                {
                    continue;
                }
            }
            return false;
        }
    }
}