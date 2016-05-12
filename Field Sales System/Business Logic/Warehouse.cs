using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    public class Warehouse
    {
        private string warehouseName;
        private string warehouseAddress;
        private string memberName;
        private ArrayList storageItems = new ArrayList();
        private WarehouseManager warehouseManager;

        public void setWarehouseName(string warehouseName)
        {
            this.warehouseName = warehouseName;
        }

        public void setWarehouseAddress(string warehouseAddress)
        {
            this.warehouseAddress = warehouseAddress;
        }

        public void setMemberName(string memberName)
        {
            this.memberName = memberName;
        }


        public string getWarehouseName()
        {
            return this.warehouseName;
        }

        public string getWarehouseAddress()
        {
            return this.warehouseAddress;
        }

        public string getMemberName()
        {
            return this.memberName;
        }

        public void addStorageItem(ArrayList products) {          
            storageItems.Add(products);
        }

        public ArrayList getStorageItems() {
            return storageItems;
        }
        public void addManager(WarehouseManager manager) {
            this.warehouseManager = manager;
        }

        public WarehouseManager getManager() {
            return warehouseManager;
        }


    }
}
