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
    class CompanyAdmin : User, UserManagement
    {
        //ObjectFactory Object;
        public CompanyAdmin(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1,string addressLine_2,string addressLine_3, Image img):base(empId,empNIC,gender,firstName,lastName,mobileNo,landNo,email,addressLine_1,addressLine_2,addressLine_3,img)
        {
        }
        public void addRepresentative(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string address) {
            string url="have to build"; // Create url 
            //Representative newrep = new Representative(empId, empNIC, gender, firstName, lastName, mobileNo, landNo, email, address, url);
        }
        public void addAgent(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string address)
        {
            string url = "have to build"; // Create url
                                          //Agent newagent = new Agent(empId, empNIC, gender, firstName, lastName, mobileNo, landNo, email, address, url);
        }
        
        public void updateProduct(String productName, int productId, String productDescription, float pricePerUnit, DisplayPicture productPicture, String category, int batchNo) {
            /*Product gotproduct = Object.getProduct(productId)[0];
            gotproduct.PricePerUnit = pricePerUnit;
            gotproduct.ProductDescription = productDescription;
            gotproduct.ProductName = productName;
            gotproduct.ProductDetails.BatchNO = batchNo;
            gotproduct.ProductDetails.Category = category;
            Object.saveProduct(productId, productName, gotproduct);*/
        }

        public void updateUser(int userid) {
            //get object from database
           


        }
        public void deactivateUser(User user) { }
        public void activateUser(User user) { }
        public void changePassword(User user) { }
        public void reviewUpdate() { }
        public void acceptUpdate() { }



        public string addUser(ObjectFactory factory, int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img, string userType,List<UserRole> rolesList)
        {
            return factory.storeUser(empId, empNIC, gender, firstName, lastName, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3, img, userType, rolesList);
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

        public override List<Order> viewOrder(ObjectFactory factory, DateTime beginDate, DateTime endDate, int ordererId)
        {
            throw new NotImplementedException();
        }

        public override string cancelOrder(ObjectFactory factory, Order order)
        {
            throw new NotImplementedException();
        }
    }
}
