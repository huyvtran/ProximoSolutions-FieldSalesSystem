using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class DailySalesDetails
    {
        private SalesEntry SalesEntry;
        private DateTime date;
        private int submitterID;

        public void setDate(DateTime date)
        {
            this.date = date;
        }

        public DateTime getDate()
        {
            return date;
        }

        public void setSubmitterID(int submitterID)
        {
            this.submitterID = submitterID;
        }

        public int getSubmitterID()
        {
            return submitterID;
        }
    }
}
