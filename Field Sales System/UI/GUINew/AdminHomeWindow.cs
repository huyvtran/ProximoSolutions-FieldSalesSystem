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

        public AdminHomeWindow(Controller controller)
        {
            InitializeComponent();

            this.controller = controller;


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
        }

        private void searchEmployeeButton_Click(object sender, EventArgs e)
<<<<<<< HEAD
        { 
            controller.searchEmployee_Admin(int.Parse(employeeIDText.Text),"cscs","sdsd");
=======
        {
            

            string employeeIDtext = empLastNameText.Text;
            try {
                int employeeID = int.Parse(employeeIDtext);
                }
            catch(FormatException a)
            {
                MessageBox.Show("invalid input,enter numbers only");
            }
            string empFirstName = empFirstNameText.Text;
            string empLastName = empLastNameText.Text;

            //controller.adminSearchEmploee(employee);
>>>>>>> 910d73690d76255d5ee2e70e3d4b46b59576632b
        }


        private void empIDText_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void adminaMainPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

<<<<<<< HEAD
       
=======
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchEmployeeButton.Enabled = true;                      
        }
>>>>>>> 910d73690d76255d5ee2e70e3d4b46b59576632b

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            controller.setMyHome_Admin();
        }

<<<<<<< HEAD
       
=======
        private void empLastNameText_TextChanged(object sender, EventArgs e)
        {
            searchEmployeeButton.Enabled = true;

        }

        private void employeeIDText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right || e.KeyChar == (char)Keys.Delete);
        }

        private void employeeIDText_Click(object sender, EventArgs e)
        {
            employeeIDText.Text = "";
        }

        private void empFirstNameText_Click(object sender, EventArgs e)
        {
            empFirstNameText.Text = "";
        }

        private void empFirstNameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right || e.KeyChar == (char)Keys.Delete);
        }

        private void empLastNameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right || e.KeyChar == (char)Keys.Delete);
        }

        private void empLastNameText_Click(object sender, EventArgs e)
        {
            empLastNameText.Text = "";
        }
>>>>>>> 910d73690d76255d5ee2e70e3d4b46b59576632b
    }
}
