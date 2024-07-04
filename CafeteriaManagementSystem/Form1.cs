using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeteriaManagementSystem.Models;

namespace CafeteriaManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        login loginn = new login();


        private void btn_login_Click_1(object sender, EventArgs e)
        {
            var db = new cafeteriaEntities();
            var login = db.logins.Where(x => x.username == txtUsername.Text.Trim()).FirstOrDefault();
            
            if (txtUsername.Text == login.username && txtPassword.Text == login.password)
            {
                Dashboard ds = new Dashboard();
                this.Hide();
                ds.Show();
            }
            else
            {
                MessageBox.Show("Invalid/Incorrect Username or Password","Try Again");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '*')
            {
                btn_show.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btn_hide.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}