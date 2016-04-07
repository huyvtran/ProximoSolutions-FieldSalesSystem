using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    interface UserManagement
    {
        void updateUser(User user);
        void deactivateUser(User user);
        void activateUser(User user);
        void changePassword(User user);
        void reviewUpdate();
        void acceptUpdate();
    }
}
