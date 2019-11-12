namespace nha_tro
{
    partial class TraPhong
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
            this.dataSet2 = new nha_tro.DataSet2();
            this.kHACHTRO_ds2_dkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHTRO_ds2_dkTableAdapter = new nha_tro.DataSet2TableAdapters.KHACHTRO_ds2_dkTableAdapter();
            this.tableAdapterManager = new nha_tro.DataSet2TableAdapters.TableAdapterManager();
            this.kHACHTRO_ds2TableAdapter = new nha_tro.DataSet2TableAdapters.KHACHTRO_ds2TableAdapter();
            this.pHONGTRO_ds2TableAdapter = new nha_tro.DataSet2TableAdapters.PHONGTRO_ds2TableAdapter();
            this.kHACHTRO_ds2_dkDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.kHACHTRO_ds2_dkBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGTRO_ds2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGTRO_ds2ComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kHACHTRO_ds2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRAPHONG_ds2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRAPHONG_ds2TableAdapter = new nha_tro.DataSet2TableAdapters.TRAPHONG_ds2TableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHTRO_ds2_dkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHTRO_ds2_dkDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHTRO_ds2_dkBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGTRO_ds2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHTRO_ds2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAPHONG_ds2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHTRO_ds2_dkBindingSource
            // 
            this.kHACHTRO_ds2_dkBindingSource.DataMember = "KHACHTRO_ds2_dk";
            this.kHACHTRO_ds2_dkBindingSource.DataSource = this.dataSet2;
            // 
            // kHACHTRO_ds2_dkTableAdapter
            // 
            this.kHACHTRO_ds2_dkTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KHACHTRO_ds2_dkTableAdapter = this.kHACHTRO_ds2_dkTableAdapter;
            this.tableAdapterManager.KHACHTRO_ds2TableAdapter = this.kHACHTRO_ds2TableAdapter;
            this.tableAdapterManager.PHONGTRO_ds2TableAdapter = this.pHONGTRO_ds2TableAdapter;
            this.tableAdapterManager.QUANLITHUEPHONGTableAdapter = null;
            this.tableAdapterManager.TRAPHONG_ds2TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = nha_tro.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kHACHTRO_ds2TableAdapter
            // 
            this.kHACHTRO_ds2TableAdapter.ClearBeforeFill = true;
            // 
            // pHONGTRO_ds2TableAdapter
            // 
            this.pHONGTRO_ds2TableAdapter.ClearBeforeFill = true;
            // 
            // kHACHTRO_ds2_dkDataGridView
            // 
            this.kHACHTRO_ds2_dkDataGridView.AutoGenerateColumns = false;
            this.kHACHTRO_ds2_dkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kHACHTRO_ds2_dkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn9});
            this.kHACHTRO_ds2_dkDataGridView.DataSource = this.kHACHTRO_ds2_dkBindingSource;
            this.kHACHTRO_ds2_dkDataGridView.Location = new System.Drawing.Point(12, 103);
            this.kHACHTRO_ds2_dkDataGridView.Name = "kHACHTRO_ds2_dkDataGridView";
            this.kHACHTRO_ds2_dkDataGridView.Size = new System.Drawing.Size(718, 220);
            this.kHACHTRO_ds2_dkDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKT";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaKT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaPT";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaPT";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn3.HeaderText = "HoTen";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CMND";
            this.dataGridViewTextBoxColumn4.HeaderText = "CMND";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GioiTinh";
            this.dataGridViewTextBoxColumn5.HeaderText = "GioiTinh";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NgeNghiep";
            this.dataGridViewTextBoxColumn6.HeaderText = "NgeNghiep";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn7.HeaderText = "DiaChi";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn8.HeaderText = "SDT";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "TrangthaiTro";
            this.dataGridViewCheckBoxColumn1.HeaderText = "TrangthaiTro";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "tendangnhap";
            this.dataGridViewTextBoxColumn9.HeaderText = "tendangnhap";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Phòng";
            // 
            // kHACHTRO_ds2_dkBindingSource1
            // 
            this.kHACHTRO_ds2_dkBindingSource1.DataMember = "KHACHTRO_ds2_dk";
            this.kHACHTRO_ds2_dkBindingSource1.DataSource = this.dataSet2;
            // 
            // pHONGTRO_ds2BindingSource
            // 
            this.pHONGTRO_ds2BindingSource.DataMember = "PHONGTRO_ds2";
            this.pHONGTRO_ds2BindingSource.DataSource = this.dataSet2;
            // 
            // pHONGTRO_ds2ComboBox
            // 
            this.pHONGTRO_ds2ComboBox.DataSource = this.pHONGTRO_ds2BindingSource;
            this.pHONGTRO_ds2ComboBox.DisplayMember = "TenPhong";
            this.pHONGTRO_ds2ComboBox.FormattingEnabled = true;
            this.pHONGTRO_ds2ComboBox.Location = new System.Drawing.Point(78, 34);
            this.pHONGTRO_ds2ComboBox.Name = "pHONGTRO_ds2ComboBox";
            this.pHONGTRO_ds2ComboBox.Size = new System.Drawing.Size(300, 21);
            this.pHONGTRO_ds2ComboBox.TabIndex = 4;
            this.pHONGTRO_ds2ComboBox.ValueMember = "MaPT";
            this.pHONGTRO_ds2ComboBox.SelectedIndexChanged += new System.EventHandler(this.pHONGTRO_ds2ComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kHACHTRO_ds2BindingSource
            // 
            this.kHACHTRO_ds2BindingSource.DataMember = "KHACHTRO_ds2";
            this.kHACHTRO_ds2BindingSource.DataSource = this.dataSet2;
            // 
            // tRAPHONG_ds2BindingSource
            // 
            this.tRAPHONG_ds2BindingSource.DataMember = "TRAPHONG_ds2";
            this.tRAPHONG_ds2BindingSource.DataSource = this.dataSet2;
            // 
            // tRAPHONG_ds2TableAdapter
            // 
            this.tRAPHONG_ds2TableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày trả";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // TraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 446);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pHONGTRO_ds2ComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kHACHTRO_ds2_dkDataGridView);
            this.Name = "TraPhong";
            this.Text = "TraPhong";
            this.Load += new System.EventHandler(this.TraPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHTRO_ds2_dkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHTRO_ds2_dkDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHTRO_ds2_dkBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGTRO_ds2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHTRO_ds2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAPHONG_ds2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource kHACHTRO_ds2_dkBindingSource;
        private DataSet2TableAdapters.KHACHTRO_ds2_dkTableAdapter kHACHTRO_ds2_dkTableAdapter;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private DataSet2TableAdapters.PHONGTRO_ds2TableAdapter pHONGTRO_ds2TableAdapter;
        private System.Windows.Forms.DataGridView kHACHTRO_ds2_dkDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource kHACHTRO_ds2_dkBindingSource1;
        private System.Windows.Forms.BindingSource pHONGTRO_ds2BindingSource;
        private System.Windows.Forms.ComboBox pHONGTRO_ds2ComboBox;
        private System.Windows.Forms.Button button1;
        private DataSet2TableAdapters.KHACHTRO_ds2TableAdapter kHACHTRO_ds2TableAdapter;
        private System.Windows.Forms.BindingSource kHACHTRO_ds2BindingSource;
        private System.Windows.Forms.BindingSource tRAPHONG_ds2BindingSource;
        private DataSet2TableAdapters.TRAPHONG_ds2TableAdapter tRAPHONG_ds2TableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}