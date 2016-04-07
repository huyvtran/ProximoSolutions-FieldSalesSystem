using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class User : Employee
    {
        private List<UserRole> userRoles;
        private UserRole UserRole;
        public void addRole(UserRole r) {
            this.userRoles.Add(r);

        }

        public void removeRole(UserRole r) {
            this.userRoles.Remove(r);
        }

        public List<User> searchUser(String keyword) {
            return new List<User>();  //Just for now. To be implemented later
        }
        public User viewUser(int userId) {
            return new User();      //To be implemented later
        }
        public List<Product> searchProduct(String keyword) {
            return new List<Product>();                         //Any system user can search for products
        }
        public Product viewProduct(int productId) {
            return new Product();                               //Any system user can view products
        }

    }
}
