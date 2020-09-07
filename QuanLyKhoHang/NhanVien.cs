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

        //Chưa làm 
        private void NhanVien_Load(object sender, EventArgs e)
        {

            
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
