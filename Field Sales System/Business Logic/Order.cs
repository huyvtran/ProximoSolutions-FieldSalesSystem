using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    public class Order
    {
        private List<OrderEntry> orders;
        private OrderProcessDetails processDetails;
        private int ordererId;
        private DateTime orderRequestedDate;
        public int OrdererId
        {
            get
            {
                return ordererId;
            }

            set
            {
                ordererId = value;
            }
        }

        public DateTime OrderRequestedDate
        {
            get
            {
                return orderRequestedDate;
            }

            set
            {
                orderRequestedDate = value;
            }
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
            orders.Add(orderedProductEntry);
        }
        public int getentrysize() {
           return this.orders.Count;

        }
        public void editordentryquantity(int entryid, int quantity)
        {
            //orders[entryid].setQuantity(quantity);
        }
        public void editordentryproduct(int entryid, Product product)
        {
            //orders[entryid].setProduct(product);
        }
        public void deleteorderentry(int orderentryid)
        {
            // Remove a record.
        }

    }




}
