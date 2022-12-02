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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTCKCSDL
{
    public partial class MeNu : Form
    {
        public MeNu()
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
            DataTable dt = Red("select * from MENU");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void MeNu_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_Menu.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cb_DG.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_Menu.ResetText();
            textBox1.ResetText();
            cb_DG.ResetText();
        }

        private void bt_TimKH_Click(object sender, EventArgs e)
        {
            DataTable dt = Red("select * from MENU where MaMon = '" + bt_timkiemMN.Text + "'");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_themHD_Click(object sender, EventArgs e)
        {
            string str = "INSERT INTO MENU VALUES('" + cb_Menu.Text + "', N'" + textBox1.Text + "', '" + cb_DG.Text + "')";
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

        private void bt_xoaHD_Click(object sender, EventArgs e)
        {
            string str = ("DELETE MENU where MaMon = '" + cb_Menu.Text + "'");
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

        private void bt_suaHD_Click(object sender, EventArgs e)
        {
            string str = "UPDATE Menu SET TenMon = N'" + textBox1.Text + "', DonGia = '" + cb_DG.Text + "' where MaMon = '" + cb_Menu.Text + "'";

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cb_DG_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_Menu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
