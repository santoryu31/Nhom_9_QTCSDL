using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCKCSDL
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MeNu Ql = new MeNu();
            Hide();
            Ql.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nhân_viên Ql = new Nhân_viên();
            Hide();
            Ql.ShowDialog();
            Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hóa_đơn Ql = new Hóa_đơn();
            Hide();
            Ql.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hóa_đơn_chi_tiết Ql = new Hóa_đơn_chi_tiết();
            Hide();
            Ql.ShowDialog();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tài_khoản Ql = new Tài_khoản();
            Hide();
            Ql.ShowDialog();
            Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeNu Ql = new MeNu();
            Hide();
            Ql.ShowDialog();
            Show();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhân_viên Ql = new Nhân_viên();
            Hide();
            Ql.ShowDialog();
            Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Khách_hàng Ql = new Khách_hàng();
            Hide();
            Ql.ShowDialog();
            Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Khách_hàng Ql = new Khách_hàng();
            Hide();
            Ql.ShowDialog();
            Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tài_khoản Ql = new Tài_khoản();
            Hide();
            Ql.ShowDialog();
            Show();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hóa_đơn_chi_tiết Ql = new Hóa_đơn_chi_tiết();
            Hide();
            Ql.ShowDialog();
            Show();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hóa_đơn Ql = new Hóa_đơn();
            Hide();
            Ql.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hang Ql = new Hang();
            Hide();
            Ql.ShowDialog();
            Show();
        }

        private void hàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hang Ql = new Hang();
            Hide();
            Ql.ShowDialog();
            Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChiTietNhaphang Ql = new ChiTietNhaphang();
            Hide();
            Ql.ShowDialog();
            Show();
        }

        private void chiTiếtNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietNhaphang Ql = new ChiTietNhaphang();
            Hide();
            Ql.ShowDialog();
            Show();
        }
    }
}

