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
    public partial class DanhSachKhachTro : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachKhachTro()
        {
            InitializeComponent();
        }

        private void DanhSachKhachTro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.kt_hd_p' table. You can move, or remove it, as needed.
            this.kt_hd_pTableAdapter.Fill_DK(this.dataSet1.kt_hd_p);

        }
    }
}