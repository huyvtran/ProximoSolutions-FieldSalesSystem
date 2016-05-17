
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    public class OrderEntry
    {
        private int quantity;
        private Product product;
        //private string entryState = "Active";
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

        
      
      
    }
}


