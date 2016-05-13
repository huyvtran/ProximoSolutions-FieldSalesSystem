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
        private int orderId;
        private DateTime orderaddedDate;
        private DateTime orderRequestedDate;

<<<<<<< HEAD
        public Order(int OrderID, DateTime OrderaddedDate, DateTime OrderRequestedDate, OrderEntry NewOrderEntry, OrderProcessDetails newprocessDetails)
        {
=======
    public Order (int OrderID, DateTime OrderaddedDate, DateTime OrderRequestedDate, OrderProcessDetails newprocessDetails)
            {
>>>>>>> master
            orderId = OrderID;
            orderaddedDate = OrderaddedDate;
            orderRequestedDate = OrderRequestedDate;
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

        public void addorderentry(OrderEntry orderedProductEntry)
        {
<<<<<<< HEAD
            int entryID = 00;
            OrderEntry newentry = new OrderEntry();
            newentry.setQuantity(amount);
            newentry.setProduct(product);
            newentry.setID(entryID);
            orders.Add(new OrderEntry());
=======
            orders.Add(orderedProductEntry);
        }
        public int getentrysize() {
           return this.orders.Count;
>>>>>>> master
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
<<<<<<< HEAD


=======
>>>>>>> master



}
