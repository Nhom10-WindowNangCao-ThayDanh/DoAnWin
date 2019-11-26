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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //khoi tao excel
            Microsoft.Office.Interop.Excel._Application  app = new Microsoft.Office.Interop.Excel.Application();
            //word book
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //khoi tao workbook
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet.Cells[1, 1].Font.Bold = true;
            worksheet.Cells[1, 1].Font.Size = 16;
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            //do du lieu vao sheet
            string fromMont = dateTimePicker1.Value.ToString().Substring(0, 2);
            string fromDay = dateTimePicker1.Value.ToString().Substring(3, 2);
            string fromyear = dateTimePicker1.Value.ToString().Substring(6,4);

            string toMont = dateTimePicker2.Value.ToString().Substring(0, 2);
            string tongay = dateTimePicker2.Value.ToString().Substring(3, 2);
            string toYear = dateTimePicker2.Value.ToString().Substring(6, 4);

            //sreach datagid
            string NamNgayThangStar = fromyear+"/"+fromMont+"/"+fromDay;
            string NamNgayThangEnd = toYear + "/" + toMont + "/" + tongay;
            try
            {
                this.hoaDonThu_sreachDayTableAdapter.Fill_dk(this.dataSet2.HoaDonThu_sreachDay, NamNgayThangStar, NamNgayThangEnd);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            //==========================================
            worksheet.Cells[1, 1] = "Báo cáo doanh thu từ " + fromDay + "/" + fromMont + "/" + fromyear + " Đến " + tongay + "/" + toMont + "/" + toYear;
            //Tinh tong tien
            int tong = 0;
            for (int j = 0; j < hoaDonThu_sreachDayDataGridView.Rows.Count - 1; j++)
            {
                tong += int.Parse(hoaDonThu_sreachDayDataGridView.Rows[j].Cells[2].Value.ToString());

            }
            //gui du lieu tu datagird vao file excel
            for (int i = 1; i < hoaDonThu_sreachDayDataGridView.Columns.Count + 1; i++)
            {
                app.Cells[2, i] = hoaDonThu_sreachDayDataGridView.Columns[i - 1].HeaderText;   
            }
            for (int i = 0; i < hoaDonThu_sreachDayDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < hoaDonThu_sreachDayDataGridView.Columns.Count ; j++)
                {
                    if (hoaDonThu_sreachDayDataGridView.Rows[i].Cells[j].Value != null)
                    {
                        app.Cells[i + 3, j + 1] = hoaDonThu_sreachDayDataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        app.Cells[i + 3, j + 1] = "Tổng tiền: ";
                        app.Cells[i + 3, j + 2] = tong.ToString();
                        app.Cells[i + 3, j + 3] = " VND";
                        break;
                    }
                }
            }
        }

        private void hoaDonThu_sreachDayBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hoaDonThu_sreachDayBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void fill_dkToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.hoaDonThu_sreachDayTableAdapter.Fill_dk(this.dataSet2.HoaDonThu_sreachDay, namthangngayStartToolStripTextBox.Text, namthangngayEndToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }
    }
}
