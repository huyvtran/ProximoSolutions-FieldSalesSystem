using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class Representative : User, OrderManagement
    {

        public Representative(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string address, string url)
            :base(empId,empNIC,gender,firstName,lastName,mobileNo,landNo,email,address,url)
        {
        
        }
            
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
