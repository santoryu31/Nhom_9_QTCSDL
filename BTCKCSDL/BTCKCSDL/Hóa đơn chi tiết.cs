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
    public partial class Hóa_đơn_chi_tiết : Form
    {
        public Hóa_đơn_chi_tiết()
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
            DataTable dt = Red("select * from CHITIETHOADON");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cb_DCKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hóa_đơn_chi_tiết_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_MaHD.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cb_SL.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cb_Thanhtien.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_MaHD.ResetText();
            textBox1.ResetText();
            cb_SL.ResetText();
            cb_Thanhtien.ResetText();
        }

        private void bt_TimKH_Click(object sender, EventArgs e)
        {
            DataTable dt = Red("select * from CHITIETHOADON where MaHD = '" + bt_timkiemCTHD.Text + "'");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void bt_xoaHD_Click(object sender, EventArgs e)
        {
            string str = "DELETE from CHITIETHOADON where MaHD = '" + cb_MaHD.Text + "' and MaMon = '" + textBox1.Text + "' ";
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

        private void bt_themHD_Click(object sender, EventArgs e)
        {
            string str = "INSERT INTO CHITIETHOADON(MaHD, MaMon, SoLuong) VALUES('" + cb_MaHD.Text + "', '" + textBox1.Text + "', '" + cb_SL.Text + "')";
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

        private void bt_suaHD_Click(object sender, EventArgs e)
        {
            string str = "UPDATE CHITIETHOADON SET SoLuong = '" + cb_SL.Text + "'  WHERE MaHD = '" + cb_MaHD.Text + "' and MaMon = '" + textBox1.Text + "' ";
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
    }
}
