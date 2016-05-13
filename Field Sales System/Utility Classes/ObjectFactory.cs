<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Field_Sales_System.Business_Logic;
using System.Collections;
=======
﻿using Field_Sales_System.Business_Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 1549e8a70960ae434c897a17d9b798621f9e4c08

namespace Field_Sales_System.Utility_Classes
{
    class ObjectFactory
<<<<<<< HEAD

    { Object send;
        public Object setObject(ArrayList inputset)
        { 
            // Get calling method name
            Console.WriteLine(this.checker().GetFrame(1).GetMethod().Name);
            String check = this.checker().GetFrame(1).GetMethod().Name;
            switch(check)
                {
                case "placeorder":
                    {
                        Object send = this.neworder(inputset);
                        return send;
                    }

            }
            return null;
        }

      
        private Object neworder(ArrayList inputset) {
            Product orderedProduct = this.getObject(Convert.ToInt32(inputset[2]));
            Order neworder = new Order(Convert.ToInt32(inputset[0]), Convert.ToDateTime(inputset[1]));
            return neworder;
   
        }

        private StackTrace checker()
        { StackTrace stackTrace = new StackTrace();
            return stackTrace;

        }
        public Object getObject(ArrayList inputget)
        {
            Console.WriteLine(this.checker().GetFrame(1).GetMethod().Name);
            String check = this.checker().GetFrame(1).GetMethod().Name;
            switch (check)
            {
                case "addtext":
                    {
                        return null;
                    }

            }
            return null;
        }

        private Object getProduct()
        {

=======
    {
        public User crerateUser(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img,string userRole, List<Permission> permissions) {
            try
            {

                //This class is not finished. Do not touch!
                if (userRole.Equals("Representative")) {
                    User rep = new Representative(empId, empNIC, gender, firstName, lastName, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3, img);
                    ContactDetails c = new ContactDetails(mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3);
                    UserRole ur = new UserRole();
                    ur.setRoleName(userRole);
                    for (int i = 0; i < permissions.Count; i++) {
                        ur.addPermission(permissions[i]);
                    }
                    
                    
                    return rep;
                }
                return null;
            }
            catch (Exception e) {
                return null;
            }
>>>>>>> 1549e8a70960ae434c897a17d9b798621f9e4c08
        }
    }
}
