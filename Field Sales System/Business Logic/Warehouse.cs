using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class Warehouse
    {
        private String warehouseName;
        private String warehouseAddress;
        private String memberName;

        public void setwarehouseName(String warehouseName)
        {
            this.warehouseName = warehouseName;
        }

        public void setwarehouseAddress(String warehouseAddress)
        {
            this.warehouseAddress = warehouseAddress;
        }

        public void setmemberName(String memberName)
        {
            this.memberName = memberName;
        }


        public String getwarehouseName()
        {
            return this.warehouseName;
        }

        public String getwarehouseAddress()
        {
            return this.warehouseAddress;
        }

        public String getmemberName()
        {
            return this.memberName;
        }


    }
}
