using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    interface OrderManagement
    {
        void requestOrder(int orderId);
        void editOrder(int orderId);
        void viewOrderSummary();
        void removeOrder(int orderId);
    }
}
