using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Field_Sales_System.Utility_Classes;

namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    public class WarehouseManager:User
    {
        
        private int warehouseKeyNo;
        public WarehouseManager(int empId, int empNIC, DateTime dOB, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img)
            :base(empId,empNIC,dOB,gender,firstName,lastName,mobileNo,landNo,email,addressLine_1,addressLine_2,addressLine_3,img)
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
                    if (tmp.ProductName == p.ProductName) {
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
                if (p.ProductID.Equals(productId) || p.ProductID.Equals(productName)) {
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

        

        public override string deactivateUser(SecurityManager securityManager, User user)
        {
            throw new NotImplementedException();
        }

        public override string activateUser(SecurityManager securityManager, User user)
        {
            throw new NotImplementedException();
        }

        public override string addRole(ObjectFactory factory, User user, UserRole newRole)
        {
            throw new NotImplementedException();
        }

        public override string removeRole(ObjectFactory factory, User user, string roleName)
        {
            throw new NotImplementedException();
        }

        public override string addOrder(ObjectFactory factory, Order order)
        {
            throw new NotImplementedException();
        }

        public override string addUser(ObjectFactory factory, SecurityManager securityManager, int empId, int empNIC, DateTime dOB, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img, string userType, List<UserRole> rolesList, string password)
        {
            throw new NotImplementedException();
        }
    }
}
