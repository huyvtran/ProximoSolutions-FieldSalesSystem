using Field_Sales_System.Utility_Classes;
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
        string addUser(ObjectFactory factory, SecurityManager securityManager, int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img, string userType, List<UserRole> rolesList, string password);
        List<User> searchUser(ObjectFactory factory, int empId = 0, string firstName = "", string lastName = "");
        string changeUsername(ObjectFactory factory, User user,string firstName,string lastName);
        string changeNIC(ObjectFactory factory, User user, int newNIC);
        string changeGender(ObjectFactory factory, User user, bool gender);
        string changePicture(ObjectFactory factory, User user, Image image);
        string changePassword(SecurityManager securityManager, User user, string oldPassword, string newPassword);

        //Company admin tasks
        string deactivateUser(SecurityManager securityManager, User user);
        string activateUser(SecurityManager securityManager, User user);        
        string addRole(ObjectFactory factory, User user, UserRole newRole);
        string removeRole(ObjectFactory factory, User user, string roleName);

        
    }
}
