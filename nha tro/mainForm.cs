using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nha_tro
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void thêmNgườiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemNguoiDung ThemNguoiDung = new ThemNguoiDung();
            ThemNguoiDung.ShowDialog();
        }

        private void thêmNDVàoNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemNguoiDungVaoNhom ThemNguoiDungVaoNhom = new ThemNguoiDungVaoNhom();
            ThemNguoiDungVaoNhom.ShowDialog();
        }
    }
}
