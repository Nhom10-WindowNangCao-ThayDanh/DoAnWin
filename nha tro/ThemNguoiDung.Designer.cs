namespace nha_tro
{
    partial class ThemNguoiDung
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
            System.Windows.Forms.Label tendangnhapLabel;
            System.Windows.Forms.Label matkhauLabel;
            System.Windows.Forms.Label hoatDongLabel;
            this.dataSet1 = new nha_tro.DataSet1();
            this.nguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiDungTableAdapter = new nha_tro.DataSet1TableAdapters.NguoiDungTableAdapter();
            this.tableAdapterManager = new nha_tro.DataSet1TableAdapters.TableAdapterManager();
            this.nguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tendangnhapTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.matkhauTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hoatDongCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.Thêm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            tendangnhapLabel = new System.Windows.Forms.Label();
            matkhauLabel = new System.Windows.Forms.Label();
            hoatDongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tendangnhapTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matkhauTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoatDongCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tendangnhapLabel
            // 
            tendangnhapLabel.AutoSize = true;
            tendangnhapLabel.Location = new System.Drawing.Point(512, 125);
            tendangnhapLabel.Name = "tendangnhapLabel";
            tendangnhapLabel.Size = new System.Drawing.Size(73, 13);
            tendangnhapLabel.TabIndex = 1;
            tendangnhapLabel.Text = "tendangnhap:";
            // 
            // matkhauLabel
            // 
            matkhauLabel.AutoSize = true;
            matkhauLabel.Location = new System.Drawing.Point(512, 151);
            matkhauLabel.Name = "matkhauLabel";
            matkhauLabel.Size = new System.Drawing.Size(51, 13);
            matkhauLabel.TabIndex = 3;
            matkhauLabel.Text = "matkhau:";
            // 
            // hoatDongLabel
            // 
            hoatDongLabel.AutoSize = true;
            hoatDongLabel.Location = new System.Drawing.Point(512, 177);
            hoatDongLabel.Name = "hoatDongLabel";
            hoatDongLabel.Size = new System.Drawing.Size(62, 13);
            hoatDongLabel.TabIndex = 5;
            hoatDongLabel.Text = "Hoat Dong:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nguoiDungBindingSource
            // 
            this.nguoiDungBindingSource.DataMember = "NguoiDung";
            this.nguoiDungBindingSource.DataSource = this.dataSet1;
            // 
            // nguoiDungTableAdapter
            // 
            this.nguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HOPDONGTableAdapter = null;
            this.tableAdapterManager.NguoiDungNhomNguoiDung_DkTableAdapter = null;
            this.tableAdapterManager.NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.NguoiDungTableAdapter = this.nguoiDungTableAdapter;
            this.tableAdapterManager.NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.PhanQuyenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = nha_tro.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.nguoiDungDataGridView.Location = new System.Drawing.Point(12, 84);
            this.nguoiDungDataGridView.Name = "nguoiDungDataGridView";
            this.nguoiDungDataGridView.Size = new System.Drawing.Size(334, 220);
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
            // tendangnhapTextEdit
            // 
            this.tendangnhapTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nguoiDungBindingSource, "tendangnhap", true));
            this.tendangnhapTextEdit.Location = new System.Drawing.Point(591, 122);
            this.tendangnhapTextEdit.Name = "tendangnhapTextEdit";
            this.tendangnhapTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tendangnhapTextEdit.TabIndex = 2;
            // 
            // matkhauTextEdit
            // 
            this.matkhauTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nguoiDungBindingSource, "matkhau", true));
            this.matkhauTextEdit.Location = new System.Drawing.Point(591, 148);
            this.matkhauTextEdit.Name = "matkhauTextEdit";
            this.matkhauTextEdit.Size = new System.Drawing.Size(100, 20);
            this.matkhauTextEdit.TabIndex = 4;
            // 
            // hoatDongCheckEdit
            // 
            this.hoatDongCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nguoiDungBindingSource, "HoatDong", true));
            this.hoatDongCheckEdit.Location = new System.Drawing.Point(591, 174);
            this.hoatDongCheckEdit.Name = "hoatDongCheckEdit";
            this.hoatDongCheckEdit.Properties.Caption = "checkEdit1";
            this.hoatDongCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.hoatDongCheckEdit.TabIndex = 6;
            // 
            // Thêm
            // 
            this.Thêm.Location = new System.Drawing.Point(396, 234);
            this.Thêm.Name = "Thêm";
            this.Thêm.Size = new System.Drawing.Size(75, 23);
            this.Thêm.TabIndex = 7;
            this.Thêm.Text = "Thêm";
            this.Thêm.UseVisualStyleBackColor = true;
            this.Thêm.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(645, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cập nhật";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ThemNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 356);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Thêm);
            this.Controls.Add(tendangnhapLabel);
            this.Controls.Add(this.tendangnhapTextEdit);
            this.Controls.Add(matkhauLabel);
            this.Controls.Add(this.matkhauTextEdit);
            this.Controls.Add(hoatDongLabel);
            this.Controls.Add(this.hoatDongCheckEdit);
            this.Controls.Add(this.nguoiDungDataGridView);
            this.Name = "ThemNguoiDung";
            this.Text = "ThemNguoiDung";
            this.Load += new System.EventHandler(this.ThemNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tendangnhapTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matkhauTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoatDongCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource;
        private DataSet1TableAdapters.NguoiDungTableAdapter nguoiDungTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nguoiDungDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DevExpress.XtraEditors.TextEdit tendangnhapTextEdit;
        private DevExpress.XtraEditors.TextEdit matkhauTextEdit;
        private DevExpress.XtraEditors.CheckEdit hoatDongCheckEdit;
        private System.Windows.Forms.Button Thêm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}