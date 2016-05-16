using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace prox
{
    public partial class proxmain : Form
    {
        public proxmain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\user\\Documents\\Visual Studio 2015\\Projects\\prox\\prox\\bin\\Debug\\proxDB.mdf; Integrated Security = True;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT*FROM [Table] ", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = false;
                dataGridView2.Rows[n].Cells[1].Value = item["productId"].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item["product Name"].ToString();
                dataGridView2.Rows[n].Cells[3].Value = item["unit price"].ToString();




            }
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            if ((bool)dataGridView2.SelectedRows[0].Cells[0].Value == false)
            {
                dataGridView2.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dataGridView2.SelectedRows[0].Cells[0].Value = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
                if ((bool)item.Cells[0].Value ==true)
                {

                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
