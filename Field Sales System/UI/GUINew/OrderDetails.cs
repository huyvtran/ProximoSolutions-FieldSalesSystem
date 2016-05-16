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
    public partial class OrderDetails : Form
    {
        public OrderDetails()
        {
            InitializeComponent();
        }

        private ViewOrders viewOrders;
        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
            viewOrders.ShowDialog();
        }
    }
}
