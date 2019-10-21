namespace nha_tro
{
    partial class PhanQuyen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataSet1 = new nha_tro.DataSet1();
            this.phanQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phanQuyenTableAdapter = new nha_tro.DataSet1TableAdapters.PhanQuyenTableAdapter();
            this.tableAdapterManager = new nha_tro.DataSet1TableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.phanQuyenDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phanQuyenDKTableAdapter = new nha_tro.DataSet1TableAdapters.PhanQuyenDKTableAdapter();
            this.phanQuyenDKDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomNguoiDungTableAdapter = new nha_tro.DataSet1TableAdapters.NhomNguoiDungTableAdapter();
            this.nhomNguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phanQuyenBindingSource
            // 
            this.phanQuyenBindingSource.DataMember = "PhanQuyen";
            this.phanQuyenBindingSource.DataSource = this.dataSet1;
            // 
            // phanQuyenTableAdapter
            // 
            this.phanQuyenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NguoiDungNhomNguoiDung_DkTableAdapter = null;
            this.tableAdapterManager.NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.NguoiDungTableAdapter = null;
            this.tableAdapterManager.NhomNguoiDungTableAdapter = this.nhomNguoiDungTableAdapter;
            this.tableAdapterManager.PhanQuyenTableAdapter = this.phanQuyenTableAdapter;
            this.tableAdapterManager.UpdateOrder = nha_tro.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // phanQuyenDKBindingSource
            // 
            this.phanQuyenDKBindingSource.DataMember = "PhanQuyenDK";
            this.phanQuyenDKBindingSource.DataSource = this.dataSet1;
            // 
            // phanQuyenDKTableAdapter
            // 
            this.phanQuyenDKTableAdapter.ClearBeforeFill = true;
            // 
            // phanQuyenDKDataGridView
            // 
            this.phanQuyenDKDataGridView.AutoGenerateColumns = false;
            this.phanQuyenDKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phanQuyenDKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn2});
            this.phanQuyenDKDataGridView.DataSource = this.phanQuyenDKBindingSource;
            this.phanQuyenDKDataGridView.Location = new System.Drawing.Point(347, 114);
            this.phanQuyenDKDataGridView.Name = "phanQuyenDKDataGridView";
            this.phanQuyenDKDataGridView.Size = new System.Drawing.Size(355, 220);
            this.phanQuyenDKDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenManHinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "TenManHinh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaManHinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaManHinh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "CoQuyen";
            this.dataGridViewCheckBoxColumn2.HeaderText = "CoQuyen";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // nhomNguoiDungBindingSource
            // 
            this.nhomNguoiDungBindingSource.DataMember = "NhomNguoiDung";
            this.nhomNguoiDungBindingSource.DataSource = this.dataSet1;
            // 
            // nhomNguoiDungTableAdapter
            // 
            this.nhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // nhomNguoiDungDataGridView
            // 
            this.nhomNguoiDungDataGridView.AutoGenerateColumns = false;
            this.nhomNguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhomNguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.nhomNguoiDungDataGridView.DataSource = this.nhomNguoiDungBindingSource;
            this.nhomNguoiDungDataGridView.Location = new System.Drawing.Point(12, 114);
            this.nhomNguoiDungDataGridView.Name = "nhomNguoiDungDataGridView";
            this.nhomNguoiDungDataGridView.Size = new System.Drawing.Size(329, 220);
            this.nhomNguoiDungDataGridView.TabIndex = 3;
            this.nhomNguoiDungDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nhomNguoiDungDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhom";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaNhom";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNhom";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenNhom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn5.HeaderText = "GhiChu";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 427);
            this.Controls.Add(this.nhomNguoiDungDataGridView);
            this.Controls.Add(this.phanQuyenDKDataGridView);
            this.Controls.Add(this.button1);
            this.Name = "PhanQuyen";
            this.Text = "PhanQuyen";
            this.Load += new System.EventHandler(this.PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource phanQuyenBindingSource;
        private DataSet1TableAdapters.PhanQuyenTableAdapter phanQuyenTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource phanQuyenDKBindingSource;
        private DataSet1TableAdapters.PhanQuyenDKTableAdapter phanQuyenDKTableAdapter;
        private System.Windows.Forms.DataGridView phanQuyenDKDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private DataSet1TableAdapters.NhomNguoiDungTableAdapter nhomNguoiDungTableAdapter;
        private System.Windows.Forms.BindingSource nhomNguoiDungBindingSource;
        private System.Windows.Forms.DataGridView nhomNguoiDungDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}