namespace CafeteriaManagementSystem
{
    partial class ADD
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
            this.btn_addItem = new System.Windows.Forms.Button();
            this.btn_AddCancel = new System.Windows.Forms.Button();
            this.txt_itemName = new System.Windows.Forms.RichTextBox();
            this.txt_itemPrice = new System.Windows.Forms.RichTextBox();
            this.lbl_itemName = new System.Windows.Forms.Label();
            this.lbl_itemPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_addItem
            // 
            this.btn_addItem.BackColor = System.Drawing.Color.Black;
            this.btn_addItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItem.ForeColor = System.Drawing.Color.White;
            this.btn_addItem.Location = new System.Drawing.Point(200, 289);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(168, 61);
            this.btn_addItem.TabIndex = 0;
            this.btn_addItem.Text = "Add Item";
            this.btn_addItem.UseVisualStyleBackColor = false;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // btn_AddCancel
            // 
            this.btn_AddCancel.BackColor = System.Drawing.Color.DimGray;
            this.btn_AddCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCancel.ForeColor = System.Drawing.Color.Black;
            this.btn_AddCancel.Location = new System.Drawing.Point(229, 356);
            this.btn_AddCancel.Name = "btn_AddCancel";
            this.btn_AddCancel.Size = new System.Drawing.Size(112, 35);
            this.btn_AddCancel.TabIndex = 1;
            this.btn_AddCancel.Text = "Cancel";
            this.btn_AddCancel.UseVisualStyleBackColor = false;
            this.btn_AddCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_itemName
            // 
            this.txt_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemName.Location = new System.Drawing.Point(121, 83);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(318, 43);
            this.txt_itemName.TabIndex = 2;
            this.txt_itemName.Text = "";
            // 
            // txt_itemPrice
            // 
            this.txt_itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemPrice.Location = new System.Drawing.Point(130, 212);
            this.txt_itemPrice.Name = "txt_itemPrice";
            this.txt_itemPrice.Size = new System.Drawing.Size(318, 42);
            this.txt_itemPrice.TabIndex = 2;
            this.txt_itemPrice.Text = "";
            this.txt_itemPrice.TextChanged += new System.EventHandler(this.txt_itemPrice_TextChanged);
            this.txt_itemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_itemPrice_KeyPress);
            // 
            // lbl_itemName
            // 
            this.lbl_itemName.AutoSize = true;
            this.lbl_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemName.Location = new System.Drawing.Point(135, 43);
            this.lbl_itemName.Name = "lbl_itemName";
            this.lbl_itemName.Size = new System.Drawing.Size(110, 24);
            this.lbl_itemName.TabIndex = 3;
            this.lbl_itemName.Text = "Item Name";
            this.lbl_itemName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_itemPrice
            // 
            this.lbl_itemPrice.AutoSize = true;
            this.lbl_itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemPrice.Location = new System.Drawing.Point(135, 176);
            this.lbl_itemPrice.Name = "lbl_itemPrice";
            this.lbl_itemPrice.Size = new System.Drawing.Size(103, 24);
            this.lbl_itemPrice.TabIndex = 3;
            this.lbl_itemPrice.Text = "Item Price";
            this.lbl_itemPrice.Click += new System.EventHandler(this.label1_Click);
            // 
            // ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(566, 439);
            this.Controls.Add(this.lbl_itemPrice);
            this.Controls.Add(this.lbl_itemName);
            this.Controls.Add(this.txt_itemPrice);
            this.Controls.Add(this.txt_itemName);
            this.Controls.Add(this.btn_AddCancel);
            this.Controls.Add(this.btn_addItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADDnDEL";
            this.Load += new System.EventHandler(this.ADD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Button btn_AddCancel;
        private System.Windows.Forms.RichTextBox txt_itemName;
        private System.Windows.Forms.RichTextBox txt_itemPrice;
        private System.Windows.Forms.Label lbl_itemName;
        private System.Windows.Forms.Label lbl_itemPrice;
    }
}