using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class SalesReturn
    {
        private int returnID;
        private DateTime returndate;
        private ArrayList<ReturnEntry> returns;
        public void setReturnEntry(ReturnEntry returnEntry) {
            this.returnEntry = returnEntry;
        }
        public ReturnEntry getReturnEntry() {
            return returnEntry;
        }
    }
}
