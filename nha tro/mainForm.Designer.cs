namespace nha_tro
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNgườiDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNDVàoNhómToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chucToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chucToolStripMenuItem
            // 
            this.chucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmNgườiDungToolStripMenuItem,
            this.thêmNDVàoNhómToolStripMenuItem});
            this.chucToolStripMenuItem.Name = "chucToolStripMenuItem";
            this.chucToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.chucToolStripMenuItem.Text = "Chức Năng";
            // 
            // thêmNgườiDungToolStripMenuItem
            // 
            this.thêmNgườiDungToolStripMenuItem.Name = "thêmNgườiDungToolStripMenuItem";
            this.thêmNgườiDungToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.thêmNgườiDungToolStripMenuItem.Text = "Thêm Người Dung";
            this.thêmNgườiDungToolStripMenuItem.Click += new System.EventHandler(this.thêmNgườiDungToolStripMenuItem_Click);
            // 
            // thêmNDVàoNhómToolStripMenuItem
            // 
            this.thêmNDVàoNhómToolStripMenuItem.Name = "thêmNDVàoNhómToolStripMenuItem";
            this.thêmNDVàoNhómToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.thêmNDVàoNhómToolStripMenuItem.Text = "Thêm ND vào nhóm";
            this.thêmNDVàoNhómToolStripMenuItem.Click += new System.EventHandler(this.thêmNDVàoNhómToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 321);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "MainFrom";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNgườiDungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNDVàoNhómToolStripMenuItem;
    }
}