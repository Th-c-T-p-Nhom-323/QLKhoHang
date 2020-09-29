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
    public partial class KhoHang : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLKhoHang;Integrated Security=True");
        public KhoHang()
        {
            InitializeComponent();
        }
        public void Show()
        {
            con.Open();
            string sql = "SELECT *FROM KHOHANG";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "INSERT INTO KHOHANG VALUES (@MAKHO, @TENKHO, @TONGSODMSP, @GHICHU)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MAKHO", txt_maKho.Text);
            cmd.Parameters.AddWithValue("TENKHO", txt_tenkho.Text);
            cmd.Parameters.AddWithValue("TONGSODMSP", txt_soluong.Text);
            cmd.Parameters.AddWithValue("GHICHU", txt_ghichu.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "UPDATE KHOHANG SET TENKHO = @TENKHO, TONGSODMSP = @TONGSODMSP, GHICHU = @GHICHU WHERE MAKHO = @MAKHO";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MAKHO", txt_maKho.Text);
            cmd.Parameters.AddWithValue("TENKHO", txt_tenkho.Text);
            cmd.Parameters.AddWithValue("TONGSODMSP", txt_soluong.Text);
            cmd.Parameters.AddWithValue("GHICHU", txt_ghichu.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "DELETE FROM KHOHANG WHERE MAKHO = @MAKHO";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MAKHO", txt_maKho.Text);
            cmd.Parameters.AddWithValue("TENKHO", txt_tenkho.Text);
            cmd.Parameters.AddWithValue("TONGSODMSP", txt_soluong.Text);
            cmd.Parameters.AddWithValue("GHICHU", txt_ghichu.Text);            
            cmd.ExecuteNonQuery();
            con.Close();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT FROM KHOHANG WHERE MAKHO = @MAKHO";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MAKHO", txt_timkiem.Text);
            cmd.Parameters.AddWithValue("TENKHO", txt_tenkho.Text);
            cmd.Parameters.AddWithValue("TONGSODMSP", txt_soluong.Text);
            cmd.Parameters.AddWithValue("GHICHU", txt_ghichu.Text);           
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }

        private void KhoHang_Load(object sender, EventArgs e)
        {
            Show();
            txt_maKho.Text = dataGridView1.Rows[0].Cells["MAKHO"].Value.ToString();
            txt_tenkho.Text = dataGridView1.Rows[0].Cells["TENKHO"].Value.ToString();
            txt_soluong.Text = dataGridView1.Rows[0].Cells["TONGSODMSP"].Value.ToString();
            txt_ghichu.Text = dataGridView1.Rows[0].Cells["GHICHU"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maKho.Text = dataGridView1.CurrentRow.Cells["MAKHO"].Value.ToString();
            txt_tenkho.Text = dataGridView1.CurrentRow.Cells["TENKHO"].Value.ToString();
            txt_soluong.Text = dataGridView1.CurrentRow.Cells["TONGSODMSP"].Value.ToString();
            txt_ghichu.Text = dataGridView1.CurrentRow.Cells["GHICHU"].Value.ToString();
        }
    }
}
