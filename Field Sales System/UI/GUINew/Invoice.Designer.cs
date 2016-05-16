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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productNameCombo = new System.Windows.Forms.ComboBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.qtyText = new System.Windows.Forms.TextBox();
            this.batchNoCombo = new System.Windows.Forms.ComboBox();
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
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.productID,
            this.productName,
            this.unitPrice,
            this.quantity,
            this.value});
            this.dataGridView2.Location = new System.Drawing.Point(46, 163);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(959, 227);
            this.dataGridView2.TabIndex = 2;
            // 
            // productNameCombo
            // 
            this.productNameCombo.AllowDrop = true;
            this.productNameCombo.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameCombo.FormattingEnabled = true;
            this.productNameCombo.Items.AddRange(new object[] {
            "New Orders",
            "Pending Orders",
            "Delivered Orders",
            "Accepted Orders",
            "Rejected Orders"});
            this.productNameCombo.Location = new System.Drawing.Point(46, 128);
            this.productNameCombo.MaxDropDownItems = 5;
            this.productNameCombo.Name = "productNameCombo";
            this.productNameCombo.Size = new System.Drawing.Size(283, 28);
            this.productNameCombo.TabIndex = 65;
            this.productNameCombo.Text = "Product Name";
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.addItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addItemButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.addItemButton.FlatAppearance.BorderSize = 0;
            this.addItemButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.addItemButton.Location = new System.Drawing.Point(845, 128);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(160, 30);
            this.addItemButton.TabIndex = 62;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = false;
            // 
            // qtyText
            // 
            this.qtyText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyText.Location = new System.Drawing.Point(728, 129);
            this.qtyText.Name = "qtyText";
            this.qtyText.Size = new System.Drawing.Size(92, 28);
            this.qtyText.TabIndex = 66;
            this.qtyText.Text = "Quantity";
            // 
            // batchNoCombo
            // 
            this.batchNoCombo.AllowDrop = true;
            this.batchNoCombo.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchNoCombo.FormattingEnabled = true;
            this.batchNoCombo.Items.AddRange(new object[] {
            "New Orders",
            "Pending Orders",
            "Delivered Orders",
            "Accepted Orders",
            "Rejected Orders"});
            this.batchNoCombo.Location = new System.Drawing.Point(484, 128);
            this.batchNoCombo.MaxDropDownItems = 5;
            this.batchNoCombo.Name = "batchNoCombo";
            this.batchNoCombo.Size = new System.Drawing.Size(106, 28);
            this.batchNoCombo.TabIndex = 69;
            this.batchNoCombo.Text = "Batch No";
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.unitPriceLabel.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.unitPriceLabel.Location = new System.Drawing.Point(605, 129);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(104, 28);
            this.unitPriceLabel.TabIndex = 70;
            this.unitPriceLabel.Text = "Unit Price";
            this.unitPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productIDLabel
            // 
            this.productIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productIDLabel.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDLabel.ForeColor = System.Drawing.Color.Black;
            this.productIDLabel.Location = new System.Drawing.Point(345, 128);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(123, 28);
            this.productIDLabel.TabIndex = 71;
            this.productIDLabel.Text = "Product ID";
            this.productIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(42, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 72;
            this.label7.Text = "Invoice Number";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(480, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 73;
            this.label1.Text = "Emp. ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 74;
            this.label2.Text = "Customer";
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Location = new System.Drawing.Point(909, 25);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(108, 23);
            this.dateLabel.TabIndex = 75;
            this.dateLabel.Text = "Set Date Here";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Black;
            this.timeLabel.Location = new System.Drawing.Point(909, 62);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(108, 23);
            this.timeLabel.TabIndex = 76;
            this.timeLabel.Text = "Set Time Here";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoiceNumberText
            // 
            this.invoiceNumberText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNumberText.Location = new System.Drawing.Point(158, 22);
            this.invoiceNumberText.Name = "invoiceNumberText";
            this.invoiceNumberText.Size = new System.Drawing.Size(180, 28);
            this.invoiceNumberText.TabIndex = 77;
            // 
            // empIDText
            // 
            this.empIDText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIDText.Location = new System.Drawing.Point(557, 22);
            this.empIDText.Name = "empIDText";
            this.empIDText.Size = new System.Drawing.Size(180, 28);
            this.empIDText.TabIndex = 78;
            // 
            // customerNameText
            // 
            this.customerNameText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameText.Location = new System.Drawing.Point(158, 59);
            this.customerNameText.Name = "customerNameText";
            this.customerNameText.Size = new System.Drawing.Size(298, 28);
            this.customerNameText.TabIndex = 79;
            // 
            // customerContactText
            // 
            this.customerContactText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerContactText.Location = new System.Drawing.Point(557, 59);
            this.customerContactText.Name = "customerContactText";
            this.customerContactText.Size = new System.Drawing.Size(180, 28);
            this.customerContactText.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(479, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 80;
            this.label3.Text = "Contact";
            // 
            // select
            // 
            this.select.Frozen = true;
            this.select.HeaderText = "Select";
            this.select.MinimumWidth = 65;
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.select.Width = 65;
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
            this.productName.Width = 270;
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
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(236)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1064, 533);
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
            this.Controls.Add(this.batchNoCombo);
            this.Controls.Add(this.qtyText);
            this.Controls.Add(this.productNameCombo);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Invoice";
            this.Text = "Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox productNameCombo;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.TextBox qtyText;
        private System.Windows.Forms.ComboBox batchNoCombo;
        private System.Windows.Forms.Label unitPriceLabel;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox invoiceNumberText;
        private System.Windows.Forms.TextBox empIDText;
        private System.Windows.Forms.TextBox customerNameText;
        private System.Windows.Forms.TextBox customerContactText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}