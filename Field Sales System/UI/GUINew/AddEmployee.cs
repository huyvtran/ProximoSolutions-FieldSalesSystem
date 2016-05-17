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
    public partial class AddEmployee : Form
    {
        Controller controller;
        bool gender;
        public AddEmployee(Controller controll)
        {
            controller = controll;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //controller.adminAddemployer(0001, Convert.ToInt32(nicText.Text), gender, Convert.ToDateTime(bdayDateTimePicker.Text), )
        }

        private void mrsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = false;
        }

        private void mrRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = true;
        }
    }
}
