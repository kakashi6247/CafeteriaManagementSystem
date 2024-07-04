namespace CafeteriaManagementSystem
{
    partial class DEL
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
            this.cmb_delItem = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeteriaItemDataSet = new CafeteriaManagementSystem.cafeteriaItemDataSet();
            this.lbl_slctDelItem = new System.Windows.Forms.Label();
            this.btn_delItem = new System.Windows.Forms.Button();
            this.btn_DelCancel = new System.Windows.Forms.Button();
            this.itemTableAdapter = new CafeteriaManagementSystem.cafeteriaItemDataSetTableAdapters.itemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeteriaItemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_delItem
            // 
            this.cmb_delItem.DataSource = this.itemBindingSource;
            this.cmb_delItem.DisplayMember = "name";
            this.cmb_delItem.FormattingEnabled = true;
            this.cmb_delItem.ItemHeight = 13;
            this.cmb_delItem.Location = new System.Drawing.Point(139, 105);
            this.cmb_delItem.Name = "cmb_delItem";
            this.cmb_delItem.Size = new System.Drawing.Size(234, 21);
            this.cmb_delItem.TabIndex = 0;
            this.cmb_delItem.ValueMember = "id";
            this.cmb_delItem.SelectedIndexChanged += new System.EventHandler(this.cmb_delItem_SelectedIndexChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.cafeteriaItemDataSet;
            // 
            // cafeteriaItemDataSet
            // 
            this.cafeteriaItemDataSet.DataSetName = "cafeteriaItemDataSet";
            this.cafeteriaItemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_slctDelItem
            // 
            this.lbl_slctDelItem.AutoSize = true;
            this.lbl_slctDelItem.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_slctDelItem.Location = new System.Drawing.Point(134, 62);
            this.lbl_slctDelItem.Name = "lbl_slctDelItem";
            this.lbl_slctDelItem.Size = new System.Drawing.Size(213, 26);
            this.lbl_slctDelItem.TabIndex = 1;
            this.lbl_slctDelItem.Text = "Select Item to Delete";
            // 
            // btn_delItem
            // 
            this.btn_delItem.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delItem.Location = new System.Drawing.Point(154, 220);
            this.btn_delItem.Name = "btn_delItem";
            this.btn_delItem.Size = new System.Drawing.Size(202, 49);
            this.btn_delItem.TabIndex = 2;
            this.btn_delItem.Text = "Delete Item";
            this.btn_delItem.UseVisualStyleBackColor = false;
            this.btn_delItem.Click += new System.EventHandler(this.btn_delItem_Click);
            // 
            // btn_DelCancel
            // 
            this.btn_DelCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btn_DelCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DelCancel.Location = new System.Drawing.Point(207, 294);
            this.btn_DelCancel.Name = "btn_DelCancel";
            this.btn_DelCancel.Size = new System.Drawing.Size(102, 27);
            this.btn_DelCancel.TabIndex = 2;
            this.btn_DelCancel.Text = "Cancel";
            this.btn_DelCancel.UseVisualStyleBackColor = false;
            this.btn_DelCancel.Click += new System.EventHandler(this.btn_DelCancel_Click);
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // DEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(520, 400);
            this.Controls.Add(this.btn_DelCancel);
            this.Controls.Add(this.btn_delItem);
            this.Controls.Add(this.lbl_slctDelItem);
            this.Controls.Add(this.cmb_delItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DEL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEL";
            this.Load += new System.EventHandler(this.DEL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeteriaItemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_delItem;
        private System.Windows.Forms.Label lbl_slctDelItem;
        private System.Windows.Forms.Button btn_delItem;
        private System.Windows.Forms.Button btn_DelCancel;
        private cafeteriaItemDataSet cafeteriaItemDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private cafeteriaItemDataSetTableAdapters.itemTableAdapter itemTableAdapter;
    }
}