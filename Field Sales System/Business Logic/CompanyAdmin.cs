using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Field_Sales_System.Utility_Classes;

namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    public class CompanyAdmin : User
    {
        //ObjectFactory Object;
        public CompanyAdmin(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1,string addressLine_2,string addressLine_3, Image img):base(empId,empNIC,gender,firstName,lastName,mobileNo,landNo,email,addressLine_1,addressLine_2,addressLine_3,img)
        {
        }

        public override string addUser(ObjectFactory factory, SecurityManager securityManager, int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img, string userType, List<UserRole> rolesList, string password)
        {
            string securityManagerStatus = securityManager.addUserLoginInformation(empId,password);
            if (securityManagerStatus == "Success!")
            {
                return factory.storeUser(empId, empNIC, gender, firstName, lastName, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3, img, userType, rolesList);

            }
            else {
                return "Can't create the profile right now. Try again later!";
            }
        }

        public override string deactivateUser(SecurityManager securityManager, User user)
        {
            string status = securityManager.modifyStatus(user.getEmpId(), 0);
            if (status == "Successfully changed status!")
            {
                user.IsActive = true;
                return status;
            }
            else {
                return status;
            }
        }

        public override string activateUser(SecurityManager securityManager, User user)
        {
            string status = securityManager.modifyStatus(user.getEmpId(), 1);
            if (status == "Successfully changed status!")
            {
                user.IsActive = true;
                return status;
            }
            else {
                return status;
            }
            

        }

        public override string addRole(ObjectFactory factory, User user, UserRole newRole)
        {
            user.UserRoles.Add(newRole);
            return factory.modifyUser(user);
        }

        public override string removeRole(ObjectFactory factory, User user, string roleName)
        {
            foreach (UserRole role in user.UserRoles) {
                if (role.getRoleName().Equals(roleName)) {
                    user.UserRoles.Remove(role);
                }
            }
            return factory.modifyUser(user);
        }

        public override string addOrder(ObjectFactory factory, Order order)
        {
            throw new NotImplementedException();
        }

        public string resetEmployeePassword(SecurityManager securityManager,int empId,string newPassword) {
            return securityManager.modifyPasswordAdmin(empId, newPassword);
        }

        public List<int> viewPasswordResetRequests(SecurityManager securityManager) {
            return securityManager.getPasswordResetRequests();
        }

        public string updateProduct(ObjectFactory factory, Product newProduct) {
            return factory.modifyProduct(newProduct);
        }

        
    }
}
