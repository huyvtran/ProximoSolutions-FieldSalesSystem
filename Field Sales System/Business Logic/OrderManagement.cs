using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{

    interface OrderManagement
    {
        bool requestOrder(Order order);
        bool addEntry(Order order, OrderEntry entry);
        bool removeEntry(Order order, OrderEntry entry);
        ArrayList viewOrderSummary(int orderId);
        bool removeOrder(int orderId);
    }
}
