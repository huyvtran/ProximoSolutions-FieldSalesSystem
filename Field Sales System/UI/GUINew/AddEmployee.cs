using Field_Sales_System.ControlLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        string userType = "Agent";
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
            //controller.addAdminEmployerSave(0003, Convert.ToInt32(nicText.Text), Convert.ToDateTime(bdayDateTimePicker.Text), gender, firstNameText.Text + " " + middleNameText.Text,lastNameText.Text, Convert.ToInt32(mobileText.Text), Convert.ToInt32(homeTelText.Text), emailText.Text, addressText.Text, cityText.Text, stateText.Text, pickBox.Image, userType,0003);
        }

        private void mrsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = false;
        }

        private void mrRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // open file dialog 
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                pickBox.Image = new Bitmap(open.FileName);
                
                // image file path
                //pickBox.Text = open.FileName;
            }
        }
        public Image PictureBoxZoom(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width), Convert.ToInt32(img.Height * size.Height));
            Graphics grap = Graphics.FromImage(bm);
            grap.InterpolationMode = InterpolationMode.Low;
            return bm;
        }

        private void zoomSlider_Scroll(object sender, EventArgs e)
        {
            Image imgOriginal;
            imgOriginal = pickBox.Image;
            pickBox.Image = PictureBoxZoom(imgOriginal, new Size(zoomSlider.Value, zoomSlider.Value));
        }

        private void wmRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void firstNameText_Click(object sender, EventArgs e)
        {
            if (firstNameText.Text == "First Name")
            {
                firstNameText.Text = "";
            }
        }

        private void middleNameText_Click(object sender, EventArgs e)
        {
            if (middleNameText.Text == "Middle Name(s)")
            {
                middleNameText.Text = "";
            }
        }

        private void lastNameText_Click(object sender, EventArgs e)
        {
            if (lastNameText.Text == "Last Name")
            {
                lastNameText.Text = "";
            }
        }

        private void addressText_Click(object sender, EventArgs e)
        {
            if (addressText.Text == "Address")
            {
                addressText.Text = "";
            }
        }

        private void cityText_Click(object sender, EventArgs e)
        {
            if (cityText.Text == "City")
            {
                cityText.Text = "";
            }
        }

        private void stateText_Click(object sender, EventArgs e)
        {
            if (stateText.Text == "State")
            {
                stateText.Text = "";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void firstNameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right || e.KeyChar == (char)Keys.Delete);
        }

        private void middleNameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Space);
        }

        private void lastNameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right || e.KeyChar == (char)Keys.Delete);
        }

        private void nicText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right || e.KeyChar == (char)Keys.Delete);
        }

        private void homeTelText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right || e.KeyChar == (char)Keys.Delete);
        }

        private void mobileText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right || e.KeyChar == (char)Keys.Delete);
        }
    }
}
