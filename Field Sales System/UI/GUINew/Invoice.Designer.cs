namespace GUINew
{
    partial class Invoice
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
            this.invoiceDataGrid = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameCombo = new System.Windows.Forms.ComboBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.qtyText = new System.Windows.Forms.TextBox();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.invoiceNumberText = new System.Windows.Forms.TextBox();
            this.empIDText = new System.Windows.Forms.TextBox();
            this.customerNameText = new System.Windows.Forms.TextBox();
            this.customerContactText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.finishButton = new System.Windows.Forms.Button();
            this.totalText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceDataGrid
            // 
            this.invoiceDataGrid.AllowUserToAddRows = false;
            this.invoiceDataGrid.AllowUserToDeleteRows = false;
            this.invoiceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.productID,
            this.productName,
            this.unitPrice,
            this.quantity,
            this.value});
            this.invoiceDataGrid.Location = new System.Drawing.Point(46, 163);
            this.invoiceDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.invoiceDataGrid.Name = "invoiceDataGrid";
            this.invoiceDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoiceDataGrid.Size = new System.Drawing.Size(959, 220);
            this.invoiceDataGrid.TabIndex = 2;
            // 
            // select
            // 
            this.select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.select.Frozen = true;
            this.select.HeaderText = "Select";
            this.select.Name = "select";
            this.select.Width = 53;
            // 
            // productID
            // 
            this.productID.Frozen = true;
            this.productID.HeaderText = "Product ID";
            this.productID.MinimumWidth = 160;
            this.productID.Name = "productID";
            this.productID.Width = 160;
            // 
            // productName
            // 
            this.productName.Frozen = true;
            this.productName.HeaderText = "Product Name";
            this.productName.MinimumWidth = 250;
            this.productName.Name = "productName";
            this.productName.Width = 300;
            // 
            // unitPrice
            // 
            this.unitPrice.Frozen = true;
            this.unitPrice.HeaderText = "Unit Price";
            this.unitPrice.MinimumWidth = 160;
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Width = 160;
            // 
            // quantity
            // 
            this.quantity.Frozen = true;
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 130;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 130;
            // 
            // value
            // 
            this.value.Frozen = true;
            this.value.HeaderText = "Value";
            this.value.MinimumWidth = 130;
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.Width = 130;
            // 
            // productNameCombo
            // 
            this.productNameCombo.AllowDrop = true;
            this.productNameCombo.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameCombo.FormattingEnabled = true;
            this.productNameCombo.Location = new System.Drawing.Point(46, 128);
            this.productNameCombo.MaxDropDownItems = 5;
            this.productNameCombo.Name = "productNameCombo";
            this.productNameCombo.Size = new System.Drawing.Size(315, 28);
            this.productNameCombo.TabIndex = 65;
            this.productNameCombo.Text = "Product Name";
            this.productNameCombo.SelectedIndexChanged += new System.EventHandler(this.productNameCombo_SelectedIndexChanged);
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.addItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addItemButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.addItemButton.FlatAppearance.BorderSize = 0;
            this.addItemButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.addItemButton.Location = new System.Drawing.Point(869, 127);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(136, 30);
            this.addItemButton.TabIndex = 62;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // qtyText
            // 
            this.qtyText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyText.Location = new System.Drawing.Point(734, 128);
            this.qtyText.Name = "qtyText";
            this.qtyText.Size = new System.Drawing.Size(106, 27);
            this.qtyText.TabIndex = 66;
            this.qtyText.Text = "Quantity";
            this.qtyText.Click += new System.EventHandler(this.qtyText_Click);
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.unitPriceLabel.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.unitPriceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unitPriceLabel.Location = new System.Drawing.Point(573, 127);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(128, 28);
            this.unitPriceLabel.TabIndex = 70;
            this.unitPriceLabel.Text = "Unit Price";
            this.unitPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productIDLabel
            // 
            this.productIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productIDLabel.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDLabel.ForeColor = System.Drawing.Color.Black;
            this.productIDLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productIDLabel.Location = new System.Drawing.Point(390, 129);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(151, 28);
            this.productIDLabel.TabIndex = 71;
            this.productIDLabel.Text = "Product ID";
            this.productIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(42, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 72;
            this.label7.Text = "Invoice Number";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(480, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 73;
            this.label1.Text = "Emp. ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 74;
            this.label2.Text = "Customer";
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Location = new System.Drawing.Point(897, 26);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(108, 23);
            this.dateLabel.TabIndex = 75;
            this.dateLabel.Text = "Set Date Here";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Black;
            this.timeLabel.Location = new System.Drawing.Point(897, 63);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(108, 23);
            this.timeLabel.TabIndex = 76;
            this.timeLabel.Text = "Set Time Here";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // invoiceNumberText
            // 
            this.invoiceNumberText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNumberText.Location = new System.Drawing.Point(158, 22);
            this.invoiceNumberText.Name = "invoiceNumberText";
            this.invoiceNumberText.Size = new System.Drawing.Size(180, 27);
            this.invoiceNumberText.TabIndex = 77;
            // 
            // empIDText
            // 
            this.empIDText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIDText.Location = new System.Drawing.Point(557, 22);
            this.empIDText.Name = "empIDText";
            this.empIDText.Size = new System.Drawing.Size(180, 27);
            this.empIDText.TabIndex = 78;
            // 
            // customerNameText
            // 
            this.customerNameText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameText.Location = new System.Drawing.Point(158, 59);
            this.customerNameText.Name = "customerNameText";
            this.customerNameText.Size = new System.Drawing.Size(298, 27);
            this.customerNameText.TabIndex = 79;
            // 
            // customerContactText
            // 
            this.customerContactText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerContactText.Location = new System.Drawing.Point(557, 59);
            this.customerContactText.Name = "customerContactText";
            this.customerContactText.Size = new System.Drawing.Size(180, 27);
            this.customerContactText.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(479, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 80;
            this.label3.Text = "Region";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // finishButton
            // 
            this.finishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.finishButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.finishButton.FlatAppearance.BorderSize = 0;
            this.finishButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.finishButton.Location = new System.Drawing.Point(868, 390);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(136, 30);
            this.finishButton.TabIndex = 82;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = false;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click_1);
            // 
            // totalText
            // 
            this.totalText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalText.Location = new System.Drawing.Point(868, 434);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(136, 27);
            this.totalText.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(781, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 84;
            this.label6.Text = "Total";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.clearButton.Location = new System.Drawing.Point(45, 390);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(213, 30);
            this.clearButton.TabIndex = 89;
            this.clearButton.Text = "New Order";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.removeButton.Location = new System.Drawing.Point(283, 390);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(213, 30);
            this.removeButton.TabIndex = 90;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(236)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1064, 533);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.customerContactText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerNameText);
            this.Controls.Add(this.empIDText);
            this.Controls.Add(this.invoiceNumberText);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productIDLabel);
            this.Controls.Add(this.unitPriceLabel);
            this.Controls.Add(this.qtyText);
            this.Controls.Add(this.productNameCombo);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.invoiceDataGrid);
            this.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Invoice";
            this.Text = "Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView invoiceDataGrid;
        public System.Windows.Forms.ComboBox productNameCombo;
        public System.Windows.Forms.Button addItemButton;
        public System.Windows.Forms.TextBox qtyText;
        public System.Windows.Forms.Label unitPriceLabel;
        public System.Windows.Forms.Label productIDLabel;
        public System.Windows.Forms.Label timeLabel;
        public System.Windows.Forms.TextBox invoiceNumberText;
        public System.Windows.Forms.TextBox empIDText;
        public System.Windows.Forms.TextBox customerNameText;
        public System.Windows.Forms.TextBox customerContactText;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label dateLabel;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button finishButton;
        public System.Windows.Forms.TextBox totalText;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button clearButton;
        public System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
    }
}