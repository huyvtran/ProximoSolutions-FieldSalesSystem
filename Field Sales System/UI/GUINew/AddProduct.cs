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

namespace Field_Sales_System.UI.GUINew
{
    public partial class AddProduct : Form
    {
        Controller controller;
        public AddProduct(Controller controller)
        {
            InitializeComponent();
            productNameText.Enabled = false;
            this.controller = controller;
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

        private void productIDText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right || e.KeyChar == (char)Keys.Delete);
        }

        private void batchNoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right || e.KeyChar == (char)Keys.Delete);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (productNameCombo.SelectedItem.ToString() == "Product Name" || productIDText.Text == null || categoryCombo.SelectedItem.ToString() == "Category" || batchNoText.Text == null || priceText.Text == null)
            {
                MessageBox.Show("Fill in the required fields");
            }
        }

        private void priceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right || e.KeyChar == (char)Keys.Delete);

            if (!char.IsControl(e.KeyChar))  //bypass control keys
            {
                int dotIndex = priceText.Text.IndexOf('.');
                if (char.IsDigit(e.KeyChar))     //ensure it's a digit
                {   //we cannot accept another digit if
                    if (dotIndex != -1 &&  //there is already a dot and
                                           //dot is to the left from the cursor position and
                        dotIndex < priceText.SelectionStart &&
                        //there're already 2 symbols to the right from the dot
                        priceText.Text.Substring(dotIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                else //we cannot accept this char if
                    e.Handled = e.KeyChar != '.' || //it's not a dot or
                                                    //there is already a dot in the text or
                                dotIndex != -1 ||
                                //text is empty or
                                priceText.Text.Length == 0 ||
                                //there are more than 2 symbols from cursor position
                                //to the end of the text
                                priceText.SelectionStart + 2 < priceText.Text.Length;
                
            }
        }
    }
}
