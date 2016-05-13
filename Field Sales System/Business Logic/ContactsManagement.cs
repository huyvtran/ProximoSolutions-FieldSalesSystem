using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    interface ContactsManagement
    {
        bool updateMobileNo(User user, int newMobileNo);
        bool updateLandNo(User user, int newLandNo);
        bool updateEmail(User user, string newEmail);

    }
}
