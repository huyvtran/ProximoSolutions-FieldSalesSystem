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
using MySql.Data.MySqlClient;

namespace Field_Sales_System.Utility_Classes
{ 
    class ObjectFactory:IConnectionManager

    {
       
        //Cache list 
      private List<Order> orderList = new List<Order>();
      private List<Product> productList = new List<Product>();
      private List<Agent> agentList = new List<Agent>();
      private List<Representative> representativeList = new List<Representative>();




/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Object Create methods

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

            saveOrder(neworder,orderID);
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



        //Create Product 
        public void newProduct(String productName, int productId, String productDescription, float pricePerUnit, DisplayPicture productPicture, String category, int batchNo)
        {
            Product newProduct = new Product();
            newProduct.ProductID = productId;
            newProduct.ProductName = productName;
            newProduct.PricePerUnit = pricePerUnit;
            newProduct.ProductDescription = productDescription;
            newProduct.ProductDetails = newProductDetails(category, batchNo);
            //Need to build the image
            saveProduct(productId, productName, newProduct);
        }


        //create productDetails
        public ProductDetails newProductDetails(String category, int batchNo)
        {
            ProductDetails newProductDetails = new ProductDetails();
            newProductDetails.BatchNO = batchNo;
            newProductDetails.Category = category;
            return newProductDetails;
        }

        //Create UserRole
        public UserRole createUserRole(string userRole)
        {
            UserRole user = new UserRole();
            user.setRoleName(userRole);
            return user;
        }


        //create ContactDetails
        public ContactDetails setContactDetails(int empId, int mobileNo, int landNo, String email, String addressLine_1, String addressLine_2, String addressLine_3)
        {
            ContactDetails contactUser = new ContactDetails(mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3);
            saveContactDetails(contactUser, empId);

            return contactUser;

        }

