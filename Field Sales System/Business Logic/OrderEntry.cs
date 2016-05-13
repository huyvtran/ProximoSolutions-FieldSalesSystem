
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    public class OrderEntry
    {
        private int quantity;
        private List<Product> product;

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

        public void addProduct(Product p) {
            product.Add(p);
        }
        public List<Product> getProductList() {
            return this.product;
        }
    
    }
}


