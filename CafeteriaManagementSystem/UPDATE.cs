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
using TableDependency.SqlClient;

namespace CafeteriaManagementSystem
{
    public partial class UPDATE : Form
    {
        public UPDATE()
        {
            InitializeComponent();
        }
        item Item = new item();
        private void btn_UptCancel_Click(object sender, EventArgs e)
        {
            Dashboard adt = new Dashboard();
            this.Hide();
            //adt.Show();
        }

        private void btn_UptItem_Click(object sender, EventArgs e)
        {
            try { 
                Item.id = int.Parse(cmb_UpdateItem.SelectedValue.ToString());
                //Item.price = long.Parse(txt_newPrice.Text.Trim());
                using (var db = new cafeteriaEntities())
                {
                    var item2 = db.items.Where(x => x.id == Item.id).FirstOrDefault();
                    if (item2 != null)
                    {
                        item2.price = long.Parse(txt_newPrice.Text.Trim());
                        var entry = db.Entry(item2);
                        if (entry.State == EntityState.Detached)
                            db.items.Attach(item2);

                        db.SaveChanges();
                        MessageBox.Show("Record Updated Successfully");
                    }
                
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show( "Enter integer value as price");
            }
        }

        private void UPDATE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeteriaUpdateDataSet.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter1.Fill(this.cafeteriaUpdateDataSet.item);
            // TODO: This line of code loads data into the 'cafeteriaDataSet1.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.cafeteriaDataSet1.item);

        }

        private void txt_newPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
