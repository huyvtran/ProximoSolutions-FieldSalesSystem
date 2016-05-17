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
    public partial class WMHomeWindow : Form
    {
        public WMHomeWindow()
        {
            InitializeComponent();
            searchButton.Enabled = false;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            searchButton.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            searchButton.Enabled = true;
            if (!System.Text.RegularExpressions.Regex.IsMatch(employeeLastNameText.Text, "^[a-zA-Z_-]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                employeeLastNameText.Text.Remove(employeeLastNameText.Text.Length - 1);
            }




        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string employeeIDtext = employeeIDText.Text;
            try
            {
                int employeeID = int.Parse(employeeIDtext);
            }
            catch (FormatException e)
            {
                MessageBox.Show("invalid input,enter numbers only");
            }
            string empFirstName = employeeFirstNameText.Text;
            string empLastName = employeeLastNameText.Text;
        }

        private void employeeFirstNameText_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(employeeFirstNameText.Text, "^[a-zA-Z_-]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                employeeFirstNameText.Text.Remove(employeeFirstNameText.Text.Length - 1);
            }
        }
    }
}