        //create User
        public User crerateUser(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img, string userRole)
        {
            try
            {

                switch (userRole)
                {
                    case "Representative":

                        User rep = new Representative(empId, empNIC, gender, firstName, lastName, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3, img);
                        ContactDetails contactRep = setContactDetails(empId, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3);
                        UserRole urRep = createUserRole(userRole);
                        List<Permission> permissionsRep = getPermissionList(userRole);

                        for (int i = 0; i < permissionsRep.Count; i++)
                        {
                            urRep.addPermission(permissionsRep[i]);
                        }


                        return rep;
                    case "Agent":

                        User agent = new Representative(empId, empNIC, gender, firstName, lastName, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3, img);
                        ContactDetails contactAgent = setContactDetails(empId, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3);
                        UserRole urAgent = createUserRole(userRole);
                        List<Permission> permissionsAgent = getPermissionList(userRole);
                        for (int i = 0; i < permissionsAgent.Count; i++)
                        {
                            urAgent.addPermission(permissionsAgent[i]);
                        }


                        return agent;

                }
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }





////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





//Object get Methods

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








        //Get Product 
        public List<Product> getProduct(int productId = -1, string productName = "")
        {
            List<Product> gotProduct = new List<Product>();
            if ((productId == -1))
            {
                if (productName.Equals(""))
                {
                    foreach (Product prd in productList)
                    {

                        gotProduct.Add(prd);
                    }
                    if (isOnline())
                    {
                        List<Product> gotProductDbList = new List<Product>();
                        gotProductDbList = (retrieveProduct((openConnection(connectDatabase(conString))), productId, productName));
                        foreach (Product prd in gotProductDbList)
                        {
                            if (gotProduct.Contains(prd)) { }
                            else
                            {
                                gotProduct.Add(prd);
                                productList.Add(prd);
                            }


                        }
                        return gotProduct;

                    }
                    else
                    {
                        //Throw exception internet lost
                    }
                }
                else
                {
                    foreach (Product prd in productList)
                    {
                        if ((prd.ProductName).Equals(productName))
                        {
                            gotProduct.Add(prd);
                        }
                    }
                    if (gotProduct.Count == 0)
                    {
                        if (isOnline())
                        {
                            gotProduct.Add((retrieveProduct((openConnection(connectDatabase(conString))), productId, productName))[0]);

                            productList.Add(gotProduct[gotProduct.Count - 1]);
                            return gotProduct;


                        }
                        else
                        {
                            //Throw exception internet lost

                        }
                    }

                    return gotProduct;

                }
            }
            else
            { 
                foreach (Product prd in productList)
                {
                    if ((prd.ProductID).Equals(productId))
                    {
                        gotProduct.Add(prd);
                    }
                }
                if (gotProduct.Count == 0)
                {

                    if (isOnline())
                    {
                        gotProduct.Add((retrieveProduct((openConnection(connectDatabase(conString))), productId, productName))[0]);

                        productList.Add(gotProduct[gotProduct.Count - 1]);
                        return gotProduct;


                    }
                    else
                    {
                        //Throw exception internet lost

                    }

                   
                }

                return gotProduct;

            }

            return null;
        }







        //Get permission
        public List<Permission> getPermissionList(string userRole)
        {
            List<Permission> PermissionList = new List<Permission>();
            try
            {

                switch (userRole)
                {
                    case "Representative":
                        //PermissionList;
                        // get user role list
                        return PermissionList;
                    case "Agent":
                        //PermissionList;
                        // get user role list
                        return PermissionList;

                }
            }
            catch (Exception e)
            {
                return null;
            }
            return null;

        }


        //get Agent 

        public Agent getAgent(int empId)
        {
            try
            {
                //use the connection and get the agent 
            }
            catch (Exception e)
            {
                return null;
            }
          return null; 
        }



        //get Representative 
        public Representative getRep(int empId)
        {
            try
            {
                //use the connection and get the agent 
            }
            catch (Exception e)
            {
                return null;
            }
            return null;
        }




//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//Object save methods


        //Save Product 
        public String  saveProduct(int productId, String productName, Product saveProduct)
        {
            if (isOnline())
            {
                if (storeProduct(openConnection(connectDatabase(conString)), productId, productName, saveProduct))
                {
                    return "Success";
                }
                else
                {   
                    //catch exception
                }

            }
            else
            {
                //Throw exception internet lost
            }
            return null;
        }


       

        //Save ContactDetails 
        public void saveContactDetails(ContactDetails saveDetails, int empId)
        {
            //create connection and pass the object
        }


        // Save Order
        public String saveOrder(Order saveOrder,int orderId)
        {
            if (isOnline())
            {
                if (storeOrder((openConnection(connectDatabase(conString)), productId, productName, saveOrder))
                {
                    return "Success";
                }
                else
                {
                    //catch exception
                }

            }
            else
            {
                //Throw exception internet lost
            }
            return null;

        }



        //Save Agent 
        public void saveAgent(Agent saveAgent)
        {
            //create connection and pass the object
        }


        //Save Rep
        public void saveRep(Representative saveRep)
        {
            //create connection and pass the object
        }




 ////////////////////////////////////////////////////////////////////////////////////////////////////////


 ConnectionManager c = new ConnectionManager();
 string conString = "Database = proximoDB; Data Source = us - cdbr - azure - central - a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f";






        public bool isOnline()
        {
            return c.isOnline();
            
        }

        public MySqlConnection connectDatabase(string conString)
        {
            return c.connectDatabase(conString);

        }

        public MySqlConnection openConnection(MySqlConnection connection)
        {
            return c.openConnection(connection);
        }

        public void closeConnection(MySqlConnection connection)
        {
            throw new NotImplementedException();
        }

        public bool storeImage(MySqlConnection connection, int empId, Image image)
        {
            throw new NotImplementedException();
        }

        public Image retrieveImage(MySqlConnection connection, int empId)
        {
            throw new NotImplementedException();
        }

        public bool modifyImage(MySqlConnection connection, Image image, int empId)
        {
            throw new NotImplementedException();
        }

        public bool storeLoginInfo(MySqlConnection connection, int empId, string pwdHash)
        {
            throw new NotImplementedException();
        }

        public bool modifyLoginInfo(MySqlConnection connection, int empId, string pwdHash = "", int isActive = -1, int pwdReset = -1)
        {
            throw new NotImplementedException();
        }

        public List<object> retrieveLoginInfo(MySqlConnection connection, int empId)
        {
            throw new NotImplementedException();
        }

        public bool storeUser(MySqlConnection connection, User user)
        {
            throw new NotImplementedException();
        }

        public bool modifyUser(MySqlConnection connection, User user)
        {
            throw new NotImplementedException();
        }

        public List<User> retrieveUser(MySqlConnection connection, int empId = 0, string empFName = "", string empLName = "")
        {
            throw new NotImplementedException();
        }

        public bool storeContactDetails(MySqlConnection connection, int empId, ContactDetails contacts)
        {
            throw new NotImplementedException();
        }

        public List<ContactDetails> retrieveContactDetails(MySqlConnection connection, int empId)
        {
            throw new NotImplementedException();
        }

        public bool storeProduct(MySqlConnection connection, int productId, string productName, Product product)
        {
           return c.storeProduct(connection, productId, productName, product);
        }

        public bool modifyProduct(MySqlConnection connection, Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> retrieveProduct(MySqlConnection connection, int productId = -1, string productName = "")
        {
            throw new NotImplementedException();
        }

        public bool storeEntry(MySqlConnection connection, object entry)
        {
            throw new NotImplementedException();
        }

        public List<object> retrieveEntry(MySqlConnection connection, DateTime beginDate, DateTime endDate, string entryType, int viewerId = 0)
        {
            throw new NotImplementedException();
        }

        public bool storeOrder(MySqlConnection connection, string status, Order order)
        {
            throw new NotImplementedException();
        }

        public bool setOrderStatus(MySqlConnection connection, string status, DateTime orderDate)
        {
            throw new NotImplementedException();
        }

        public List<Order> retrievOrdersByStatus(MySqlConnection connection, string status, int ordererId = 0)
        {
            throw new NotImplementedException();
        }

        public bool storeReport(MySqlConnection connection, object report)
        {
            throw new NotImplementedException();
        }

        public List<object> retrieveReport(MySqlConnection connection, DateTime beginDate, DateTime endDate, string reportType)
        {
            throw new NotImplementedException();
        }
    }
}
