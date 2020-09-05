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
    public partial class NhapXuat : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSI;Initial Catalog=QLKH;Integrated Security=True");
        public NhapXuat()
        {
            InitializeComponent();
        }
        public DataTable data;
        int keyn = 0;
        int keyx = 0;
        Connection acc = new Connection();
        private static float temp;
        public static string filepart = "";
        private string NVNHAP;
        private string NVXUAT;
        private string MASPPN;
        private string MASPPX;
        private string MANCC;
        private string MAKH;
        private string MAKHOPN;
        private string MAKHOPX;
      
       
        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            acc.AutoCompletecbx(txb_nvnhap, "select TENNV from NHANVIEN", "TENNV");
            acc.AutoCompletecbx(txb_maspPN, "Select TENSP from SANPHAM", "TENSP");
            acc.AutoCompletecbx(txb_mancc, "SELECT TENNHACC FROM NHACUNGCAP", "TENNHACC");
            acc.AutoCompletecbx(txb_makhoPN, "SELECT TENKHO FROM KHOHANG", "TENKHO");
            acc.AutoCompletecbx(txb_manvPX, "select TENNV from NHANVIEN", "TENNV");
            acc.AutoCompletecbx(txb_maspPX, "Select TENSP from SANPHAM", "TENSP");
            acc.AutoCompletecbx(txb_makh, "select TENKH from KHACHHANG", "TENKH");
            acc.AutoCompletecbx(txb_makhoPX, "SELECT TENKHO FROM KHOHANG", "TENKHO");
            // 

            txb_maPN.Text = ""; txb_maPX.Text = ""; DisablePN(); DisablePX();
            dgv_phieunhap.DataSource = acc.Select_Data("SELECT PN.MAPN, KHOHANG.TENKHO,NHANVIEN.TENNV,NGAYNHAP,NHACUNGCAP.TENNHACC,SANPHAM.TENSP,CT.SOLUONG,TONGTIEN,PN.GHICHU FROM PHIEUNHAPKHO PN left join NHACUNGCAP on NHACUNGCAP.MANCC = PN.MANCC left join KHOHANG on KHOHANG.MAKHO = PN.MAKHO left join NHANVIEN on NHANVIEN.MANV = PN.NVNHAP INNER JOIN CHITIETPHIEUNHAP CT ON PN.MAPN=CT.MAPN INNER join SANPHAM on SANPHAM.MASP = CT.MASP");
            dgv_phieuxuat.DataSource = acc.Select_Data("SELECT PX.MAPX, KHOHANG.TENKHO, NHANVIEN.TENNV,NGAYXUAT,KHACHHANG.TENKH,SANPHAM.TENSP,CT.SOLUONG,TONGTIEN,PX.GHICHU FROM PHIEUXUAT PX LEFT join NHANVIEN on NHANVIEN.MANV = PX.NVXUAT left join KHACHHANG on KHACHHANG.MAKH = PX.MAKH left join KHOHANG on KHOHANG.MAKHO = PX.MAKHO INNER JOIN CHITIETPHIEUXUAT CT ON PX.MAPX = CT.MAPX INNER join SANPHAM on SANPHAM.MASP = CT.MASP");

            cleartextPN();
            dgv_phieunhap.ClearSelection();
            //autoWidth();

            // Hiển thị tên cột nhập hàng:

            dgv_phieunhap.Columns[0].HeaderText = "Mã Phiếu Nhập";
            dgv_phieunhap.Columns[1].HeaderText = "Tên Kho";
            dgv_phieunhap.Columns[2].HeaderText = "Tên Nhân Viên";
            dgv_phieunhap.Columns[3].HeaderText = "Ngày Nhập";
            dgv_phieunhap.Columns[4].HeaderText = "Tên Nhà Cung Cấp";
            dgv_phieunhap.Columns[5].HeaderText = "Tên Sản Phẩm";
            dgv_phieunhap.Columns[6].HeaderText = "Số lượng";
            dgv_phieunhap.Columns[7].HeaderText = "Tổng Tiền";
            dgv_phieunhap.Columns[8].HeaderText = "Ghi Chú";
            // căn chỉnh độ rộng cột:
            dgv_phieunhap.Columns[0].Width = 60;
            dgv_phieunhap.Columns[1].Width = 150;
            dgv_phieunhap.Columns[2].Width = 150;
            dgv_phieunhap.Columns[6].Width = 50;
            dgv_phieunhap.Columns[3].Width = 80;
            dgv_phieunhap.Columns[4].Width = 200;
            dgv_phieunhap.Columns[5].Width = 200;
            // Hiển Thị tên cột xuất hàng:
            dgv_phieuxuat.Columns[0].HeaderText = "Mã Phiếu Xuất";
            dgv_phieuxuat.Columns[1].HeaderText = "Tên kho";
            dgv_phieuxuat.Columns[2].HeaderText = "Nhân Viên Xuất";
            dgv_phieuxuat.Columns[3].HeaderText = "Ngày Xuất";
            dgv_phieuxuat.Columns[4].HeaderText = "Tên Khách Hàng";
            dgv_phieuxuat.Columns[5].HeaderText = "Tên Sản Phẩm";
            dgv_phieuxuat.Columns[6].HeaderText = "Số Lượng";
            dgv_phieuxuat.Columns[7].HeaderText = "Tổng Tiền";
            dgv_phieuxuat.Columns[8].HeaderText = "Ghi Chú";
            // can do rong cot:
            dgv_phieuxuat.Columns[0].Width = 60;
            dgv_phieuxuat.Columns[1].Width = 150;
            dgv_phieuxuat.Columns[2].Width = 150;
            dgv_phieuxuat.Columns[4].Width = 150;

            dgv_phieuxuat.Columns[5].Width = 150;
            dgv_phieuxuat.Columns[6].Width = 50;

            bt_xoa.Enabled = true;
            bt_them.Enabled = true;
            btn_themPX.Enabled = true;
            button_chophepsua.Enabled = true;
            btn_xoaPX.Enabled = true;
            btn_themPX.Enabled = true;
            btn_ghinhan.Enabled = false;
            btn_chophepsua.Enabled = true;
            btn_suaPX.Enabled = false;
            DisablePN();
            DisablePX();
            txb_maPN.Enabled = false;
            txb_maPX.Enabled = false;
        }
        public void cleartextPN()
        {
            txb_nvnhap.Focus();
            txb_maPN.Clear(); txb_ghichu.Clear(); txb_nvnhap.ResetText();
            txb_makhoPN.ResetText(); txb_timkiem_N.Clear();
            txb_tongtienPN.Clear();
            txb_soluongPN.Clear(); txb_mancc.ResetText(); txb_maspPN.ResetText();
        }
        public void cleartextPX()
        {
            txb_maPX.Clear();
            txb_manvPX.ResetText();
            txb_maspPX.ResetText();
            txb_soluongPX.Clear();
            txb_tongtienPX.Clear();
            txb_manvPX.Focus();
            txb_makh.ResetText();
            txb_makhoPX.ResetText();
            txb_ghichuPX.Clear();
            txb_timkiemPX.Clear();

        }
        public void DisablePN()
        {
            txb_nvnhap.Enabled = false;
            ngaynhap.Enabled = false;
            txb_maspPN.Enabled = false;
            txb_soluongPN.Enabled = false;
            txb_tongtienPN.Enabled = false;
            txb_mancc.Enabled = false;
            txb_makhoPN.Enabled = false;
            txb_ghichu.Enabled = false;
        }
        public void EnablePN()
        {
            txb_nvnhap.Enabled = true;
            ngaynhap.Enabled = true;
            txb_maspPN.Enabled = true;
            txb_soluongPN.Enabled = true;
            txb_tongtienPN.Enabled = true;
            txb_mancc.Enabled = true;
            txb_makhoPN.Enabled = true;
            txb_ghichu.Enabled = true;
        }
        public void DisablePX()
        {
            txb_manvPX.Enabled = false;
            ngayxuat.Enabled = false;
            txb_maspPX.Enabled = false;
            txb_soluongPX.Enabled = false;
            txb_tongtienPX.Enabled = false;
            txb_makh.Enabled = false;
            txb_makhoPX.Enabled = false;
            txb_ghichuPX.Enabled = false;
        }
        public void EnablePX()
        {
            txb_manvPX.Enabled = true;
            ngayxuat.Enabled = true;
            txb_maspPX.Enabled = true;
            txb_soluongPX.Enabled = true;
            txb_tongtienPX.Enabled = true;
            txb_makh.Enabled = true;
            txb_makhoPX.Enabled = true;
            txb_ghichuPX.Enabled = true;
        }
        public DataTable ThongTinKHOPX(string TEXT)
        {
            
        }
        public DataTable ThongTinKHOPN(string TEXT)
        {
           
        }
        public DataTable ThongTinSPPX(string TEXT)
        {
        }
        public DataTable ThongTinSPPN(string TEXT)
        {
            
        }
        public DataTable ThongTinKH(string TEXT)
        {
            
        }
        public DataTable ThongTinNVXUAT(string TEXT)
        {
        }
        public DataTable ThongTinNVNHAP(string TEXT)
        {
            
        }
        public DataTable ThongTinNCC(string TEXT)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
           
        }
        //xoa 1 phieu nhap :
        private void bt_xoa_Click(object sender, EventArgs e)
        {
        }
        //sua phieu nhap san pham:
        private void button_chophepsua_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_ghinhan_Click(object sender, EventArgs e)
        {
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            
        }

        private void button_lammoi_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void dgv_phieuxuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_phieunhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txb_maPN.Text = dgv_phieunhap.CurrentRow.Cells["MAKHO"].Value.ToString();
            //txb_nvnhap.Text = dgv_phieunhap.CurrentRow.Cells["MAKHO"].Value.ToString();
            //ngaynhap.Text = dgv_phieunhap.CurrentRow.Cells["MAKHO"].Value.ToString();
            //txb_maspPN.Text = dgv_phieunhap.CurrentRow.Cells["MAKHO"].Value.ToString();
            //txb_soluongPN.Text = dgv_phieunhap.CurrentRow.Cells["MAKHO"].Value.ToString();
            //txb_tongtienPN.Text = dgv_phieunhap.CurrentRow.Cells["MAKHO"].Value.ToString();
            //txb_mancc.Text = dgv_phieunhap.CurrentRow.Cells["MAKHO"].Value.ToString();
            //txb_makhoPN.Text = dgv_phieunhap.CurrentRow.Cells["MAKHO"].Value.ToString();
            //txb_ghichu.Text = dgv_phieunhap.CurrentRow.Cells["MAKHO"].Value.ToString();
        }
    }
}