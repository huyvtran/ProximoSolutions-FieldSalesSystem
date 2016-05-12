using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    public class WarehouseManager:User
    {
        
        private int warehouseKeyNo;
        public WarehouseManager(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img)
            :base(empId,empNIC,gender,firstName,lastName,mobileNo,landNo,email,addressLine_1,addressLine_2,addressLine_3,img)
        {

        }

        public void setKey(int key) {
            this.warehouseKeyNo = key;
        }
        public int getKey() {
            return this.warehouseKeyNo;
        }
        public void addItems(Warehouse warehouse,ArrayList products) {
            while (products.Count > 0) {
                Product p = (Product)products[0];
                ArrayList storage = warehouse.getStorageItems();
                for (int i = 0; i < storage.Count; i++) {
                    ArrayList category = (ArrayList)storage[i];
                    Product tmp = (Product)category[0];
                    if (tmp.getProductName() == p.getProductName()) {
                        category.Add(p);
                        products.Remove(p);
                        break;
                    }
                }
                ArrayList newList = new ArrayList();
                newList.Add(p);
                products.Remove(p);
                storage.Add(newList);
                addItems(warehouse, products);
            }
        }
        public ArrayList dispatchItems(Warehouse warehouse, int quantity,int productId = 0,string productName = "") {
            ArrayList tempList = new ArrayList();
            ArrayList inventory = warehouse.getStorageItems();
            ArrayList returnList = new ArrayList();
            for (int i = 0; i < inventory.Count; i++)
            {
                ArrayList tmp = (ArrayList)inventory[i];
                Product p = (Product)tmp[0];
                if (p.getProductID().Equals(productId) || p.getProductName().Equals(productName)) {
                    tempList = tmp;
                    break;
                }
            }
            if (tempList.Count >= quantity) {
                for (int i = 0; i < quantity; i++) {
                    returnList.Add(tempList[0]);
                    tempList.Remove(tempList[0]);
                }
            }
            return returnList;
        }

    }
}
