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
    public partial class DangKyThuePhong : DevExpress.XtraEditors.XtraForm
    {
        public DangKyThuePhong()
        {
            InitializeComponent();
        }

        private void DangKyThuePhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.HOPDONG' table. You can move, or remove it, as needed.
            this.hOPDONGTableAdapter.Fill(this.dataSet1.HOPDONG);

        }
    }
}