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
    public partial class TraPhong : Form
    {
        public TraPhong()
        {
            InitializeComponent();
        }

        private void kHACHTRO_ds2_dkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACHTRO_ds2_dkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void fill_dkToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.kHACHTRO_ds2_dkTableAdapter.Fill_dk(this.dataSet2.KHACHTRO_ds2_dk, mAPTToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void TraPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.TRAPHONG_ds2' table. You can move, or remove it, as needed.
            this.tRAPHONG_ds2TableAdapter.Fill(this.dataSet2.TRAPHONG_ds2);
            // TODO: This line of code loads data into the 'dataSet2.KHACHTRO_ds2' table. You can move, or remove it, as needed.
            this.kHACHTRO_ds2TableAdapter.Fill_ds2(this.dataSet2.KHACHTRO_ds2);
            // TODO: This line of code loads data into the 'dataSet2.PHONGTRO_ds2' table. You can move, or remove it, as needed.
            this.pHONGTRO_ds2TableAdapter.Fill(this.dataSet2.PHONGTRO_ds2);

        }

        private void pHONGTRO_ds2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.kHACHTRO_ds2_dkTableAdapter.Fill_dk(this.dataSet2.KHACHTRO_ds2_dk, pHONGTRO_ds2ComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

                string makt = kHACHTRO_ds2_dkDataGridView.CurrentRow.Cells[0].Value.ToString();
                if (pHONGTRO_ds2ComboBox.SelectedIndex >= 0)
                {
                    if (makt != null)
                    {//neu phong do chi có 1 ng thì cap nhat trang thai kt trong bang khach thue,cap nhat so nguoi dang o va trang thai thue cua bang phong tro
                        int sl = ((int) (kHACHTRO_ds2TableAdapter.kt_songuoi_ophong(pHONGTRO_ds2ComboBox.SelectedValue.ToString())));
                        if (sl < 2)
                        {

                            kHACHTRO_ds2TableAdapter.Update_traphong(makt, pHONGTRO_ds2ComboBox.SelectedValue.ToString());

                            pHONGTRO_ds2TableAdapter.update_TrangThaiPhong_false(pHONGTRO_ds2ComboBox.SelectedValue.ToString());
                            //cap nhat so nguoi o hien tai
                            pHONGTRO_ds2TableAdapter.update_songuoiohientai(pHONGTRO_ds2ComboBox.SelectedValue.ToString());
                            //cap nhat lai trang thai phong boi vi khong co ai o
                            pHONGTRO_ds2TableAdapter.update_TrangThaiPhong_false(pHONGTRO_ds2ComboBox.SelectedValue.ToString());
                            //them thong tin vao bang tra phong
                            string tenkt = kHACHTRO_ds2_dkDataGridView.CurrentRow.Cells[2].Value.ToString();
                            tRAPHONG_ds2TableAdapter.Insert(makt, tenkt, dateTimePicker1.Value, "");
                            MessageBox.Show("Thành Công");
                            //load lai gridview
                            this.kHACHTRO_ds2_dkTableAdapter.Fill_dk(this.dataSet2.KHACHTRO_ds2_dk, pHONGTRO_ds2ComboBox.SelectedValue.ToString());

                        }
                        else//cap nhat trang thai kt trong bang khach thue va cap nhat so nguoi dang o
                        {
                            kHACHTRO_ds2TableAdapter.Update_traphong(makt, pHONGTRO_ds2ComboBox.SelectedValue.ToString());
                            //cap nhat so nguoi o hien tai
                            pHONGTRO_ds2TableAdapter.update_songuoiohientai(pHONGTRO_ds2ComboBox.SelectedValue.ToString());
                            MessageBox.Show("Thành Công");
                            //them thong tin vao bang tra phong
                            string tenkt = kHACHTRO_ds2_dkDataGridView.CurrentRow.Cells[2].Value.ToString();
                            tRAPHONG_ds2TableAdapter.Insert(makt, tenkt, dateTimePicker1.Value, "");
                            //load lai gridview
                            this.kHACHTRO_ds2_dkTableAdapter.Fill_dk(this.dataSet2.KHACHTRO_ds2_dk, pHONGTRO_ds2ComboBox.SelectedValue.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("vui lòng chọn người cần trả phòng");
                    }
                }
                else
                    MessageBox.Show("vui lòng chọn phòng");
            }
        }
    
}
