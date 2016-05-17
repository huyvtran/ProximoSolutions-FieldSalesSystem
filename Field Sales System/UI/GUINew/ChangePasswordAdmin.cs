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
            this.controller = controller;
            adminPwdText .PasswordChar = '*';
        }

        private void changePwdButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
