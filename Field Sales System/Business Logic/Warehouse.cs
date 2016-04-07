using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class Warehouse
    {
        private string warehouseName;
        private string warehouseAddress;
        private string memberName;

        public void setwarehouseName(string warehouseName)
        {
            this.warehouseName = warehouseName;
        }

        public void setwarehouseAddress(string warehouseAddress)
        {
            this.warehouseAddress = warehouseAddress;
        }

        public void setmemberName(string memberName)
        {
            this.memberName = memberName;
        }


        public string getwarehouseName()
        {
            return this.warehouseName;
        }

        public string getwarehouseAddress()
        {
            return this.warehouseAddress;
        }

        public string getmemberName()
        {
            return this.memberName;
        }


    }
}
