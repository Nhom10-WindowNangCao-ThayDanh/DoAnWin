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
            this.tendangnhapTextBox = new System.Windows.Forms.TextBox();
            this.matkhauTextBox = new System.Windows.Forms.TextBox();
            this.hoatDongCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            tendangnhapLabel = new System.Windows.Forms.Label();
            matkhauLabel = new System.Windows.Forms.Label();
            hoatDongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.NguoiDungNhomNguoiDung_DkTableAdapter = null;
            this.tableAdapterManager.NguoiDungTableAdapter = this.nguoiDungTableAdapter;
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
            this.nguoiDungDataGridView.Location = new System.Drawing.Point(12, 119);
            this.nguoiDungDataGridView.Name = "nguoiDungDataGridView";
            this.nguoiDungDataGridView.Size = new System.Drawing.Size(343, 220);
            this.nguoiDungDataGridView.TabIndex = 0;
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
            // tendangnhapLabel
            // 
            tendangnhapLabel.AutoSize = true;
            tendangnhapLabel.Location = new System.Drawing.Point(393, 119);
            tendangnhapLabel.Name = "tendangnhapLabel";
            tendangnhapLabel.Size = new System.Drawing.Size(73, 13);
            tendangnhapLabel.TabIndex = 1;
            tendangnhapLabel.Text = "tendangnhap:";
            // 
            // tendangnhapTextBox
            // 
            this.tendangnhapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nguoiDungBindingSource, "tendangnhap", true));
            this.tendangnhapTextBox.Location = new System.Drawing.Point(472, 116);
            this.tendangnhapTextBox.Name = "tendangnhapTextBox";
            this.tendangnhapTextBox.Size = new System.Drawing.Size(104, 20);
            this.tendangnhapTextBox.TabIndex = 2;
            // 
            // matkhauLabel
            // 
            matkhauLabel.AutoSize = true;
            matkhauLabel.Location = new System.Drawing.Point(393, 145);
            matkhauLabel.Name = "matkhauLabel";
            matkhauLabel.Size = new System.Drawing.Size(51, 13);
            matkhauLabel.TabIndex = 3;
            matkhauLabel.Text = "matkhau:";
            // 
            // matkhauTextBox
            // 
            this.matkhauTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nguoiDungBindingSource, "matkhau", true));
            this.matkhauTextBox.Location = new System.Drawing.Point(472, 142);
            this.matkhauTextBox.Name = "matkhauTextBox";
            this.matkhauTextBox.Size = new System.Drawing.Size(104, 20);
            this.matkhauTextBox.TabIndex = 4;
            // 
            // hoatDongLabel
            // 
            hoatDongLabel.AutoSize = true;
            hoatDongLabel.Location = new System.Drawing.Point(393, 173);
            hoatDongLabel.Name = "hoatDongLabel";
            hoatDongLabel.Size = new System.Drawing.Size(62, 13);
            hoatDongLabel.TabIndex = 5;
            hoatDongLabel.Text = "Hoat Dong:";
            // 
            // hoatDongCheckBox
            // 
            this.hoatDongCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.nguoiDungBindingSource, "HoatDong", true));
            this.hoatDongCheckBox.Location = new System.Drawing.Point(472, 168);
            this.hoatDongCheckBox.Name = "hoatDongCheckBox";
            this.hoatDongCheckBox.Size = new System.Drawing.Size(104, 24);
            this.hoatDongCheckBox.TabIndex = 6;
            this.hoatDongCheckBox.Text = "checkBox1";
            this.hoatDongCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(558, 225);
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
            this.ClientSize = new System.Drawing.Size(730, 415);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(tendangnhapLabel);
            this.Controls.Add(this.tendangnhapTextBox);
            this.Controls.Add(matkhauLabel);
            this.Controls.Add(this.matkhauTextBox);
            this.Controls.Add(hoatDongLabel);
            this.Controls.Add(this.hoatDongCheckBox);
            this.Controls.Add(this.nguoiDungDataGridView);
            this.Name = "ThemNguoiDung";
            this.Text = "ThemNguoiDung";
            this.Load += new System.EventHandler(this.ThemNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungDataGridView)).EndInit();
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
        private System.Windows.Forms.TextBox tendangnhapTextBox;
        private System.Windows.Forms.TextBox matkhauTextBox;
        private System.Windows.Forms.CheckBox hoatDongCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}