using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    public class ReturnEntry
    {
        private int quantity;
        private int itemOrderID;

        private Product product;

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

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

        internal Product Product
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
    }
}
