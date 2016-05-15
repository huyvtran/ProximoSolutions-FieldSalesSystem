using Field_Sales_System.Utility_Classes;
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
        string addOrder(ObjectFactory factory, Order order);
        List<Order> viewOrder(ObjectFactory factory, DateTime beginDate, DateTime endDate, int ordererId );
        string cancelOrder(ObjectFactory factory, Order order);
    }
}
