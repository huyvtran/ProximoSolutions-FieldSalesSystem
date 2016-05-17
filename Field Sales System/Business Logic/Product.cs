
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    public class Product
    {

        private String productName;
        private int productID;
        private String productDescription;
        private ProductDetails productDetails;
        private float pricePerUnit;
        [NonSerialized]DisplayPicture productPicture;

        public String ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }

        public int ProductID
        {
           get
            {
                return productID;
            }

            set
            {
                productID = value;
            }
        }
        public float PricePerUnit
        {
            get
            {
                return pricePerUnit;
            }
            set
            {
                pricePerUnit = value;
            }
        }
        public String ProductDescription
        {
            get
            {
                return productDescription;

            }
            set
            {
                productDescription = value;
            }
        }

        public ProductDetails ProductDetails
        {
            get
            {
                return productDetails;
            }
            set
            {
                productDetails = value;
            }
        }

        public DisplayPicture ProductPicture
        {
            get
            {
                return productPicture;
            }

            set
            {
                productPicture = value;
            }
        }
    }
}
