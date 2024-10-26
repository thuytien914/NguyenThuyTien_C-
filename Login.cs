using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class Login : Form
    {
        string tentaikhoan = "thuytien";
        string matkhau = "1234";
        public Login()
        {
            InitializeComponent();
        }

        public bool kt;

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(tbUserName.Text, tbPassWord.Text))
            {
                TableManager f = new TableManager();
                f.Show();
                this.Hide();
                f.Thoat += F_Thoat;
                tbUserName.Text = "";
                tbPassWord.Text = "";
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Error");
                tbUserName.Focus();
            }

        }

        private void F_Thoat(object sender, EventArgs e)
        {
            this.Show(); 
            (sender as TableManager)?.Close();

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tbPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassWord.UseSystemPasswordChar = true;
            }
        }
        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            if (tentaikhoan == this.tentaikhoan && matkhau == this.matkhau)
            {
                return true;
            }
            return false;
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
