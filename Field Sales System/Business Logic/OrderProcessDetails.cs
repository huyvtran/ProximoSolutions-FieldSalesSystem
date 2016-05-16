using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    public class OrderProcessDetails
    {
        private string orderStatus="Not Processed";
        private int processedBy;
        private OrderPickupSchedule OrderPickupSchedule;

        public OrderPickupSchedule OrderPickupSchedule1
        {
            get
            {
                return OrderPickupSchedule;
            }

            set
            {
                OrderPickupSchedule = value;
            }
        }

        public void setOrderStatus(string orderStatus) {
            this.orderStatus = orderStatus;
        }
        public void setProcessedBy(int processedBy) {
            this.processedBy = processedBy;
        }
        public string getOrderStatus() {
            return this.orderStatus;
        }
        public int getProcessedBy() {
            return this.processedBy;
        }
        
    }
}
