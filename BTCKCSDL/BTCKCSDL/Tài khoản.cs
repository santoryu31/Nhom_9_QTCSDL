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
    public partial class Tài_khoản : Form
    {
        public Tài_khoản()
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
            DataTable dt = Red("select * from TAIKHOAN");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_MaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Tài_khoản_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_TK.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cb_MK.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }


        private void bt_rsTk_Click(object sender, EventArgs e)
        {
            cb_TK.ResetText();
            cb_MK.ResetText();
        }

        private void bt_TimTK_Click(object sender, EventArgs e)
        {
            DataTable dt = Red("select * from TAIKHOAN where Username = '" + bt_timkiemTK.Text + "'");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void bt_themtk_Click(object sender, EventArgs e)
        {
            string str = "INSERT INTO TAIKHOAN VALUES('" + cb_TK.Text + "', N'" + cb_MK.Text + "'";
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

        private void bt_xoatk_Click(object sender, EventArgs e)
        {
            string str = "DELETE from TAIKHOAN where Username = '" + cb_TK.Text + "'";
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

        private void bt_suaTK_Click(object sender, EventArgs e)
        {
            string str = "UPDATE TAIKHOAN SET  Username = N'" + cb_TK.Text + "', Pass = '" + cb_MK.Text + "'";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
