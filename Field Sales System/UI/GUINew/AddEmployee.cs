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
            controller.addAdminEmployerSave(0001, Convert.ToInt32(nicText.Text), Convert.ToDateTime(bdayDateTimePicker.Text), gender, firstNameText.Text + " " + middleNameText.Text,lastNameText.Text, Convert.ToInt32(mobileText.Text), Convert.ToInt32(homeTelText.Text), emailText.Text, addressText.Text, cityText.Text, stateText.Text, pickBox.Image, userType);
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
    }
}
