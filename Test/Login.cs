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
using Test.DAO;

namespace Test
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn__dn_Click(object sender, EventArgs e)
        {
            string username = txtTendn.Text;
            string password = txtMk.Text;
            if (Login1(username,password))
            {
                
                Main m = new Main();
                this.Hide();
                m.ShowDialog();
                txtTendn.Clear();
                txtMk.Clear();
                this.Show();
            }
            else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu","Thông Báo");
        }
        bool Login1(string username,string password)
        {
            return AccountDAO.Instance.Login1(username,password);
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình","Thông báo", MessageBoxButtons.OKCancel) !=System.Windows.Forms.DialogResult.OK)
                //e.cancel you cannot inplement the event 
                e.Cancel = true;
        }
    }
}
