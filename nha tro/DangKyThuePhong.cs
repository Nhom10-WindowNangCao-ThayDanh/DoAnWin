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
            loadDL_gid();
            load_cbo_phong();

        }
        DataClassesLinQDataContext QLPT = new DataClassesLinQDataContext();
        public void loadDL_gid()
        {
            var KT_HD_P = from kt in QLPT.KHACHTHUEs
                          join hd in QLPT.HOPDONGs on kt.MAKT equals hd.MAKT
                          join p in QLPT.Phongs on hd.MAPHONG equals p.MAPHONG
                          select new { kt.TENKT, kt.NAMSINH, kt.SDT, kt.CMND, p.TenPhong,p.TinhTrang };
            dataGridView1.DataSource = KT_HD_P;
        }
        public void load_cbo_phong()
        {
            var phong = from ph in QLPT.Phongs select new{ph.MAPHONG,ph.TenPhong};
            comboBox1.DataSource = phong.ToList();
            comboBox1.ValueMember = "MAPHONG";
            comboBox1.DisplayMember = "TenPhong";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maphong = comboBox1.SelectedItem.ToString();
            //var GiaPhong = from ph in QLPT.Phongs where ph.MAPHONG == comboBox1.SelectedItem select new { ph.GiaPhong };
            //textBox1.Text = GiaPhong.ToString();
        }
    }
}