
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class OrderEntry
    {
        private int ID;
        private int quantity;
        private Product product;
        
        public void setQuantity(int quantity) {
            this.quantity = quantity;
        }
        public int getQuantity() {
            return this.quantity;
        }
        public void setProduct(Product p) {
            this.product = p;
        }
        public Product getProduct() {
            return this.product;
        }
        public void setID(int entryID)
        {
            this.ID = entryID;
        }
    }
}


