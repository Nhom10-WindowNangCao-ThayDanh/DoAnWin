namespace nha_tro
{
    partial class ThemNguoiDungVaoNhom
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
            this.nguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new nha_tro.DataSet1();
            this.nguoiDungNhomNguoiDung_DkDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiDungNhomNguoiDung_DkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiDungTableAdapter = new nha_tro.DataSet1TableAdapters.NguoiDungTableAdapter();
            this.tableAdapterManager = new nha_tro.DataSet1TableAdapters.TableAdapterManager();
            this.nguoiDungNhomNguoiDung_DkTableAdapter = new nha_tro.DataSet1TableAdapters.NguoiDungNhomNguoiDung_DkTableAdapter();
            this.nguoiDungBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiDungNhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiDungNhomNguoiDungTableAdapter = new nha_tro.DataSet1TableAdapters.NguoiDungNhomNguoiDungTableAdapter();
            this.nhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomNguoiDungTableAdapter = new nha_tro.DataSet1TableAdapters.NhomNguoiDungTableAdapter();
            this.nhomNguoiDungComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungNhomNguoiDung_DkDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungNhomNguoiDung_DkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungNhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nguoiDungDataGridView
            // 
            this.nguoiDungDataGridView.AutoGenerateColumns = false;
            this.nguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.nguoiDungDataGridView.DataSource = this.nguoiDungBindingSource;
            this.nguoiDungDataGridView.Location = new System.Drawing.Point(12, 81);
            this.nguoiDungDataGridView.Name = "nguoiDungDataGridView";
            this.nguoiDungDataGridView.Size = new System.Drawing.Size(341, 220);
            this.nguoiDungDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tendangnhap";
            this.dataGridViewTextBoxColumn1.HeaderText = "tendangnhap";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "matkhau";
            this.dataGridViewTextBoxColumn2.HeaderText = "matkhau";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "HoatDong";
            this.dataGridViewCheckBoxColumn1.HeaderText = "HoatDong";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // nguoiDungBindingSource
            // 
            this.nguoiDungBindingSource.DataMember = "NguoiDung";
            this.nguoiDungBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nguoiDungNhomNguoiDung_DkDataGridView
            // 
            this.nguoiDungNhomNguoiDung_DkDataGridView.AutoGenerateColumns = false;
            this.nguoiDungNhomNguoiDung_DkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nguoiDungNhomNguoiDung_DkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.nguoiDungNhomNguoiDung_DkDataGridView.DataSource = this.nguoiDungNhomNguoiDung_DkBindingSource;
            this.nguoiDungNhomNguoiDung_DkDataGridView.Location = new System.Drawing.Point(445, 81);
            this.nguoiDungNhomNguoiDung_DkDataGridView.Name = "nguoiDungNhomNguoiDung_DkDataGridView";
            this.nguoiDungNhomNguoiDung_DkDataGridView.Size = new System.Drawing.Size(300, 220);
            this.nguoiDungNhomNguoiDung_DkDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tendangnhap";
            this.dataGridViewTextBoxColumn3.HeaderText = "tendangnhap";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaNhom";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaNhom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // nguoiDungNhomNguoiDung_DkBindingSource
            // 
            this.nguoiDungNhomNguoiDung_DkBindingSource.DataMember = "NguoiDungNhomNguoiDung_Dk";
            this.nguoiDungNhomNguoiDung_DkBindingSource.DataSource = this.dataSet1;
            // 
            // nguoiDungTableAdapter
            // 
            this.nguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NguoiDungNhomNguoiDung_DkTableAdapter = this.nguoiDungNhomNguoiDung_DkTableAdapter;
            this.tableAdapterManager.NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.NguoiDungTableAdapter = this.nguoiDungTableAdapter;
            this.tableAdapterManager.NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = nha_tro.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nguoiDungNhomNguoiDung_DkTableAdapter
            // 
            this.nguoiDungNhomNguoiDung_DkTableAdapter.ClearBeforeFill = true;
            // 
            // nguoiDungBindingSource1
            // 
            this.nguoiDungBindingSource1.DataMember = "NguoiDung";
            this.nguoiDungBindingSource1.DataSource = this.dataSet1;
            // 
            // nguoiDungNhomNguoiDungBindingSource
            // 
            this.nguoiDungNhomNguoiDungBindingSource.DataMember = "NguoiDungNhomNguoiDung";
            this.nguoiDungNhomNguoiDungBindingSource.DataSource = this.dataSet1;
            // 
            // nguoiDungNhomNguoiDungTableAdapter
            // 
            this.nguoiDungNhomNguoiDungTableAdapter.ClearBeforeFill = true;
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
            // nhomNguoiDungComboBox
            // 
            this.nhomNguoiDungComboBox.DataSource = this.nhomNguoiDungBindingSource;
            this.nhomNguoiDungComboBox.DisplayMember = "TenNhom";
            this.nhomNguoiDungComboBox.FormattingEnabled = true;
            this.nhomNguoiDungComboBox.Location = new System.Drawing.Point(445, 44);
            this.nhomNguoiDungComboBox.Name = "nhomNguoiDungComboBox";
            this.nhomNguoiDungComboBox.Size = new System.Drawing.Size(300, 21);
            this.nhomNguoiDungComboBox.TabIndex = 3;
            this.nhomNguoiDungComboBox.ValueMember = "MaNhom";
            this.nhomNguoiDungComboBox.SelectedIndexChanged += new System.EventHandler(this.nhomNguoiDungComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ThemNguoiDungVaoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 409);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nhomNguoiDungComboBox);
            this.Controls.Add(this.nguoiDungNhomNguoiDung_DkDataGridView);
            this.Controls.Add(this.nguoiDungDataGridView);
            this.Name = "ThemNguoiDungVaoNhom";
            this.Text = "ThemNguoiDungVaoNhom";
            this.Load += new System.EventHandler(this.ThemNguoiDungVaoNhom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungNhomNguoiDung_DkDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungNhomNguoiDung_DkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungNhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource;
        private DataSet1TableAdapters.NguoiDungTableAdapter nguoiDungTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DataSet1TableAdapters.NguoiDungNhomNguoiDung_DkTableAdapter nguoiDungNhomNguoiDung_DkTableAdapter;
        private System.Windows.Forms.DataGridView nguoiDungDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource nguoiDungNhomNguoiDung_DkBindingSource;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource1;
        private System.Windows.Forms.DataGridView nguoiDungNhomNguoiDung_DkDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource nguoiDungNhomNguoiDungBindingSource;
        private DataSet1TableAdapters.NguoiDungNhomNguoiDungTableAdapter nguoiDungNhomNguoiDungTableAdapter;
        private System.Windows.Forms.BindingSource nhomNguoiDungBindingSource;
        private DataSet1TableAdapters.NhomNguoiDungTableAdapter nhomNguoiDungTableAdapter;
        private System.Windows.Forms.ComboBox nhomNguoiDungComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}