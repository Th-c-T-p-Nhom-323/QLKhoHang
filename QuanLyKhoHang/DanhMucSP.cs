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

        //Chưa làm
        private void DanhMucSP_Load(object sender, EventArgs e)
        {
            
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

        //Chưa làm
        private void bt_them_Click(object sender, EventArgs e)
        {
            
        }

        //Chưa làm
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            
        }

        //Chưa làm
        private void bt_chophepsua_Click(object sender, EventArgs e)
        {
            
        }

        //Chưa làm
        public DataTable ThongTinMaKho(string Text)
        {
            
        }

        //Chưa làm
        private void btn_ghinhan_Click(object sender, EventArgs e)
        {

            
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
