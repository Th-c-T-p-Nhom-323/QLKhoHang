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
using System.IO;

namespace QuanLyKhoHang
{
    public partial class SANPHAM : Form
    {
        public SANPHAM()
        {
            InitializeComponent();
        }
        private string[] DS_PhanLoai = new string[] { "Hàng Mới Quốc Tế", "Hàng Cũ Quốc Tế", "Hàng Xách Tay", "Hàng Xách Tay Cũ" };
        Connection acc = new Connection();
        
        public void ConverttoString(DateTime dt)
        {

        }
        
        
        public DataTable ThongTinNCC(string TEXT)
        {
            SqlDataReader a = acc.ExecuteReader("Select MANCC FROM NHACUNGCAP WHERE TENNHACC LIKE N'" + TEXT + "'");
            while (a.Read())
            {
                MANCC = a["MANCC"].ToString().Trim();
            }
            return null;
        }
        public DataTable ThongTinDM(string TEXT)
        {
            SqlDataReader a = acc.ExecuteReader("Select MADANHMUC FROM DANHMUC WHERE TENDANHMUC LIKE N'" + TEXT + "'");
            while (a.Read())
            {
                MADM = a["MADANHMUC"].ToString().Trim();
            }
            return null;
        }
        private void SANPHAM_Load(object sender, EventArgs e)
        {
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainmenu = new MainMenu();
            mainmenu.ShowDialog();
        }
        //them san pham
       
        //HIEN THỊ NỘI DUNG LÊN TEXTBOX
        private void dgv_SANPHAM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //sửa thông tin sản phẩm:
        private void button2_Click(object sender, EventArgs e)
        {
            Enable();
            tbx_masp.Enabled = false;
            btn_themmoi.Enabled = false;
            btn_xoa.Enabled = false;
            btn_chophepsua.Enabled = false;
            btn_ghinhan.Enabled = true;
            key = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbx_masp.Enabled = true;
            btn_themmoi.Enabled = false;
            btn_xoa.Enabled = false;
            btn_chophepsua.Enabled = false;
            btn_ghinhan.Enabled = true;
            key = 3;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SANPHAM_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SANPHAM_Load(sender, e);
            dgv_SANPHAM.ClearSelection();
            groupBox_DSSP.Text = "Danh Sách Sản Phẩm";

        }
        // Tìm kiếm sản phẩm
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            
        }

        private void txb_timkiem_Leave(object sender, EventArgs e)
        {
            if (txb_timkiem.Text == "")
            {
                txb_timkiem.Text = "Hãy nhập từ khóa tìm kiếm..";
            }
        }

        private void txb_timkiem_Enter(object sender, EventArgs e)
        {
            if (txb_timkiem.Text == "Hãy nhập từ khóa tìm kiếm..")
            {
                txb_timkiem.Text = "";
            }
        }

        private void SANPHAM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }
        // ghi nhan:
        private void button6_Click_1(object sender, EventArgs e)
        {
            
        }
        private void vềTrangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu home = new MainMenu();
            home.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Ứng Dụng", "Quản Lý KHo Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // chuc nang huy nhap:
        private void btn_huynhap_Click(object sender, EventArgs e)
        {
            cleartext();
        }
        // KẾT QUẢ TÌM KIẾM SẼ THAY ĐỔI KHI TỪ KHÓA THAY ĐỔI:
        private void txb_timkiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txb_soluong_ValueChanged(object sender, EventArgs e)
        {
            
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu home = new MainMenu();
            home.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtpicker_nsx_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpicker_hsd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txb_soluong_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
