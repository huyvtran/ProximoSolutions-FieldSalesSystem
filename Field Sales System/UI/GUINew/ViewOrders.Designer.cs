namespace GUINew
{
    partial class ViewOrders
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
            this.viewOrderGrid = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.invoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickupList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.viewOrderButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // viewOrderGrid
            // 
            this.viewOrderGrid.AllowUserToDeleteRows = false;
            this.viewOrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewOrderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.invoiceNo,
            this.repName,
            this.region,
            this.orderStatus});
            this.viewOrderGrid.Location = new System.Drawing.Point(50, 41);
            this.viewOrderGrid.Margin = new System.Windows.Forms.Padding(4);
            this.viewOrderGrid.Name = "viewOrderGrid";
            this.viewOrderGrid.ReadOnly = true;
            this.viewOrderGrid.Size = new System.Drawing.Size(712, 448);
            this.viewOrderGrid.TabIndex = 0;
            // 
            // select
            // 
            this.select.HeaderText = "Select";
            this.select.MinimumWidth = 70;
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Width = 70;
            // 
            // invoiceNo
            // 
            this.invoiceNo.HeaderText = "Invoice No.";
            this.invoiceNo.MinimumWidth = 100;
            this.invoiceNo.Name = "invoiceNo";
            this.invoiceNo.ReadOnly = true;
            this.invoiceNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.invoiceNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.invoiceNo.Width = 150;
            // 
            // repName
            // 
            this.repName.HeaderText = "Representative name";
            this.repName.MinimumWidth = 150;
            this.repName.Name = "repName";
            this.repName.ReadOnly = true;
            this.repName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.repName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.repName.Width = 250;
            // 
            // region
            // 
            this.region.HeaderText = "Region";
            this.region.MinimumWidth = 100;
            this.region.Name = "region";
            this.region.ReadOnly = true;
            this.region.Width = 110;
            // 
            // orderStatus
            // 
            this.orderStatus.HeaderText = "Order Status";
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.ReadOnly = true;
            this.orderStatus.Width = 90;
            // 
            // pickupList
            // 
            this.pickupList.Location = new System.Drawing.Point(770, 80);
            this.pickupList.Margin = new System.Windows.Forms.Padding(4);
            this.pickupList.Name = "pickupList";
            this.pickupList.Size = new System.Drawing.Size(261, 333);
            this.pickupList.TabIndex = 1;
            this.pickupList.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(770, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pickup Schedule";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // viewOrderButton
            // 
            this.viewOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.viewOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.viewOrderButton.FlatAppearance.BorderSize = 0;
            this.viewOrderButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.viewOrderButton.Location = new System.Drawing.Point(770, 421);
            this.viewOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.viewOrderButton.Name = "viewOrderButton";
            this.viewOrderButton.Size = new System.Drawing.Size(261, 30);
            this.viewOrderButton.TabIndex = 10;
            this.viewOrderButton.Text = "View Order";
            this.viewOrderButton.UseVisualStyleBackColor = false;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.refreshButton.Location = new System.Drawing.Point(770, 459);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(261, 30);
            this.refreshButton.TabIndex = 11;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(236)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.viewOrderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickupList);
            this.Controls.Add(this.viewOrderGrid);
            this.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewOrderGrid;
        private System.Windows.Forms.ListView pickupList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn repName;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatus;
        private System.Windows.Forms.Button viewOrderButton;
        private System.Windows.Forms.Button refreshButton;
    }
}