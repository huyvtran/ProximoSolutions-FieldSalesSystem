using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    public class ReturnEntry
    {
        private int itemOrderID;
        private Product product;
        private string notes;
        

        public int ItemOrderID
        {
            get
            {
                return itemOrderID;
            }

            set
            {
                itemOrderID = value;
            }
        }

        public Product Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
            }
        }

        public string Notes
        {
            get
            {
                return notes;
            }

            set
            {
                notes = value;
            }
        }
    }
}
