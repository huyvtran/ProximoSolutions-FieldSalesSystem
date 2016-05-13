using System;
using System.Collections.Generic;
using System.Drawing;
using Field_Sales_System.Business_Logic;
using MySql.Data.MySqlClient;

namespace Field_Sales_System.Utility_Classes
{
    public interface IConnectionManager
    {
        bool isOnline();
        MySqlConnection connectDatabase(string conString);
        MySqlConnection openConnection(MySqlConnection connection);
        void closeConnection(MySqlConnection connection);
        

        bool storeImage(MySqlConnection connection, int empId, Image image);
        Image retrieveImage(MySqlConnection connection, int empId);
        bool modifyImage(MySqlConnection connection, Image image, int empId);


        bool storeLoginInfo(MySqlConnection connection, int empId, string pwdHash);
        bool modifyLoginInfo(MySqlConnection connection, int empId, string pwdHash = "", int isActive = -1, int pwdReset = -1);
        List<object> retrieveLoginInfo(MySqlConnection connection, int empId);


        bool storeUser(MySqlConnection connection, User user);
        bool modifyUser(MySqlConnection connection, User user);
        List<User> retrieveUser(MySqlConnection connection, int empId = 0, string empFName = "", string empLName = "");

        bool storeContactDetails(MySqlConnection connection, int empId, ContactDetails contacts);
        List<ContactDetails> retrieveContactDetails(MySqlConnection connection, int empId);

        bool storeProduct(MySqlConnection connection, int productId, string productName, Product product);
        bool modifyProduct(MySqlConnection connection, Product product);
        List<Product> retrieveProduct(MySqlConnection connection, int productId = -1, string productName = "");

        bool storeEntry(MySqlConnection connection, object entry);
        List<object> retrieveEntry(MySqlConnection connection, DateTime beginDate, DateTime endDate, string entryType, int viewerId = 0);

        bool storeOrder(MySqlConnection connection, string status, Order order);
        bool setOrderStatus(MySqlConnection connection, string status, DateTime orderDate);
        List<Order> retrievOrdersByStatus(MySqlConnection connection, string status, int ordererId = 0);

        bool storeReport(MySqlConnection connection, object report);
        List<object> retrieveReport(MySqlConnection connection, DateTime beginDate, DateTime endDate, string reportType);    
        
    }
}