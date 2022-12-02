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
    public partial class ChiTietNhaphang : Form
    {
        public ChiTietNhaphang()
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
            DataTable dt = Red("select * from CHITIETNHAPHANG");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void ChiTietNhaphang_Load(object sender, EventArgs e)
        {
           load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_Mahang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_maNH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_tenH.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_dongia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_DVT.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tb_SL.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tb_Thanhtien.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void bt_RS_Click(object sender, EventArgs e)
        {
            tb_Mahang.ResetText();
            tb_maNH.ResetText();
            tb_tenH.ResetText();
            tb_dongia.ResetText();
            tb_DVT.ResetText();
            tb_SL.ResetText();
            tb_Thanhtien.ResetText();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_tkCTNH_Click(object sender, EventArgs e)
        {
            DataTable dt = Red("select * from CHITIETNHAPHANG where MaNV = '" + bt_timkiemCTNH.Text + "'");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            string str = "INSERT INTO CHITIETNHAPHANG(MaHang, MaNhapHang, TenHang, DonGia, DVT, SoLuong) VALUES('" + tb_Mahang.Text + "', '" + tb_maNH.Text + "', N'" + tb_tenH.Text + "', '" + tb_dongia.Text + "', '" + tb_DVT.Text + "', '" + tb_SL.Text + "')";
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
            string str = "DELETE CHITETHOADON WHERE MaHang = '" + tb_Mahang.Text + "' and MaNhaphang = '" + tb_maNH.Text + "' ";
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
            string str = "UPDATE CHITIETNHAPHANG SET MaHang = '" + tb_Mahang.Text + "' , MaNhapHang = '" + tb_maNH.Text + "', TenHang = N'" + tb_tenH.Text + "', DonGia = '" + tb_dongia.Text + "', DVT = '" + tb_DVT.Text + "', SoLuong = N'" + tb_SL.Text + "' where MaHang = '" + tb_Mahang.Text + "' ";

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
