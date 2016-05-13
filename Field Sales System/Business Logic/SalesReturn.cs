using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    public class SalesReturn
    {
        private int returnerId;
        private DateTime returnDate;
        private List<ReturnEntry> returns = new List<ReturnEntry>();

        public int ReturnID
        {
            get
            {
                return returnerId;
            }

            set
            {
                returnerId = value;
            }
        }

        public DateTime ReturnDate
        {
            get
            {
                return returnDate;
            }

            set
            {
                returnDate = value;
            }
        }

        public void addReturnEntry(ReturnEntry ret) {
            returns.Add(ret);
        }
        public List<ReturnEntry> getReturnEntryList() {
            return returns;
        }
    }
}
