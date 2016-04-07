using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class Product
    {
        private String productName;
        private int productID;
        private String productDescription;

        public void setProductName(String productName)
        {
            this.productName = productName;
        }

        public String getProductName()
        {
            return productName;
        }

        public void setProductID(int productID)
        {
            this.productID = productID;
        }
        public int getProductID()
        {
            return productID;
        }

        public void setProductDescription(String productDescription)
        {
            this.productDescription = productDescription;
        }
        public String getProductDescription()
        {
            return productDescription;
        }
    }
}
