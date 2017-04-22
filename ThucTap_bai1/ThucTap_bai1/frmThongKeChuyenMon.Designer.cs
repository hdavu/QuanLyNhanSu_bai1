namespace ThucTap_bai1
{
    partial class frmThongKeChuyenMon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboThongke = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTrinhdo = new System.Windows.Forms.ComboBox();
            this.trinhdoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHUCTAP5QuanLyNhanSuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.___THUCTAP5___QuanLyNhanSuDataSet = new ThucTap_bai1.@__THUCTAP5___QuanLyNhanSuDataSet();
            this.cboPhongban = new System.Windows.Forms.ComboBox();
            this.phongbanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboChuyenmon = new System.Windows.Forms.ComboBox();
            this.chuyenmonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboChucvu = new System.Windows.Forms.ComboBox();
            this.chucvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.trinhdoTableAdapter = new ThucTap_bai1.@__THUCTAP5___QuanLyNhanSuDataSetTableAdapters.trinhdoTableAdapter();
            this.phongbanTableAdapter = new ThucTap_bai1.@__THUCTAP5___QuanLyNhanSuDataSetTableAdapters.phongbanTableAdapter();
            this.chuyenmonTableAdapter = new ThucTap_bai1.@__THUCTAP5___QuanLyNhanSuDataSetTableAdapters.chuyenmonTableAdapter();
            this.chucvuTableAdapter = new ThucTap_bai1.@__THUCTAP5___QuanLyNhanSuDataSetTableAdapters.chucvuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhdoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUCTAP5QuanLyNhanSuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.___THUCTAP5___QuanLyNhanSuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenmonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // cboThongke
            // 
            this.cboThongke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThongke.Items.AddRange(new object[] {
            "Phòng ban",
            "Chuyên môn",
            "Trình độ",
            "Chức vụ"});
            this.cboThongke.Location = new System.Drawing.Point(109, 234);
            this.cboThongke.Name = "cboThongke";
            this.cboThongke.Size = new System.Drawing.Size(168, 21);
            this.cboThongke.TabIndex = 1;
            this.cboThongke.SelectedIndexChanged += new System.EventHandler(this.cboThongke_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thống kê theo:";
            // 
            // cboTrinhdo
            // 
            this.cboTrinhdo.DataSource = this.trinhdoBindingSource;
            this.cboTrinhdo.DisplayMember = "tentrinhdo";
            this.cboTrinhdo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrinhdo.Enabled = false;
            this.cboTrinhdo.Location = new System.Drawing.Point(335, 288);
            this.cboTrinhdo.Name = "cboTrinhdo";
            this.cboTrinhdo.Size = new System.Drawing.Size(181, 21);
            this.cboTrinhdo.TabIndex = 3;
            this.cboTrinhdo.ValueMember = "ma";
            this.cboTrinhdo.SelectedIndexChanged += new System.EventHandler(this.cboTrinhdo_SelectedIndexChanged);
            // 
            // trinhdoBindingSource
            // 
            this.trinhdoBindingSource.DataMember = "trinhdo";
            this.trinhdoBindingSource.DataSource = this.tHUCTAP5QuanLyNhanSuDataSetBindingSource;
            // 
            // tHUCTAP5QuanLyNhanSuDataSetBindingSource
            // 
            this.tHUCTAP5QuanLyNhanSuDataSetBindingSource.DataSource = this.___THUCTAP5___QuanLyNhanSuDataSet;
            this.tHUCTAP5QuanLyNhanSuDataSetBindingSource.Position = 0;
            // 
            // ___THUCTAP5___QuanLyNhanSuDataSet
            // 
            this.___THUCTAP5___QuanLyNhanSuDataSet.DataSetName = "__THUCTAP5___QuanLyNhanSuDataSet";
            this.___THUCTAP5___QuanLyNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboPhongban
            // 
            this.cboPhongban.DataSource = this.phongbanBindingSource;
            this.cboPhongban.DisplayMember = "ten";
            this.cboPhongban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongban.Enabled = false;
            this.cboPhongban.FormattingEnabled = true;
            this.cboPhongban.Location = new System.Drawing.Point(335, 234);
            this.cboPhongban.Name = "cboPhongban";
            this.cboPhongban.Size = new System.Drawing.Size(181, 21);
            this.cboPhongban.TabIndex = 3;
            this.cboPhongban.ValueMember = "ma";
            this.cboPhongban.SelectedIndexChanged += new System.EventHandler(this.cboPhongban_SelectedIndexChanged);
            // 
            // phongbanBindingSource
            // 
            this.phongbanBindingSource.DataMember = "phongban";
            this.phongbanBindingSource.DataSource = this.tHUCTAP5QuanLyNhanSuDataSetBindingSource;
            // 
            // cboChuyenmon
            // 
            this.cboChuyenmon.DataSource = this.chuyenmonBindingSource;
            this.cboChuyenmon.DisplayMember = "tenchuyenmon";
            this.cboChuyenmon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenmon.Enabled = false;
            this.cboChuyenmon.FormattingEnabled = true;
            this.cboChuyenmon.Location = new System.Drawing.Point(335, 261);
            this.cboChuyenmon.Name = "cboChuyenmon";
            this.cboChuyenmon.Size = new System.Drawing.Size(181, 21);
            this.cboChuyenmon.TabIndex = 3;
            this.cboChuyenmon.ValueMember = "ma";
            this.cboChuyenmon.SelectedIndexChanged += new System.EventHandler(this.cboChuyenmon_SelectedIndexChanged);
            // 
            // chuyenmonBindingSource
            // 
            this.chuyenmonBindingSource.DataMember = "chuyenmon";
            this.chuyenmonBindingSource.DataSource = this.tHUCTAP5QuanLyNhanSuDataSetBindingSource;
            // 
            // cboChucvu
            // 
            this.cboChucvu.DataSource = this.chucvuBindingSource;
            this.cboChucvu.DisplayMember = "ten";
            this.cboChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucvu.Enabled = false;
            this.cboChucvu.FormattingEnabled = true;
            this.cboChucvu.Location = new System.Drawing.Point(335, 315);
            this.cboChucvu.Name = "cboChucvu";
            this.cboChucvu.Size = new System.Drawing.Size(181, 21);
            this.cboChucvu.TabIndex = 3;
            this.cboChucvu.ValueMember = "ma";
            this.cboChucvu.SelectedIndexChanged += new System.EventHandler(this.cboChucvu_SelectedIndexChanged);
            // 
            // chucvuBindingSource
            // 
            this.chucvuBindingSource.DataMember = "chucvu";
            this.chucvuBindingSource.DataSource = this.tHUCTAP5QuanLyNhanSuDataSetBindingSource;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(26, 313);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(77, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // trinhdoTableAdapter
            // 
            this.trinhdoTableAdapter.ClearBeforeFill = true;
            // 
            // phongbanTableAdapter
            // 
            this.phongbanTableAdapter.ClearBeforeFill = true;
            // 
            // chuyenmonTableAdapter
            // 
            this.chuyenmonTableAdapter.ClearBeforeFill = true;
            // 
            // chucvuTableAdapter
            // 
            this.chucvuTableAdapter.ClearBeforeFill = true;
            // 
            // frmThongKeChuyenMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 360);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cboChucvu);
            this.Controls.Add(this.cboChuyenmon);
            this.Controls.Add(this.cboPhongban);
            this.Controls.Add(this.cboTrinhdo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboThongke);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmThongKeChuyenMon";
            this.Text = "Thống kê chuyên môn";
            this.Load += new System.EventHandler(this.frmThongKeChuyenMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhdoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUCTAP5QuanLyNhanSuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.___THUCTAP5___QuanLyNhanSuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenmonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboThongke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTrinhdo;
        private System.Windows.Forms.ComboBox cboPhongban;
        private System.Windows.Forms.ComboBox cboChuyenmon;
        private System.Windows.Forms.ComboBox cboChucvu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.BindingSource tHUCTAP5QuanLyNhanSuDataSetBindingSource;
        private __THUCTAP5___QuanLyNhanSuDataSet ___THUCTAP5___QuanLyNhanSuDataSet;
        private System.Windows.Forms.BindingSource trinhdoBindingSource;
        private __THUCTAP5___QuanLyNhanSuDataSetTableAdapters.trinhdoTableAdapter trinhdoTableAdapter;
        private System.Windows.Forms.BindingSource phongbanBindingSource;
        private __THUCTAP5___QuanLyNhanSuDataSetTableAdapters.phongbanTableAdapter phongbanTableAdapter;
        private System.Windows.Forms.BindingSource chuyenmonBindingSource;
        private __THUCTAP5___QuanLyNhanSuDataSetTableAdapters.chuyenmonTableAdapter chuyenmonTableAdapter;
        private System.Windows.Forms.BindingSource chucvuBindingSource;
        private __THUCTAP5___QuanLyNhanSuDataSetTableAdapters.chucvuTableAdapter chucvuTableAdapter;
    }
}