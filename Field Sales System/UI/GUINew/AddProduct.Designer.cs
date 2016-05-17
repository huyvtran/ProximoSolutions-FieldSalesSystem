namespace Field_Sales_System.UI.GUINew
{
    partial class AddProduct
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productIDText = new System.Windows.Forms.TextBox();
            this.batchNoText = new System.Windows.Forms.TextBox();
            this.productNameText = new System.Windows.Forms.TextBox();
            this.productNameCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionRichText = new System.Windows.Forms.RichTextBox();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.expDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mfdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.InitialImage = global::Field_Sales_System.Properties.Resources.Camera;
            this.pictureBox1.Location = new System.Drawing.Point(53, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label9.Location = new System.Drawing.Point(233, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 23);
            this.label9.TabIndex = 37;
            this.label9.Text = "Product Name";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label10.Location = new System.Drawing.Point(643, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 23);
            this.label10.TabIndex = 36;
            this.label10.Text = "Product ID";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(49, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Batch No";
            // 
            // productIDText
            // 
            this.productIDText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDText.Location = new System.Drawing.Point(647, 77);
            this.productIDText.Name = "productIDText";
            this.productIDText.Size = new System.Drawing.Size(135, 28);
            this.productIDText.TabIndex = 42;
            // 
            // batchNoText
            // 
            this.batchNoText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchNoText.Location = new System.Drawing.Point(151, 208);
            this.batchNoText.Name = "batchNoText";
            this.batchNoText.Size = new System.Drawing.Size(122, 28);
            this.batchNoText.TabIndex = 41;
            // 
            // productNameText
            // 
            this.productNameText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameText.Location = new System.Drawing.Point(237, 110);
            this.productNameText.Name = "productNameText";
            this.productNameText.Size = new System.Drawing.Size(334, 28);
            this.productNameText.TabIndex = 40;
            // 
            // productNameCombo
            // 
            this.productNameCombo.AllowDrop = true;
            this.productNameCombo.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameCombo.FormattingEnabled = true;
            this.productNameCombo.Items.AddRange(new object[] {
            "--New--"});
            this.productNameCombo.Location = new System.Drawing.Point(237, 77);
            this.productNameCombo.MaxDropDownItems = 5;
            this.productNameCombo.Name = "productNameCombo";
            this.productNameCombo.Size = new System.Drawing.Size(334, 28);
            this.productNameCombo.TabIndex = 66;
            this.productNameCombo.Text = "Product Name";
            this.productNameCombo.SelectedIndexChanged += new System.EventHandler(this.productNameCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(49, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 67;
            this.label2.Text = "Description";
            // 
            // descriptionRichText
            // 
            this.descriptionRichText.Location = new System.Drawing.Point(151, 264);
            this.descriptionRichText.Name = "descriptionRichText";
            this.descriptionRichText.Size = new System.Drawing.Size(857, 163);
            this.descriptionRichText.TabIndex = 68;
            this.descriptionRichText.Text = "";
            // 
            // categoryCombo
            // 
            this.categoryCombo.AllowDrop = true;
            this.categoryCombo.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Items.AddRange(new object[] {
            "Chocolate",
            "Toffee",
            "Biscuit",
            "Soap"});
            this.categoryCombo.Location = new System.Drawing.Point(854, 77);
            this.categoryCombo.MaxDropDownItems = 5;
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(154, 28);
            this.categoryCombo.TabIndex = 70;
            this.categoryCombo.Text = "Category";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label3.Location = new System.Drawing.Point(850, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 69;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label4.Location = new System.Drawing.Point(712, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 71;
            this.label4.Text = "EXP";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label5.Location = new System.Drawing.Point(335, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 73;
            this.label5.Text = "MFD";
            // 
            // expDateTimePicker
            // 
            this.expDateTimePicker.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expDateTimePicker.Location = new System.Drawing.Point(763, 205);
            this.expDateTimePicker.Name = "expDateTimePicker";
            this.expDateTimePicker.Size = new System.Drawing.Size(245, 28);
            this.expDateTimePicker.TabIndex = 74;
            // 
            // mfdDateTimePicker
            // 
            this.mfdDateTimePicker.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mfdDateTimePicker.Location = new System.Drawing.Point(394, 205);
            this.mfdDateTimePicker.Name = "mfdDateTimePicker";
            this.mfdDateTimePicker.Size = new System.Drawing.Size(245, 28);
            this.mfdDateTimePicker.TabIndex = 75;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.clearButton.Location = new System.Drawing.Point(570, 480);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(200, 30);
            this.clearButton.TabIndex = 77;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.addButton.Location = new System.Drawing.Point(270, 480);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(200, 30);
            this.addButton.TabIndex = 76;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(236)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.mfdDateTimePicker);
            this.Controls.Add(this.expDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categoryCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriptionRichText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productNameCombo);
            this.Controls.Add(this.productIDText);
            this.Controls.Add(this.batchNoText);
            this.Controls.Add(this.productNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox productIDText;
        public System.Windows.Forms.TextBox batchNoText;
        public System.Windows.Forms.TextBox productNameText;
        private System.Windows.Forms.ComboBox productNameCombo;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox descriptionRichText;
        private System.Windows.Forms.ComboBox categoryCombo;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker expDateTimePicker;
        public System.Windows.Forms.DateTimePicker mfdDateTimePicker;
        public System.Windows.Forms.Button clearButton;
        public System.Windows.Forms.Button addButton;
    }
}