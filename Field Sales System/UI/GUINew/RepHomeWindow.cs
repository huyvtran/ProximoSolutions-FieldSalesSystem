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
    public partial class RepHomeWindow : Form
    {
        Controller controller;
        public RepHomeWindow(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
<<<<<<< HEAD

        private void myProfileButton_Click(object sender, EventArgs e)
        {

        }

        private void repMainPannel_Paint(object sender, PaintEventArgs e)
        {
            controller.setMyHome_Representative();
        }
=======
>>>>>>> d6aefedffd0523b7f221b64f52ead1f663ac6841
    }
}
