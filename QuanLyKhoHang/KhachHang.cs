using System;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
       // SqlConnection con;
        //SqlDataAdapter sda;
        //DataTable dt;
        //SqlCommand cmd;

        public static SqlConnection Con;  //Khai báo đối tượng kết nối        

        public static void Connect()
        {
            Con = new SqlConnection();   //Khởi tạo đối tượng
            Con.ConnectionString = @"Data Source=DESKTOP-EJJ3P12;Initial Catalog=QLKH;Integrated Security=True";
            Con.Open();//mở kết nối
            //kiểm tra kết nối
            if (Con.State == ConnectionState.Open)
                MessageBox.Show("Kết nối thành công");
            else MessageBox.Show("Không thể kết nối với dữ liệu");

        }

        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   	//Đóng kết nối
                Con.Dispose(); 	//Giải phóng tài nguyên
                Con = null;
            }
        }

        //thực hiện câu lệnh SQL truy vấn dữ liệu từ CSDL đổ vào đối tượng bảng
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter MyData = new SqlDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Tạo đối tượng thuộc lớp SqlCommand
            MyData.SelectCommand = new SqlCommand();
            MyData.SelectCommand.Connection = Con; //Kết nối cơ sở dữ liệu
            MyData.SelectCommand.CommandText = sql; //Lệnh SQL
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            MyData.Fill(table);
            return table;
        }

        //Hàm kiểm tra khoá trùng

        public static bool CheckKey(string sql)
        {
            SqlDataAdapter MyData = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            MyData.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }



        //Hàm thực hiện câu lệnh SQL
        public static void RunSQL(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = Con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }

        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Dữ liệu đang được dùng, không thể xoá...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        DataTable KHACHHANG; //Lưu dữ liệu bảng KHÁCH HÀNG
        private void KhachHang_Load(object sender, EventArgs e)
        {
            Connect(); //Mở kết nối
            txtma.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MAKH,TENKH,DIACHI,GIOITINH,DIENTHOAI,EMAIL,FAX FROM KHACHHANG";
            KHACHHANG = GetDataToTable(sql); //lấy dữ liệu
            DataGridView.DataSource = KHACHHANG;

            DataGridView.Columns[0].HeaderText = "Mã khách hàng";
            DataGridView.Columns[1].HeaderText = "Tên khách hàng";

            DataGridView.Columns[2].HeaderText = "Địa chỉ";
            DataGridView.Columns[3].HeaderText = "Giới tính";
            DataGridView.Columns[4].HeaderText = "SĐT";
            DataGridView.Columns[5].HeaderText = "Email";
            DataGridView.Columns[6].HeaderText = "Fax";

            DataGridView.Columns[0].Width = 150;
            DataGridView.Columns[1].Width = 200;
            DataGridView.Columns[2].Width = 150;
            DataGridView.Columns[3].Width = 150;
            DataGridView.Columns[4].Width = 150;

            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtma.Focus();
                return;
            }
            if (KHACHHANG.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtma.Text = DataGridView.CurrentRow.Cells["MAKH"].Value.ToString();
            txtten.Text = DataGridView.CurrentRow.Cells["TENKH"].Value.ToString();
            txtdc.Text = DataGridView.CurrentRow.Cells["DIACHI"].Value.ToString();
            txtGT.Text = DataGridView.CurrentRow.Cells["GIOITINH"].Value.ToString();
            txtsdt.Text = DataGridView.CurrentRow.Cells["DIENTHOAI"].Value.ToString();
            txtemail.Text = DataGridView.CurrentRow.Cells["EMAIL"].Value.ToString();
            txtfax.Text = DataGridView.CurrentRow.Cells["FAX"].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }

        public void ResetValue()
        {
            txtma.ResetText();
            txtten.ResetText();
            txtdc.ResetText();
            txtGT.ResetText();

            txtsdt.ResetText();
            txtemail.ResetText();
            txtfax.ResetText();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue();
            txtma.Enabled = true;
            txtma.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }


        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTimKiem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnIndanhsach_Click(object sender, EventArgs e)
        {
            
        }

      

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
