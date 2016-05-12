using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    public class UserRole
    {

        private List<Permission> perms;
        private string roleName;
        public void setRoleName(string name) {
            this.roleName = name;
        }
        public string getRoleName() {
            return this.roleName;
        }
        public void addPermission(Permission p) {
            this.perms.Add(p);
        }
        public void dropPermission(Permission p) {
            this.perms.Remove(p);
        }
        


    }
}
