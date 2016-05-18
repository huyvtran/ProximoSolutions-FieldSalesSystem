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
    public partial class ChangePassword : Form
    {
        private Controller controller;
        public ChangePassword(Controller controller)
        {
            InitializeComponent();

            changePwdButton.Enabled = false;
            confirmPwdText.Enabled = false;
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
        }

        private void newPwdText_TextChanged(object sender, EventArgs e)
        {
            changePwdButton.Enabled = true;
            confirmPwdText.Enabled = false;
        }
        
        private void confirmPwdText_TextChanged(object sender, EventArgs e)
        {
            changePwdButton.Enabled = true;
        }

        string currentPassword, newPassword, confirmedPassword;

        private void newPwdText_TextChanged_1(object sender, EventArgs e)
        {
            confirmPwdText.Enabled = true;
        }

        private void changePwdButton_Click(object sender, EventArgs e)
        {
            currentPassword = currentPwdText.Text;

            newPassword = newPwdText.Text;
            confirmedPassword = confirmPwdText.Text;

            if (String.IsNullOrEmpty(currentPassword) && (String.IsNullOrEmpty(newPassword)) && (String.IsNullOrEmpty(confirmedPassword)))
            {
                MessageBox.Show("Enter all required data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else {
                if (confirmedPassword != newPassword)
                {
                    MessageBox.Show("Passwords do not match");
                    newPwdText.Text = string.Empty;
                    confirmPwdText.Text = string.Empty;
                }

            }



            
        }
    }
}
