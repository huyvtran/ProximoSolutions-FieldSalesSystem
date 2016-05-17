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
    public partial class AgentHomeWindow : Form
    {
        public AgentHomeWindow()
        {
            InitializeComponent();
            searchEmployeeButton.Enabled = false;

        }

        private void empID_TextChanged(object sender, EventArgs e)
        {
            searchEmployeeButton.Enabled = true;
        }

        private void empLastName_TextChanged(object sender, EventArgs e)
        {
            searchEmployeeButton.Enabled = true;
            if (!System.Text.RegularExpressions.Regex.IsMatch(empLastName.Text, "^[a-zA-Z_-]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                empLastName.Text.Remove(empLastName.Text.Length - 1);
            }



        }

        private void empFirstName_TextChanged(object sender, EventArgs e)
        {
            searchEmployeeButton.Enabled = true;
            if (!System.Text.RegularExpressions.Regex.IsMatch(empFirstName.Text, "^[a-zA-Z_-]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                empFirstName.Text.Remove(empFirstName.Text.Length - 1);
            }


        }
    }
}
