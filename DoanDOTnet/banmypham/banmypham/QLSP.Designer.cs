namespace banmypham
{
    partial class QLSP
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
            this.lvssp = new System.Windows.Forms.ListView();
            this.masp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tensp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dongia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.donvitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tencd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txtmt = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtdvt = new System.Windows.Forms.TextBox();
            this.txtdg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbcd = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvssp
            // 
            this.lvssp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.masp,
            this.tensp,
            this.dongia,
            this.donvitinh,
            this.mota,
            this.tencd});
            this.lvssp.Location = new System.Drawing.Point(12, 359);
            this.lvssp.Name = "lvssp";
            this.lvssp.Size = new System.Drawing.Size(805, 241);
            this.lvssp.TabIndex = 0;
            this.lvssp.UseCompatibleStateImageBehavior = false;
            this.lvssp.View = System.Windows.Forms.View.Details;
            this.lvssp.SelectedIndexChanged += new System.EventHandler(this.lvssp_SelectedIndexChanged);
            // 
            // masp
            // 
            this.masp.Text = "Mã Sản Phẩm";
            this.masp.Width = 145;
            // 
            // tensp
            // 
            this.tensp.Text = "Tên Sản Phẩm";
            this.tensp.Width = 145;
            // 
            // dongia
            // 
            this.dongia.Text = "Đơn Giá";
            this.dongia.Width = 91;
            // 
            // donvitinh
            // 
            this.donvitinh.Text = "Đơn vị tính";
            this.donvitinh.Width = 109;
            // 
            // mota
            // 
            this.mota.Text = "Mô Tả";
            this.mota.Width = 111;
            // 
            // tencd
            // 
            this.tencd.Text = "Tên Chủ Đề";
            this.tencd.Width = 255;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbcd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdg);
            this.groupBox1.Controls.Add(this.txtdvt);
            this.groupBox1.Controls.Add(this.txttensp);
            this.groupBox1.Controls.Add(this.txtmt);
            this.groupBox1.Controls.Add(this.txtmasp);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(170, 34);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(171, 22);
            this.txtmasp.TabIndex = 0;
            // 
            // txtmt
            // 
            this.txtmt.Location = new System.Drawing.Point(526, 65);
            this.txtmt.Name = "txtmt";
            this.txtmt.Size = new System.Drawing.Size(169, 22);
            this.txtmt.TabIndex = 2;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(525, 34);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(170, 22);
            this.txttensp.TabIndex = 3;
            // 
            // txtdvt
            // 
            this.txtdvt.Location = new System.Drawing.Point(170, 90);
            this.txtdvt.Name = "txtdvt";
            this.txtdvt.Size = new System.Drawing.Size(171, 22);
            this.txtdvt.TabIndex = 4;
            // 
            // txtdg
            // 
            this.txtdg.Location = new System.Drawing.Point(170, 62);
            this.txtdg.Name = "txtdg";
            this.txtdg.Size = new System.Drawing.Size(171, 22);
            this.txtdg.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên chủ đề";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mô tả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Đơn vị tính";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(742, 277);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 53);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(661, 277);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 53);
            this.btnhuy.TabIndex = 3;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(580, 277);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 53);
            this.btnluu.TabIndex = 4;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(499, 277);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 53);
            this.btnsua.TabIndex = 5;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(337, 277);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 53);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(418, 277);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 53);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(223, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(412, 46);
            this.label8.TabIndex = 8;
            this.label8.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // cbbcd
            // 
            this.cbbcd.FormattingEnabled = true;
            this.cbbcd.Items.AddRange(new object[] {
            "",
            "Sữa Rửa Mặt",
            "Toner Nước Hoa Hồng",
            "Dưỡng Ẩm",
            "Serum Tinh Dưỡng",
            "Dưỡng Trắng",
            "Chống Lão Hóa",
            "Chăm Sóc Vùng Da Mắt",
            "Trị Mụn",
            "Lotion Dưỡng Ẩm",
            "Tinh Chất Dưỡng",
            "Dưỡng Trắng",
            "Chống Lão Hóa",
            "Chăm Sóc Da Mặt",
            "Mặt Nạ Dưỡng Da",
            "Chống Nắng Bảo Vệ Da"});
            this.cbbcd.Location = new System.Drawing.Point(526, 95);
            this.cbbcd.Name = "cbbcd";
            this.cbbcd.Size = new System.Drawing.Size(169, 24);
            this.cbbcd.TabIndex = 13;
            // 
            // QLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 612);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvssp);
            this.Name = "QLSP";
            this.Text = "QLSP";
            this.Load += new System.EventHandler(this.QLSP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvssp;
        private System.Windows.Forms.ColumnHeader masp;
        private System.Windows.Forms.ColumnHeader tensp;
        private System.Windows.Forms.ColumnHeader dongia;
        private System.Windows.Forms.ColumnHeader donvitinh;
        private System.Windows.Forms.ColumnHeader mota;
        private System.Windows.Forms.ColumnHeader tencd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbcd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdg;
        private System.Windows.Forms.TextBox txtdvt;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtmt;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label label8;
    }
}