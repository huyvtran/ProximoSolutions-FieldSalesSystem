using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

        public void addorderentry(int amount, Product product)
        {
            int entryID = orders.count;
            OrderEntry newentry = new OrderEntry();
            newentry.setQuantity(amount);
            newentry.setProduct(product);
            newentry.setID(entryID);
            orders.Add(new OrderEntry());
        }
        public void editordentryquantity(int entryid, int quantity)
        {
            orders[entryid].setQuantity(quantity);
        }
        public void editordentryproduct(int entryid, Product product)
        {
            orders[entryid].setProduct(product);
        }
        public void deleteorderentry(int orderentryid)
        {
            // Remove a record.
        }

        public void passtobuilder(Order saveorder)
        {
            // Send the object to quary builder
        }
    }



}
