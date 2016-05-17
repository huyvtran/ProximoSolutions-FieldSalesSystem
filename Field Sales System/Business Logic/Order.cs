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
        private int orderId;
        private string orderNote;
        private DateTime orderRequestedDate;
        private string orderRegion;  
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

        public List<OrderEntry> Orders
        {
            get
            {
                return orders;
            }

            set
            {
                orders = value;
            }
        }

        public string OrderNote
        {
            get
            {
                return orderNote;
            }

            set
            {
                orderNote = value;
            }
        }

        public int OrderId
        {
            get
            {
                return orderId;
            }

            set
            {
                orderId = value;
            }
        }

        public string OrderRegion
        {
            get
            {
                return orderRegion;
            }

            set
            {
                orderRegion = value;
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
            Orders.Add(orderedProductEntry);
        }
        public int getentrysize() {
           return this.Orders.Count;

        }
        public void editordentryquantity(int entryid, int quantity, Product gotProdct)
        {   
            Orders[entryid].Quantity = quantity;
            Orders[entryid].Product = gotProdct;
        }
    
        public void deleteorderentry(int orderEntryId)
        {
           // Orders[orderEntryId].EntryState = "Cancelled";
        }

    }




}
