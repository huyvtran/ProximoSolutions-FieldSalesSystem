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

        public User(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img) : base(empId, empNIC, gender, firstName, lastName, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3, img)
        {
            databaseCon.connectDatabase(Properties.Settings.Default.dbServerConnectionString);
        }




        public string addUser(ObjectFactory factory, int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img,string userType) {
            List<Permission> basicPermission = new List<Permission>();
            List<UserRole> basicUserRoleList = new List<UserRole>();
            basicPermission.Add(factory.createPermission("Minimum Permission", 500));
            UserRole basicRole = factory.createUserRole("Basic Role",basicPermission );
            basicUserRoleList.Add(basicRole);
            bool adminRights = false;
            foreach (UserRole role in this.userRoles)
            {
                foreach (Permission perm in role.Permissions)
                {
                    if (perm.PermId == 2500)
                    {
                        adminRights = true;
                    }
                }
            }
            if (adminRights)
            {

                return factory.storeUser(empId, empNIC, gender, firstName, lastName, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3, img, userType, basicUserRoleList);
            }
            else {
                return "You do not have permission to perform the action!";
            }
            
        }
        public List<User> searchUser(ObjectFactory factory, int empId = 0, string firstName = "", string lastName = "") {
            return factory.searchUser(empId, firstName, lastName);
        }
        public string changeUsername(ObjectFactory factory, User user, string firstName, string lastName) {
            bool adminRights = false;
            foreach (UserRole role in user.userRoles) {
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
            foreach (UserRole role in user.userRoles)
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
                    if (perm.PermId == 2000)
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
            return "";//tbi later
        }
        public string updateEmail(ObjectFactory factory, User user, string newEmail) {
            return "";//tbi later
        }
        public string updateAddress(ObjectFactory factory, User user, string addressLine_1, string addressLine_2, string addressLine_3) {
            return "";//tbi later
        }

        public abstract string addOrder(ObjectFactory factory, Order order);
        public abstract List<Order> viewOrder(ObjectFactory factory, DateTime beginDate, DateTime endDate, int ordererId);
        public abstract string cancelOrder(ObjectFactory factory, Order order);


        //public UserRole getRole() {
        //return }
        /*
                public bool activateUser(User user)
                {
                    try
                    {
                        user.isActive = true;
                        return true;
                    }
                    catch (Exception e) {
                        return false;
                    }

                }

                public bool addRole(User user, UserRole newRole)
                {
                    try
                    {
                        user.userRoles.Add(newRole);
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }

                }

                public void addUser(User user)
                {

                }

                public bool changeGender(User user, bool gender)
                {
                    throw new NotImplementedException();
                }

                public bool changeNIC(User user, int newNIC)
                {
                    throw new NotImplementedException();
                }

                public bool changePassword(User user, string oldPassword, string newPassword)
                {
                    throw new NotImplementedException();
                }

                public bool changePicture(User user, Image image)
                {
                    throw new NotImplementedException();
                }

                public bool changeUsername(User user, string firstName, string lastName)
                {
                    throw new NotImplementedException();
                }

                public void deactivateUser(User user)
                {
                    user.isActive = false;
                }

                public bool removeRole(User user, string roleName)
                {
                    throw new NotImplementedException();
                }

                public List<User> searchUser(int empId = 0, string firstName = "", string lastName = "")
                {
                    throw new NotImplementedException();
                }

                public bool updateEmail(User user, string newEmail)
                {
                    throw new NotImplementedException();
                }

                public bool updateLandNo(User user, int newLandNo)
                {
                    throw new NotImplementedException();
                }

                public bool updateMobileNo(User user, int newMobileNo)
                {
                    throw new NotImplementedException();
                }

                bool UserManagement.addUser(User user)
                {
                    throw new NotImplementedException();
                }

                bool UserManagement.deactivateUser(User user)
                {
                    throw new NotImplementedException();
                }
            

            */

    }
}
