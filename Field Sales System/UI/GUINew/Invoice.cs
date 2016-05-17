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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            invoiceNumberText.Text = "";
            empIDText.Text = "";
            customerNameText.Text = "";
            customerContactText.Text = "";
            productNameCombo.Text = "Product Name";
            productIDLabel.Text = "Product ID";
            unitPriceLabel.Text = "Unit Price";
            qtyText.Text = "Quantity";

            invoiceDataGrid.RowCount = 0;

            totalText.Text = "";
        }

        float price;
        DataTable table = new DataTable();
        private void addItemButton_Click(object sender, EventArgs e)
        {
            price = (float.Parse(unitPriceLabel.Text)) * (float.Parse(qtyText.Text));
            table.Rows.Add(productIDLabel.Text, productNameCombo.GetItemText(productNameCombo.SelectedItem), unitPriceLabel.Text, qtyText.Text, price);

            invoiceDataGrid.DataSource = table;
        }        

        private void removeButton_Click(object sender, EventArgs e)
        {
            int rowIndex = invoiceDataGrid.CurrentCell.RowIndex;
            invoiceDataGrid.Rows.RemoveAt(rowIndex);
        }

        double sum;

        private void finishButton_Click(object sender, EventArgs e)
        {
            sum = 0;
            for (int i = 0; i < invoiceDataGrid.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(invoiceDataGrid.Rows[i].Cells["Value"].Value);
            }

            totalText.Text = sum.ToString();
        }

        

        
    }
}
