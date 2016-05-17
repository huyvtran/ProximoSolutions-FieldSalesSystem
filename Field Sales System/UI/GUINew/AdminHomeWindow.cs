using Field_Sales_System.ControlLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUINew
{
    public partial class AdminHomeWindow : Form
    {
        private ReportsHome reportsHome;
        private AddEmployee addEmployee;
        private ViewEmployee viewEmployee;
        private EmployeeProfile employeeProfile;
        private Controller controller;



        public AdminHomeWindow(Controller controller)

        {
            InitializeComponent();
            this.controller = controller;
            searchEmployeeButton.Enabled = false;
        }

        private void viewReportsButton_Click(object sender, EventArgs e)
        {
            //reportsHome = new ReportsHome();
            //this.Close();
            //reportsHome.Show();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            controller.adminAddemployer();
            
        }

        private void viewEmployeesButton_Click(object sender, EventArgs e)
        {
            //this.IsMdiContainer = true;
            //viewEmployee = new ViewEmployee();
            //viewEmployee.MdiParent = this;
            //viewEmployee.Show();
            //viewEmployee.Location = new Point(279, 113);
        }

        private void searchEmployeeButton_Click(object sender, EventArgs e)
        {

            this.IsMdiContainer = true;
            employeeProfile = new EmployeeProfile(controller);
            employeeProfile.MdiParent = this;
            employeeProfile.Show();
            employeeProfile.Location = new Point(279, 113);



            string employeeIDtext = empLastNameText.Text;
            try {
                int employeeID = int.Parse(employeeIDtext);
                }
            catch(FormatException e)
            {
                MessageBox.Show("invalid input,enter numbers only");
            }
            string empFirstName = empFirstNameText.Text;
            string empLastName = empLastNameText.Text;

            //controller.adminSearchEmploee(employee);

        }


        private void empIDText_TextChanged(object sender, EventArgs e)
        {
            searchEmployeeButton.Enabled = true;
        }

        private void adminaMainPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchEmployeeButton.Enabled = true;
            if (!System.Text.RegularExpressions.Regex.IsMatch(empFirstNameText.Text, "^[a-zA-Z_-]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                empFirstNameText.Text.Remove(empFirstNameText.Text.Length - 1);
            }



        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            controller.setMyHome_Admin();
        }

        private void empLastNameText_TextChanged(object sender, EventArgs e)
        {
            searchEmployeeButton.Enabled = true;
            if (!System.Text.RegularExpressions.Regex.IsMatch(empLastNameText.Text, "^[a-zA-Z_-]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                empLastNameText.Text.Remove(empLastNameText.Text.Length - 1);
            }




        }
    }
}
