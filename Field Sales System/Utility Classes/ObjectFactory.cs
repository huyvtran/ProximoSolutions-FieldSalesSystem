using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Field_Sales_System.Business_Logic;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Windows.Documents;

namespace Field_Sales_System.Utility_Classes
{
    class ObjectFactory
    { private List<Order> orderList = new List<Order>();
      private List<Product> productList = new List<Product>();






        //Create new order
        public string neworder(int orderID, DateTime OrderaddedDate, DateTime OrderRequestedDate, int[] quantity, int[] productID, int  placedEmpID)
        {

            OrderProcessDetails gotprocessDetails = getOrderProcessDetails();
            Order neworder = new Order();
            neworder.OrderId = orderID;
            neworder.OrderRequestedDate = OrderRequestedDate;
            neworder.setProcessDetails(gotprocessDetails);

            for (int i = 0; i < quantity.Length; i++)
            {
                int entryID = neworder.getentrysize();
                OrderEntry orderedProductEntry = this.setOrderEntry(entryID, productID[i], quantity[i] );
                neworder.addorderentry(orderedProductEntry);

            }
            return "neworder";

        }
       
       
       
        //Create Orderentry
        public  OrderEntry setOrderEntry(int entryID, int ProductID, int Quantity)
        {
            Product gotProduct = (getProduct(ProductID)[0]);
            OrderEntry newEntry= new OrderEntry();
            newEntry.Quantity = Quantity;
            newEntry.Product = gotProduct;
            return newEntry;
        }




      
        //Create OrderProcessDetails
        private OrderProcessDetails getOrderProcessDetails()
        {
            OrderProcessDetails gotOrderProcessDetails = new OrderProcessDetails() ;
            return gotOrderProcessDetails;
        }






        //get Order
        public List<Order> getOrder(int ordereditID = -1, int placedEmpID = -1)
        {
            List<Order> gotOrders = new List<Order>();
            if (placedEmpID == -1)
            {
                foreach (Order ord in orderList)
                {
                    if ((ord.OrderId).Equals(ordereditID))
                    {
                        gotOrders.Add(ord);
                    }
                }
                if (gotOrders.Count == 0)
                {//connect to the database and get objects
                }

            }
            else {
                foreach (Order ord in orderList)
                {
                    if ((ord.OrderId).Equals(placedEmpID))
                    {
                        gotOrders.Add(ord);
                    }
                }

                //connect to the database and get objects
            }


            return gotOrders;
        }


        // Save Order
        public void saveOrder(Order saveOrder)
        {
            //create connection and pass the object
        }

      

        //Create Product 
        public void newProduct(String productName, int productId, String productDescription, float pricePerUnit, DisplayPicture productPicture,String category, int batchNo )
        {
            Product newProduct = new Product();
            newProduct.ProductID = productId;
            newProduct.ProductName = productName;
            newProduct.PricePerUnit = pricePerUnit;
            newProduct.ProductDescription = productDescription;
            newProduct.ProductDetails = newProductDetails(category, batchNo);
            //Need to build the image
        }



        //create productDetails
        public ProductDetails newProductDetails(String category, int batchNo)
        {
            ProductDetails newProductDetails = new ProductDetails();
            newProductDetails.BatchNO = batchNo;
            newProductDetails.Category = category;
            return  newProductDetails;
        }




        //Get Product Method
        public List<Product> getProduct(int productID=-1)
        {
            List<Product> gotProduct = new List<Product>();
            if (productID == -1)
            {
                foreach (Product prd in productList)
                {

                    gotProduct.Add(prd);
                }
           //conect to the database and getobjects
           
            }

            foreach (Product prd in productList)
            {
                if ((prd.ProductID).Equals(productID))
                {
                    gotProduct.Add(prd);
                }
            }
            if (gotProduct.Count == 0)
            {//connect to the database and get objects
            }


            return gotProduct;
        }




        //Save Product 
        public void saveProduct(Product saveOrder)
        {
            //create connection and pass the object
        }








        public User crerateUser(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img, string userRole, List<Permission> permissions)
        {
            try
            {

                switch(userRole)
                {
                    case "Representative":
                    
                        User rep = new Representative(empId, empNIC, gender, firstName, lastName, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3, img);
                        ContactDetails c = new ContactDetails(mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3);
                        UserRole ur = new UserRole();
                        ur.setRoleName(userRole);
                        for (int i = 0; i < permissions.Count; i++)
                        {
                            ur.addPermission(permissions[i]);
                        }


                        return rep;
                    
                }
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
