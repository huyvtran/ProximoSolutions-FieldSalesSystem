using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.

namespace Field_Sales_System.Business_Logic
{
    class Order
    {
        private ArrayList<> orders;
        private OrderProcessDetails processDetails;
        private int orderId;
        private DateTime orderDate;
        public void setOrderId(int orderId) {
            this.orderId = orderId;
        }
        public void setOrderDate(DateTime orderDate) {
            this.orderDate = orderDate;
        }
        public DateTime getOrderDate() {
            return this.orderDate;
        }
        public int getOrderId() {
            return this.orderId;
        }

        public void setProcessDetails(OrderProcessDetails pd) {
            this.processDetails = pd;
        }
        public OrderProcessDetails getProcessDetails() {
            return processDetails;
        }
        public void addOrderEntry(OrderEntry oe) {
            this.orders.Add(oe);
        }

        public ArrayList()



    }
}
