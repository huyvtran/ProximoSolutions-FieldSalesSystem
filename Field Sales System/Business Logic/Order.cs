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
        private int placedempID;
        public int OrderId
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
        public void editordentryquantity(int entryid, int quantity, Product gotProdct)
        {   
            orders[entryid].Quantity = quantity;
            orders[entryid].Product = gotProdct;
        }
    
        public void deleteorderentry(int orderEntryId)
        {
            orders[orderEntryId].EntryState = "Cancelled";
        }

    }




}
