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
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_logout = new System.Windows.Forms.LinkLabel();
            this.btn_placeOrder = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pnl_nav);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.lbl_logout);
            this.panel1.Controls.Add(this.btn_placeOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 80);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnl_nav
            // 
            this.pnl_nav.BackColor = System.Drawing.Color.Gold;
            this.pnl_nav.Location = new System.Drawing.Point(175, 1);
            this.pnl_nav.Name = "pnl_nav";
            this.pnl_nav.Size = new System.Drawing.Size(127, 5);
            this.pnl_nav.TabIndex = 3;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_update.Location = new System.Drawing.Point(461, 0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(129, 85);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "Update Menu";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_logout.LinkColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_logout.Location = new System.Drawing.Point(708, 45);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(59, 20);
            this.lbl_logout.TabIndex = 2;
            this.lbl_logout.TabStop = true;
            this.lbl_logout.Text = "LogOut";
            this.lbl_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_logout_LinkClicked);
            // 
            // btn_placeOrder
            // 
            this.btn_placeOrder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_placeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_placeOrder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_placeOrder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_placeOrder.Location = new System.Drawing.Point(174, 0);
            this.btn_placeOrder.Name = "btn_placeOrder";
            this.btn_placeOrder.Size = new System.Drawing.Size(129, 81);
            this.btn_placeOrder.TabIndex = 0;
            this.btn_placeOrder.Text = "Place Order";
            this.btn_placeOrder.UseVisualStyleBackColor = false;
            this.btn_placeOrder.Click += new System.EventHandler(this.btn_placeOrder_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.ForeColor = System.Drawing.Color.Red;
            this.btn_Exit.Location = new System.Drawing.Point(788, 1);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(35, 30);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 80);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(823, 371);
            this.main_panel.TabIndex = 2;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 451);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_update;
        private Button btn_placeOrder;
        private Button btn_Exit;
        private LinkLabel lbl_logout;
        private Panel pnl_nav;
        private Panel main_panel;
    }
}