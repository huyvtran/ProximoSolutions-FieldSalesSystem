using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class CompanyAdmin : User, UserManagement
    {
        public void addRepresentative(String firstName, String secondName, int contactNo, String address) { }
        public void addAgent(String agencyName, String firstName, String secondName, int contactNo, String address) { }
        public void updateProduct(Product p) {
            //update details of product p
        }

        public void updateUser(User user) { }
        public void deactivateUser(User user) { }
        public void activateUser(User user) { }
        public void changePassword(User user) { }
        public void reviewUpdate() { }
        public void acceptUpdate() { }

    }
}
