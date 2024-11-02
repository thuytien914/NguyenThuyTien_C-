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
    public partial class TableManager : Form
    {
        public bool isThoat = true;
        public event EventHandler Thoat;
        public TableManager()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btTroGiup_Click(object sender, EventArgs e)
        {

        }

        private void msQuanLy_Click(object sender, EventArgs e)
        {

        }

        private void msHeThong_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.ShowDialog();
        }
        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.ShowDialog();
            this.Hide();
        }

        private void quảnLýNgườToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManager f = new UserManager();
            f.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Thoat?.Invoke(this, EventArgs.Empty);
        }

        private void msTroGiup_Click(object sender, EventArgs e)
        {
            Help f = new Help();
            f.ShowDialog();
        }
    }
}
