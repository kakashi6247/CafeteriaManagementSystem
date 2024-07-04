using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using CafeteriaManagementSystem.Models;

namespace CafeteriaManagementSystem
{
    public partial class ADD : Form
    {
        public ADD()
        {
            InitializeComponent();
        }

        item Item = new item();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard adt = new Dashboard();
            this.Hide();
            //adt.Show();
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            Item.name = txt_itemName.Text.Trim();

            Item.price = long.Parse(txt_itemPrice.Text.Trim());

            //for crud operation
            using (var db = new cafeteriaEntities())
            {
                db.items.Add(Item);
                db.SaveChanges();
            }

            MessageBox.Show("Record Save Successfully");
        }

        private void ADD_Load(object sender, EventArgs e)
        {

        }

        private void txt_itemPrice_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_itemPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
