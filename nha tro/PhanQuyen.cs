﻿using System;
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
    public partial class PhanQuyen : Form
    {
        public PhanQuyen()
        {
            InitializeComponent();
        }

        private void phanQuyenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phanQuyenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.NhomNguoiDung' table. You can move, or remove it, as needed.
            this.nhomNguoiDungTableAdapter.Fill(this.dataSet1.NhomNguoiDung);
            // TODO: This line of code loads data into the 'dataSet1.PhanQuyen' table. You can move, or remove it, as needed.
            this.phanQuyenTableAdapter.Fill(this.dataSet1.PhanQuyen);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maMH = phanQuyenDKDataGridView.CurrentRow.Cells[1].Value.ToString();
            string manhom = nhomNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();
            string coquyen = phanQuyenDKDataGridView.CurrentRow.Cells[2].Value.ToString();

            bool quyen;
            if (coquyen == "True")
            {
                quyen = true;
                phanQuyenTableAdapter.Insert(manhom, maMH, quyen);
            }
            else
            {
                phanQuyenTableAdapter.Delete(manhom, maMH, true);
            }
            MessageBox.Show("Thành Công !!!");
        }

        private void fill_dkToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.phanQuyenDKTableAdapter.Fill_dk(this.dataSet1.PhanQuyenDK, maNhomToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void nhomNguoiDungDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string manhom = nhomNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();
            try
            {
                this.phanQuyenDKTableAdapter.Fill_dk(this.dataSet1.PhanQuyenDK, manhom);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
