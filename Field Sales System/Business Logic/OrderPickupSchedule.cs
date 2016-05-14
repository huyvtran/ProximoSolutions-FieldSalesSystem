using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    public class OrderPickupSchedule
    {
        
        private DateTime pickUpDateAndTime;
        private String pickUpAgency;
        private int pickUpId;
        private String pickUpStatus="Not yet";

        public DateTime PickUpDateAndTime
        {
            get
            {
                return pickUpDateAndTime;
            }

            set
            {
                pickUpDateAndTime = value;
            }
        }

        public int PickUpId
        {
            get
            {
                return pickUpId;
            }

            set
            {
                pickUpId = value;
            }
        }

 
        public string PickUpStatus
        {
            get
            {
                return pickUpStatus;
            }

            set
            {
                pickUpStatus = value;
            }
        }

        public String  PickUpAgency
        {
            get
            {
                return pickUpAgency;
            }
            set
            {
                pickUpAgency = value;
            }
        }
    }
}
