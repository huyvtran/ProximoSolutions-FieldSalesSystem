using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class Permission
    {
        private string permName;
        private int permId;
        public void setPermName(string permName) {
            this.permName = permName;
        }
        public void setPermId() {
            this.permId = generatePermId();
        }
        private int generatePermId() {
            int id = 0; //Temporary value untill the real implimentation 
            return id;
        }

        public int getPermId() {
            return this.permId;
        }

        public string getPermName() {
            return this.permName;
        }

    }
}
