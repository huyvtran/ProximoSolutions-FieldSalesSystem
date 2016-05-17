namespace GUINew
{
    partial class ViewEmployee
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
            this.employeGrid = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
<<<<<<< HEAD
            this.batchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mFD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employeGrid)).BeginInit();
=======
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
>>>>>>> fcb33e7c63b9e32796192b8623168f1e3f8827d1
            this.SuspendLayout();
            // 
            // employeGrid
            // 
<<<<<<< HEAD
            this.employeGrid.AllowUserToDeleteRows = false;
            this.employeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.photo,
            this.batchNo,
            this.productName,
            this.category,
            this.unitPrice,
            this.mFD,
            this.eXP,
            this.quantity});
            this.employeGrid.GridColor = System.Drawing.SystemColors.Info;
            this.employeGrid.Location = new System.Drawing.Point(31, 33);
            this.employeGrid.Name = "employeGrid";
            this.employeGrid.ReadOnly = true;
            this.employeGrid.Size = new System.Drawing.Size(1003, 495);
            this.employeGrid.TabIndex = 2;
            // 
            // productID
            // 
            this.productID.HeaderText = "PID";
            this.productID.MinimumWidth = 60;
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Width = 60;
=======
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empNo,
            this.photo,
            this.name,
            this.jobTitle,
            this.status,
            this.mobile,
            this.email});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 150;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 510);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // empNo
            // 
            this.empNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.empNo.Frozen = true;
            this.empNo.HeaderText = "Emp No:";
            this.empNo.MinimumWidth = 60;
            this.empNo.Name = "empNo";
            this.empNo.ReadOnly = true;
            this.empNo.Width = 60;
>>>>>>> fcb33e7c63b9e32796192b8623168f1e3f8827d1
            // 
            // photo
            // 
            this.photo.HeaderText = "Photo";
            this.photo.MinimumWidth = 150;
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            this.photo.Width = 150;
            // 
<<<<<<< HEAD
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
=======
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.Frozen = true;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 200;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // jobTitle
            // 
            this.jobTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jobTitle.Frozen = true;
            this.jobTitle.HeaderText = "Job Title";
            this.jobTitle.MinimumWidth = 30;
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.ReadOnly = true;
            this.jobTitle.Width = 95;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.Frozen = true;
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 30;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 80;
            // 
            // mobile
            // 
            this.mobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mobile.Frozen = true;
            this.mobile.HeaderText = "Mobile";
            this.mobile.MinimumWidth = 60;
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            this.mobile.Width = 84;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.email.Frozen = true;
            this.email.HeaderText = "E-mail";
            this.email.MinimumWidth = 150;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 150;
>>>>>>> fcb33e7c63b9e32796192b8623168f1e3f8827d1
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(236)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.employeGrid);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Employee";
            ((System.ComponentModel.ISupportInitialize)(this.employeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.DataGridView employeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn mFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXP;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewImageColumn photo;
=======
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNo;
>>>>>>> fcb33e7c63b9e32796192b8623168f1e3f8827d1
    }
}