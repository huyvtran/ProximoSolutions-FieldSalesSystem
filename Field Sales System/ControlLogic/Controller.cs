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
using System.Data;
using System.Windows.Forms;

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
        ForgotPassword forgotPassword;
        ChangePassword changePasswordForm;
        ChangePasswordAdmin changePasswordAdminForm;
        UpdateEmployee updateEmployee;
        Invoice createOrder;
        


        public ForgotPassword ForgotPassword
        {
            get
            {
                return forgotPassword;
            }

            set
            {
                forgotPassword = value;
            }
        }

        public SignIn OpeningDialogBox
        {
            get
            {
                return openingDialogBox;
            }

            set
            {
                openingDialogBox = value;
            }
        }

        public Controller()
        {
            objectFactory = new ObjectFactory();
            securityManager = new SecurityManager();
            this.openingDialogBox = new SignIn(this);
            profile = new EmployeeProfile(this);
            ForgotPassword = new ForgotPassword(this);
            updateEmployee = new UpdateEmployee();
            viewEmployee = new ViewEmployee(this);
            createOrder = new Invoice(this);

        }
        public void initilizer()
        {
            OpeningDialogBox.ShowDialog();
        }
        public void logIn(int empId, string password)
        {
            string check = securityManager.login(empId, password);
            if (check.Equals("Successfully logged in!"))
            {
                System.Windows.Forms.MessageBox.Show(check);
                User u = objectFactory.getUser(empId);
                if (u != null)
                {
                    currentUser = u;
                    if (u is CompanyAdmin)
                    {
                        adminHW = new AdminHomeWindow(this);
                        //adminHW.TopLevel = false;
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
                        OpeningDialogBox.Hide();
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
                    System.Windows.Forms.MessageBox.Show(check);
                    OpeningDialogBox.usernameText.Text = "";
                    OpeningDialogBox.passwordText.Text = "";
                }
            }
            else {
                
            }

        }
        public void adminAddemployer()
        {
            newEmployee = new AddEmployee(this);
            newEmployee.ShowDialog();
        }
        public List<Permission> permission()
        { List<Permission> permissionList = new List<Permission>();
            Permission permission = objectFactory.createPermission("blah", 1);
            permissionList.Add(permission);
            return permissionList;
        }
        public List<UserRole> userRole(string type)
        { List<Permission> permissionListSent = permission();
            List<UserRole> userRoleList = new List<UserRole>();

            UserRole userRole = objectFactory.createUserRole(type, permissionListSent);
            userRoleList.Add(userRole);
            return userRoleList;

        }
        public void addAdminEmployerSave(int empId, int empNIC, DateTime Now, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img, string userType)
        {
            List<UserRole> roles = userRole(userType);
             MessageBox.Show( ((CompanyAdmin)currentUser).addUser(objectFactory,securityManager,empId, empNIC, Now, gender, firstName, lastName, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3, img, userType, roles,"cat"));
        }
        public void searchEmployee_Admin(int empId, string firstName, string lastName)
        {
            adminHW.adminMainPanel1.Controls.Clear();
            List<User> searchResult = objectFactory.searchUser(empId, firstName, lastName);
            //this.viewEmployee.dataGridView1 = new System.Windows.Forms.DataGridView();

            foreach (User user in searchResult)
            {
                Image pic = user.Dp.getPicture();
                this.viewEmployee.dataGridView1.Rows.Add(user.getEmpId(), user.Dp.getPicture(), user.getFirstName() + " " + user.getLastName(), user.GetType().ToString(), checkState(user.IsActive), user.ContactDetails.MobileNo, user.ContactDetails.EmailAddress);

            }
            viewEmployee.TopLevel = false;
            viewEmployee.AutoScroll = true;
           adminHW.TopLevel = true;
            adminHW.adminMainPanel1.Controls.Add(viewEmployee);
            viewEmployee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            viewEmployee.Show();
        }
   

        public void setMyHome_Representative() {
            profile.TopLevel = false;
            repHW.TopLevel = true;
            profile.AutoScroll = true;

            profile.updateButton.Visible = false;
            profile.addressLabel.Text = currentUser.ContactDetails.AddressLine_1;
            profile.cityLabel.Text = currentUser.ContactDetails.AddressLine_2;
            profile.stateLabel.Text = currentUser.ContactDetails.AddressLine_3;
            profile.mobileLabel.Text = currentUser.ContactDetails.MobileNo.ToString();
            profile.homeTelLabel.Text = currentUser.ContactDetails.LandNo.ToString();
            profile.nameLabel.Text = currentUser.getFirstName() +" "+ currentUser.getLastName();
            profile.regionLabel.Text = "---";
            profile.photoLabel.Image = currentUser.Dp.getPicture();
            //profile.jobTitleLabel.Text = currentUser.UserRoles[0].getRoleName();
            //profile.statusLabel.Text = isActive(currentUser);
            profile.jobTitleLabel.Text = currentUser.GetType().ToString();

            
           // profile.addressLabel.Text = currentUser.ContactDetails.AddressLine_1;
            //profile.cityLabel.Text = currentUser.ContactDetails.AddressLine_2;
            //profile.stateLabel.Text = currentUser.ContactDetails.AddressLine_3;
            //profile.mobileLabel.Text = currentUser.ContactDetails.MobileNo.ToString();
            //profile.homeTelLabel.Text = currentUser.ContactDetails.LandNo.ToString();
           // profile.nameLabel.Text = currentUser.getFirstName() + currentUser.getLastName();
           // profile.regionLabel.Text = "---";
           // profile.jobTitleLabel.Text = currentUser.UserRoles[0].getRoleName();
            repHW.repMainPannel.Controls.Add(profile);
            profile.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            profile.Show();
        }
        public string isActive(User u) {
            if (u.IsActive)
            {
                return "Active";
            }
            else {
                return "Temporarily restricted access";
            }
        }
        public void resetPassword(int empId) {
            string s = securityManager.requestPasswordReset(empId);
            System.Windows.Forms.MessageBox.Show(s);
        }
        public void changeEmployeePassword() {
            if (currentUser is CompanyAdmin)
            {
                changePasswordAdminForm = new ChangePasswordAdmin(this);
                changePasswordAdminForm.Show();
            }
            else {
                changePasswordForm = new ChangePassword(this);
                changePasswordForm.Show();
            }
        }
        public void changePasswordNonAdmin(string oldPassword,string newPassword) {
            string status = securityManager.modifyPassword(currentUser.getEmpId(), oldPassword, newPassword);
            System.Windows.Forms.MessageBox.Show(status);
            changePasswordForm.Hide();
        }
        public void changePasswordAdmin(int empId, string newPassword) {
            string status = securityManager.modifyPasswordAdmin(empId, newPassword);
            System.Windows.Forms.MessageBox.Show(status);
            changePasswordForm.Hide();
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

        public void searchEmployee_Rep(int empId, string firstName,string lastName) {
            repHW.repMainPannel.Controls.Clear();
            List<User> searchResult = objectFactory.searchUser(empId,firstName,lastName);
            //this.viewEmployee.dataGridView1 = new System.Windows.Forms.DataGridView();
            
            foreach (User user in searchResult)
            {
                Image pic = user.Dp.getPicture();
                this.viewEmployee.dataGridView1.Rows.Add(user.getEmpId(), user.Dp.getPicture(), user.getFirstName() + " " + user.getLastName(), user.GetType().ToString(), checkState(user.IsActive), user.ContactDetails.MobileNo, user.ContactDetails.EmailAddress);
                       
            }
            viewEmployee.TopLevel = false;
            viewEmployee.AutoScroll = true;
            repHW.TopLevel = true;
            repHW.repMainPannel.Controls.Add(viewEmployee);
            viewEmployee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
            viewEmployee.Show();
        }

        public string checkState(bool b)
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
        public string getUserRegion(User user)
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

        public void createNewOrder_Rep() {
            List<Product> products = objectFactory.retrieveAllProducts();
            if (products != null)
            {
                repHW.repMainPannel.Controls.Clear();
                createOrder.TopLevel = false;
                repHW.TopLevel = true;
                createOrder.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                createOrder.productNameCombo.Items.Clear();
                foreach (Product p in products) {
                    createOrder.productNameCombo.Items.Add(p.ProductName);
                }
                repHW.repMainPannel.Controls.Add(createOrder);
                createOrder.dateLabel.Text = System.DateTime.Now.ToLongDateString();
                createOrder.timeLabel.Text = DateTime.Now.ToLongTimeString();
                createOrder.Show();
            }
            else {
                System.Windows.Forms.MessageBox.Show("There was something wrong. Try again Later!");
            }
        }

        public Product getSelectedProduct(string productName) {
            return objectFactory.getProduct(-1, productName);
        }

        public void addOrder() {
            List<OrderEntry> entries = new List<OrderEntry>();
            foreach (DataGridViewRow row in createOrder.invoiceDataGrid.Rows) {
                OrderEntry oe = new OrderEntry();
                oe.Product = getSelectedProduct(row.Cells[2].Value.ToString());
                oe.Quantity = Int32.Parse(row.Cells[4].Value.ToString());
                entries.Add(oe);
            }


            //DateTime time = new DateTime(createOrder.timeLabel.Text);
            //order.OrderRequestedDate = System.DateTime.Now;
            System.Windows.Forms.MessageBox.Show(objectFactory.storeNewOrder(Int32.Parse(createOrder.invoiceNumberText.Text), DateTime.Now, entries, Int32.Parse(createOrder.empIDText.Text), createOrder.customerContactText.Text));

        }

        public void viewOrder() {
           // List<Order> orderList = objectFactory.
        }





    }
}
