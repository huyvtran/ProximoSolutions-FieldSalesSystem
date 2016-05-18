using Field_Sales_System.Utility_Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    public abstract class User : Employee,UserManagement,ContactsManagement,OrderManagement
    {
        private List<UserRole> userRoles;
        private bool isActive;
        private ConnectionManager databaseCon = new ConnectionManager();

        public bool IsActive
        {
            get
            {
                return isActive;
            }

            set
            {
                isActive = value;
            }
        }

        internal List<UserRole> UserRoles
        {
            get
            {
                return userRoles;
            }

            set
            {
                userRoles = value;
            }
        }

        public User(int empId, int empNIC, DateTime dOB, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img) : base(empId, empNIC, dOB, gender, firstName, lastName, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3, img)
        {
            databaseCon.connectDatabase(Properties.Settings.Default.dbServerConnectionString);
        }




        public abstract string addUser(ObjectFactory factory, SecurityManager securityManager, int empId, int empNIC,DateTime dOB, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img, string userType, List<UserRole> rolesList, string password);
        public List<User> searchUser(ObjectFactory factory, int empId = 0, string firstName = "", string lastName = "") {
            return factory.searchUser(empId, firstName, lastName);
        }
        public string changeUsername(ObjectFactory factory, User user, string firstName, string lastName) {
            bool adminRights = false;
            foreach (UserRole role in this.userRoles) {
                foreach (Permission perm in role.Permissions) {
                    if (perm.PermId == 2000) {
                        adminRights = true;
                    }
                } 
            }
            if (adminRights)
            {
                user.setFirstName(firstName);
                user.setLastName(lastName);
                factory.modifyUser(user);
                return "Successfully changed the username";
            }
            else {
                if (this.getEmpId() == user.getEmpId())
                {
                    user.setFirstName(firstName);
                    user.setLastName(lastName);
                    factory.modifyUser(user);
                    return "Successfully changed the username";
                }
                else {
                    return "You do not have permission to perform the action!";
                }
            }

        }
        public string changeNIC(ObjectFactory factory, User user, int newNIC) {
            bool adminRights = false;
            foreach (UserRole role in this.userRoles)
            {
                foreach (Permission perm in role.Permissions)
                {
                    if (perm.PermId == 2001)
                    {
                        adminRights = true;
                    }
                }
            }
            if (adminRights)
            {
                user.EmpNIC = newNIC;
                factory.modifyUser(user);
                return "Successfully changed the NIC";
            }
            else {
                if (this.getEmpId() == user.getEmpId())
                {
                    user.EmpNIC = newNIC;
                    factory.modifyUser(user);
                    return "Successfully changed the username";
                }
                else {
                    return "You do not have permission to perform the action!";
                }
            }
        }
        public string changeGender(ObjectFactory factory, User user, bool gender) {
            return ""; //implement later
        }
        public string changePicture(ObjectFactory factory, User user, Image image) {
            return ""; //implement later
        }

        public string changePassword(SecurityManager securityManager, User user, string oldPassword, string newPassword) {
            bool adminRights = false;
            foreach (UserRole role in user.userRoles)
            {
                foreach (Permission perm in role.Permissions)
                {
                    if (perm.PermId == 2004)
                    {
                        adminRights = true;
                    }
                }
            }
            if (adminRights)
            {
                return securityManager.modifyPassword(user.getEmpId(),oldPassword,newPassword);
            }
            else {
                if (this.getEmpId() == user.getEmpId())
                {
                    return securityManager.modifyPassword(user.getEmpId(), oldPassword, newPassword);
                }
                else {
                    return "You do not have permission to perform the action!";
                }
            }
        }
        public abstract string deactivateUser(SecurityManager securityManager, User user);
        public abstract string activateUser(SecurityManager securityManager, User user);      
        public abstract string addRole(ObjectFactory factory, User user, UserRole newRole);
        public abstract string removeRole(ObjectFactory factory, User user, string roleName);

        //manage contacts
        public string updateMobileNo(ObjectFactory factory, User user, int newMobileNo) {
            bool adminRights = false;
            foreach (UserRole role in user.userRoles)
            {
                foreach (Permission perm in role.Permissions)
                {
                    if (perm.PermId == 2005)
                    {
                        adminRights = true;
                    }
                }
            }
            if (adminRights)
            {

                user.ContactDetails.MobileNo = newMobileNo;
                factory.modifyUser(user);
                return "Successfully changed the mobile number";
            }
            else {
                if (this.getEmpId() == user.getEmpId())
                {
                    user.ContactDetails.MobileNo = newMobileNo;
                    factory.modifyUser(user);
                    return "Successfully changed the mobile number";
                }
                else {
                    return "You do not have permission to perform the action!";
                }
            }

        }
        public string updateLandNo(ObjectFactory factory, User user, int newLandNo) {
            bool adminRights = false;
            foreach (UserRole role in user.userRoles)
            {
                foreach (Permission perm in role.Permissions)
                {
                    if (perm.PermId == 2006)
                    {
                        adminRights = true;
                    }
                }
            }
            if (adminRights)
            {

                user.ContactDetails.LandNo = newLandNo;
                factory.modifyUser(user);
                return "Successfully changed the Land number";
            }
            else {
                if (this.getEmpId() == user.getEmpId())
                {
                    user.ContactDetails.LandNo = newLandNo;
                    factory.modifyUser(user);
                    return "Successfully changed the Land number";
                }
                else {
                    return "You do not have permission to perform the action!";
                }
            }
        }
        public string updateEmail(ObjectFactory factory, User user, string newEmail) {
            bool adminRights = false;
            foreach (UserRole role in user.userRoles)
            {
                foreach (Permission perm in role.Permissions)
                {
                    if (perm.PermId == 2007)
                    {
                        adminRights = true;
                    }
                }
            }
            if (adminRights)
            {

                user.ContactDetails.EmailAddress = newEmail;
                factory.modifyUser(user);
                return "Successfully changed the email address";
            }
            else {
                if (this.getEmpId() == user.getEmpId())
                {
                    user.ContactDetails.EmailAddress = newEmail;
                    factory.modifyUser(user);
                    return "Successfully changed the email address";
                }
                else {
                    return "You do not have permission to perform the action!";
                }
            }
        }
        public string updateAddress(ObjectFactory factory, User user, string addressLine_1, string addressLine_2, string addressLine_3) {
            bool adminRights = false;
            foreach (UserRole role in user.userRoles)
            {
                foreach (Permission perm in role.Permissions)
                {
                    if (perm.PermId == 2008)
                    {
                        adminRights = true;
                    }
                }
            }
            if (adminRights)
            {

                user.ContactDetails.AddressLine_1 = addressLine_1;
                user.ContactDetails.AddressLine_2 = addressLine_2;
                user.ContactDetails.AddressLine_3 = addressLine_3;
                factory.modifyUser(user);
                return "Successfully changed the address";
            }
            else {
                if (this.getEmpId() == user.getEmpId())
                {
                    user.ContactDetails.AddressLine_1 = addressLine_1;
                    user.ContactDetails.AddressLine_2 = addressLine_2;
                    user.ContactDetails.AddressLine_3 = addressLine_3;
                    factory.modifyUser(user);
                    return "Successfully changed the address";
                }
                else {
                    return "You do not have permission to perform the action!";
                }
            }
        }

        public abstract string addOrder(ObjectFactory factory, Order order);
        public List<Order> viewOrder(ObjectFactory factory, DateTime beginDate, DateTime endDate, int ordererId) {
            return factory.getOrder(this, beginDate, endDate);
        }
        public List<Order> viewOrderByStatus(ObjectFactory factory, string status) {
            return factory.getOrderByStatus(this, status);
        }
        public string updateOrder(ObjectFactory factory, Order order,string newStatus) {
            bool adminRights = false;
            foreach (UserRole role in this.userRoles)
            {
                foreach (Permission perm in role.Permissions)
                {
                    if (perm.PermId == 2020)
                    {
                        adminRights = true;
                    }
                }
            }
            if (adminRights)
            {
                return factory.modifyOrderStatus(order, newStatus);
            }
            else {
                
                return "You do not have permissions to perform this action!";
                
            }
        }
        public string cancelOrder(ObjectFactory factory, Order order) {
            bool adminRights = false;
            foreach (UserRole role in this.userRoles)
            {
                foreach (Permission perm in role.Permissions)
                {
                    if (perm.PermId == 2010)
                    {
                        adminRights = true;
                    }
                }
            }
            if (adminRights)
            {
                return factory.modifyOrderStatus(order, "Cancelled!");
            }
            else {
                if (order.OrdererId == this.getEmpId()) {
                    return factory.modifyOrderStatus(order, "Cancelled!");
                }
                else {
                    return "You do not have permissions to perform this action!";
                }
            }
            
        }


        

    }
}
