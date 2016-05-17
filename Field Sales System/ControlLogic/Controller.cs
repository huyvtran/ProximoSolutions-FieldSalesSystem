using Field_Sales_System.Business_Logic;
using Field_Sales_System.Utility_Classes;
using GUINew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;


namespace Field_Sales_System.ControlLogic
{
    public class Controller
    {
        ObjectFactory objectFactory;
        SecurityManager securityManager;
        SignIn openingDialogBox;
        AdminHomeWindow adminHW;
        AgentHomeWindow agentHW;
        RepHomeWindow repHW;
        WMHomeWindow wmHW;
        User currentUser;
        AddEmployee newEmployee;
        ViewEmployee viewEmployee;
        EmployeeProfile profile;

        public Controller()
        { objectFactory = new ObjectFactory();
            securityManager = new SecurityManager();
            openingDialogBox = new SignIn(this);
            profile = new EmployeeProfile();

        }
        public void initilizer()
        {
            openingDialogBox.ShowDialog();
        }
        public void logIn(int empId, string password)
        {
            string check = securityManager.login(empId, password);
            if (check.Equals("Successfully logged in!"))
            {
                MessageBox.Show(check);
                User u = objectFactory.getUser(empId);
                currentUser = u;
                if (u is CompanyAdmin)
                {
                    adminHW = new AdminHomeWindow(this);


                    adminHW.nameLabel.Text = u.getFirstName() + " " + u.getLastName();
                    adminHW.photoLabel.Image = u.Dp.getPicture();
                    openingDialogBox.changeCurser();
                    openingDialogBox.Hide();
                    adminHW.ShowDialog();

                }
                else if (u is Agent)
                {
                    agentHW = new AgentHomeWindow();
                    agentHW.nameLabel.Text = u.getFirstName() + " " + u.getLastName();
                    agentHW.photoLabel.Image = u.Dp.getPicture();
                    agentHW.ShowDialog();

                }
                else if (u is Representative)
                {
                    repHW = new RepHomeWindow(this);
                    repHW.nameLabel.Text = u.getFirstName() + " " + u.getLastName();
                    repHW.photoLabel.Image = u.Dp.getPicture();
                    openingDialogBox.Hide();
                    repHW.ShowDialog();

                }   
                else if (u is Agent)
                {
                    agentHW = new AgentHomeWindow();
                    
                    agentHW.nameLabel.Text = u.getFirstName() + " " + u.getLastName();
                    agentHW.photoLabel.Image = u.Dp.getPicture();
                    agentHW.ShowDialog();
                }
              
                else if (u is WarehouseManager)
                {
                    wmHW = new WMHomeWindow();
                   
                    wmHW.nameLabel.Text = u.getFirstName() + " " + u.getLastName();
                    wmHW.photoLabel.Image = u.Dp.getPicture();
                    wmHW.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(check);
                openingDialogBox.usernameText.Text = "";
                openingDialogBox.passwordText.Text = "";
            }

        }
        public void adminAddemployer()
        {
            newEmployee = new AddEmployee(this);
            newEmployee.ShowDialog();
        }
        public string addadminemployersave(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img, string userType, List<UserRole> roles)
        {
             return objectFactory.storeUser(empId, empNIC, gender, firstName, lastName, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3, img, userType, roles);
        }
        public void adminViewEmployer()
        {
            viewEmployee.ShowDialog();
        }
        public void adminSearchEmploee(int empId=0, string empFirstName="", string empLastName="")

        {         

            viewEmployee.setData(objectFactory.searchUser(empId, empFirstName, empLastName));
            viewEmployee.ShowDialog();

        }

        public void setMyHome_Representative() {
            profile.TopLevel = false;
            repHW.TopLevel = true;
            profile.AutoScroll = true;
            
            profile.addressLabel.Text = currentUser.ContactDetails.AddressLine_1;
            profile.cityLabel.Text = currentUser.ContactDetails.AddressLine_2;
            profile.stateLabel.Text = currentUser.ContactDetails.AddressLine_3;
            profile.mobileLabel.Text = currentUser.ContactDetails.MobileNo.ToString();
            profile.homeTelLabel.Text = currentUser.ContactDetails.LandNo.ToString();
            profile.nameLabel.Text = currentUser.getFirstName() + currentUser.getLastName();
            profile.regionLabel.Text = "---";
            profile.jobTitleLabel.Text = currentUser.UserRoles[0].getRoleName();
            repHW.repMainPannel.Controls.Add(profile);
            profile.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            profile.Show();
        }

        public void setMyHome_Admin()
        {
            profile.TopLevel = false;
            adminHW.TopLevel = true;
            profile.AutoScroll = true;

            profile.addressLabel.Text = currentUser.ContactDetails.AddressLine_1;
            profile.cityLabel.Text = currentUser.ContactDetails.AddressLine_2;
            profile.stateLabel.Text = currentUser.ContactDetails.AddressLine_3;
            profile.mobileLabel.Text = currentUser.ContactDetails.MobileNo.ToString();
            profile.homeTelLabel.Text = currentUser.ContactDetails.LandNo.ToString();
            profile.nameLabel.Text = currentUser.getFirstName() +" "+ currentUser.getLastName();
            profile.regionLabel.Text = "---";
            profile.jobTitleLabel.Text = "ioio";// currentUser.UserRoles[0].getRoleName();
            adminHW.adminMainPanel1.Controls.Add(profile);
            profile.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            profile.Show();
        }


    }
}
