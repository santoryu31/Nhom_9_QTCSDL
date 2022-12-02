using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTCKCSDL
{
    public partial class Nhân_viên : Form
    {

        void dataload()
        {

        }

        public Nhân_viên()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=NhomPro;Integrated Security=True");
        private void opencon()
        {
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }    
        }

        private void closecon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private Boolean Exe(string cmd)
        {
            opencon();
            Boolean check;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check= false;
            }

            closecon();
            return check;
        }

        private DataTable Red(string cmd)
        {
            con.Open();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            closecon();
            return dt;
        }

        private void load()
        {
            DataTable dt = Red("select * from NHANVIEN");
            if (dt!=null)
            {
                dataGridView1.DataSource= dt;
            }    
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_DC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nhân_viên_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_MaNV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cb_tenNV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cb_CCCD.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxNS.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxGT.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cb_DC.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cb_SDT.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            string str = "INSERT INTO NHANVIEN VALUES('" + cb_MaNV.Text + "', N'" + cb_tenNV.Text + "', '" + cb_CCCD.Text + "', N'" + textBoxNS.Text + "', N'" + textBoxGT.Text + "', N'" + cb_DC.Text + "', '" + cb_SDT.Text + "')";
            bool b;
            b = Exe(str);
            if (b == false)
            {
                MessageBox.Show("lỗi");
            }
            else
            {
                MessageBox.Show("Thêm mới thành công");
            }
            load();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string str = ("DELETE NHANVIEN where MaNV = '" + cb_MaNV.Text + "'");
            bool b;
            b = Exe(str);
            if (b == false)
            {
                MessageBox.Show("lỗi");
            }
            else
            {
                MessageBox.Show("Đã xóa");
            }
            load();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {

            string str = "UPDATE NHANVIEN SET TenNV = N'" + cb_tenNV.Text + "', CCCD = '" + cb_CCCD.Text + "', NgaySinh = '" + textBoxNS.Text + "', GioiTinh = '" + textBoxGT.Text + "', DiaChi = '" + cb_DC.Text + "', SĐT = '" + cb_SDT.Text + "' where MaNV = '" + cb_MaNV.Text + "'";

            bool b;
            b = Exe(str);
            if (b == false)
            {
                MessageBox.Show("lỗi");
            }
            else
            {
                MessageBox.Show("Cập nhật thành công");
            }
            load();
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_MaNV.ResetText();
            cb_tenNV.ResetText();
            cb_CCCD.ResetText();
            textBoxNS.ResetText();
            cb_GT.ResetText();
            cb_DC.ResetText();
            cb_SDT.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = Red("select * from NHANVIEN where MaNV = '" + bt_timkiem.Text + "'");
            if (dt != null)
            {
                dataGridView1.DataSource= dt;
            }
        }

        private void bt_timkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
