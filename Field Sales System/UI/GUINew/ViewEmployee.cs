using Field_Sales_System.Business_Logic;
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
        public ViewEmployee()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void setData(List<User> userList)
        {
            foreach (User user in userList)
            {



                this.dataGridView1.Rows.Add(user.ContactDetails.EmailAddress, user.ContactDetails.MobileNo, user.ContactDetails.AddressLine_1 + "," + user.ContactDetails.AddressLine_2 + "," + user.ContactDetails.AddressLine_3, checkState(user.IsActive), getUserRegion(user), user.GetType(), user.getFirstName() + " " + user.getLastName(), user.Dp.getPicture(), user.getEmpId());  
            }
        }
        private string checkState(bool b)
        {
            if (b)
            {
                return "Active";
            }
            else
            {
                return "Removed";

            }

        }
        private string getUserRegion(User user)
        {
            string region = "";
            if (user is Agent)
            {
                Agent agent = (Agent)user;
                region = agent.getCoverageArea();
            }
            else
            {
                region = "Not assigned";
            }
            return region;
        }
    }
}
