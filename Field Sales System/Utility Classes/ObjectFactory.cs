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
    public class ObjectFactory : IObjectFactory

    {     
        private List<Product> productList = new List<Product>();
        private List<User> userList = new List<User>();
        private ConnectionManager dbManager = new ConnectionManager();
        private MySqlConnection connection = new MySqlConnection();

        public ObjectFactory()
        {
            connection = dbManager.connectDatabase(Properties.Settings.Default.dbServerConnectionString);
        }



        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Object Create methods

        //Create new order

        public string storeNewOrder(int orderId, DateTime OrderRequestedDate, List<OrderEntry> orderEntries,int ordererId)
        {
           
            OrderProcessDetails gotprocessDetails = getOrderProcessDetails();
            Order newOrder = new Order();
            newOrder.OrderId = orderId;
            newOrder.OrdererId = ordererId;
            newOrder.OrderRequestedDate = OrderRequestedDate;
            newOrder.Orders = orderEntries;
            newOrder.setProcessDetails(gotprocessDetails);


            bool isOnline = false;
            isOnline = dbManager.isOnline();
            if (isOnline)
            {
                connection = dbManager.openConnection(connection);
                if (connection != null)
                {
                    bool b = dbManager.storeOrder(connection, "New Order", newOrder);
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        dbManager.closeConnection(connection);
                    }

                    if (b)
                    {

                        //orderList.Add(newOrder);
                        return "Successfully stored the order!";
                    }
                    else {
                        return "There was an error during the storage process. Please try again.";
                    }

                }
                else {
                    return "Error! Cannot establish a connection with database. Try again later.";
                }

            }
            else {
                return "Error! No internet connection! Fix the internet connection and try again.";
            }


        }



        //Create Orderentry
        public OrderEntry setOrderEntry(Product product, int Quantity)
        {
            OrderEntry newEntry = new OrderEntry();
            newEntry.Quantity = Quantity;
            newEntry.Product = product;
            return newEntry;
        }


        //Create OrderProcessDetails
        //Cant understand the meaning of this method just to instantiate a ProcessDetails object
        private OrderProcessDetails getOrderProcessDetails()
        {
            OrderProcessDetails gotOrderProcessDetails = new OrderProcessDetails();
            return gotOrderProcessDetails;
        }



        //Create Product 
        public string storeNewProduct(String productName, int productId, String productDescription, float pricePerUnit, DisplayPicture productPicture, String category, int batchNo)
        {
            Product newProduct = new Product();
            newProduct.ProductID = productId;
            newProduct.ProductName = productName;
            newProduct.PricePerUnit = pricePerUnit;
            newProduct.ProductDescription = productDescription;
            newProduct.ProductDetails = newProductDetails(category, batchNo);
            newProduct.ProductPicture = productPicture;
            bool isOnline = false;
            isOnline = dbManager.isOnline();
            if (isOnline)
            {
                connection = dbManager.openConnection(connection);
                if (connection != null)
                {
                    bool b = dbManager.storeProduct(connection, productId, productName, newProduct);
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        dbManager.closeConnection(connection);
                    }

                    if (b)
                    {

                        return "Successfully stored the product!";
                    }
                    else {
                        return "There was an error during the storage process. Please try again.";
                    }

                }
                else {
                    return "Error! Cannot establish a connection with database. Try again later.";
                }

            }
            else {
                return "Error! No internet connection! Fix the internet connection and try again.";
            }

        }


        //create productDetails
        public ProductDetails newProductDetails(String category, int batchNo)
        {
            ProductDetails newProductDetails = new ProductDetails();
            newProductDetails.BatchNO = batchNo;
            newProductDetails.Category = category;
            return newProductDetails;
        }

        public Product updateProcuctDetails(Product product, int batchNo, DateTime MFD, DateTime EXP, string category)
        {
            product.ProductDetails.BatchNO = batchNo;
            product.ProductDetails.Category = category;
            product.ProductDetails.ProductEXP = EXP;
            product.ProductDetails.ProductMFD = MFD;
            return product;
        }

        //Create UserRole
        public UserRole createUserRole(string userRole, List<Permission> permissions)
        {
            UserRole user = new UserRole();
            user.Permissions = permissions;
            user.setRoleName(userRole);
            return user;
        }
        //Create a permission
        public Permission createPermission(string permName, int permId)
        {
            Permission p = new Permission();
            p.PermName = permName;
            p.PermId = permId;
            return p;
        }


        //create ContactDetails
        public ContactDetails createContactDetails(int empId, int mobileNo, int landNo, String email, String addressLine_1, String addressLine_2, String addressLine_3)
        {
            ContactDetails contactUser = new ContactDetails(mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3);
            return contactUser;

        }

        public string storeContactDetails(ContactDetails contact)
        {
            bool isOnline = false;
            isOnline = dbManager.isOnline();
            if (isOnline)
            {
                connection = dbManager.openConnection(connection);
                if (connection != null)
                {
                    bool b = dbManager.storeContactDetails(connection, contact.EmpId, contact);
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        dbManager.closeConnection(connection);
                    }

                    if (b)
                    {

                        return "Successfully stored the contact details!";
                    }
                    else {
                        return "There was an error during the storage process. Please try again.";
                    }

                }
                else {
                    return "Error! Cannot establish a connection with database. Try again later.";
                }

            }
            else {
                return "Error! No internet connection! Fix the internet connection and try again.";
            }
        }
        //create User
        public string storeUser(int empId, int empNIC, DateTime dOB, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img, string userType, List<UserRole> roles)
        {
            try
            {
                User user = null;
                switch (userType)
                {
                    case "Representative":

                        Representative rep = new Representative(empId, empNIC, dOB,gender, firstName, lastName, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3, img);
                        
                        rep.UserRoles = roles;

                        

                        user = rep;
                        break;
                    case "Agent":

                        Agent agent = new Agent(empId, empNIC, dOB, gender, firstName, lastName, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3, img);
                        
                        agent.UserRoles = roles;
                        user = agent;
                        break;

                    case "CompanyAdmin":
                        CompanyAdmin admin = new CompanyAdmin(empId, empNIC, dOB, gender, firstName, lastName, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3, img);
                        
                        admin.UserRoles = roles;
                        user = admin;
                        break;
                    case "WarehouseManager":
                        WarehouseManager wManager = new WarehouseManager(empId, empNIC, dOB, gender, firstName, lastName, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3, img);
                        
                        wManager.UserRoles = roles;
                        user = wManager;
                        break;

                }
                if (user!=null)
                {
                    bool isOnline = false;
                    isOnline = dbManager.isOnline();
                    if (isOnline)
                    {
                        connection = dbManager.openConnection(connection);
                        if (connection != null)
                        {
                            user.IsActive = true;
                            bool user_status = dbManager.storeUser(connection, user);
                            dbManager.closeConnection(connection);
                            dbManager.openConnection(connection);
                            bool contacts_status = dbManager.storeContactDetails(connection, empId, user.ContactDetails);
                            dbManager.closeConnection(connection);
                            dbManager.openConnection(connection);
                            bool dp_status = dbManager.storeImage(connection, user.getEmpId(), user.Dp.getPicture());
                            if (connection.State == System.Data.ConnectionState.Open)
                            {
                                dbManager.closeConnection(connection);
                            }

                            if (user_status && contacts_status && dp_status)
                            {

                                return "Successfully stored the user!";
                            }
                            else {
                                return "There was an error during the storage process. Please try again.";
                            }

                        }
                        else {
                            return "Error! Cannot establish a connection with database. Try again later.";
                        }

                    }
                    else {
                        return "Error! No internet connection! Fix the internet connection and try again.";
                    }
                }
                else {
                    return "Error! There was something wrong with the inputs.";
                }
            }
            catch (Exception e)
            {
                return "Error! There was something wrong with the inputs.";
            }
        }



        public string storeDailySalesDetails(DailySalesDetails dsd)
        {
            bool isOnline = false;
            isOnline = dbManager.isOnline();
            if (isOnline)
            {
                connection = dbManager.openConnection(connection);
                if (connection != null)
                {
                    bool b = dbManager.storeEntry(connection, dsd);
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        dbManager.closeConnection(connection);
                    }

                    if (b)
                    {

                        return "Successfully stored the daily sales details!";
                    }
                    else {
                        return "There was an error during the storage process. Please try again.";
                    }

                }
                else {
                    return "Error! Cannot establish a connection with database. Try again later.";
                }

            }
            else {
                return "Error! No internet connection! Fix the internet connection and try again.";
            }
        }

        public string storeSalesReturns(SalesReturn returns)
        {
            bool isOnline = false;
            isOnline = dbManager.isOnline();
            if (isOnline)
            {
                connection = dbManager.openConnection(connection);
                if (connection!=null)
                {
                    bool b = dbManager.storeEntry(connection, returns);
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        dbManager.closeConnection(connection);
                    }

                    if (b)
                    {

                        return "Successfully stored the sales return entry!";
                    }
                    else {
                        return "There was an error during the storage process. Please try again.";
                    }

                }
                else {
                    return "Error! Cannot establish a connection with database. Try again later.";
                }

            }
            else {
                return "Error! No internet connection! Fix the internet connection and try again.";
            }
        }

        public string storeReport(object report)
        {
            bool isOnline = false;
            isOnline = dbManager.isOnline();
            if (isOnline)
            {
                connection = dbManager.openConnection(connection);
                if (connection != null)
                {
                    bool b = dbManager.storeReport(connection, report);
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        dbManager.closeConnection(connection);
                    }

                    if (b)
                    {

                        return "Successfully stored the report!";
                    }
                    else {
                        return "There was an error during the storage process. Please try again.";
                    }

                }
                else {
                    return "Error! Cannot establish a connection with database. Try again later.";
                }

            }
            else {
                return "Error! No internet connection! Fix the internet connection and try again.";
            }
        }









        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





        //Object get Methods

        //get Order
        public List<Order> getOrder(User validate_user,DateTime beginDate,DateTime endDate)
        {
            bool adminrights = false;
            foreach (UserRole u in validate_user.UserRoles) {
                foreach (Permission p in u.Permissions) {
                    if (p.PermId == 1000) {
                        adminrights = true;
                    }
                }
            }
            if (adminrights)
            {
                bool isOnline = false;
                isOnline = dbManager.isOnline();
                if (isOnline)
                {
                    connection = dbManager.openConnection(connection);
                    if (connection != null)
                    {
                        List <object> orders = dbManager.retrieveEntry(connection,beginDate,endDate,"orderEntry");
                        List<Order> ret_orders = new List<Order>();
                        foreach (object o in orders) {
                            ret_orders.Add((Order)o);
                        }
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            dbManager.closeConnection(connection);
                        }

                        if (orders!=null)
                        {

                            return ret_orders;
                        }
                        else {
                            return null;
                        }

                    }
                    else {
                        return null;
                    }

                }
                else {
                    return null;
                }
            }
            else {
                bool isOnline = false;
                isOnline = dbManager.isOnline();
                if (isOnline)
                {
                    connection = dbManager.openConnection(connection);
                    if (connection != null)
                    {
                        List<object> orders = dbManager.retrieveEntry(connection, beginDate, endDate, "orderEntry",validate_user.getEmpId());
                        List<Order> ret_orders = new List<Order>();
                        foreach (object o in orders)
                        {
                            ret_orders.Add((Order)o);
                        }
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            dbManager.closeConnection(connection);
                        }

                        if (orders!=null)
                        {

                            return ret_orders;
                        }
                        else {
                            return null;
                        }

                    }
                    else {
                        return null;
                    }

                }
                else {
                    return null;
                }
            }
        }

        public List<Order> getOrderByStatus(User validate_user, string status) {
            bool adminrights = false;
            foreach (UserRole u in validate_user.UserRoles)
            {
                foreach (Permission p in u.Permissions)
                {
                    if (p.PermId == 1000)
                    {
                        adminrights = true;
                    }
                }
            }
            if (adminrights)
            {
                bool isOnline = false;
                isOnline = dbManager.isOnline();
                if (isOnline)
                {
                    connection = dbManager.openConnection(connection);
                    if (connection != null)
                    {
                        List<Order> orders = dbManager.retrieveOrdersByStatus(connection,status);
                        
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            dbManager.closeConnection(connection);
                        }

                        if (orders!=null)
                        {

                            return orders;
                        }
                        else {
                            return null;
                        }

                    }
                    else {
                        return null;
                    }

                }
                else {
                    return null;
                }
            }
            else {
                bool isOnline = false;
                isOnline = dbManager.isOnline();
                if (isOnline)
                {
                    connection = dbManager.openConnection(connection);
                    if (connection != null)
                    {
                        List<Order> orders = dbManager.retrieveOrdersByStatus(connection, status,validate_user.getEmpId());
             
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            dbManager.closeConnection(connection);
                        }

                        if (orders!=null)
                        {

                            return orders;
                        }
                        else {
                            return null;
                        }

                    }
                    else {
                        return null;
                    }

                }
                else {
                    return null;
                }
            }
        }







        //Get Product 
        //Assumed that there are no two products with same product Id and product name
        public Product getProduct(int productId = -1, string productName = "")
        {
            Product returnProduct = null;
            foreach (Product p in productList) {
                if (p.ProductID == productId || p.ProductName == productName) {
                    returnProduct = p;
                    break;
                }
            }
            if (returnProduct!=null)
            {
                return returnProduct;
            }
            //if not found in the list
            else {
                bool isOnline = false;
                isOnline = dbManager.isOnline();
                if (isOnline)
                {
                    connection = dbManager.openConnection(connection);
                    if (connection != null)
                    {
                        returnProduct = dbManager.retrieveProduct(connection, productId, productName);
                        
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            dbManager.closeConnection(connection);
                        }

                        return returnProduct;  

                    }
                    else {
                        return null;
                    }

                }
                else {
                    return null;
                }
            }
        }


        

        public User getUser(int empId) {
            User returnUser = null;
            foreach (User u in userList) {
                if (u.getEmpId() == empId) {
                    returnUser = u;
                    break;
                }
            }
            if (returnUser!=null)
            {
                return returnUser;
            }
            else {
                bool isOnline = false;
                isOnline = dbManager.isOnline();
                if (isOnline)
                {
                    connection = dbManager.openConnection(connection);
                    if (connection!=null)
                    {
                        returnUser = dbManager.retrieveUser(connection, empId)[0];
                        dbManager.closeConnection(connection);
                        dbManager.openConnection(connection);
                        Image i = dbManager.retrieveImage(connection, returnUser.getEmpId());
                        dbManager.closeConnection(connection);
                        dbManager.openConnection(connection);
                        returnUser.Dp = new DisplayPicture(i);
                        List<ContactDetails> contacts = dbManager.retrieveContactDetails(connection, returnUser.getEmpId());
                        returnUser.ContactDetails = contacts[contacts.Count - 1];

                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            dbManager.closeConnection(connection);
                        }
                        userList.Add(returnUser);
                        return returnUser;

                    }
                    else {
                        return null;
                    }

                }
                else {
                    return null;
                }
            }
        }

        public List<User> searchUser(int empId = 0, string firstName = "", string lastName = "") {

            bool isOnline = false;
            isOnline = dbManager.isOnline();
            if (isOnline)
            {
                connection = dbManager.openConnection(connection);
                if (connection != null)
                {
                    List<User> returnUser = dbManager.retrieveUser(connection, empId, firstName, lastName);
                    foreach (User u in returnUser) {
                        if (connection.State.Equals(System.Data.ConnectionState.Open)) {
                            u.Dp = new DisplayPicture(dbManager.retrieveImage(connection, u.getEmpId()));
                            List<ContactDetails> contactList = dbManager.retrieveContactDetails(connection, u.getEmpId());
                            u.ContactDetails = contactList[contactList.Count - 1];
                            userList.Add(u);
                        }        
                    }
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        dbManager.closeConnection(connection);
                    }

                    return returnUser;

                }
                else {
                    return null;
                }

            }
            else {
                return null;
            }
        }

        //returns a list of daily sales details

        public List<DailySalesDetails> getDailySalesDetails(User validate_user,DateTime beginDate,DateTime endDate) {
            bool adminrights = false;
            foreach (UserRole u in validate_user.UserRoles)
            {
                foreach (Permission p in u.Permissions)
                {
                    if (p.PermId == 1001)
                    {
                        adminrights = true;
                    }
                }
            }
            if (adminrights)
            {
                bool isOnline = false;
                isOnline = dbManager.isOnline();
                if (isOnline)
                {
                    connection = dbManager.openConnection(connection);
                    if (connection != null)
                    {
                        List<object> orders = dbManager.retrieveEntry(connection, beginDate, endDate, "salesEntry");
                        List<DailySalesDetails> ret_orders = new List<DailySalesDetails>();
                        foreach (object o in orders) {
                            ret_orders.Add((DailySalesDetails)o);
                        }

                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            dbManager.closeConnection(connection);
                        }

                        if (orders!=null)
                        {

                            return ret_orders;
                        }
                        else {
                            return null;
                        }

                    }
                    else {
                        return null;
                    }

                }
                else {
                    return null;
                }
            }
            else {
                bool isOnline = false;
                isOnline = dbManager.isOnline();
                if (isOnline)
                {
                    connection = dbManager.openConnection(connection);
                    if (connection != null)
                    {
                        List<object> orders = dbManager.retrieveEntry(connection, beginDate, endDate, "salesEntry",validate_user.getEmpId());
                        List<DailySalesDetails> ret_orders = new List<DailySalesDetails>();
                        foreach (object o in orders)
                        {
                            ret_orders.Add((DailySalesDetails)o);
                        }
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            dbManager.closeConnection(connection);
                        }

                        if (orders!=null)
                        {

                            return ret_orders;
                        }
                        else {
                            return null;
                        }

                    }
                    else {
                        return null;
                    }

                }
                else {
                    return null;
                }
            }
            }


        public List<SalesReturn> getSalesReturns(User validate_user, DateTime beginDate, DateTime endDate)
        {
            bool adminrights = false;
            foreach (UserRole u in validate_user.UserRoles)
            {
                foreach (Permission p in u.Permissions)
                {
                    if (p.PermId == 1002)
                    {
                        adminrights = true;
                    }
                }
            }
            if (adminrights)
            {
                bool isOnline = false;
                isOnline = dbManager.isOnline();
                if (isOnline)
                {
                    connection = dbManager.openConnection(connection);
                    if (connection != null)
                    {
                        List<object> orders = dbManager.retrieveEntry(connection, beginDate, endDate, "returnEntry");
                        List<SalesReturn> ret_orders = new List<SalesReturn>();
                        foreach (object o in orders)
                        {
                            ret_orders.Add((SalesReturn)o);
                        }

                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            dbManager.closeConnection(connection);
                        }

                        if (orders!=null)
                        {

                            return ret_orders;
                        }
                        else {
                            return null;
                        }

                    }
                    else {
                        return null;
                    }

                }
                else {
                    return null;
                }
            }
            else {
                bool isOnline = false;
                isOnline = dbManager.isOnline();
                if (isOnline)
                {
                    connection = dbManager.openConnection(connection);
                    if (connection != null)
                    {
                        List<object> orders = dbManager.retrieveEntry(connection, beginDate, endDate, "returnEntry", validate_user.getEmpId());
                        List<SalesReturn> ret_orders = new List<SalesReturn>();
                        foreach (object o in orders)
                        {
                            ret_orders.Add((SalesReturn)o);
                        }
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            dbManager.closeConnection(connection);
                        }

                        if (orders!=null)
                        {

                            return ret_orders;
                        }
                        else {
                            return null;
                        }

                    }
                    else {
                        return null;
                    }

                }
                else {
                    return null;
                }
            }
        }


        public List<DailySalesReport> getDailyReport( DateTime beginDate, DateTime endDate) {

            bool isOnline = false;
            isOnline = dbManager.isOnline();
            if (isOnline)
            {
                    connection = dbManager.openConnection(connection);
                    if (connection != null)
                    {
                    List<object> orders = dbManager.retrieveReport(connection, beginDate, endDate, "Daily Report");
                        List<DailySalesReport> ret_orders = new List<DailySalesReport>();
                        foreach (object o in orders)
                        {
                            ret_orders.Add((DailySalesReport)o);
                        }

                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            dbManager.closeConnection(connection);
                        }

                        if (orders!=null)
                        {

                            return ret_orders;
                        }
                        else {
                            return null;
                        }

                    }
                    else {
                        return null;
                    }

                }
                else {
                    return null;
                }
            
            
        }

        public List<WeeklySalesReport> getWeeklyReport(DateTime beginDate, DateTime endDate)
        {

            bool isOnline = false;
            isOnline = dbManager.isOnline();
            if (isOnline)
            {
                connection = dbManager.openConnection(connection);
                if (connection != null)
                {
                    List<object> orders = dbManager.retrieveReport(connection, beginDate, endDate, "Weekly Report");
                    List<WeeklySalesReport> ret_orders = new List<WeeklySalesReport>();
                    foreach (object o in orders)
                    {
                        ret_orders.Add((WeeklySalesReport)o);
                    }

                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        dbManager.closeConnection(connection);
                    }

                    if (orders!=null)
                    {

                        return ret_orders;
                    }
                    else {
                        return null;
                    }

                }
                else {
                    return null;
                }

            }
            else {
                return null;
            }
        }




        ////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public string modifyUser(User user) {
            bool isOnline = false;
                isOnline = dbManager.isOnline();
                if (isOnline)
            {
                connection = dbManager.openConnection(connection);
                if (connection != null)
                {
                    bool user_status = dbManager.modifyUser(connection, user);
                    bool contacts_status = dbManager.storeContactDetails(connection, user.getEmpId(), user.ContactDetails);
                    bool dp_status = dbManager.modifyImage(connection, user.Dp.getPicture(), user.getEmpId());
                    
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        dbManager.closeConnection(connection);
                    }

                    if (user_status && contacts_status && dp_status)
                    {
                        
                        return "Successfully updated the details!";
                    }
                    else {
                        return "There was an error during the storage process. Please try again.";
                    }

                }
                else {
                    return "Error! Cannot establish a connection with database. Try again later.";
                }

            }
            else {
                return "Error! No internet connection! Fix the internet connection and try again.";
            }
        }

        public string modifyProduct(Product product) {
            bool isOnline = false;
            isOnline = dbManager.isOnline();
            if (isOnline)
            {
                connection = dbManager.openConnection(connection);
                if (connection != null)
                {
                    bool product_status = dbManager.modifyProduct(connection, product);
                    

                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        dbManager.closeConnection(connection);
                    }

                    if (product_status)
                    {

                        return "Successfully updated the details!";
                    }
                    else {
                        return "There was an error during the storage process. Please try again.";
                    }

                }
                else {
                    return "Error! Cannot establish a connection with database. Try again later.";
                }

            }
            else {
                return "Error! No internet connection! Fix the internet connection and try again.";
            }
        }

        public string modifyOrderStatus(Order updatedOrder,string orderStatus) {
            bool isOnline = false;
            isOnline = dbManager.isOnline();
            if (isOnline)
            {
                connection = dbManager.openConnection(connection);
                if (connection != null)
                {
                    bool product_status = dbManager.setOrderStatus(connection,orderStatus,updatedOrder);


                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        dbManager.closeConnection(connection);
                    }

                    if (product_status)
                    {

                        return "Successfully updated the details!";
                    }
                    else {
                        return "There was an error during the storage process. Please try again.";
                    }

                }
                else {
                    return "Error! Cannot establish a connection with database. Try again later.";
                }

            }
            else {
                return "Error! No internet connection! Fix the internet connection and try again.";
            }
        }


    }
    
}
