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
    public partial class ThemNguoiDungVaoNhom : Form
    {
        public ThemNguoiDungVaoNhom()
        {
            InitializeComponent();
        }

        private void nguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ThemNguoiDungVaoNhom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.NhomNguoiDung' table. You can move, or remove it, as needed.
            this.nhomNguoiDungTableAdapter.Fill(this.dataSet1.NhomNguoiDung);
            // TODO: This line of code loads data into the 'dataSet1.NguoiDungNhomNguoiDung' table. You can move, or remove it, as needed.
            this.nguoiDungNhomNguoiDungTableAdapter.Fill(this.dataSet1.NguoiDungNhomNguoiDung);
            // TODO: This line of code loads data into the 'dataSet1.NguoiDung' table. You can move, or remove it, as needed.
            this.nguoiDungTableAdapter.Fill(this.dataSet1.NguoiDung);
            load_dl();

        }

        private void nhomNguoiDungComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.nguoiDungNhomNguoiDung_DkTableAdapter.Fill_Dk(this.dataSet1.NguoiDungNhomNguoiDung_Dk, nhomNguoiDungComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void load_dl()
        {
            if (nhomNguoiDungComboBox.SelectedValue != null)
            {
                try
                {
                    this.nguoiDungNhomNguoiDung_DkTableAdapter.Fill_Dk(this.dataSet1.NguoiDungNhomNguoiDung_Dk, nhomNguoiDungComboBox.SelectedValue.ToString());
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenDN = nguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();
            string manhom = nhomNguoiDungComboBox.SelectedValue.ToString();

            nguoiDungNhomNguoiDungTableAdapter.Insert(tenDN,manhom,"");
            MessageBox.Show("Thanh Cong");

            load_dl();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tenDN = nguoiDungNhomNguoiDung_DkDataGridView.CurrentRow.Cells[0].Value.ToString();
            string manhom = nhomNguoiDungComboBox.SelectedValue.ToString();
            nguoiDungNhomNguoiDungTableAdapter.Delete(tenDN, manhom, "");
            MessageBox.Show("Thanh Cong");

            load_dl();
        }
        
    }
}
