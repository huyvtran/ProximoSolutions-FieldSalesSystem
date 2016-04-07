using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    abstract class User : Employee
    {
        private List<UserRole> userRoles;

        public void addRole(UserRole r) {
            this.userRoles.Add(r);

        }

        public void removeRole(UserRole r) {
            this.userRoles.Remove(r);
        }
    }
}
