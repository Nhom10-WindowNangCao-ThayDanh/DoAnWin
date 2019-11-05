namespace nha_tro
{
    partial class TrangThaiPhong
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.đặtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userControl11 = new ConTrol_TrangThaiPhong.UserControl1();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đặtPhòngToolStripMenuItem,
            this.thêmPhòngToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 48);
            // 
            // đặtPhòngToolStripMenuItem
            // 
            this.đặtPhòngToolStripMenuItem.Name = "đặtPhòngToolStripMenuItem";
            this.đặtPhòngToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.đặtPhòngToolStripMenuItem.Text = "Đặt Phòng";
            // 
            // thêmPhòngToolStripMenuItem
            // 
            this.thêmPhòngToolStripMenuItem.Name = "thêmPhòngToolStripMenuItem";
            this.thêmPhòngToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.thêmPhòngToolStripMenuItem.Text = "Thêm Phòng";
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(12, 6);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(973, 418);
            this.userControl11.TabIndex = 1;
            // 
            // TrangThaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 436);
            this.Controls.Add(this.userControl11);
            this.Name = "TrangThaiPhong";
            this.Text = "TrangThaiPhong";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrangThaiPhong_MouseClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đặtPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmPhòngToolStripMenuItem;
        private ConTrol_TrangThaiPhong.UserControl1 userControl11;
    }
}