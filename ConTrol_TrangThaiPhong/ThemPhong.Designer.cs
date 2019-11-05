namespace ConTrol_TrangThaiPhong
{
    partial class ThemPhong
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
            System.Windows.Forms.Label maPTLabel;
            System.Windows.Forms.Label maKVLabel;
            System.Windows.Forms.Label maBangGiaLabel;
            System.Windows.Forms.Label tenPhongLabel;
            System.Windows.Forms.Label sLToiDaLabel;
            this.dataSet_phong = new ConTrol_TrangThaiPhong.DataSet_phong();
            this.pHONGTROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGTROTableAdapter = new ConTrol_TrangThaiPhong.DataSet_phongTableAdapters.PHONGTROTableAdapter();
            this.tableAdapterManager = new ConTrol_TrangThaiPhong.DataSet_phongTableAdapters.TableAdapterManager();
            this.pHONGTRODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHUVUCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHUVUCTableAdapter = new ConTrol_TrangThaiPhong.DataSet_phongTableAdapters.KHUVUCTableAdapter();
            this.bangGiaTien_DKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangGiaTien_DKTableAdapter = new ConTrol_TrangThaiPhong.DataSet_phongTableAdapters.BangGiaTien_DKTableAdapter();
            this.bangGiaTien_DKDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenPhongTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sLToiDaSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.kHUVUCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kHUVUCComboBox = new System.Windows.Forms.ComboBox();
            this.bangGiaTien_DKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bangGiaTien_DKComboBox = new System.Windows.Forms.ComboBox();
            maPTLabel = new System.Windows.Forms.Label();
            maKVLabel = new System.Windows.Forms.Label();
            maBangGiaLabel = new System.Windows.Forms.Label();
            tenPhongLabel = new System.Windows.Forms.Label();
            sLToiDaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_phong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGTROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGTRODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUVUCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangGiaTien_DKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangGiaTien_DKDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maPTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenPhongTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLToiDaSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUVUCBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangGiaTien_DKBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet_phong
            // 
            this.dataSet_phong.DataSetName = "DataSet_phong";
            this.dataSet_phong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHONGTROBindingSource
            // 
            this.pHONGTROBindingSource.DataMember = "PHONGTRO";
            this.pHONGTROBindingSource.DataSource = this.dataSet_phong;
            // 
            // pHONGTROTableAdapter
            // 
            this.pHONGTROTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangGiaTien_DKTableAdapter = this.bangGiaTien_DKTableAdapter;
            this.tableAdapterManager.KHUVUCTableAdapter = this.kHUVUCTableAdapter;
            this.tableAdapterManager.PHONGTROTableAdapter = this.pHONGTROTableAdapter;
            this.tableAdapterManager.UpdateOrder = ConTrol_TrangThaiPhong.DataSet_phongTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pHONGTRODataGridView
            // 
            this.pHONGTRODataGridView.AutoGenerateColumns = false;
            this.pHONGTRODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pHONGTRODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn6});
            this.pHONGTRODataGridView.DataSource = this.pHONGTROBindingSource;
            this.pHONGTRODataGridView.Location = new System.Drawing.Point(22, 211);
            this.pHONGTRODataGridView.Name = "pHONGTRODataGridView";
            this.pHONGTRODataGridView.Size = new System.Drawing.Size(835, 276);
            this.pHONGTRODataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaPT";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaPT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaKV";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaKV";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaBangGia";
            this.dataGridViewTextBoxColumn3.HeaderText = "MaBangGia";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TenPhong";
            this.dataGridViewTextBoxColumn4.HeaderText = "TenPhong";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SLToiDa";
            this.dataGridViewTextBoxColumn5.HeaderText = "SLToiDa";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "TrangThai";
            this.dataGridViewCheckBoxColumn1.HeaderText = "TrangThai";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "TrangThaiThue";
            this.dataGridViewCheckBoxColumn2.HeaderText = "TrangThaiThue";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SoNguoiHienTai";
            this.dataGridViewTextBoxColumn6.HeaderText = "SoNguoiHienTai";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // kHUVUCBindingSource
            // 
            this.kHUVUCBindingSource.DataMember = "KHUVUC";
            this.kHUVUCBindingSource.DataSource = this.dataSet_phong;
            // 
            // kHUVUCTableAdapter
            // 
            this.kHUVUCTableAdapter.ClearBeforeFill = true;
            // 
            // bangGiaTien_DKBindingSource
            // 
            this.bangGiaTien_DKBindingSource.DataMember = "BangGiaTien_DK";
            this.bangGiaTien_DKBindingSource.DataSource = this.dataSet_phong;
            // 
            // bangGiaTien_DKTableAdapter
            // 
            this.bangGiaTien_DKTableAdapter.ClearBeforeFill = true;
            // 
            // bangGiaTien_DKDataGridView
            // 
            this.bangGiaTien_DKDataGridView.AutoGenerateColumns = false;
            this.bangGiaTien_DKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangGiaTien_DKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.bangGiaTien_DKDataGridView.DataSource = this.bangGiaTien_DKBindingSource;
            this.bangGiaTien_DKDataGridView.Location = new System.Drawing.Point(539, 12);
            this.bangGiaTien_DKDataGridView.Name = "bangGiaTien_DKDataGridView";
            this.bangGiaTien_DKDataGridView.Size = new System.Drawing.Size(300, 193);
            this.bangGiaTien_DKDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "MaGia";
            this.dataGridViewTextBoxColumn11.HeaderText = "MaGia";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "MaKV";
            this.dataGridViewTextBoxColumn12.HeaderText = "MaKV";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "GiaTien";
            this.dataGridViewTextBoxColumn13.HeaderText = "GiaTien";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // maPTLabel
            // 
            maPTLabel.AutoSize = true;
            maPTLabel.Location = new System.Drawing.Point(128, 20);
            maPTLabel.Name = "maPTLabel";
            maPTLabel.Size = new System.Drawing.Size(42, 13);
            maPTLabel.TabIndex = 4;
            maPTLabel.Text = "Ma PT:";
            // 
            // maPTTextEdit
            // 
            this.maPTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pHONGTROBindingSource, "MaPT", true));
            this.maPTTextEdit.Location = new System.Drawing.Point(231, 17);
            this.maPTTextEdit.Name = "maPTTextEdit";
            this.maPTTextEdit.Size = new System.Drawing.Size(100, 20);
            this.maPTTextEdit.TabIndex = 5;
            // 
            // maKVLabel
            // 
            maKVLabel.AutoSize = true;
            maKVLabel.Location = new System.Drawing.Point(128, 46);
            maKVLabel.Name = "maKVLabel";
            maKVLabel.Size = new System.Drawing.Size(42, 13);
            maKVLabel.TabIndex = 6;
            maKVLabel.Text = "Ma KV:";
            // 
            // maBangGiaLabel
            // 
            maBangGiaLabel.AutoSize = true;
            maBangGiaLabel.Location = new System.Drawing.Point(128, 72);
            maBangGiaLabel.Name = "maBangGiaLabel";
            maBangGiaLabel.Size = new System.Drawing.Size(72, 13);
            maBangGiaLabel.TabIndex = 8;
            maBangGiaLabel.Text = "Ma Bang Gia:";
            // 
            // tenPhongLabel
            // 
            tenPhongLabel.AutoSize = true;
            tenPhongLabel.Location = new System.Drawing.Point(128, 98);
            tenPhongLabel.Name = "tenPhongLabel";
            tenPhongLabel.Size = new System.Drawing.Size(63, 13);
            tenPhongLabel.TabIndex = 10;
            tenPhongLabel.Text = "Ten Phong:";
            // 
            // tenPhongTextEdit
            // 
            this.tenPhongTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pHONGTROBindingSource, "TenPhong", true));
            this.tenPhongTextEdit.Location = new System.Drawing.Point(231, 95);
            this.tenPhongTextEdit.Name = "tenPhongTextEdit";
            this.tenPhongTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tenPhongTextEdit.TabIndex = 11;
            // 
            // sLToiDaLabel
            // 
            sLToiDaLabel.AutoSize = true;
            sLToiDaLabel.Location = new System.Drawing.Point(128, 124);
            sLToiDaLabel.Name = "sLToiDaLabel";
            sLToiDaLabel.Size = new System.Drawing.Size(55, 13);
            sLToiDaLabel.TabIndex = 12;
            sLToiDaLabel.Text = "SLToi Da:";
            // 
            // sLToiDaSpinEdit
            // 
            this.sLToiDaSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pHONGTROBindingSource, "SLToiDa", true));
            this.sLToiDaSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sLToiDaSpinEdit.Location = new System.Drawing.Point(231, 121);
            this.sLToiDaSpinEdit.Name = "sLToiDaSpinEdit";
            this.sLToiDaSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sLToiDaSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.sLToiDaSpinEdit.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kHUVUCBindingSource1
            // 
            this.kHUVUCBindingSource1.DataMember = "KHUVUC";
            this.kHUVUCBindingSource1.DataSource = this.dataSet_phong;
            // 
            // kHUVUCComboBox
            // 
            this.kHUVUCComboBox.DataSource = this.kHUVUCBindingSource1;
            this.kHUVUCComboBox.DisplayMember = "TenKV";
            this.kHUVUCComboBox.FormattingEnabled = true;
            this.kHUVUCComboBox.Location = new System.Drawing.Point(233, 43);
            this.kHUVUCComboBox.Name = "kHUVUCComboBox";
            this.kHUVUCComboBox.Size = new System.Drawing.Size(98, 21);
            this.kHUVUCComboBox.TabIndex = 14;
            this.kHUVUCComboBox.ValueMember = "MaKV";
            this.kHUVUCComboBox.SelectedIndexChanged += new System.EventHandler(this.kHUVUCComboBox_SelectedIndexChanged);
            // 
            // bangGiaTien_DKBindingSource1
            // 
            this.bangGiaTien_DKBindingSource1.DataMember = "BangGiaTien_DK";
            this.bangGiaTien_DKBindingSource1.DataSource = this.dataSet_phong;
            // 
            // bangGiaTien_DKComboBox
            // 
            this.bangGiaTien_DKComboBox.DataSource = this.bangGiaTien_DKBindingSource1;
            this.bangGiaTien_DKComboBox.DisplayMember = "GiaTien";
            this.bangGiaTien_DKComboBox.FormattingEnabled = true;
            this.bangGiaTien_DKComboBox.Location = new System.Drawing.Point(231, 68);
            this.bangGiaTien_DKComboBox.Name = "bangGiaTien_DKComboBox";
            this.bangGiaTien_DKComboBox.Size = new System.Drawing.Size(100, 21);
            this.bangGiaTien_DKComboBox.TabIndex = 14;
            this.bangGiaTien_DKComboBox.ValueMember = "MaGia";
            // 
            // ThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 511);
            this.Controls.Add(this.bangGiaTien_DKComboBox);
            this.Controls.Add(this.kHUVUCComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(maPTLabel);
            this.Controls.Add(this.maPTTextEdit);
            this.Controls.Add(maKVLabel);
            this.Controls.Add(maBangGiaLabel);
            this.Controls.Add(tenPhongLabel);
            this.Controls.Add(this.tenPhongTextEdit);
            this.Controls.Add(sLToiDaLabel);
            this.Controls.Add(this.sLToiDaSpinEdit);
            this.Controls.Add(this.bangGiaTien_DKDataGridView);
            this.Controls.Add(this.pHONGTRODataGridView);
            this.Name = "ThemPhong";
            this.Text = "ThemPhong";
            this.Load += new System.EventHandler(this.ThemPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_phong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGTROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGTRODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUVUCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangGiaTien_DKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangGiaTien_DKDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maPTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenPhongTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLToiDaSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUVUCBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangGiaTien_DKBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet_phong dataSet_phong;
        private System.Windows.Forms.BindingSource pHONGTROBindingSource;
        private DataSet_phongTableAdapters.PHONGTROTableAdapter pHONGTROTableAdapter;
        private DataSet_phongTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSet_phongTableAdapters.KHUVUCTableAdapter kHUVUCTableAdapter;
        private System.Windows.Forms.DataGridView pHONGTRODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource kHUVUCBindingSource;
        private DataSet_phongTableAdapters.BangGiaTien_DKTableAdapter bangGiaTien_DKTableAdapter;
        private System.Windows.Forms.BindingSource bangGiaTien_DKBindingSource;
        private System.Windows.Forms.DataGridView bangGiaTien_DKDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DevExpress.XtraEditors.TextEdit maPTTextEdit;
        private DevExpress.XtraEditors.TextEdit tenPhongTextEdit;
        private DevExpress.XtraEditors.SpinEdit sLToiDaSpinEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource kHUVUCBindingSource1;
        private System.Windows.Forms.ComboBox kHUVUCComboBox;
        private System.Windows.Forms.BindingSource bangGiaTien_DKBindingSource1;
        private System.Windows.Forms.ComboBox bangGiaTien_DKComboBox;
    }
}