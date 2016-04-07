using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class WarehouseManager
    {
        private int warehouseKeyNo;

        public void setKey(int key) {
            this.warehouseKeyNo = key;
        }
        public int getKey() {
            return this.warehouseKeyNo;
        }
        public void updateWarehouseDetails(Warehouse warehouse) {
            //update
        }

    }
}
