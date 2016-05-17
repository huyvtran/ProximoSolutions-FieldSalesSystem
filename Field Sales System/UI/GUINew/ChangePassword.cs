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
            this.controller = controller;
        }
    }
}
