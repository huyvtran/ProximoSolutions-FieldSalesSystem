using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    [Serializable()]
    class Representative : User, OrderManagement
    {

        public Representative(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1,string addressLine_2,string addressLine_3, Image img)
            :base(empId,empNIC,gender,firstName,lastName,mobileNo,landNo,email,addressLine_1,addressLine_2,addressLine_3,img)
        {
        
        }

        public bool addEntry(Order order, OrderEntry entry)
        {
            throw new NotImplementedException();
        }

        public bool removeEntry(Order order, OrderEntry entry)
        {
            throw new NotImplementedException();
        }

        public bool removeOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public bool requestOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public ArrayList viewOrderSummary(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
