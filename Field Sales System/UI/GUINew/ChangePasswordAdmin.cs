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
    public partial class ChangePasswordAdmin : Form
    {
        private Controller controller;
        public ChangePasswordAdmin(Controller controller)
        {
            InitializeComponent();

            changePwdButton.Enabled = false;
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
            changePwdButton.Enabled = true;
        }

        private void adminPwdText_TextChanged(object sender, EventArgs e)
        {
            changePwdButton.Enabled = true;
        }



        private void changePwdButton_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text;
            string adminPassword = adminPwdText.Text;

            if (String.IsNullOrEmpty(usernameText.Text) && (String.IsNullOrEmpty(adminPwdText.Text)))
            {
                MessageBox.Show("Enter all required data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }




            this.controller = controller;

        }
    }
}
