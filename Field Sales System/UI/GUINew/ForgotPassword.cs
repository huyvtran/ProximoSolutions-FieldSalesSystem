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
    public partial class ForgotPassword : Form
    {
        private Controller controller;
        public ForgotPassword(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }


        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            controller.OpeningDialogBox.Show();
            
        }

        private void requestNewPasswordButton_Click(object sender, EventArgs e)
        {
            controller.resetPassword(Int32.Parse(usernameText.Text));
        }
    }
}
