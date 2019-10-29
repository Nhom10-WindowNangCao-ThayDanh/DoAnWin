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
            // TODO: This line of code loads data into the 'dataSet2.PHONGTRO_ds2' table. You can move, or remove it, as needed.
            this.pHONGTRO_ds2TableAdapter.Fill(this.dataSet2.PHONGTRO_ds2);
            // TODO: This line of code loads data into the 'dataSet2.phieudkthuephong_ds2' table. You can move, or remove it, as needed.
            this.phieudkthuephong_ds2TableAdapter.Fill_ds2(this.dataSet2.phieudkthuephong_ds2);
            // TODO: This line of code loads data into the 'dataSet2.QUANLITHUEPHONG' table. You can move, or remove it, as needed.
            this.qUANLITHUEPHONGTableAdapter.Fill(this.dataSet2.QUANLITHUEPHONG);
            // TODO: This line of code loads data into the 'dataSet2.QUANLITHUEPHONG' table. You can move, or remove it, as needed.
            this.qUANLITHUEPHONGTableAdapter.Fill(this.dataSet2.QUANLITHUEPHONG);
            
            // TODO: This line of code loads data into the 'dataSet1.KHUVUC' table. You can move, or remove it, as needed.
            this.kHUVUCTableAdapter.Fill(this.dataSet1.KHUVUC);
            // TODO: This line of code loads data into the 'dataSet1.BangGiaTien' table. You can move, or remove it, as needed.
            this.bangGiaTienTableAdapter.Fill(this.dataSet1.BangGiaTien);
            // TODO: This line of code loads data into the 'dataSet1.PHONGTRO' table. You can move, or remove it, as needed.
            this.pHONGTROTableAdapter.Fill(this.dataSet1.PHONGTRO);
// TODO: This line of code loads data into the 'dataSet1.KHACHTRO' table. You can move, or remove it, as needed.
this.kHACHTROTableAdapter.Fill(this.dataSet1.KHACHTRO);
            // TODO: This line of code loads data into the 'dataSet1.DangKyThuePhong' table. You can move, or remove it, as needed.
            


            //read only
            maPTTextEdit.Properties.ReadOnly = true;
            maKVTextEdit.Properties.ReadOnly = true;
            sLToiDaSpinEdit.Properties.ReadOnly = true;
            soNguoiHienTaiSpinEdit.Properties.ReadOnly = true;
            tenKVTextEdit.Properties.ReadOnly = true;
            maBangGiaTextEdit.Properties.ReadOnly = true;
            giaTienSpinEdit.Properties.ReadOnly = true;


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        //====nhan ten dang nhap tu form main
        private string tendn;
        public DangKyThuePhong(string Message)
            : this()
        {
            tendn = Message;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(soNguoiHienTaiSpinEdit.Text) + 1 <= int.Parse(sLToiDaSpinEdit.Text))
            {

                //them thong tin vao bang  KHACHTRO
                bool TrangthaiTro = true; // true:dang ở //false khong con ở
                string gioitinh = dkthuephong_dkComboBox.Text;
                kHACHTROTableAdapter.Insert(textBox4.Text, maPTTextEdit.Text, textBox3.Text, textBox6.Text, gioitinh, textBox5.Text, textBox10.Text, textBox11.Text, TrangthaiTro, tendn);
                //======================================================================================================================

                //them thong tin vao bang  QUANLITHUEPHONG
                string Date = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                decimal tiendatcon = int.Parse(textBox12.Text);
                qUANLITHUEPHONGTableAdapter.Insert(textBox4.Text, Date, true, tiendatcon);
                //load lai datagird
                this.phieudkthuephong_ds2TableAdapter.Fill_ds2(this.dataSet2.phieudkthuephong_ds2);
                MessageBox.Show("thêm thành công!!!");
                //cap nhat lai so ng dang o hien tai trong bang phong tro
                pHONGTRO_ds2TableAdapter.UpdateQuery(maPTTextEdit.Text, maKVTextEdit.Text, maBangGiaTextEdit.Text, true, maPTTextEdit.Text);
                //load lai from
                DangKyThuePhong_Load(sender, e);
            }
            else
                MessageBox.Show("phòng đã hết chổ");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void load_tt_phong()
        {
            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void fill_dkToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void maKVTextEdit_TextChanged(object sender, EventArgs e)
        {
            //load ten khu vuc
            try
            {
                this.kHUVUCDKTableAdapter.Fill_dk(this.dataSet1.KHUVUCDK, maKVTextEdit.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            //load gia tien
            try
            {
                this.bangGiaTien_DKTableAdapter.Fill_DK(this.dataSet1.BangGiaTien_DK, maBangGiaTextEdit.Text, maKVTextEdit.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fill_DKToolStripButton_Click_1(object sender, EventArgs e)
        {
           

        }











    }
}