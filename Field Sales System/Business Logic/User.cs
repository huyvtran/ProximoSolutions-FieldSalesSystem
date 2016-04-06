using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class User : Employee
    {
        private List<Role> userRoles;

        public void addRole(Role r) {
            this.userRoles.Add(r);

        }

        public void removeRole(Role r) {
            this.userRoles.Remove(r);
        }
    }
}
