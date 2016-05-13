using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    public class DailySalesDetails
    {
        private List<SalesEntry> salesEntries = new List<SalesEntry>();
        private DateTime date;
        private int submitterID;

        public int SubmitterID
        {
            get
            {
                return submitterID;
            }

            set
            {
                submitterID = value;
            }
        }

        public void setDate(DateTime date)
        {
            this.date = date;
        }

        public DateTime getDate()
        {
            return date;
        }

        
        public void addEntry(SalesEntry entry) {
            salesEntries.Add(entry);
        }
        public List<SalesEntry> getSalesEntries() {
            return salesEntries;
        }
    }
}
