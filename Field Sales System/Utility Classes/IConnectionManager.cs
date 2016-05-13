using System.Collections.Generic;
using System.Drawing;
using Field_Sales_System.Business_Logic;
using MySql.Data.MySqlClient;

namespace Field_Sales_System.Utility_Classes
{
    public interface IConnectionManager
    {
        void closeConnection(MySqlConnection connection);
        MySqlConnection connectDatabase(string conString);
        bool isOnline();
        bool modifyImage(MySqlConnection connection, Image image, int empId);
        bool modifyLoginInfo(MySqlConnection connection, int empId, string pwdHash = "", int isActive = -1, int pwdReset = -1);
        bool modifyUser(MySqlConnection connection, User user);
        MySqlConnection openConnection(MySqlConnection connection);
        List<ContactDetails> retrieveContactDetails(MySqlConnection connection, int empId);
        Image retrieveImage(MySqlConnection connection, int empId);
        List<object> retrieveLoginInfo(MySqlConnection connection, int empId);
        List<User> retrieveUser(MySqlConnection connection, int empId = 0, string empFName = "", string empLName = "");
        bool storeContactDetails(MySqlConnection connection, int empId, ContactDetails contacts);
        bool storeImage(MySqlConnection connection, int empId, Image image);
        bool storeLoginInfo(MySqlConnection connection, int empId, string pwdHash);
        bool storeProduct(MySqlConnection connection, int productId, string productName, Product product);
        bool storeUser(MySqlConnection connection, User user);
    }
}