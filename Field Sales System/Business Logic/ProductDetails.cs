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
        private String MFD;
        private String EXP;

        public void setCategory(String category)
        {
            this.category = category;
        }
        public String getCategory()
        {
            return category;
        }

        public void setBatchNO(int batchNO)
        {
            this.batchNO = batchNO;
        }
        public int getBatchNO()
        {
            return batchNO;
        }

        public void setMFD(String MFD)
        {
            this.MFD = MFD;
        }
        public String getMFD()
        {
            return MFD;
        }

        public void setEXP(String EXP)
        {
            this.EXP = EXP;
        }
        public String getEXP()
        {
            return EXP;
        }
    }
}
