using System;
using System.Collections;
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
        public void addItems(Warehouse warehouse,Product product,int quantity) {
            warehouse.addStorageItem(product, quantity);
        }
        public void removeItems(Warehouse warehouse, Product product, int quantity) {
            ArrayList inventory = warehouse.getStorageItems();
            ArrayList tempList = new ArrayList();
            int itemsCount = 0;
            for (int i = 0; i < inventory.Count; i++)
            {
                ArrayList products = (ArrayList)inventory[i];
                Product currentProduct = (Product)products[0];
                int currentCount = (int)products[1];
                if (currentProduct.getProductID() == product.getProductID()) {
                    tempList.Add(currentProduct);
                    itemsCount+=
                }
                
            }
        }

    }
}
