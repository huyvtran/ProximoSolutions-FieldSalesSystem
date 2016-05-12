using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    public class SalesReturn
    {
        private int returnID;
        private DateTime returndate;
        private ArrayList returns;
        public void addReturnEntry(ReturnEntry ret) {
            returns.Add(ret);
        }
        public ArrayList getReturnEntry() {
            return returns;
        }
    }
}
