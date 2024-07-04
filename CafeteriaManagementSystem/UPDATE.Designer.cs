namespace CafeteriaManagementSystem
{
    partial class UPDATE
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
            this.components = new System.ComponentModel.Container();
            this.btn_UptCancel = new System.Windows.Forms.Button();
            this.btn_UptItem = new System.Windows.Forms.Button();
            this.lbl_slctUptItem = new System.Windows.Forms.Label();
            this.cmb_UpdateItem = new System.Windows.Forms.ComboBox();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cafeteriaUpdateDataSet = new CafeteriaManagementSystem.cafeteriaUpdateDataSet();
            this.txt_newPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cafeteriaDataSet1 = new CafeteriaManagementSystem.cafeteriaDataSet1();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new CafeteriaManagementSystem.cafeteriaDataSet1TableAdapters.itemTableAdapter();
            this.itemTableAdapter1 = new CafeteriaManagementSystem.cafeteriaUpdateDataSetTableAdapters.itemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeteriaUpdateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeteriaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_UptCancel
            // 
            this.btn_UptCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btn_UptCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_UptCancel.Location = new System.Drawing.Point(221, 283);
            this.btn_UptCancel.Name = "btn_UptCancel";
            this.btn_UptCancel.Size = new System.Drawing.Size(102, 27);
            this.btn_UptCancel.TabIndex = 5;
            this.btn_UptCancel.Text = "Cancel";
            this.btn_UptCancel.UseVisualStyleBackColor = false;
            this.btn_UptCancel.Click += new System.EventHandler(this.btn_UptCancel_Click);
            // 
            // btn_UptItem
            // 
            this.btn_UptItem.BackColor = System.Drawing.Color.IndianRed;
            this.btn_UptItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_UptItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UptItem.Location = new System.Drawing.Point(168, 228);
            this.btn_UptItem.Name = "btn_UptItem";
            this.btn_UptItem.Size = new System.Drawing.Size(202, 49);
            this.btn_UptItem.TabIndex = 6;
            this.btn_UptItem.Text = "Update Price";
            this.btn_UptItem.UseVisualStyleBackColor = false;
            this.btn_UptItem.Click += new System.EventHandler(this.btn_UptItem_Click);
            // 
            // lbl_slctUptItem
            // 
            this.lbl_slctUptItem.AutoSize = true;
            this.lbl_slctUptItem.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_slctUptItem.Location = new System.Drawing.Point(148, 51);
            this.lbl_slctUptItem.Name = "lbl_slctUptItem";
            this.lbl_slctUptItem.Size = new System.Drawing.Size(222, 26);
            this.lbl_slctUptItem.TabIndex = 4;
            this.lbl_slctUptItem.Text = "Select Item to Update";
            // 
            // cmb_UpdateItem
            // 
            this.cmb_UpdateItem.DataSource = this.itemBindingSource1;
            this.cmb_UpdateItem.DisplayMember = "name";
            this.cmb_UpdateItem.FormattingEnabled = true;
            this.cmb_UpdateItem.ItemHeight = 13;
            this.cmb_UpdateItem.Location = new System.Drawing.Point(153, 80);
            this.cmb_UpdateItem.Name = "cmb_UpdateItem";
            this.cmb_UpdateItem.Size = new System.Drawing.Size(234, 21);
            this.cmb_UpdateItem.TabIndex = 3;
            this.cmb_UpdateItem.ValueMember = "id";
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataMember = "item";
            this.itemBindingSource1.DataSource = this.cafeteriaUpdateDataSet;
            // 
            // cafeteriaUpdateDataSet
            // 
            this.cafeteriaUpdateDataSet.DataSetName = "cafeteriaUpdateDataSet";
            this.cafeteriaUpdateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_newPrice
            // 
            this.txt_newPrice.Location = new System.Drawing.Point(153, 180);
            this.txt_newPrice.Name = "txt_newPrice";
            this.txt_newPrice.Size = new System.Drawing.Size(234, 20);
            this.txt_newPrice.TabIndex = 7;
            this.txt_newPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_newPrice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter new Price";
            // 
            // cafeteriaDataSet1
            // 
            this.cafeteriaDataSet1.DataSetName = "cafeteriaDataSet1";
            this.cafeteriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.cafeteriaDataSet1;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // itemTableAdapter1
            // 
            this.itemTableAdapter1.ClearBeforeFill = true;
            // 
            // UPDATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(521, 361);
            this.Controls.Add(this.txt_newPrice);
            this.Controls.Add(this.btn_UptCancel);
            this.Controls.Add(this.btn_UptItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_slctUptItem);
            this.Controls.Add(this.cmb_UpdateItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UPDATE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPDATE";
            this.Load += new System.EventHandler(this.UPDATE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeteriaUpdateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeteriaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_UptCancel;
        private System.Windows.Forms.Button btn_UptItem;
        private System.Windows.Forms.Label lbl_slctUptItem;
        private System.Windows.Forms.ComboBox cmb_UpdateItem;
        private System.Windows.Forms.TextBox txt_newPrice;
        private System.Windows.Forms.Label label1;
        private cafeteriaDataSet1 cafeteriaDataSet1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private cafeteriaDataSet1TableAdapters.itemTableAdapter itemTableAdapter;
        private cafeteriaUpdateDataSet cafeteriaUpdateDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private cafeteriaUpdateDataSetTableAdapters.itemTableAdapter itemTableAdapter1;
    }
}