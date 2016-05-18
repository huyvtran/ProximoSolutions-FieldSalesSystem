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
    public partial class ReportsHome : Form
    {
        private Controller controller;
        public ReportsHome(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void orderDetailsButton_Click(object sender, EventArgs e)
        {
            controller.viewOrderDetailsInit();
            DateTime beginDate = Convert.ToDateTime(orderFromDateTimePicker.Value.ToString());
            DateTime endDate = Convert.ToDateTime(orderToDateTimePicker.Value.ToString());
            controller.loadOrderDetails(orderStatusRadio.Checked, orderStatusCombo.SelectedItem.ToString(),beginDate ,endDate );
        }

        private void mainPannel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
