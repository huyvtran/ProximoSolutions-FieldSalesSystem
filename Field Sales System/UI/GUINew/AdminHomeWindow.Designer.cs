namespace GUINew
{
    partial class AdminHomeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomeWindow));
            this.photoLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.mainPannel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.viewReportsButton = new System.Windows.Forms.Button();
            this.itemDispatchButton = new System.Windows.Forms.Button();
            this.searchEmployeeButton = new System.Windows.Forms.Button();
            this.viewEmployeesButton = new System.Windows.Forms.Button();
            this.empNameText = new System.Windows.Forms.TextBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.empIDText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // photoLabel
            // 
            this.photoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.photoLabel.Image = ((System.Drawing.Image)(resources.GetObject("photoLabel.Image")));
            this.photoLabel.Location = new System.Drawing.Point(16, 18);
            this.photoLabel.Name = "photoLabel";
            this.photoLabel.Size = new System.Drawing.Size(50, 50);
            this.photoLabel.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Californian FB", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(72, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(513, 50);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.label3.Location = new System.Drawing.Point(4, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1355, 7);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.label4.Location = new System.Drawing.Point(269, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(7, 639);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.addEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployeeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.addEmployeeButton.FlatAppearance.BorderSize = 0;
            this.addEmployeeButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.addEmployeeButton.Location = new System.Drawing.Point(16, 152);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(236, 30);
            this.addEmployeeButton.TabIndex = 10;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // mainPannel
            // 
            this.mainPannel.Location = new System.Drawing.Point(279, 113);
            this.mainPannel.Name = "mainPannel";
            this.mainPannel.Size = new System.Drawing.Size(1080, 600);
            this.mainPannel.TabIndex = 11;
            this.mainPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(1107, 722);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = " UPALI FOODS AND BEVERAGES (PVT.) LTD.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viewReportsButton
            // 
            this.viewReportsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.viewReportsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewReportsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.viewReportsButton.FlatAppearance.BorderSize = 0;
            this.viewReportsButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReportsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.viewReportsButton.Location = new System.Drawing.Point(16, 576);
            this.viewReportsButton.Name = "viewReportsButton";
            this.viewReportsButton.Size = new System.Drawing.Size(236, 30);
            this.viewReportsButton.TabIndex = 13;
            this.viewReportsButton.Text = "View Reports";
            this.viewReportsButton.UseVisualStyleBackColor = false;
            // 
            // itemDispatchButton
            // 
            this.itemDispatchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.itemDispatchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemDispatchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.itemDispatchButton.FlatAppearance.BorderSize = 0;
            this.itemDispatchButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDispatchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.itemDispatchButton.Location = new System.Drawing.Point(16, 475);
            this.itemDispatchButton.Name = "itemDispatchButton";
            this.itemDispatchButton.Size = new System.Drawing.Size(236, 30);
            this.itemDispatchButton.TabIndex = 14;
            this.itemDispatchButton.Text = "Authenticate Item Dispatch";
            this.itemDispatchButton.UseVisualStyleBackColor = false;
            // 
            // searchEmployeeButton
            // 
            this.searchEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.searchEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchEmployeeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.searchEmployeeButton.FlatAppearance.BorderSize = 0;
            this.searchEmployeeButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmployeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.searchEmployeeButton.Location = new System.Drawing.Point(16, 394);
            this.searchEmployeeButton.Name = "searchEmployeeButton";
            this.searchEmployeeButton.Size = new System.Drawing.Size(236, 30);
            this.searchEmployeeButton.TabIndex = 15;
            this.searchEmployeeButton.Text = "Search Employee";
            this.searchEmployeeButton.UseVisualStyleBackColor = false;
            this.searchEmployeeButton.Click += new System.EventHandler(this.searchEmployeeButton_Click);
            // 
            // viewEmployeesButton
            // 
            this.viewEmployeesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.viewEmployeesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewEmployeesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.viewEmployeesButton.FlatAppearance.BorderSize = 0;
            this.viewEmployeesButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewEmployeesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.viewEmployeesButton.Location = new System.Drawing.Point(16, 250);
            this.viewEmployeesButton.Name = "viewEmployeesButton";
            this.viewEmployeesButton.Size = new System.Drawing.Size(236, 30);
            this.viewEmployeesButton.TabIndex = 16;
            this.viewEmployeesButton.Text = "View Employee Details";
            this.viewEmployeesButton.UseVisualStyleBackColor = false;
            this.viewEmployeesButton.Click += new System.EventHandler(this.viewEmployeesButton_Click);
            // 
            // empNameText
            // 
            this.empNameText.Location = new System.Drawing.Point(16, 362);
            this.empNameText.Name = "empNameText";
            this.empNameText.Size = new System.Drawing.Size(236, 26);
            this.empNameText.TabIndex = 17;
            this.empNameText.Text = "Employee Last Name";
            // 
            // logoutButton
            // 
            this.logoutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutButton.BackgroundImage")));
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Location = new System.Drawing.Point(1300, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(50, 50);
            this.logoutButton.TabIndex = 18;
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // empIDText
            // 
            this.empIDText.Location = new System.Drawing.Point(16, 330);
            this.empIDText.Name = "empIDText";
            this.empIDText.Size = new System.Drawing.Size(236, 26);
            this.empIDText.TabIndex = 19;
            this.empIDText.Text = "Employee First Name";
            this.empIDText.TextChanged += new System.EventHandler(this.empIDText_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 26);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Employee ID";
            // 
            // AdminHomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(236)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.empIDText);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.empNameText);
            this.Controls.Add(this.viewEmployeesButton);
            this.Controls.Add(this.searchEmployeeButton);
            this.Controls.Add(this.itemDispatchButton);
            this.Controls.Add(this.viewReportsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainPannel);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.photoLabel);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminHomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label photoLabel;
        public System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Panel mainPannel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewReportsButton;
        private System.Windows.Forms.Button itemDispatchButton;
        private System.Windows.Forms.Button searchEmployeeButton;
        private System.Windows.Forms.Button viewEmployeesButton;
        private System.Windows.Forms.TextBox empNameText;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TextBox empIDText;
        private System.Windows.Forms.TextBox textBox1;
    }
}