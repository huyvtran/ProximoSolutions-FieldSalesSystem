using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Field_Sales_System.Business_Logic
{
    class Order
    {
        private List<OrderEntry> orders;
        private OrderProcessDetails processDetails;
        private OrderEntry newOrderEntry;
        private int orderId;
        private DateTime orderaddedDate;
        private DateTime orderRequestedDate;

        public Order(int OrderID, DateTime OrderaddedDate, DateTime OrderRequestedDate, OrderEntry NewOrderEntry, OrderProcessDetails newprocessDetails)
        {
            orderId = OrderID;
            orderaddedDate = OrderaddedDate;
            orderRequestedDate = OrderRequestedDate;
            newOrderEntry = NewOrderEntry;
            processDetails = newprocessDetails;
        }
        public void setOrderId(int orderId)
        {
            this.orderId = orderId;
        }
        public void setOrderDate(DateTime orderDate)
        {
            this.orderaddedDate = orderDate;
        }
        public DateTime getOrderDate()
        {
            return this.orderaddedDate;
        }
        public int getOrderId()
        {
            return this.orderId;
        }

        public void setProcessDetails(OrderProcessDetails pd)
        {
            this.processDetails = pd;
        }
        public OrderProcessDetails getProcessDetails()
        {
            return processDetails;
        }

        public void addorderentry(int amount, Product product)
        {
            int entryID = 00;
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

    }





}
