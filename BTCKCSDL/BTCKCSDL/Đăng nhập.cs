using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTCKCSDL
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDN_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=NhomPro;Integrated Security=True");
                con.Open();
                var query = "selecct * from TAIKHOAN where Username = @Username and pass = @pass";
                var cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", textBoxTK.Text);
                cmd.Parameters.AddWithValue("@pass", textBoxMK.Text);
                string TK = textBoxTK.Text;
                string MK = textBoxMK.Text;
                string sql = "select * from TAIKHOAN where Username = '" + TK + "' and Pass = '" + MK + "' ";
                SqlCommand cmd1 = new SqlCommand(sql, con);
                SqlDataReader dta = cmd1.ExecuteReader();
                if (dta.Read() == true)
                {
                    QuanLy Ql = new QuanLy();
                    Hide();
                    Ql.ShowDialog();
                    Show();
                } 
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool v1 = MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK;
            if (v1)
            {
                e.Cancel = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}