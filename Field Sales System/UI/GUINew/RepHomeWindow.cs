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
            searchRepsButton.Enabled = false;

        }


        private void repMainPannel_Paint(object sender, PaintEventArgs e)
        {
            controller.setMyHome_Representative();
        }

        private void searchRepsButton_Click(object sender, EventArgs e)
        {

            controller.searchEmployee_Rep(Int32.Parse(empIdText.Text), firstNameText.Text, lastNameText.Text);
        }

        private void empIdText_Click(object sender, EventArgs e)
        {
            if (empIdText.Text == "Employee ID")
            {
                empIdText.Text = "";
            }
        }

        private void firstNameText_TextChanged(object sender, EventArgs e)
        {


        }

        private void empIdText_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameText_Click(object sender, EventArgs e)
        {
            if (firstNameText.Text == "First Name")
            {
                firstNameText.Text = "";
            }
        }

        private void lastNameText_Click(object sender, EventArgs e)
        {
            if (lastNameText.Text == "Last Name")
            {
                lastNameText.Text = "";
            }
        }

        private void myProfileButton_Click(object sender, EventArgs e)
        {

        }

        private void viewInventoryButton_Click(object sender, EventArgs e)
        {

        }

        private void requestNewOrderButton_Click(object sender, EventArgs e)
        {
            controller.createNewOrder_Rep();
        }

        private void empIdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (empIdText.Text.Length >= 1)
            {
                searchRepsButton.Enabled = true;
            }

            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right || e.KeyChar == (char)Keys.Delete);
        }

        private void firstNameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (firstNameText.Text.Length >= 1)
            {
                searchRepsButton.Enabled = true;
            }
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right || e.KeyChar == (char)Keys.Delete);
        }

        private void lastNameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lastNameText.Text.Length >= 1)
            {
                searchRepsButton.Enabled = true;
            }
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right || e.KeyChar == (char)Keys.Delete);

        }
    }
}
