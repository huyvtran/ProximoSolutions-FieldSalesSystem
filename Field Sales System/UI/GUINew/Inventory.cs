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
    public partial class Inventory : Form
    {
        Controller controller;
        public Inventory(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
    }
}
