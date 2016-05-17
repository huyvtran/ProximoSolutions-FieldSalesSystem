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
    public partial class SignIn : Form
    {
        private ForgotPassword forgotPassword;
        Controller controller;
        public SignIn(Controller controll)
        {
            InitializeComponent();
            this.controller = controll;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            forgotPassword = new ForgotPassword();
            this.Hide();
            forgotPassword.ShowDialog();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            controller.logIn(Convert.ToInt32(usernameText.Text),passwordText.Text);
        }
        public void changeCurser()
        {
            Cursor.Current = Cursors.Default;
        }

       
    }
}
