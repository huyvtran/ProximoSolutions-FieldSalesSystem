using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class OrderEntry
    {
        private int quantity;
        private Product product;
        //private Prdu
        public void setQuantity(int quantity) {
            this.quantity = quantity;
        }
        public int getQuantity() {
            return this.quantity;
        }

    }
}
