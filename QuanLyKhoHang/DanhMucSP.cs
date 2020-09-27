﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhoHang
{
    public partial class DanhMucSP : Form
    {
        Connection con = new Connection();
        private string MAKHO;
        private int key = 0;
        public DanhMucSP()
        {
            InitializeComponent();
        }
        public void cleartext()
        {
            tbx_ghichu.Clear();
            tbx_madm.Clear();
            tbx_makho.ResetText();
            tbx_tendm.Clear();


        }
        public void Disable()
        {
            tbx_madm.Enabled = false; tbx_makho.Enabled = false; tbx_tendm.Enabled = false; tbx_ghichu.Enabled = false;
        }
        public void Enable()
        {
            tbx_madm.Enabled = true; tbx_makho.Enabled = true; tbx_tendm.Enabled = true; tbx_ghichu.Enabled = true; tbx_tendm.Focus();
        }

       
        private void DanhMucSP_Load(object sender, EventArgs e)
        {
            tbx_madm.Text = " ";
            Disable();
            bt_xoa.Enabled = true;
            tbx_tendm.Focus();
            con.AutoCompletecbx(tbx_makho, "SELECT TENKHO FROM KHOHANG", "TENKHO");
            tbx_madm.Enabled = false;
            dgvDANHMUC.DataSource = con.Select_Data("SELECT DM.MADANHMUC,TENDANHMUC,KHOHANG.TENKHO,DM.GHICHU from DANHMUC DM left join KHOHANG on KHOHANG.MAKHO=DM.MAKHO");
            dgvDANHMUC.ClearSelection();

            //hiển thị tiêu đề của các cột:
            dgvDANHMUC.Columns[0].HeaderText = "Mã Danh Mục";
            dgvDANHMUC.Columns[1].HeaderText = "Tên Danh Mục";
            dgvDANHMUC.Columns[2].HeaderText = "Tên Kho";
            dgvDANHMUC.Columns[3].HeaderText = "Ghi Chú";

            //căn độ rộng cột:
            dgvDANHMUC.Columns[1].Width = 200;
            dgvDANHMUC.Columns[2].Width = 250;
            dgvDANHMUC.Columns[3].Width = 300;


            btn_ghinhan.Enabled = false;
            bt_them.Enabled = true;
            bt_xoa.Enabled = true;
            bt_chophepsua.Enabled = true;
        }

        private void vềTtrangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu home = new MainMenu();
            home.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát khỏi danh mục sản phẩm ?","Quản lý kho hàng",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
        private void bt_them_Click(object sender, EventArgs e)
        {
            cleartext();
            tbx_tendm.Focus();
            Enable();
            tbx_madm.Enabled = false;
            key = 1;
            bt_them.Enabled = false;
            bt_xoa.Enabled = false;
            bt_chophepsua.Enabled = false;
            btn_ghinhan.Enabled = true;
        }

       
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            bt_xoa.Enabled = false;
            bt_them.Enabled = false;
            bt_chophepsua.Enabled = false;
            btn_ghinhan.Enabled = true;
            key = 3;
            Disable();
            tbx_madm.Enabled = true;
        }

        
        private void bt_chophepsua_Click(object sender, EventArgs e)
        {
            Enable();
            bt_xoa.Enabled = false;
            bt_them.Enabled = false;
            bt_chophepsua.Enabled = false;
            btn_ghinhan.Enabled = true;
            key = 2;
            tbx_madm.Enabled = false;
        }

       
        public DataTable ThongTinMaKho(string Text)
        {
            SqlDataReader a = con.ExecuteReader("Select MAKHO FROM KHOHANG WHERE TENKHO LIKE N'" + Text + "'");
            while (a.Read())
            {
                MAKHO = a["MAKHO"].ToString().Trim();
            }
            return null;
        }

       
        private void btn_ghinhan_Click(object sender, EventArgs e)
        {
            if (key == 1)
            {
                if (tbx_tendm.Text == "" || tbx_makho.Text == "")
                {
                    MessageBox.Show("Hãy Nhập đủ thông tin vào các trường", "ThônG Báo");
                    tbx_madm.Focus();

                }
                else
                {
                    var itemMakho = tbx_makho.GetItemText(tbx_makho.SelectedItem);
                    ThongTinMaKho(itemMakho);
                    DataTable dtdm = con.CheckSql("SELECT * From DANHMUC where MADANHMUC='" + tbx_madm.Text + "'");
                    if (dtdm.Rows.Count > 0)
                    {
                        MessageBox.Show("Mã Danh Mục đã Tồn tại!", "Cảnh báo");
                        tbx_madm.Clear();
                        tbx_madm.Focus();
                    }
                    else
                    {

                        con.THEM_DANHMUC(tbx_madm.Text, tbx_tendm.Text, tbx_ghichu.Text, MAKHO);
                        DanhMucSP_Load(sender, e);
                        MessageBox.Show("Thêm THành Công Danh Mục!", "Thông Báo");
                        //lb_thongbao.Text = "Thêm Thành Công";
                        cleartext();
                        tbx_tendm.Focus();
                    }
                }


            }
            if (key == 2)
            {
                if (tbx_madm.Text == "" || dgvDANHMUC.SelectedRows == null)
                {
                    MessageBox.Show("Hãy Nhập Mã Danh mục cần sửa đổi hoặc chọn trực tiếp trên bảng", "Cảnh báo");
                    tbx_madm.Focus();
                }
                else
                {
                    var itemMakho = tbx_makho.GetItemText(tbx_makho.SelectedItem);
                    ThongTinMaKho(itemMakho);
                    con.SUA_DANHMUC(tbx_madm.Text, tbx_tendm.Text, tbx_ghichu.Text, MAKHO);
                    DanhMucSP_Load(sender, e);
                    cleartext();
                    //lb_thongbao.Text = "Sửa Thành Công";

                }
            }
            if (key == 3)
            {
                if (tbx_madm.Text == "" || dgvDANHMUC.SelectedRows == null)
                {
                    MessageBox.Show("Hãy Nhập thông tin mã Danh Mục cần xóa hoặc chọn trên Bảng Dữ liệu");
                    tbx_madm.Focus();
                    tbx_madm.Enabled = true;
                    tbx_madm.BackColor = Color.White;
                }
                else
                {
                    if (MessageBox.Show("Bạn có Chắc chắn muốn xóa danh mục này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.XOA_DANHMUC("UPDATE SANPHAM SET MADANHMUC=NULL WHERE MADANHMUC='" + tbx_madm.Text + "'");
                        con.XOA_DANHMUC(tbx_madm.Text);
                        DanhMucSP_Load(sender, e);
                        //lb_thongbao.Text = "Xóa Thành Công";
                        cleartext();
                    }
                }
            }

        }

        //Chưa làm
        private void button_lammoi_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        //Chưa làm
        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            
        }

        //Chưa làm
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        //Chưa làm
        private void dgvDANHMUC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //Chưa làm
        private void tbx_madm_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DanhMucSP_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu mn = new MainMenu();
            mn.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }
    }
}
