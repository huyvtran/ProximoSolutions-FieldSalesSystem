
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

       public  OrderEntry(int IID, int Quantity, Product Product)
        {
            ID = IID;
            quantity = Quantity;
            product = Product;


        }
        
        public void UpdateQuantity(int quantity) {
            this.quantity = quantity;
        }
        public int getQuantity() {
            return this.quantity;
        }
        public void UpdateProduct(Product p) {
            this.product = p;
        }
        public Product getProduct() {
            return this.product;
        }
    
    }
}


