using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    public class ProductDetails
    {
        private String category;
        private int batchNO;
        private DateTime productMFD;
        private DateTime productEXP;

      

    

        public String  Category
        {   get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        public int BatchNO
        {
          get
            {
                return batchNO;

            }
            set
            {
                batchNO = value;
            }
        }

        public DateTime ProductMFD
        {
            get
            {
                return productMFD;
            }

            set
            {
                productMFD = value;
            }
        }

        public DateTime ProductEXP
        {
            get
            {
                return productEXP;
            }

            set
            {
                productEXP = value;
            }
        }
    }
}
