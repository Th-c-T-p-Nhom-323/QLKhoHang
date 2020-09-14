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

namespace QuanLyKhoHang
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        Connection acc = new Connection();
        public static string TDN;
        public static string filepath = "";
        private string filename;
        private int key = 0;
        private int keyall = 0;
        private string MaBP;
        public static string QUYENHD;
        private string MANV;
        private string TRANGTHAI;
        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }
        private void Disablebtn()
        {
            btn_ghinhan.Enabled = true;
            btn_sua.Enabled = false;
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            //btn_file.Enabled = true;
        }
        private void Enablebtn()
        {
            btn_ghinhan.Enabled = false;
            //btn_file.Enabled = false;
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
        }
        private void Disabletbx()
        {
            tbx_chucvu.Enabled = false;
            tbx_DiaChi.Enabled = false;
            tbx_DienThoai.Enabled = false;
            tbx_Email.Enabled = false;
            tbx_luong.Enabled = false;
            tbx_MaBP.Enabled = false;
            tbx_MaNV.Enabled = false;
            tbx_TenNV.Enabled = false;
            dateTimePicker_NS.Enabled = false;
            pn_radio.Enabled = false;
        }
        private void Enabletbx()
        {
            tbx_chucvu.Enabled = true;
            tbx_DiaChi.Enabled = true;
            tbx_DienThoai.Enabled = true;
            tbx_Email.Enabled = true;
            tbx_luong.Enabled = true;
            tbx_MaBP.Enabled = true;
            tbx_MaNV.Enabled = true;
            tbx_TenNV.Enabled = true;
            dateTimePicker_NS.Enabled = true;
            pn_radio.Enabled = true;
        }
        // Xóa text trong TextBox
        public void ClearText()
        {
            tbx_MaNV.Clear();
            tbx_TenNV.Clear();
            tbx_Email.Clear();
            tbx_DienThoai.Clear();
            tbx_DiaChi.Clear();
            tbx_luong.Clear();
            tbx_MaBP.ResetText();
            tbx_chucvu.Clear();
            rbtn_Nam.Checked = true;
           // pc_nhanvien.Image = null;
            dateTimePicker_NS.Text = DateTime.Now.ToShortDateString();
            tbx_MaNV.Focus();
            //filename = "";
            tbx_MaNV.Enabled = false;
            dgvNhanVien.ClearSelection();
        }
        public DataTable ThongTinMANV(string TENBP)
        {
            Connection acc = new Connection();
            SqlDataReader a = acc.ExecuteReader("Select MABP FROM BOPHAN WHERE TENBP like N'" + TENBP + "'");
            while (a.Read())
            {
                MaBP = a["MABP"].ToString().Trim();
            }
            return null;
        }
        public DataTable ThongTinTDN(string TDNHT)
        {
            Connection acc = new Connection();
            SqlDataReader a = acc.ExecuteReader("Select MANV FROM DANGNHAP WHERE USERNAME = '" + TDNHT + "'");
            while (a.Read())
            {
                MANV = a["MANV"].ToString().Trim();
            }
            return null;
        }
        public DataTable ThongTinMABP(string TENBP)
        {
            Connection acc = new Connection();
            SqlDataReader a = acc.ExecuteReader("Select MABP FROM BOPHAN WHERE TENBP like N'" + TENBP + "'");
            while (a.Read())
            {
                MaBP = a["MABP"].ToString().Trim();
            }
            return null;
        }

      
        private void NhanVien_Load(object sender, EventArgs e)
        {
            Disabletbx();
            Enablebtn();
            lbx_trangthai.Visible = false;
            cbx_trangthai.Visible = false;
            cbx_trangthai.Checked = false;
            acc.AutoComplete(tbx_MaNV, "SELECT MANV FROM NHANVIEN");
            acc.AutoCompletecbx(tbx_MaBP, "SELECT TENBP FROM BOPHAN", "TENBP");
            acc.AutoComplete(tbx_chucvu, "SELECT CHUCVU FROM NHANVIEN");

            dgvNhanVien.DataSource = acc.Select_Data("Select NHANVIEN.TRANGTHAI, MANV, TENNV, EMAIL, NS, GT, NHANVIEN.DIENTHOAI, CHUCVU, HINHANH, DIACHI, LUONG, TENBP from NHANVIEN left join BOPHAN on BOPHAN.MABP = NHANVIEN.MABP WHERE NHANVIEN.TRANGTHAI = '1' order by GT asc");
            dgvNhanVien.ClearSelection();
            tbx_MaNV.Enabled = false;
            rbtn_Nam.Checked = true;

            dgvNhanVien.Columns["TRANGTHAI"].HeaderText = "TT";
            dgvNhanVien.Columns["MANV"].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns["TENNV"].HeaderText = "Nhân Viên";
            dgvNhanVien.Columns["EMAIL"].HeaderText = "Email";
            dgvNhanVien.Columns["NS"].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns["GT"].HeaderText = "GT";
            dgvNhanVien.Columns["DIENTHOAI"].HeaderText = "Điện Thoại";
            dgvNhanVien.Columns["CHUCVU"].HeaderText = "Chức Vụ";
            dgvNhanVien.Columns["HINHANH"].HeaderText = "Ảnh";
            dgvNhanVien.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns["LUONG"].HeaderText = "Lương";
            dgvNhanVien.Columns["TENBP"].HeaderText = "Bộ Phận";

            dgvNhanVien.Columns["TRANGTHAI"].Width = 30;
            dgvNhanVien.Columns["MANV"].Width = 70;
            dgvNhanVien.Columns["GT"].Width = 60;
            dgvNhanVien.Columns["TENNV"].Width = 150;
            dgvNhanVien.Columns["TENBP"].Width = 170;
            dgvNhanVien.Columns["EMAIL"].Width = 150;
            dgvNhanVien.Columns["CHUCVU"].Width = 150;

            dgvNhanVien.CurrentRow.Cells["TRANGTHAI"].ReadOnly = false;

            if (QUYENHD == "ADMIN" || QUYENHD == "Admin" || QUYENHD == "admin")
            {
                btn_xoa.Enabled = true;
            }
            else
            {
                btn_xoa.Enabled = false;
            }

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Disablebtn();
            Enabletbx();
            tbx_MaNV.Enabled = false;
            key = 1;
        }

        //Chưa làm
        private void btn_sua_Click(object sender, EventArgs e)
        {
            
        }

        //Chưa làm
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
        }

        //Chưa làm
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            
        }

        //Chưa làm
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        //Chưa làm
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                btn_xoa_Click(sender, e);
            }
        }

        private void NhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }

        //Chưa làm
        private void btn_ghinhan_Click(object sender, EventArgs e)
        {
           
        }
    }
}
