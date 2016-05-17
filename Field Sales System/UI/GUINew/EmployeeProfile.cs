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
    public partial class EmployeeProfile : Form
    {
        private ChangePassword changePassword;
        private UpdateEmployee updateEmployee;
        private Controller controller;

        public EmployeeProfile(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void changePwdButton_Click(object sender, EventArgs e)
        {
            changePassword = new ChangePassword(controller);
            changePassword.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            updateEmployee = new UpdateEmployee();
            updateEmployee.Show();

        }
    }
}
