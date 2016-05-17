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
        public ChangePassword()
        {
            InitializeComponent();
            changePwdButton.Enabled = false;
            confirmPwdText.Enabled = false;
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
            changePwdButton.Enabled = true;
        }

        private void adminPwdText_TextChanged(object sender, EventArgs e)
        {
            changePwdButton.Enabled = true;
            confirmPwdText.Enabled = false;
        }

        private void confirmPwdText_TextChanged(object sender, EventArgs e)
        {
            changePwdButton.Enabled = true;
        }



        private void changePwdButton_Click(object sender, EventArgs e)
        {
            string currentPassword = currentPwdText.Text;
            
            string newPassword = newPwdText.Text;
            string confirmedPassword= confirmPwdText.Text;

            if (newPassword != confirmedPassword)
            {
                MessageBox.Show("passwords do not match");
                newPwdText.Text = string.Empty;
                confirmPwdText.Text = string.Empty;
            }


        }
    }
}
