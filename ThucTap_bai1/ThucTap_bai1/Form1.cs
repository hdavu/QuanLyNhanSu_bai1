using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ThucTap_bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        SqlConnection con = new SqlConnection(@"Data Source=HDAVU\SQLEXPRESS;Initial Catalog=QuanLiNhanSu_TT;Integrated Security=True");

        private void KetNoiCSDL()
        {
            con.Open();
            string sql = "SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, nv.gioitinh , phongban.ten , trinhdo.tentrinhdo"
                + " FROM nhanvien nv"
                + " INNER JOIN phongban ON nv.phongbanma = phongban.ma"
                + " INNER JOIN trinhdo ON nv.trinhdoma = trinhdo.ma";

            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            // DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.Close();

            danh_sachdataGridView1.DataSource = ds.Tables[0].DefaultView;
            danh_sachdataGridView1.Columns["ten1"].HeaderText = "Phòng ban";
            danh_sachdataGridView1.Columns["tentrinhdo"].HeaderText = "Trình độ";
            //dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KetNoiCSDL();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void danh_sachdataGridView1_SelectionChanged(object sender, EventArgs e) // chon tat cac o
        {
            try
            {
                danh_sachdataGridView1.CurrentRow.Selected = true;
            }
            catch
            { }
        }


        private void LoadData() //hien hti du lieu len cac o textbox
        {
            //xoa trang cac o textbox
            txtHoTen.DataBindings.Clear();
            txtChucVu.DataBindings.Clear();
            txtChuyenMon.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtPhongBan.DataBindings.Clear();
            txtPhongBan.DataBindings.Clear();
            txtQueQuan.DataBindings.Clear();
            txtTonGiao.DataBindings.Clear();
            txtTrinhDo.DataBindings.Clear();



        }
    }
}
