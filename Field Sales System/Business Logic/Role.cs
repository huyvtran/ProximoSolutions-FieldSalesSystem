using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class Role
    {

        private List<Permission> perms;
        private string roleName;
        public void setRoleName(string name) {
            this.roleName = name;
        }
        public string getRoleName() {
            return this.roleName;
        }


    }
}
