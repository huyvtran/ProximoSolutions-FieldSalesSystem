using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    public interface UserManagement
    {
        bool addUser(User user);
        List<User> searchUser(int empId = 0, string firstName = "", string lastName = "");
        bool changeUsername(User user,string firstName,string lastName);
        bool changeNIC(User user, int newNIC);
        bool changeGender(User user, bool gender);
        bool changePicture(User user, Image image);
        bool deactivateUser(User user);
        bool activateUser(User user);
        bool changePassword(User user,string oldPassword,string newPassword);
        bool addRole(User user, UserRole newRole);
        bool removeRole(User user, string roleName);

        
    }
}
