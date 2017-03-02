namespace ThucTap_bai1
{
    partial class Form1
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tim_kiem_tenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tim_kiem_que_quanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tim_kiem_dia_chiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tìmTheochứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmTheoPhòngBanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thong_ke_thu_nhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.thong_ke_chuyen_monToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huong_danToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.thong_tinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danh_sachdataGridView1 = new System.Windows.Forms.DataGridView();
            this.ho_so_chi_tietgroupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danh_sachdataGridView1)).BeginInit();
            this.ho_so_chi_tietgroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.hỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.fileToolStripMenuItem.Text = "&Quản lý";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themToolStripMenuItem,
            this.suaToolStripMenuItem,
            this.xoaToolStripMenuItem});
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.newToolStripMenuItem.Text = "&Nhân viên";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // themToolStripMenuItem
            // 
            this.themToolStripMenuItem.Name = "themToolStripMenuItem";
            this.themToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.themToolStripMenuItem.Text = "&Thêm";
            // 
            // suaToolStripMenuItem
            // 
            this.suaToolStripMenuItem.Name = "suaToolStripMenuItem";
            this.suaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.suaToolStripMenuItem.Text = "&Sửa";
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xoaToolStripMenuItem.Text = "&Xóa";
            this.xoaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(168, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phòngBanToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem1.Text = "&Lương";
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.phòngBanToolStripMenuItem.Text = "Phòng ban";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.toolStripSeparator4,
            this.tìmTheochứcVụToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.toolsToolStripMenuItem.Text = "&Tìm kiếm";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tim_kiem_tenToolStripMenuItem,
            this.tim_kiem_que_quanToolStripMenuItem,
            this.tim_kiem_dia_chiToolStripMenuItem});
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customizeToolStripMenuItem.Text = "Theo &cá nhân";
            // 
            // tim_kiem_tenToolStripMenuItem
            // 
            this.tim_kiem_tenToolStripMenuItem.Name = "tim_kiem_tenToolStripMenuItem";
            this.tim_kiem_tenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tim_kiem_tenToolStripMenuItem.Text = "&Tên";
            // 
            // tim_kiem_que_quanToolStripMenuItem
            // 
            this.tim_kiem_que_quanToolStripMenuItem.Name = "tim_kiem_que_quanToolStripMenuItem";
            this.tim_kiem_que_quanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tim_kiem_que_quanToolStripMenuItem.Text = "&Quê quán";
            // 
            // tim_kiem_dia_chiToolStripMenuItem
            // 
            this.tim_kiem_dia_chiToolStripMenuItem.Name = "tim_kiem_dia_chiToolStripMenuItem";
            this.tim_kiem_dia_chiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tim_kiem_dia_chiToolStripMenuItem.Text = "Địa &chỉ";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // tìmTheochứcVụToolStripMenuItem
            // 
            this.tìmTheochứcVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmTheoPhòngBanToolStripMenuItem1,
            this.chứcVụToolStripMenuItem});
            this.tìmTheochứcVụToolStripMenuItem.Name = "tìmTheochứcVụToolStripMenuItem";
            this.tìmTheochứcVụToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tìmTheochứcVụToolStripMenuItem.Text = "Theo &tổ chức";
            // 
            // tìmTheoPhòngBanToolStripMenuItem1
            // 
            this.tìmTheoPhòngBanToolStripMenuItem1.Name = "tìmTheoPhòngBanToolStripMenuItem1";
            this.tìmTheoPhòngBanToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.tìmTheoPhòngBanToolStripMenuItem1.Text = "&Phòng ban";
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chứcVụToolStripMenuItem.Text = "&Chức vụ";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thong_ke_thu_nhapToolStripMenuItem,
            this.toolStripSeparator5,
            this.thong_ke_chuyen_monToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.helpToolStripMenuItem.Text = "&Thống kê";
            // 
            // thong_ke_thu_nhapToolStripMenuItem
            // 
            this.thong_ke_thu_nhapToolStripMenuItem.Name = "thong_ke_thu_nhapToolStripMenuItem";
            this.thong_ke_thu_nhapToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.thong_ke_thu_nhapToolStripMenuItem.Text = "&Theo mức thu nhập";
            this.thong_ke_thu_nhapToolStripMenuItem.Click += new System.EventHandler(this.contentsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(176, 6);
            // 
            // thong_ke_chuyen_monToolStripMenuItem
            // 
            this.thong_ke_chuyen_monToolStripMenuItem.Name = "thong_ke_chuyen_monToolStripMenuItem";
            this.thong_ke_chuyen_monToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.thong_ke_chuyen_monToolStripMenuItem.Text = "Theo chuyên môn";
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huong_danToolStripMenuItem,
            this.toolStripSeparator2,
            this.thong_tinToolStripMenuItem});
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // huong_danToolStripMenuItem
            // 
            this.huong_danToolStripMenuItem.Name = "huong_danToolStripMenuItem";
            this.huong_danToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.huong_danToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // thong_tinToolStripMenuItem
            // 
            this.thong_tinToolStripMenuItem.Name = "thong_tinToolStripMenuItem";
            this.thong_tinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thong_tinToolStripMenuItem.Text = "Thông tin";
            // 
            // danh_sachdataGridView1
            // 
            this.danh_sachdataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.danh_sachdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danh_sachdataGridView1.Location = new System.Drawing.Point(12, 272);
            this.danh_sachdataGridView1.Name = "danh_sachdataGridView1";
            this.danh_sachdataGridView1.Size = new System.Drawing.Size(711, 208);
            this.danh_sachdataGridView1.TabIndex = 1;
            this.danh_sachdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ho_so_chi_tietgroupBox1
            // 
            this.ho_so_chi_tietgroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label8);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label7);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label6);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label5);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.textBox5);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.textBox4);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label4);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label3);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label2);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.textBox3);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.textBox2);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.textBox1);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.label1);
            this.ho_so_chi_tietgroupBox1.Controls.Add(this.groupBox1);
            this.ho_so_chi_tietgroupBox1.Location = new System.Drawing.Point(12, 61);
            this.ho_so_chi_tietgroupBox1.Name = "ho_so_chi_tietgroupBox1";
            this.ho_so_chi_tietgroupBox1.Size = new System.Drawing.Size(711, 187);
            this.ho_so_chi_tietgroupBox1.TabIndex = 2;
            this.ho_so_chi_tietgroupBox1.TabStop = false;
            this.ho_so_chi_tietgroupBox1.Text = "Hồ sơ chi tiết";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(235, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phòng ban";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chuyên môn";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(235, 129);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(235, 167);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(112, 20);
            this.textBox5.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Trình độ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quê quán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ngày sinh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 492);
            this.Controls.Add(this.ho_so_chi_tietgroupBox1);
            this.Controls.Add(this.danh_sachdataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danh_sachdataGridView1)).EndInit();
            this.ho_so_chi_tietgroupBox1.ResumeLayout(false);
            this.ho_so_chi_tietgroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thong_ke_thu_nhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridView danh_sachdataGridView1;
        private System.Windows.Forms.GroupBox ho_so_chi_tietgroupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tim_kiem_tenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tim_kiem_que_quanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tim_kiem_dia_chiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmTheochứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmTheoPhòngBanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huong_danToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thong_tinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem thong_ke_chuyen_monToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
    }
}

