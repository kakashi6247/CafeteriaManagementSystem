using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaManagementSystem
{
    public partial class Add_Delete_Items : Form
    {
        public Add_Delete_Items()
        {
            InitializeComponent();
        }

        

        private void btn_DeleteItemForm_Click(object sender, EventArgs e)
        {
            DEL del = new DEL();
            this.Hide();
            del.Show();
        }

        private void btn_AddItemForm_Click(object sender, EventArgs e)
        {
            ADD add = new ADD();
            this.Hide();
            add.Show();
        }

        private void btn_updatePriceForm_Click(object sender, EventArgs e)
        {
            UPDATE upt = new UPDATE();
            this.Hide();
            upt.Show();
        }
    }
}
