using CafeteriaManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaManagementSystem
{
    public partial class DEL : Form
    {
        public DEL()
        {
            InitializeComponent();
        }

        item Item = new item();
        private void btn_DelCancel_Click(object sender, EventArgs e)
        {
            Dashboard adt = new Dashboard();
            this.Hide();
            //adt.Show();
        }

        private void DEL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeteriaItemDataSet.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.cafeteriaItemDataSet.item);

        }

        private void btn_delItem_Click(object sender, EventArgs e)
        {
            Item.id = int.Parse(cmb_delItem.SelectedValue.ToString());
            using (var db = new cafeteriaEntities())
            {
                var entry = db.Entry(Item);
                if (entry.State == EntityState.Detached)
                    db.items.Attach(Item);

                db.items.Remove(Item);
                db.SaveChanges();
            }
            this.itemTableAdapter.Fill(this.cafeteriaItemDataSet.item);
            MessageBox.Show("Record Deleted Successfully", "Deleted ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void cmb_delItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
