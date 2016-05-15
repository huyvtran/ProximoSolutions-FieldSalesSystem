using Field_Sales_System.Utility_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    interface ContactsManagement
    {
        string updateMobileNo(ObjectFactory factory, User user, int newMobileNo);
        string updateLandNo(ObjectFactory factory, User user, int newLandNo);
        string updateEmail(ObjectFactory factory, User user, string newEmail);
        string updateAddress(ObjectFactory factory, User user, string addressLine_1, string addressLine_2, string addressLine_3);

    }
}
