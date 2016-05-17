namespace GUINew
{
    partial class OrderDetails
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
            this.rejectOrderButton = new System.Windows.Forms.Button();
            this.acceptOrderButton = new System.Windows.Forms.Button();
            this.customerContactText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerNameText = new System.Windows.Forms.TextBox();
            this.empIDText = new System.Windows.Forms.TextBox();
            this.invoiceNumberText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateAndTimeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.invoiceDataGrid = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doneButton = new System.Windows.Forms.Button();
            this.dispatchOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // rejectOrderButton
            // 
            this.rejectOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.rejectOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rejectOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.rejectOrderButton.FlatAppearance.BorderSize = 0;
            this.rejectOrderButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.rejectOrderButton.Location = new System.Drawing.Point(303, 498);
            this.rejectOrderButton.Name = "rejectOrderButton";
            this.rejectOrderButton.Size = new System.Drawing.Size(213, 30);
            this.rejectOrderButton.TabIndex = 103;
            this.rejectOrderButton.Text = "Reject Order";
            this.rejectOrderButton.UseVisualStyleBackColor = false;
            // 
            // acceptOrderButton
            // 
            this.acceptOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.acceptOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.acceptOrderButton.FlatAppearance.BorderSize = 0;
            this.acceptOrderButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.acceptOrderButton.Location = new System.Drawing.Point(60, 498);
            this.acceptOrderButton.Name = "acceptOrderButton";
            this.acceptOrderButton.Size = new System.Drawing.Size(213, 30);
            this.acceptOrderButton.TabIndex = 102;
            this.acceptOrderButton.Text = "Accept Order";
            this.acceptOrderButton.UseVisualStyleBackColor = false;
            // 
            // customerContactText
            // 
            this.customerContactText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerContactText.Location = new System.Drawing.Point(571, 73);
            this.customerContactText.Name = "customerContactText";
            this.customerContactText.ReadOnly = true;
            this.customerContactText.Size = new System.Drawing.Size(180, 28);
            this.customerContactText.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(493, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 100;
            this.label3.Text = "Contact";
            // 
            // customerNameText
            // 
            this.customerNameText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameText.Location = new System.Drawing.Point(172, 73);
            this.customerNameText.Name = "customerNameText";
            this.customerNameText.ReadOnly = true;
            this.customerNameText.Size = new System.Drawing.Size(298, 28);
            this.customerNameText.TabIndex = 99;
            // 
            // empIDText
            // 
            this.empIDText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIDText.Location = new System.Drawing.Point(571, 36);
            this.empIDText.Name = "empIDText";
            this.empIDText.ReadOnly = true;
            this.empIDText.Size = new System.Drawing.Size(180, 28);
            this.empIDText.TabIndex = 98;
            // 
            // invoiceNumberText
            // 
            this.invoiceNumberText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNumberText.Location = new System.Drawing.Point(172, 36);
            this.invoiceNumberText.Name = "invoiceNumberText";
            this.invoiceNumberText.ReadOnly = true;
            this.invoiceNumberText.Size = new System.Drawing.Size(180, 28);
            this.invoiceNumberText.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(56, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 94;
            this.label2.Text = "Customer";
            // 
            // dateAndTimeLabel
            // 
            this.dateAndTimeLabel.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAndTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.dateAndTimeLabel.Location = new System.Drawing.Point(831, 40);
            this.dateAndTimeLabel.Name = "dateAndTimeLabel";
            this.dateAndTimeLabel.Size = new System.Drawing.Size(188, 23);
            this.dateAndTimeLabel.TabIndex = 95;
            this.dateAndTimeLabel.Text = "Set Date-Time Here";
            this.dateAndTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(56, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 92;
            this.label7.Text = "Invoice No.";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(494, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 93;
            this.label1.Text = "Emp. ID";
            // 
            // invoiceDataGrid
            // 
            this.invoiceDataGrid.AllowUserToAddRows = false;
            this.invoiceDataGrid.AllowUserToDeleteRows = false;
            this.invoiceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.unitPrice,
            this.quantity,
            this.value});
            this.invoiceDataGrid.Location = new System.Drawing.Point(60, 126);
            this.invoiceDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.invoiceDataGrid.Name = "invoiceDataGrid";
            this.invoiceDataGrid.ReadOnly = true;
            this.invoiceDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoiceDataGrid.Size = new System.Drawing.Size(959, 350);
            this.invoiceDataGrid.TabIndex = 91;
            // 
            // productID
            // 
            this.productID.Frozen = true;
            this.productID.HeaderText = "Product ID";
            this.productID.MinimumWidth = 160;
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Width = 160;
            // 
            // productName
            // 
            this.productName.Frozen = true;
            this.productName.HeaderText = "Product Name";
            this.productName.MinimumWidth = 300;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 320;
            // 
            // unitPrice
            // 
            this.unitPrice.Frozen = true;
            this.unitPrice.HeaderText = "Unit Price";
            this.unitPrice.MinimumWidth = 160;
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.ReadOnly = true;
            this.unitPrice.Width = 160;
            // 
            // quantity
            // 
            this.quantity.Frozen = true;
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 130;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 150;
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
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.doneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doneButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.doneButton.FlatAppearance.BorderSize = 0;
            this.doneButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.doneButton.Location = new System.Drawing.Point(806, 498);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(213, 30);
            this.doneButton.TabIndex = 104;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // dispatchOrderButton
            // 
            this.dispatchOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.dispatchOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dispatchOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.dispatchOrderButton.FlatAppearance.BorderSize = 0;
            this.dispatchOrderButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispatchOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.dispatchOrderButton.Location = new System.Drawing.Point(555, 498);
            this.dispatchOrderButton.Name = "dispatchOrderButton";
            this.dispatchOrderButton.Size = new System.Drawing.Size(213, 30);
            this.dispatchOrderButton.TabIndex = 105;
            this.dispatchOrderButton.Text = "Dispatch Order";
            this.dispatchOrderButton.UseVisualStyleBackColor = false;
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(236)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.dispatchOrderButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.rejectOrderButton);
            this.Controls.Add(this.acceptOrderButton);
            this.Controls.Add(this.customerContactText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerNameText);
            this.Controls.Add(this.empIDText);
            this.Controls.Add(this.invoiceNumberText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateAndTimeLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.invoiceDataGrid);
            this.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Order Details";
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rejectOrderButton;
        private System.Windows.Forms.Button acceptOrderButton;
        private System.Windows.Forms.TextBox customerContactText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerNameText;
        private System.Windows.Forms.TextBox empIDText;
        private System.Windows.Forms.TextBox invoiceNumberText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dateAndTimeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView invoiceDataGrid;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.Button dispatchOrderButton;
    }
}