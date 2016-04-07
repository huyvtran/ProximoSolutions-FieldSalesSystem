using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class Representative : User, OrderManagement
    {
        public void requestOrder(int orderId) { }
        public void editOrder(int orderId) { }
        public void viewOrderSummary() { }
        public void removeOrder(int orderId) { }
        public void requestPaymentDetailsUpdate(int orderNo)
        {

        }

        public void enterPaymentDetails(int orderNo)
        {

        }

    }
}
