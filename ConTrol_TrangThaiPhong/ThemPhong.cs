using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConTrol_TrangThaiPhong
{
    public partial class ThemPhong : Form
    {
        public ThemPhong()
        {
            InitializeComponent();
        }

        private void pHONGTROBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHONGTROBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_phong);

        }

        private void ThemPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_phong.KHUVUC' table. You can move, or remove it, as needed.
            this.kHUVUCTableAdapter.Fill(this.dataSet_phong.KHUVUC);
            // TODO: This line of code loads data into the 'dataSet_phong.PHONGTRO' table. You can move, or remove it, as needed.
            this.pHONGTROTableAdapter.Fill(this.dataSet_phong.PHONGTRO);

        }

        private void fill_dkToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.bangGiaTien_DKTableAdapter.Fill_dk(this.dataSet_phong.BangGiaTien_DK, makvToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataPhong_LinQDataContext dataphong = new dataPhong_LinQDataContext();
            var so_phong = (from p in dataphong.PHONGTROs where p.MaPT == maPTTextEdit.Text select p).Count();

            if (so_phong != 0)
            {
                MessageBox.Show("Đã tồn tại mã phòng !!!");
            }
            else
            {
                this.tableAdapterManager.PHONGTROTableAdapter.Insert(maPTTextEdit.Text, kHUVUCComboBox.SelectedValue.ToString().Trim(), bangGiaTien_DKComboBox.SelectedValue.ToString().Trim(), tenPhongTextEdit.Text, int.Parse(sLToiDaSpinEdit.Text), true, false, 0);
                this.pHONGTROTableAdapter.Fill(this.dataSet_phong.PHONGTRO);
                MessageBox.Show("Thêm Thành Công!!!");
            }
        }

        private void kHUVUCComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.bangGiaTien_DKTableAdapter.Fill_dk(this.dataSet_phong.BangGiaTien_DK, kHUVUCComboBox.SelectedValue.ToString().Trim());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
