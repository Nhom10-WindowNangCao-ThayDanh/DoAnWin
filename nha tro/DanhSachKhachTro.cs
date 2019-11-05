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
using System.Data.SqlClient;

namespace nha_tro
{
    public partial class DanhSachKhachTro : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachKhachTro()
        {
            InitializeComponent();
        }
        void Xemkhachtro()
        {
            DanhSachKhachTroDataContext dskt = new DanhSachKhachTroDataContext();
            dataGridView1.DataSource = dskt.KHACHTROs.Select(d => d);


        }

        private void DanhSachKhachTro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.PHONGTRO_ds2' table. You can move, or remove it, as needed.
            this.pHONGTRO_ds2TableAdapter.Fill(this.dataSet2.PHONGTRO_ds2);
            // TODO: This line of code loads data into the 'dataSet1.PHONGTRO' table. You can move, or remove it, as needed.
            this.pHONGTROTableAdapter.Fill(this.dataSet1.PHONGTRO);
            Xemkhachtro();
        }

        private void pHONGTROBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHONGTROBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void maPTComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maPTLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {


        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DanhSachKhachTroDataContext db = new DanhSachKhachTroDataContext();
            dataGridView1.DataSource = db.KHACHTROs.Where(p => p.HoTen.Equals(txtTimkiem.Text));


        }
    }
}