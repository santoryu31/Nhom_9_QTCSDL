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
    public partial class Hóa_đơn : Form
    {
        public Hóa_đơn()
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
            DataTable dt = Red("select * from HOADON");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void Hóa_đơn_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_MaHD.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cb_NV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cb_MaKH.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cb_NgayHD.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cb_GioHD.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cb_TongTHD.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cb_Mamon_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_MaHD.ResetText();
            cb_NV.ResetText();
            cb_MaKH.ResetText();
            cb_NgayHD.ResetText();
            cb_GioHD.ResetText();
            cb_TongTHD.ResetText();

        }

        private void bt_TimKH_Click(object sender, EventArgs e)
        {
            DataTable dt = Red("select * from HOADON where MaHD = '" + bt_timkiemHD.Text + "'");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void bt_xoaHD_Click(object sender, EventArgs e)
        {
            string str = "DELETE from HOADON where MaHD = '" + cb_MaHD.Text + "'";
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
            string str = "INSERT INTO HOADON(MaHD, MaNV, MaKH, Ngay, Gio) VALUES('" + cb_MaHD.Text + "', '" + cb_NV.Text + "', '" + cb_MaKH.Text + "', '" + cb_NgayHD.Text + "', '" + cb_GioHD.Text + "')";
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
            string str = "UPDATE HOADON SET MaNV = '" + cb_NV.Text + "', MaKH = '" + cb_MaKH.Text + "', Ngay = '" + cb_NgayHD.Text + "', Gio = '" + cb_GioHD.Text + "' WHERE MaHD = '" + cb_MaHD.Text + "' ";
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
