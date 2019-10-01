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
    }
}