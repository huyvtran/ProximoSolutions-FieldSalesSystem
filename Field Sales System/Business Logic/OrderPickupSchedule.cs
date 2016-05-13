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
        private int pickUpId;
        private int pickUpNIC;
        private String pickUpStatus;

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

        public int PickUpNIC
        {
            get
            {
                return pickUpNIC;
            }

            set
            {
                pickUpNIC = value;
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
    }
}
