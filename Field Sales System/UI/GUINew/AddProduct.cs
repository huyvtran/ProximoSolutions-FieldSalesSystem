using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Field_Sales_System.UI.GUINew
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            productNameText.Enabled = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            productNameCombo.Text = "Product Name";
            productIDText.Text = "";
            categoryCombo.Text = "Category";

            batchNoText.Text = "";
            descriptionRichText.Text = "";

            productNameText.Text = "";
            productNameText.Enabled = false;
        }

        private void productNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productNameCombo.SelectedItem.ToString() == "--New--")
            {
                productNameText.Enabled = true;
            }
        }
    }
}
