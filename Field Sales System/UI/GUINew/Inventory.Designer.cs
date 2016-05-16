namespace GUINew
{
    partial class Inventory
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
            this.inventoryGrid = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.batchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mFD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryGrid
            // 
            this.inventoryGrid.AllowUserToAddRows = false;
            this.inventoryGrid.AllowUserToDeleteRows = false;
            this.inventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.photo,
            this.batchNo,
            this.productName,
            this.category,
            this.unitPrice,
            this.mFD,
            this.eXP,
            this.quantity});
            this.inventoryGrid.GridColor = System.Drawing.SystemColors.Info;
            this.inventoryGrid.Location = new System.Drawing.Point(32, 35);
            this.inventoryGrid.Name = "inventoryGrid";
            this.inventoryGrid.ReadOnly = true;
            this.inventoryGrid.Size = new System.Drawing.Size(1003, 495);
            this.inventoryGrid.TabIndex = 1;
            // 
            // productID
            // 
            this.productID.HeaderText = "PID";
            this.productID.MinimumWidth = 60;
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Width = 60;
            // 
            // photo
            // 
            this.photo.HeaderText = "Photo";
            this.photo.MinimumWidth = 150;
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            this.photo.Width = 150;
            // 
            // batchNo
            // 
            this.batchNo.HeaderText = "Batch No.";
            this.batchNo.MinimumWidth = 60;
            this.batchNo.Name = "batchNo";
            this.batchNo.ReadOnly = true;
            this.batchNo.Width = 60;
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.MinimumWidth = 250;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 250;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 110;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 110;
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Unit Price";
            this.unitPrice.MinimumWidth = 75;
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.ReadOnly = true;
            this.unitPrice.Width = 75;
            // 
            // mFD
            // 
            this.mFD.HeaderText = "MFD";
            this.mFD.MinimumWidth = 80;
            this.mFD.Name = "mFD";
            this.mFD.ReadOnly = true;
            this.mFD.Width = 80;
            // 
            // eXP
            // 
            this.eXP.HeaderText = "EXP";
            this.eXP.MinimumWidth = 80;
            this.eXP.Name = "eXP";
            this.eXP.ReadOnly = true;
            this.eXP.Width = 80;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 100;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(236)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.inventoryGrid);
            this.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView inventoryGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn mFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXP;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}