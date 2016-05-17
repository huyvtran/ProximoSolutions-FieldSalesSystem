using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
<<<<<<< HEAD
{[Serializable]
=======
{
    [Serializable]
>>>>>>> 910d73690d76255d5ee2e70e3d4b46b59576632b
    public class Permission
    {
        private string permName;
        private int permId;

        public string PermName
        {
            get
            {
                return permName;
            }

            set
            {
                permName = value;
            }
        }

        public int PermId
        {
            get
            {
                return permId;
            }

            set
            {
                permId = value;
            }
        }
    }
}
