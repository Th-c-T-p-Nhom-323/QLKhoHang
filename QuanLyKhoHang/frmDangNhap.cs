﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace QuanLyKhoHang
{
    public partial class DangNhapHeThong : Form
    {
        public static string QuyenHan = "";
        public static string USERNAME = "";
        public static string MaNV = "";
        public DangNhapHeThong()
        {
            InitializeComponent();
        }
        public DataTable QH(string UN)
        {
            Connection acc = new Connection();
            SqlDataReader a = acc.ExecuteReader("SELECT QUYENHAN FROM DANGNHAP WHERE USERNAME='" + UN + "'");
            while (a.Read())
            {
                QuyenHan = a["QUYENHAN"].ToString();

            }
            return null;
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            Connection acc = new Connection();
            string user = tbx_username.Text.Trim();
            string pass = tbx_password.Text.Trim();
            SqlDataReader reader = acc.ExecuteReader("select USERNAME,PASSWORD, QUYENHAN from DANGNHAP where USERNAME='" + user + "' and PASSWORD='" + pass + "'");
            if (reader.Read() == true)
            {
                QH(tbx_username.Text);
                MainMenu.Quyenhan = QuyenHan;
                NguoiDung.QuyenHan = QuyenHan;
                NguoiDung.TenDangNhap = tbx_username.Text;
               // HuongDan.TenDangNhap = tbx_username.Text;
                Doimatkhau.USERNAME = tbx_username.Text;
                DoiQuyen.USERNAME = tbx_username.Text;
                Doimatkhau.QUYENHAN = QuyenHan;
                ThemTaiKhoan.Username = tbx_username.Text;
                //lb_STT.Text = "Đăng Nhập Thành Công!";
                MessageBox.Show("Bạn Đang Là: " + QuyenHan + "");
                this.Hide();
                MainMenu menu = new MainMenu();
                menu.ShowDialog();
            }
            else
            {
                //lb_STT.Text = "Sai Thông Tin Đăng Nhập! Vui Lòng Nhập Lại!";
                tbx_username.Clear();
                tbx_password.Clear();
                tbx_username.Focus();
            }

        }

        private void tbx_password_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void chb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
           
        }

    }
}
