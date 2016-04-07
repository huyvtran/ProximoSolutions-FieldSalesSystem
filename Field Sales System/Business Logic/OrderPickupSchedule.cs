using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class OrderPickupSchedule
    {
        private DateTime pickUpDateAndTime;
        private String pickedUpBy;

        public void setPickUpDateAndTime(DateTime pickUpDateAndTime)
        {
            this.pickUpDateAndTime = pickUpDateAndTime;
        }

        public DateTime getPickUpDateAndTime()
        {
            return pickUpDateAndTime;
        }

        public void setPickedUpBy(String pickedUpBy)
        {
            this.pickedUpBy = pickedUpBy;
        }

        public String getPickedUpBy()
        {
            return pickedUpBy;
        }
    }
}
