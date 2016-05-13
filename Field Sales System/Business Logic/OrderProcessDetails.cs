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
        private string processedBy= "------";
        private OrderPickupSchedule OrderPickupSchedule;
        public void setOrderStatus(string orderStatus) {
            this.orderStatus = orderStatus;
        }
        public void setProcessedBy(string processedBy) {
            this.processedBy = processedBy;
        }
        public string getOrderStatus() {
            return this.orderStatus;
        }
        public string getProcessedBy() {
            return this.processedBy;
        }
    }
}
