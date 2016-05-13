using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    class DailySalesDetails
    {
        private List<SalesEntry> salesEntries = new List<SalesEntry>();
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
        public void addEntry(SalesEntry entry) {
            salesEntries.Add(entry);
        }
        public ArrayList getSalesEntries() {
            return salesEntries;
        }
    }
}
