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
    public partial class Hang : Form
    {
        public Hang()
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
            DataTable dt = Red("select * from PHIEUNHAPHANG");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void Hang_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_MaNhapHang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cb_MaNV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cb_NgayN.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cb_GioN.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cb_TongTNhap.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_RSH_Click(object sender, EventArgs e)
        {
            cb_MaNhapHang.ResetText();
            cb_MaNV.ResetText();
            cb_NgayN.ResetText();
            cb_GioN.ResetText();
            cb_TongTNhap.ResetText();
        }

        private void bt_TimH_Click(object sender, EventArgs e)
        {
            DataTable dt = Red("select * from PHIEUNHAPHANG where MaNhapHang = '" + bt_timkiemPNH.Text + "'");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void bt_themH_Click(object sender, EventArgs e)
        {
            string str = "INSERT INTO PHIEUNHAPHANG(MaNhapHang, MaNV, NgayNhap, GioNhap) VALUES('" + cb_MaNhapHang.Text + "', '" + cb_MaNV.Text + "', '" + cb_NgayN.Text + "', '" + cb_GioN.Text + "') ";
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
        private void bt_suaH_Click(object sender, EventArgs e)
        {

            string str ="UPDATE PHIEUNHAPHANG SET MaNV = '" + cb_MaNV.Text + "' Where MaNhapHang = '" + cb_MaNhapHang.Text + "' " ;
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

        private void bt_xoaH_Click(object sender, EventArgs e)
        {
            string str = "DELETE FROM PHIEUNHAPHANG Where MaNhapHang = '" + cb_MaNhapHang.Text + "'";
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
    }
}
