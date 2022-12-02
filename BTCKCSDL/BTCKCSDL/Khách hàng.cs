using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCKCSDL
{
    public partial class Khách_hàng : Form
    {
        public Khách_hàng()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=NhomPro;Integrated Security=True");
        private void opencon()
        {
            if (con.State == ConnectionState.Closed)
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
                check = false;
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
            DataTable dt = Red("select * from KHACHHANG");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_MaKH.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cb_tenKH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cb_SDTKH.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cb_DCKH.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void Khách_hàng_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_MaKH.ResetText();
            cb_tenKH.ResetText();
            cb_SDTKH.ResetText();
            cb_DCKH.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = Red("select * from KHACHHANG where MaKH = '" + bt_timkiemKH.Text + "'");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            
            string str = "DELETE from KHACHHANG where MaKH = '" + cb_MaKH.Text + "'";
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
            string str = "UPDATE KHACHHANG SET  TenKH = N'" + cb_tenKH.Text + "', SDT = '" + cb_SDTKH.Text + "', DiaChi = '" + cb_DCKH.Text + "' where MaKH = '" + cb_MaKH.Text + "'";
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

        private void bt_them_Click(object sender, EventArgs e)
        {
            String str = "INSERT INTO KHACHHANG VALUES ('" + cb_MaKH.Text + "', N'" + cb_tenKH.Text + "', '" + cb_SDTKH.Text + "', '" + cb_DCKH.Text + "')";
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

        private void bt_timkiemKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cb_DCKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_SDTKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_tenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_MaKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
