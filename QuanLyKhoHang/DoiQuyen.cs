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
    public partial class DoiQuyen : Form
    {
        public static string USERNAME = "";
        public static string QuyenHan = "";
        Connection con = new Connection();
        public DoiQuyen()
        {
            InitializeComponent();
        }
        public DataTable QH(string USERNAME)
        {
            Connection con = new Connection();
            SqlDataReader a = con.ExecuteReader("SELECT QUYENHAN FROM DANGNHAP WHERE USERNAME='" + USERNAME + "'");
            while (a.Read())
            {
                QuyenHan = a["QUYENHAN"].ToString();

            }
            return null;
        }

        private void DoiQuyen_Load(object sender, EventArgs e)
        {
            con.AutoComplete(tbx_tdn, "SELECT USERNAME FROM DANGNHAP");
            con.AutoComplete(tbx_quyencu, "SELECT QUYENHAN FROM DANGNHAP");
            con.AutoComplete(tbx_quyenmoi, "SELECT QUYENHAN FROM DANGNHAP");
        }

        private void btn_dq_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            
        }

        private void tbx_tdn_Validated(object sender, EventArgs e)
        {
            
        }
    }
}
