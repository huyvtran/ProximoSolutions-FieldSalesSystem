using Field_Sales_System.Utility_Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    public class User : Employee, UserManagement,ContactsManagement
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

        public User(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1,string addressLine_2,string addressLine_3, Image img):base(empId,empNIC,gender,firstName,lastName,mobileNo,landNo,email,addressLine_1,addressLine_2,addressLine_3,img)
        {
            databaseCon.connectDatabase(Properties.Settings.Default.dbServerConnectionString);
        }
        public UserRole getRole() {
        return }

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
    }
}
