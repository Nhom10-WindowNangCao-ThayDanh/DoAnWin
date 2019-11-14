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
using BLL;
namespace nha_tro
{
    public partial class TinhTienPhong : DevExpress.XtraEditors.XtraForm
    {
        public TinhTienPhong()
        {
            InitializeComponent();
        }

        private void pHONGTRO_ds2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHONGTRO_ds2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void TinhTienPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.HoaDonThu_DS22' table. You can move, or remove it, as needed.
            this.hoaDonThu_DS22TableAdapter.Fill(this.dataSet2.HoaDonThu_DS22);
            // TODO: This line of code loads data into the 'dataSet2.HoaDonThu_ds2' table. You can move, or remove it, as needed.
            this.hoaDonThu_ds2TableAdapter.Fill(this.dataSet2.HoaDonThu_ds2);
            // TODO: This line of code loads data into the 'dataSet2.KHACHTRO_ds2' table. You can move, or remove it, as needed.
            this.kHACHTRO_ds2TableAdapter.Fill_ds2(this.dataSet2.KHACHTRO_ds2);
            // TODO: This line of code loads data into the 'dataSet2.QLTHUTIEN_ds2' table. You can move, or remove it, as needed.
            this.qLTHUTIEN_ds2TableAdapter.Fill(this.dataSet2.QLTHUTIEN_ds2);
            // TODO: This line of code loads data into the 'dataSet2.PHONGTRO_ds2' table. You can move, or remove it, as needed.
            this.pHONGTRO_ds2TableAdapter.Fill(this.dataSet2.PHONGTRO_ds2);

        }

        private void fill_dkToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.pHONGTRO_ds2_dkTableAdapter.Fill_dk(this.dataSet2.PHONGTRO_ds2_dk, maptToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void pHONGTRO_ds2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.pHONGTRO_ds2_dkTableAdapter.Fill_dk(this.dataSet2.PHONGTRO_ds2_dk, pHONGTRO_ds2ComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                this.dv_dangsudung_dkTableAdapter.Fill_dk(this.dataSet2.dv_dangsudung_dk, pHONGTRO_ds2ComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            //try
            //{
            //    this.ds_dv_ds2_dkTableAdapter.Fill_dk(this.dataSet2.ds_dv_ds2_dk, maptToolStripTextBox1.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
            int tong = 0;
            //load tong tien dv
            for (int i = 0; i < ds_dv_ds2_dkDataGridView.Rows.Count - 1; i++)
            {
                tong += int.Parse(ds_dv_ds2_dkDataGridView.Rows[i].Cells[1].Value.ToString()) * int.Parse(ds_dv_ds2_dkDataGridView.Rows[i].Cells[2].Value.ToString());
            }
            label7.Text = tong.ToString(); 

            //load tien pHONGTRO_ds2ComboBox
            string mabanggia = pHONGTRO_ds2_dkDataGridView.Rows[0].Cells[2].Value.ToString();
            try
            {
                this.bangGiaTien_ds2_dkTableAdapter.Fill_dk(this.dataSet2.BangGiaTien_ds2_dk, mabanggia);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            label4.Text = bangGiaTien_ds2_dkDataGridView.Rows[0].Cells[0].Value.ToString();

            label17.Text = (int.Parse(label7.Text) + int.Parse(label4.Text)).ToString();

            tinhtien_BLL dichvu_tinhtien = new tinhtien_BLL();
            string x = DateTime.Today.ToString("yyyy/MM/dd");
            DateTime y = DateTime.Parse(x);
            bool kt = dichvu_tinhtien.kt_daDongTienChua(y, pHONGTRO_ds2ComboBox.SelectedValue.ToString());
            if (kt == true)
            {
                button1.Visible = true;
            }
            else
                button1.Visible = false;
            try
            {
                this.kHACHTRO_ds2_dkTableAdapter.Fill_dk(this.dataSet2.KHACHTRO_ds2_dk, pHONGTRO_ds2ComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fill_dkToolStripButton_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    this.dv_dangsudung_dkTableAdapter.Fill_dk(this.dataSet2.dv_dangsudung_dk, maPTToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void fill_dkToolStripButton_Click_2(object sender, EventArgs e)
        {
            //try
            //{
            //    this.dv_dangsudung_dkTableAdapter.Fill_dk(this.dataSet2.dv_dangsudung_dk, maPTToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void fill_dkToolStripButton_Click_3(object sender, EventArgs e)
        {
            //try
            //{
            //    this.bangGiaTien_ds2_dkTableAdapter.Fill_dk(this.dataSet2.BangGiaTien_ds2_dk, magiaToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(pHONGTRO_ds2_dkDataGridView.Rows[0].Cells[7].Value.ToString()) == 0)
            {
                MessageBox.Show("Phòng chưa có ai ở");
            }
            else
            {
                string makt = kHACHTRO_ds2_dkDataGridView.CurrentRow.Cells[0].Value.ToString();
                qLTHUTIEN_ds2TableAdapter.Insert(1,pHONGTRO_ds2ComboBox.SelectedValue.ToString(),makt,1,DateTime.Now);
                hoaDonThu_DS22TableAdapter.Insert(pHONGTRO_ds2ComboBox.SelectedValue.ToString(), int.Parse(label17.Text), DateTime.Now);
                MessageBox.Show("Thanh Cong");
            }
        }

        private void fill_dkToolStripButton_Click_4(object sender, EventArgs e)
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

        private void fill_dkToolStripButton_Click_5(object sender, EventArgs e)
        {
            //try
            //{
            //    this.cT_DV_PhongTro_ds2_dkTableAdapter.Fill_dk(this.dataSet2.CT_DV_PhongTro_ds2_dk, maPTToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void fill_dkToolStripButton1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.ds_dv_ds2_dkTableAdapter.Fill_dk(this.dataSet2.ds_dv_ds2_dk, maptToolStripTextBox1.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }
    }
}