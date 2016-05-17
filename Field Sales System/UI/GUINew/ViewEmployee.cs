using Field_Sales_System.Business_Logic;
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
    public partial class ViewEmployee : Form
    {
        private Controller controller;
        public ViewEmployee(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private String address = "";

        public void setData(List<User> userList)
        {            
            foreach (User user in userList)
            {
                address = user.ContactDetails.AddressLine_1 + "," + user.ContactDetails.AddressLine_2 + "," + user.ContactDetails.AddressLine_3;
                this.dataGridView1.Rows.Add(user.ContactDetails.EmailAddress, user.ContactDetails.MobileNo, address, controller.checkState(user.IsActive), controller.getUserRegion(user), user.GetType(), user.getFirstName() + " " + user.getLastName(), user.Dp.getPicture(), user.getEmpId());
            }
        }
        
    }
}
