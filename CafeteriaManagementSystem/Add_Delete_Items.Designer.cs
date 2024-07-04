namespace CafeteriaManagementSystem
{
    partial class Add_Delete_Items
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
            this.btn_DeleteItemForm = new System.Windows.Forms.Button();
            this.btn_updatePriceForm = new System.Windows.Forms.Button();
            this.btn_AddItemForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DeleteItemForm
            // 
            this.btn_DeleteItemForm.BackColor = System.Drawing.Color.Crimson;
            this.btn_DeleteItemForm.FlatAppearance.BorderSize = 0;
            this.btn_DeleteItemForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DeleteItemForm.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteItemForm.Location = new System.Drawing.Point(303, 252);
            this.btn_DeleteItemForm.Name = "btn_DeleteItemForm";
            this.btn_DeleteItemForm.Size = new System.Drawing.Size(170, 65);
            this.btn_DeleteItemForm.TabIndex = 1;
            this.btn_DeleteItemForm.Text = "Delete Items";
            this.btn_DeleteItemForm.UseVisualStyleBackColor = false;
            this.btn_DeleteItemForm.Click += new System.EventHandler(this.btn_DeleteItemForm_Click);
            // 
            // btn_updatePriceForm
            // 
            this.btn_updatePriceForm.BackColor = System.Drawing.Color.Gold;
            this.btn_updatePriceForm.FlatAppearance.BorderSize = 0;
            this.btn_updatePriceForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_updatePriceForm.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatePriceForm.Location = new System.Drawing.Point(505, 106);
            this.btn_updatePriceForm.Name = "btn_updatePriceForm";
            this.btn_updatePriceForm.Size = new System.Drawing.Size(170, 65);
            this.btn_updatePriceForm.TabIndex = 2;
            this.btn_updatePriceForm.Text = "Update Price";
            this.btn_updatePriceForm.UseVisualStyleBackColor = false;
            this.btn_updatePriceForm.Click += new System.EventHandler(this.btn_updatePriceForm_Click);
            // 
            // btn_AddItemForm
            // 
            this.btn_AddItemForm.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_AddItemForm.FlatAppearance.BorderSize = 0;
            this.btn_AddItemForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddItemForm.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddItemForm.Location = new System.Drawing.Point(103, 106);
            this.btn_AddItemForm.Name = "btn_AddItemForm";
            this.btn_AddItemForm.Size = new System.Drawing.Size(170, 65);
            this.btn_AddItemForm.TabIndex = 3;
            this.btn_AddItemForm.Text = "Add Items";
            this.btn_AddItemForm.UseVisualStyleBackColor = false;
            this.btn_AddItemForm.Click += new System.EventHandler(this.btn_AddItemForm_Click);
            // 
            // Add_Delete_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AddItemForm);
            this.Controls.Add(this.btn_updatePriceForm);
            this.Controls.Add(this.btn_DeleteItemForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Delete_Items";
            this.Text = "Add_Delete_Items";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_DeleteItemForm;
        private System.Windows.Forms.Button btn_updatePriceForm;
        private System.Windows.Forms.Button btn_AddItemForm;
    }
}