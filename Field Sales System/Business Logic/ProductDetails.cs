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
        private DateTime MDF;
        private DateTime EXP;

      

    

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

      
    }
}
