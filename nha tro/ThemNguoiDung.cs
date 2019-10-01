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
    public partial class ThemNguoiDung : Form
    {
        public ThemNguoiDung()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.NguoiDungTableAdapter.Insert(tendangnhapTextEdit.Text, matkhauTextEdit.Text, hoatDongCheckEdit.Checked);
            this.nguoiDungTableAdapter.Fill(this.dataSet1.NguoiDung);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.NguoiDungTableAdapter.Delete(tendangnhapTextEdit.Text, matkhauTextEdit.Text, hoatDongCheckEdit.Checked);
            this.nguoiDungTableAdapter.Fill(this.dataSet1.NguoiDung);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            MessageBox.Show("Cập nhật thành công!!!");
        }

        private void nguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ThemNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.NguoiDung' table. You can move, or remove it, as needed.
            this.nguoiDungTableAdapter.Fill(this.dataSet1.NguoiDung);

        }
    }
}
