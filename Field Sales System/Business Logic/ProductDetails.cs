using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class ProductDetails
    {
        private String category;
        private int batchNO;
        private DateTime MFD;
        private DateTime EXP;

        public ProductDetails(String Category, int BatchNO, DateTime mfd, DateTime exp)
            {
            category = Category;
            batchNO = BatchNO;
            MFD = mfd;
            EXP = exp;
    }

        public void updateCategory(String category)
        {   //get the object 
            this.category = category;
            // save the object
        }
        public String getCategory()
        {
            return category;
        }

        public void updateBatchNO(int batchNO)
        {
            this.batchNO = batchNO;
        }
        public int getBatchNO()
        {
            return batchNO;
        }

        public void updateMFD(DateTime mfd)
        {
            this.MFD =mfd;
        }
        public DateTime getMFD()
        {
            return MFD;
        }

        public void setEXP(DateTime exp)
        {
            this.EXP = exp;
        }
        public DateTime getEXP()
        {
            return EXP;
        }
    }
}
