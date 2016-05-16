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

        public EmployeeProfile()
        {
            InitializeComponent();
        }

        private void changePwdButton_Click(object sender, EventArgs e)
        {
            changePassword = new ChangePassword();
            changePassword.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            updateEmployee = new UpdateEmployee();
            updateEmployee.Show();
        }
    }
}
