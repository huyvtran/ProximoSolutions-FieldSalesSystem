
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
        private ProductDetails productDetails;
        private float pricePerUnit;
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

        public void setProductDescription()
        {
            
        }
        public String getProductDescription()
        {
            return productDescription;
        }
        public void setProductDetails(String Category, int BatchNO, DateTime MFD, DateTime EXP)
        {//Pass to factory to creat the object
         
        }
        public ProductDetails getProductDetails() {
            return this.productDetails;
        }
        public void setPricePerUnit(float p)
        {
            this.pricePerUnit = p;
        }
        public float getPricePerUnit()
        {
            return pricePerUnit;
        }

    }
}
