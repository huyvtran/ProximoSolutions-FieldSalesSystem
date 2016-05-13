using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Field_Sales_System.Business_Logic;
using System.Collections;

namespace Field_Sales_System.Utility_Classes
{
    class ObjectFactory

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

        }
    }
}
