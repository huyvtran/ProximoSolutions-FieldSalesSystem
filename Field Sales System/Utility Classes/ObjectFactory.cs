using Field_Sales_System.Business_Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Utility_Classes
{
    class ObjectFactory
    {
        public User crerateUser(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img,string userRole, List<Permission> permissions) {
            try
            {

                //This class is not finished. Do not touch!
                if (userRole.Equals("Representative")) {
                    User rep = new Representative(empId, empNIC, gender, firstName, lastName, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3, img);
                    ContactDetails c = new ContactDetails(mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3);
                    UserRole ur = new UserRole();
                    ur.setRoleName(userRole);
                    for (int i = 0; i < permissions.Count; i++) {
                        ur.addPermission(permissions[i]);
                    }
                    
                    
                    return rep;
                }
                return null;
            }
            catch (Exception e) {
                return null;
            }
        }
    }
}
