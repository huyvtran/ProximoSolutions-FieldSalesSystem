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
        Controller controller;
        private ReportsHome reportsHome;
        private AddEmployee addEmployee;
        private ViewEmployee viewEmployee;
        private EmployeeProfile employeeProfile;

        public AdminHomeWindow()
        {
            InitializeComponent();
        }

        private void viewReportsButton_Click(object sender, EventArgs e)
        {
            reportsHome = new ReportsHome();
            this.Close();
            reportsHome.Show();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            addEmployee = new AddEmployee();
            addEmployee.MdiParent = this;
            addEmployee.Show();
            addEmployee.Location = new Point(279, 113);
        }

        private void viewEmployeesButton_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            viewEmployee = new ViewEmployee();
            viewEmployee.MdiParent = this;
            viewEmployee.Show();
            viewEmployee.Location = new Point(279, 113);
        }

        private void searchEmployeeButton_Click(object sender, EventArgs e)
        {
            string employeeIDtext = empLastNameText.Text;
            string empFirstName = empFirstNameText.Text;
            string empLastName = empLastNameText.Text;
            if ()
          controller.adminSearchEmploee(empId)
        }

        private void empIDText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
