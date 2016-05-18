namespace GUINew
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nicText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.middleNameText = new System.Windows.Forms.TextBox();
            this.bdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.TextBox();
            this.stateText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.mobileText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.homeTelText = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.regionText = new System.Windows.Forms.TextBox();
            this.hireDateDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.clearButton = new System.Windows.Forms.Button();
            this.pickBox = new System.Windows.Forms.PictureBox();
            this.zoomSlider = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.titleGroup = new System.Windows.Forms.GroupBox();
            this.msRadio = new System.Windows.Forms.RadioButton();
            this.mrRadio = new System.Windows.Forms.RadioButton();
            this.jobTitleGroup = new System.Windows.Forms.GroupBox();
            this.companyAdminRadio = new System.Windows.Forms.RadioButton();
            this.repRadio = new System.Windows.Forms.RadioButton();
            this.agentRadio = new System.Windows.Forms.RadioButton();
            this.wmRadio = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.permissionCombo = new System.Windows.Forms.ComboBox();
            this.permissionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proximoDBDataSet_permissions = new Field_Sales_System.proximoDBDataSet_permissions();
            this.permissionList = new System.Windows.Forms.ListView();
            this.Permission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.permissionsTableAdapter = new Field_Sales_System.proximoDBDataSet_permissionsTableAdapters.permissionsTableAdapter();
            this.listClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pickBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).BeginInit();
            this.titleGroup.SuspendLayout();
            this.jobTitleGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximoDBDataSet_permissions)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameText
            // 
            this.firstNameText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameText.Location = new System.Drawing.Point(260, 66);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(224, 27);
            this.firstNameText.TabIndex = 29;
            this.firstNameText.Text = "First Name *";
            this.firstNameText.Click += new System.EventHandler(this.firstNameText_Click);
            this.firstNameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNameText_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Basic Information";
            // 
            // nicText
            // 
            this.nicText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicText.Location = new System.Drawing.Point(158, 274);
            this.nicText.MaxLength = 9;
            this.nicText.Name = "nicText";
            this.nicText.Size = new System.Drawing.Size(293, 27);
            this.nicText.TabIndex = 27;
            this.nicText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nicText_KeyPress);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.addButton.Location = new System.Drawing.Point(594, 509);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(200, 30);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(20, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Contact Information";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label3.Location = new System.Drawing.Point(553, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Job Information";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label4.Location = new System.Drawing.Point(561, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Permission";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.label5.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label5.Location = new System.Drawing.Point(530, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(7, 550);
            this.label5.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label7.Location = new System.Drawing.Point(53, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 23);
            this.label7.TabIndex = 37;
            this.label7.Text = "Birth Date *";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label8.Location = new System.Drawing.Point(53, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 36;
            this.label8.Text = "NIC No. *";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label9.Location = new System.Drawing.Point(202, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 23);
            this.label9.TabIndex = 35;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label10.Location = new System.Drawing.Point(202, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 23);
            this.label10.TabIndex = 34;
            this.label10.Text = "Title";
            // 
            // lastNameText
            // 
            this.lastNameText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameText.Location = new System.Drawing.Point(260, 128);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(224, 27);
            this.lastNameText.TabIndex = 38;
            this.lastNameText.Text = "Last Name *";
            this.lastNameText.Click += new System.EventHandler(this.lastNameText_Click);
            this.lastNameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNameText_KeyPress);
            // 
            // middleNameText
            // 
            this.middleNameText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameText.Location = new System.Drawing.Point(260, 97);
            this.middleNameText.Name = "middleNameText";
            this.middleNameText.Size = new System.Drawing.Size(224, 27);
            this.middleNameText.TabIndex = 39;
            this.middleNameText.Text = "Middle Name(s)";
            this.middleNameText.Click += new System.EventHandler(this.middleNameText_Click);
            this.middleNameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.middleNameText_KeyPress);
            // 
            // bdayDateTimePicker
            // 
            this.bdayDateTimePicker.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdayDateTimePicker.Location = new System.Drawing.Point(159, 241);
            this.bdayDateTimePicker.Name = "bdayDateTimePicker";
            this.bdayDateTimePicker.Size = new System.Drawing.Size(325, 27);
            this.bdayDateTimePicker.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label11.Location = new System.Drawing.Point(54, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 23);
            this.label11.TabIndex = 45;
            this.label11.Text = "Address *";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label12.Location = new System.Drawing.Point(54, 443);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 23);
            this.label12.TabIndex = 44;
            this.label12.Text = "Home Tel.";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label13.Location = new System.Drawing.Point(54, 479);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 23);
            this.label13.TabIndex = 47;
            this.label13.Text = "Mobile *";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label14.Location = new System.Drawing.Point(54, 512);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 23);
            this.label14.TabIndex = 46;
            this.label14.Text = "E-mail";
            // 
            // cityText
            // 
            this.cityText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityText.Location = new System.Drawing.Point(159, 369);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(325, 27);
            this.cityText.TabIndex = 50;
            this.cityText.Text = "City";
            this.cityText.Click += new System.EventHandler(this.cityText_Click);
            // 
            // stateText
            // 
            this.stateText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateText.Location = new System.Drawing.Point(159, 400);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(325, 27);
            this.stateText.TabIndex = 49;
            this.stateText.Text = "State";
            this.stateText.Click += new System.EventHandler(this.stateText_Click);
            // 
            // addressText
            // 
            this.addressText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressText.Location = new System.Drawing.Point(159, 338);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(325, 27);
            this.addressText.TabIndex = 48;
            this.addressText.Text = "Address";
            this.addressText.Click += new System.EventHandler(this.addressText_Click);
            // 
            // mobileText
            // 
            this.mobileText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileText.Location = new System.Drawing.Point(159, 474);
            this.mobileText.MaxLength = 10;
            this.mobileText.Name = "mobileText";
            this.mobileText.Size = new System.Drawing.Size(325, 27);
            this.mobileText.TabIndex = 53;
            this.mobileText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mobileText_KeyPress);
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.Location = new System.Drawing.Point(159, 509);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(325, 27);
            this.emailText.TabIndex = 52;
            this.emailText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // homeTelText
            // 
            this.homeTelText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTelText.Location = new System.Drawing.Point(159, 438);
            this.homeTelText.MaxLength = 10;
            this.homeTelText.Name = "homeTelText";
            this.homeTelText.Size = new System.Drawing.Size(325, 27);
            this.homeTelText.TabIndex = 51;
            this.homeTelText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.homeTelText_KeyPress);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label15.Location = new System.Drawing.Point(590, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 23);
            this.label15.TabIndex = 56;
            this.label15.Text = "Hire Date";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label16.Location = new System.Drawing.Point(590, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 23);
            this.label16.TabIndex = 55;
            this.label16.Text = "Job Title *";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label17.Location = new System.Drawing.Point(590, 194);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 23);
            this.label17.TabIndex = 54;
            this.label17.Text = "Region *";
            // 
            // regionText
            // 
            this.regionText.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionText.Location = new System.Drawing.Point(689, 190);
            this.regionText.Name = "regionText";
            this.regionText.Size = new System.Drawing.Size(325, 27);
            this.regionText.TabIndex = 61;
            // 
            // hireDateDateTimePicker2
            // 
            this.hireDateDateTimePicker2.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hireDateDateTimePicker2.Location = new System.Drawing.Point(689, 225);
            this.hireDateDateTimePicker2.Name = "hireDateDateTimePicker2";
            this.hireDateDateTimePicker2.Size = new System.Drawing.Size(324, 27);
            this.hireDateDateTimePicker2.TabIndex = 62;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.clearButton.Location = new System.Drawing.Point(814, 509);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(200, 30);
            this.clearButton.TabIndex = 64;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // pickBox
            // 
            this.pickBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pickBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pickBox.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.pickBox.Image = ((System.Drawing.Image)(resources.GetObject("pickBox.Image")));
            this.pickBox.Location = new System.Drawing.Point(37, 56);
            this.pickBox.Name = "pickBox";
            this.pickBox.Size = new System.Drawing.Size(150, 150);
            this.pickBox.TabIndex = 33;
            this.pickBox.TabStop = false;
            this.pickBox.Click += new System.EventHandler(this.label6_Click);
            // 
            // zoomSlider
            // 
            this.zoomSlider.LargeChange = 1;
            this.zoomSlider.Location = new System.Drawing.Point(61, 210);
            this.zoomSlider.Maximum = 5;
            this.zoomSlider.Minimum = 1;
            this.zoomSlider.Name = "zoomSlider";
            this.zoomSlider.Size = new System.Drawing.Size(104, 45);
            this.zoomSlider.TabIndex = 65;
            this.zoomSlider.Value = 1;
            this.zoomSlider.Visible = false;
            this.zoomSlider.Scroll += new System.EventHandler(this.zoomSlider_Scroll);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Adobe Garamond Pro", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label6.Location = new System.Drawing.Point(457, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 23);
            this.label6.TabIndex = 66;
            this.label6.Text = "V";
            // 
            // titleGroup
            // 
            this.titleGroup.Controls.Add(this.msRadio);
            this.titleGroup.Controls.Add(this.mrRadio);
            this.titleGroup.Location = new System.Drawing.Point(260, 169);
            this.titleGroup.Name = "titleGroup";
            this.titleGroup.Size = new System.Drawing.Size(224, 28);
            this.titleGroup.TabIndex = 67;
            this.titleGroup.TabStop = false;
            // 
            // msRadio
            // 
            this.msRadio.AutoSize = true;
            this.msRadio.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msRadio.Location = new System.Drawing.Point(71, 2);
            this.msRadio.Name = "msRadio";
            this.msRadio.Size = new System.Drawing.Size(52, 23);
            this.msRadio.TabIndex = 1;
            this.msRadio.TabStop = true;
            this.msRadio.Text = "Ms.";
            this.msRadio.UseVisualStyleBackColor = true;
            // 
            // mrRadio
            // 
            this.mrRadio.AutoSize = true;
            this.mrRadio.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrRadio.Location = new System.Drawing.Point(6, 2);
            this.mrRadio.Name = "mrRadio";
            this.mrRadio.Size = new System.Drawing.Size(51, 23);
            this.mrRadio.TabIndex = 0;
            this.mrRadio.TabStop = true;
            this.mrRadio.Text = "Mr.";
            this.mrRadio.UseVisualStyleBackColor = true;
            // 
            // jobTitleGroup
            // 
            this.jobTitleGroup.Controls.Add(this.companyAdminRadio);
            this.jobTitleGroup.Controls.Add(this.repRadio);
            this.jobTitleGroup.Controls.Add(this.agentRadio);
            this.jobTitleGroup.Controls.Add(this.wmRadio);
            this.jobTitleGroup.Location = new System.Drawing.Point(689, 56);
            this.jobTitleGroup.Name = "jobTitleGroup";
            this.jobTitleGroup.Size = new System.Drawing.Size(324, 128);
            this.jobTitleGroup.TabIndex = 68;
            this.jobTitleGroup.TabStop = false;
            // 
            // companyAdminRadio
            // 
            this.companyAdminRadio.AutoSize = true;
            this.companyAdminRadio.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyAdminRadio.Location = new System.Drawing.Point(9, 97);
            this.companyAdminRadio.Name = "companyAdminRadio";
            this.companyAdminRadio.Size = new System.Drawing.Size(142, 23);
            this.companyAdminRadio.TabIndex = 3;
            this.companyAdminRadio.TabStop = true;
            this.companyAdminRadio.Text = "Company Admin";
            this.companyAdminRadio.UseVisualStyleBackColor = true;
            // 
            // repRadio
            // 
            this.repRadio.AutoSize = true;
            this.repRadio.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repRadio.Location = new System.Drawing.Point(7, 68);
            this.repRadio.Name = "repRadio";
            this.repRadio.Size = new System.Drawing.Size(161, 23);
            this.repRadio.TabIndex = 2;
            this.repRadio.TabStop = true;
            this.repRadio.Text = "Sales Representative";
            this.repRadio.UseVisualStyleBackColor = true;
            // 
            // agentRadio
            // 
            this.agentRadio.AutoSize = true;
            this.agentRadio.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentRadio.Location = new System.Drawing.Point(7, 39);
            this.agentRadio.Name = "agentRadio";
            this.agentRadio.Size = new System.Drawing.Size(66, 23);
            this.agentRadio.TabIndex = 1;
            this.agentRadio.TabStop = true;
            this.agentRadio.Text = "Agent";
            this.agentRadio.UseVisualStyleBackColor = true;
            // 
            // wmRadio
            // 
            this.wmRadio.AutoSize = true;
            this.wmRadio.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wmRadio.Location = new System.Drawing.Point(7, 10);
            this.wmRadio.Name = "wmRadio";
            this.wmRadio.Size = new System.Drawing.Size(163, 23);
            this.wmRadio.TabIndex = 0;
            this.wmRadio.TabStop = true;
            this.wmRadio.Text = "Warehouse Manager";
            this.wmRadio.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.label18.Location = new System.Drawing.Point(813, 267);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(200, 23);
            this.label18.TabIndex = 69;
            this.label18.Text = "* fields are necessary";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // permissionCombo
            // 
            this.permissionCombo.DataSource = this.permissionsBindingSource;
            this.permissionCombo.DisplayMember = "permName";
            this.permissionCombo.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permissionCombo.FormattingEnabled = true;
            this.permissionCombo.Location = new System.Drawing.Point(594, 308);
            this.permissionCombo.Name = "permissionCombo";
            this.permissionCombo.Size = new System.Drawing.Size(200, 27);
            this.permissionCombo.TabIndex = 70;
            this.permissionCombo.ValueMember = "permId";
            this.permissionCombo.SelectedIndexChanged += new System.EventHandler(this.permissionCombo_SelectedIndexChanged);
            // 
            // permissionsBindingSource
            // 
            this.permissionsBindingSource.DataMember = "permissions";
            this.permissionsBindingSource.DataSource = this.proximoDBDataSet_permissions;
            // 
            // proximoDBDataSet_permissions
            // 
            this.proximoDBDataSet_permissions.DataSetName = "proximoDBDataSet_permissions";
            this.proximoDBDataSet_permissions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // permissionList
            // 
            this.permissionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Permission});
            this.permissionList.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permissionList.Location = new System.Drawing.Point(814, 308);
            this.permissionList.Name = "permissionList";
            this.permissionList.Size = new System.Drawing.Size(200, 193);
            this.permissionList.TabIndex = 71;
            this.permissionList.UseCompatibleStateImageBehavior = false;
            this.permissionList.View = System.Windows.Forms.View.List;
            // 
            // Permission
            // 
            this.Permission.Width = 250;
            // 
            // permissionsTableAdapter
            // 
            this.permissionsTableAdapter.ClearBeforeFill = true;
            // 
            // listClear
            // 
            this.listClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(31)))), ((int)(((byte)(1)))));
            this.listClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.listClear.FlatAppearance.BorderSize = 0;
            this.listClear.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.listClear.Location = new System.Drawing.Point(595, 354);
            this.listClear.Name = "listClear";
            this.listClear.Size = new System.Drawing.Size(200, 30);
            this.listClear.TabIndex = 72;
            this.listClear.Text = "Clear Permission List";
            this.listClear.UseVisualStyleBackColor = false;
            this.listClear.Click += new System.EventHandler(this.listClear_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(236)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.listClear);
            this.Controls.Add(this.permissionList);
            this.Controls.Add(this.permissionCombo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.jobTitleGroup);
            this.Controls.Add(this.titleGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.hireDateDateTimePicker2);
            this.Controls.Add(this.regionText);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.mobileText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.homeTelText);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bdayDateTimePicker);
            this.Controls.Add(this.middleNameText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pickBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nicText);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zoomSlider);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pickBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).EndInit();
            this.titleGroup.ResumeLayout(false);
            this.titleGroup.PerformLayout();
            this.jobTitleGroup.ResumeLayout(false);
            this.jobTitleGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximoDBDataSet_permissions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox firstNameText;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox nicText;
        public System.Windows.Forms.Button addButton;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.PictureBox pickBox;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox lastNameText;
        public System.Windows.Forms.TextBox middleNameText;
        public System.Windows.Forms.DateTimePicker bdayDateTimePicker;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox cityText;
        public System.Windows.Forms.TextBox stateText;
        public System.Windows.Forms.TextBox addressText;
        public System.Windows.Forms.TextBox mobileText;
        public System.Windows.Forms.TextBox emailText;
        public System.Windows.Forms.TextBox homeTelText;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox regionText;
        public System.Windows.Forms.DateTimePicker hireDateDateTimePicker2;
        public System.Windows.Forms.Button clearButton;
        public System.Windows.Forms.TrackBar zoomSlider;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.GroupBox jobTitleGroup;
        public System.Windows.Forms.GroupBox titleGroup;
        public System.Windows.Forms.RadioButton msRadio;
        public System.Windows.Forms.RadioButton repRadio;
        public System.Windows.Forms.RadioButton agentRadio;
        public System.Windows.Forms.RadioButton wmRadio;
        public System.Windows.Forms.RadioButton mrRadio;
        public System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox permissionCombo;
        private System.Windows.Forms.ListView permissionList;
        private Field_Sales_System.proximoDBDataSet_permissions proximoDBDataSet_permissions;
        private System.Windows.Forms.BindingSource permissionsBindingSource;
        private Field_Sales_System.proximoDBDataSet_permissionsTableAdapters.permissionsTableAdapter permissionsTableAdapter;
        public System.Windows.Forms.Button listClear;
        private System.Windows.Forms.ColumnHeader Permission;
        public System.Windows.Forms.RadioButton companyAdminRadio;
    }
}