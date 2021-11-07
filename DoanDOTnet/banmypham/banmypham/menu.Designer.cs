namespace banmypham
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ttkh = new System.Windows.Forms.ToolStripButton();
            this.ttsp = new System.Windows.Forms.ToolStripButton();
            this.ttnsx = new System.Windows.Forms.ToolStripButton();
            this.ttdx = new System.Windows.Forms.ToolStripButton();
            this.ttttsv = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttkh,
            this.ttsp,
            this.ttnsx,
            this.ttdx,
            this.ttttsv});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(829, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ttkh
            // 
            this.ttkh.Image = ((System.Drawing.Image)(resources.GetObject("ttkh.Image")));
            this.ttkh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttkh.Name = "ttkh";
            this.ttkh.Size = new System.Drawing.Size(129, 24);
            this.ttkh.Text = "KHÁCH HÀNG";
            this.ttkh.Click += new System.EventHandler(this.ttkh_Click);
            // 
            // ttsp
            // 
            this.ttsp.Image = ((System.Drawing.Image)(resources.GetObject("ttsp.Image")));
            this.ttsp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttsp.Name = "ttsp";
            this.ttsp.Size = new System.Drawing.Size(108, 24);
            this.ttsp.Text = "SẢN PHẨM";
            this.ttsp.Click += new System.EventHandler(this.ttsp_Click);
            // 
            // ttnsx
            // 
            this.ttnsx.Image = ((System.Drawing.Image)(resources.GetObject("ttnsx.Image")));
            this.ttnsx.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttnsx.Name = "ttnsx";
            this.ttnsx.Size = new System.Drawing.Size(139, 24);
            this.ttnsx.Text = "NHÀ SẢN XUẤT";
            this.ttnsx.Click += new System.EventHandler(this.ttnsx_Click);
            // 
            // ttdx
            // 
            this.ttdx.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ttdx.Image = ((System.Drawing.Image)(resources.GetObject("ttdx.Image")));
            this.ttdx.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttdx.Name = "ttdx";
            this.ttdx.Size = new System.Drawing.Size(116, 24);
            this.ttdx.Text = "ĐĂNG XUẤT";
            this.ttdx.Click += new System.EventHandler(this.ttdx_Click);
            // 
            // ttttsv
            // 
            this.ttttsv.Image = ((System.Drawing.Image)(resources.GetObject("ttttsv.Image")));
            this.ttttsv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttttsv.Name = "ttttsv";
            this.ttttsv.Size = new System.Drawing.Size(185, 24);
            this.ttttsv.Text = "THÔNG TIN SINH VIÊN";
            this.ttttsv.Click += new System.EventHandler(this.ttttsv_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "In số khách hàng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "In thông tin chi tiết hóa đơn";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cyan;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "In số hóa đơn đã có";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Cyan;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "In nhà sản xuất";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(311, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(279, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "CỬA HÀNG BÁN MỸ PHẨM";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::banmypham.Properties.Resources.hinh_nen_hoa_tuyet_trong_nang_052337129;
            this.ClientSize = new System.Drawing.Size(829, 307);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "menu";
            this.Text = "Phần mềm quản lý cửa hàng bán mỹ phẩm";
            this.Load += new System.EventHandler(this.menu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ttkh;
        private System.Windows.Forms.ToolStripButton ttsp;
        private System.Windows.Forms.ToolStripButton ttnsx;
        private System.Windows.Forms.ToolStripButton ttdx;
        private System.Windows.Forms.ToolStripButton ttttsv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}