using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CafeteriaManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            pnl_nav.Height = 5;
            pnl_nav.Left = btn_placeOrder.Left;
            pnl_nav.Top = btn_placeOrder.Top;
            btn_placeOrder.BackColor = Color.Red;
        }

        public void loadform(object Form)
        {
            if (this.main_panel.Controls.Count > 0)
            {
                main_panel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(f);
            this.main_panel.Tag = f;
            f.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();            //this.Hide();
        }

        private void btn_placeOrder_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = 5;
            pnl_nav.Left = btn_placeOrder.Left;
            pnl_nav.Top = btn_placeOrder.Top;
            btn_placeOrder.BackColor = Color.Crimson;

            loadform(new PlaceOrder());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = 5;
            pnl_nav.Left = btn_update.Left;
            pnl_nav.Top = btn_update.Top;
            btn_update.BackColor = Color.Crimson;

            loadform(new Add_Delete_Items());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
