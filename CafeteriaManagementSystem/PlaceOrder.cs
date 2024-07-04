using CafeteriaManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using static CafeteriaManagementSystem.PlaceOrder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CafeteriaManagementSystem
{
    public partial class PlaceOrder : Form
    {
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();

        public PlaceOrder()
        {
            InitializeComponent();
            StartItemTrigger();
            FillGrid(ChangeType.None, Int64.MinValue);
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
        }

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox2.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, 20, 20);
        }

        item Item1 = new item();


        public class itemTrigger
        {
            public int id { get; set; }
            public string name { get; set; }
            public long price { get; set; }
        }

        //sql table dependency object
        //private SqlTableDependency
        private SqlTableDependency<itemTrigger> _sqlTableDependency;
        private delegate void UiCallback(ChangeType pChangeType, Int64 Emp_SSN);


        private void StartItemTrigger()
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        private void StopItemTrigger()
        {
            if (backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();
        }



        private void OnDatabaseEventChanged(object sender, RecordChangedEventArgs<itemTrigger> e)
        {
            if (!IsHandleCreated)
                this.CreateControl();
            Invoke(new UiCallback(FillGrid), e.ChangeType, e.Entity.id);
        }

        private void FillGrid(ChangeType changetype, Int64 i)
        {
            this.itemTableAdapter1.Fill(this.cafeteriaDataSet2.item);
            this.itemTableAdapter.Fill(this.cafeteriaDataSet.item);

        }
        private void RegisterForDatabaseEvents()
        {
            _sqlTableDependency = new SqlTableDependency<itemTrigger>("Data source=Nabeel;Initial Catalog=cafeteria;Integrated Security=True", "item");
            _sqlTableDependency.OnChanged += OnDatabaseEventChanged;
            _sqlTableDependency.Start();

        }


 

        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeteriaDataSet2.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter1.Fill(this.cafeteriaDataSet2.item);
            // TODO: This line of code loads data into the 'cafeteriaUpdateDataSet.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.cafeteriaDataSet.item);



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemTableAdapter.Fill(this.cafeteriaDataSet.item);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.itemTableAdapter.Fill(this.cafeteriaDataSet.item);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        int sum = 0;
        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemTableAdapter.Fill(this.cafeteriaDataSet.item);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cmb_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (richTextBox2.Text == "")
            {
                richTextBox2.Text = (cmb_Items.SelectedValue.ToString());
                sum += int.Parse(richTextBox2.Text);
            }
            else
            {
                sum += int.Parse(cmb_Items.SelectedValue.ToString());
                richTextBox2.Text = sum.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sum -= int.Parse(cmb_Items.SelectedValue.ToString());
            if (sum > 0)
            {
                richTextBox2.Text = sum.ToString();
            }
            else
            {
                richTextBox2.Text = "0";
                sum = 0;
            }
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }


        private void button3_Click(object sender, EventArgs e)
        {
            dialog.Document = document;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //using (var db = new cafeteriaEntities())
                //{
                //    db.
                //    db.SaveChanges();
                //}
                document.Print();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            RegisterForDatabaseEvents();
        }
    }
}
