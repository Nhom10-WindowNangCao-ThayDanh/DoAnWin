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
        DataClassesLinQDataContext QLPT = new DataClassesLinQDataContext();
        public void loadDL()
        {
            var KT_HD_P = from kt in QLPT.KHACHTHUEs 
                           join hd in QLPT.HOPDONGs  on kt.MAKT equals hd.MAKT 
                           join p in QLPT.Phongs on hd.MAPHONG equals p.MAPHONG
                           select new { kt.TENKT,kt.NAMSINH,kt.SDT,kt.CMND,p.TenPhong};
            dataGridView1.DataSource = KT_HD_P;
        }

        private void DanhSachKhachTro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.kt_hd_p' table. You can move, or remove it, as needed.
            this.kt_hd_pTableAdapter.Fill_DK(this.dataSet1.kt_hd_p);
            loadDL();

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KHACHTHUE KHACHTHUE = QLPT.KHACHTHUEs.Where(kt => kt.MAKT == dataGridView1.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault();
            if (KHACHTHUE != null)
            {
                KHACHTHUE.SDT = textBox6.Text;
                KHACHTHUE.TENKT = textBox3.Text;
                KHACHTHUE.CMND = textBox7.Text;
                KHACHTHUE.NAMSINH = textBox5.Text;
                QLPT.SubmitChanges();
                loadDL();
            }
        }
    }
}