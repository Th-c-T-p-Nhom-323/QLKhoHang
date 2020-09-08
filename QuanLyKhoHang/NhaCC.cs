using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class NhaCC : Form
    {
        public NhaCC()
        {
            InitializeComponent();
        }
        Connection acc = new Connection();
        public int key = 0;
        public void ClearText()
        {
            tbx_MaNCC.Clear();
            tbx_TenNCC.Clear();
            tbx_Diachi.Clear();
            tbx_Ghichu.Clear();
            tbx_MaNCC.Focus();
            dgv_nhacungcap.ClearSelection();
            tbx_MaNCC.Enabled = false;
        }
        private void NhaCC_Load(object sender, EventArgs e)
        {
            acc.AutoComplete(tbx_MaNCC, "SELECT MANCC FROM NHACUNGCAP");
            dgv_nhacungcap.DataSource = acc.Select_Data("SELECT * FROM NHACUNGCAP");
            ClearText();
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            tbx_Diachi.Enabled = false;
            tbx_Ghichu.Enabled = false;
            tbx_MaNCC.Enabled = false;
            tbx_TenNCC.Enabled = false;
            btn_ghinhan.Enabled = false;
            btn_mo.Enabled = false;
        }

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ClearText();
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            tbx_Diachi.Enabled = true;
            tbx_Ghichu.Enabled = true;
            tbx_MaNCC.Enabled = false;
            tbx_TenNCC.Enabled = true;
            btn_ghinhan.Enabled = true;
            btn_mo.Enabled = true;
            key = 1;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            tbx_Diachi.Enabled = false;
            tbx_Ghichu.Enabled = false;
            tbx_MaNCC.Enabled = true;
            tbx_TenNCC.Enabled = false;
            btn_ghinhan.Enabled = true;
            btn_mo.Enabled = false;
            key = 3;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            tbx_Diachi.Enabled = true;
            tbx_Ghichu.Enabled = true;
            tbx_MaNCC.Enabled = false;
            tbx_TenNCC.Enabled = true;
            btn_ghinhan.Enabled = true;
            btn_mo.Enabled = false;
            key = 2;
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            NhaCC_Load(sender, e);
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text.Trim() == "")
            {
                MessageBox.Show("Đề Nghị Bạn Nhập Từ Khóa Càn Tìm!", "Thông Báo!");
                return;
            }
            else
            {
                dgv_nhacungcap.DataSource = acc.Select_Data("Select  * from NHACUNGCAP Where MANCC like N'%" + tbx_timkiem.Text + "%' OR TENNHACC like N'%" + tbx_timkiem.Text + "%' OR DIACHI like N'%" + tbx_timkiem.Text + "%'");
                tbx_timkiem.Clear();
                dgv_nhacungcap.ClearSelection();
            }
        }

        private void dgv_nhacungcap_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dgv_nhacungcap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void NhaCC_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btn_ghinhan_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
