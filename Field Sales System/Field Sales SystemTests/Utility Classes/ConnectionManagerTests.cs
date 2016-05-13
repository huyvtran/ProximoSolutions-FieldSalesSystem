using Field_Sales_System.Business_Logic;
using Field_Sales_System.Utility_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;


namespace Field_Sales_System.Utility_Classes.Tests
{
    [TestClass()]
    public class ConnectionManagerTests
    {
        ConnectionManager c = new ConnectionManager();

        [TestMethod()]
        public void isOnlineTest()
        {

            Assert.IsTrue(c.isOnline());
        }

        [TestMethod()]
        public void connectDatabaseTest()
        {

            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");

            Assert.IsFalse(connection == null);
        }

        [TestMethod()]
        public void openConnectionTest()
        {
            MySqlConnection connection = c.openConnection(c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f"));
            Assert.IsFalse(connection == null);

        }
        [TestMethod()]
        public void retrieveImageTest()
        {
            ConnectionManager cnct = new ConnectionManager();
            MySqlConnection connection = cnct.openConnection(cnct.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f"));
            ImageHandler ih = new ImageHandler();
            Image i = cnct.retrieveImage(connection, 1212);
            bool b = ih.saveImage(1516, "C:/testImg", i);
            Assert.IsTrue(b);
        }

        [TestMethod()]
        public void storeUserTest()
        {
            ImageHandler ih = new ImageHandler();
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");

            c.openConnection(connection);
            Image image = ih.openImage("C:/testImg/1515.jpg");
            WarehouseManager manager = new WarehouseManager(1212, 454545, true, "fName", "sName", 0775487515, 112451414, "email@asd", "Add1", "add2", "add3", image);
            c.storeUser(connection, manager);
            List<User> u = c.retrieveUser(connection, 1212);


        }

        [TestMethod()]
        public void storeImageTest()
        {
            ConnectionManager cnct = new ConnectionManager();
            MySqlConnection connection = cnct.openConnection(cnct.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f"));
            ImageHandler ih = new ImageHandler();
            Image img = ih.openImage("C:/testImg/test.jpg");
            img = ih.resizeImage(img);
            bool b = cnct.storeImage(connection, 1212, img);
            Assert.IsTrue(b);
        }

        [TestMethod()]
        public void storeContactDetailsTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");
            c.openConnection(connection);
            bool b = c.storeContactDetails(connection, 1212, new ContactDetails(121241, 54451245, "izu@as.com", "add1", "add2", "add3"));
            Assert.IsTrue(b);
        }

        [TestMethod()]
        public void retrieveContactDetailsTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");
            c.openConnection(connection);
            List<ContactDetails> cnt = c.retrieveContactDetails(connection, 1212);
        }

        [TestMethod()]
        public void modifyUserTest()
        {
            ImageHandler ih = new ImageHandler();
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");

            c.openConnection(connection);
            Image image = ih.openImage("C:/testImg/1515.jpg");
            WarehouseManager manager = new WarehouseManager(1212, 454545, true, "fName", "sName", 0775487515, 112451414, "email@asd", "Add1", "add2", "add3", image);
            c.storeUser(connection, manager);
            List<User> u = c.retrieveUser(connection, 1212);
            u[0].setFirstName("Izzzzzzzzz");
            c.modifyUser(connection, u[0]);
            List<User> u2 = c.retrieveUser(connection, 1212);
        }

        [TestMethod()]
        public void storeLoginInfoTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");
            c.openConnection(connection);
            bool b = c.storeLoginInfo(connection, 1545, "test");
            c.closeConnection(connection);
            Assert.IsTrue(b);
        }

        [TestMethod()]
        public void retrieveLoginInfoTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");
            c.openConnection(connection);
            List<object> l = c.retrieveLoginInfo(connection, 1545);
            c.closeConnection(connection);
            Assert.IsTrue(System.Convert.ToInt32(l[2]) == 1);
        }

        [TestMethod()]
        public void modifyLoginInfoTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");
            c.openConnection(connection);
            bool b = c.modifyLoginInfo(connection, 1545, "", -1, 1);
            Assert.IsTrue(b);
        }

        [TestMethod()]
        public void storeProductTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");
            c.openConnection(connection);
            Product p = new Product();
            p.setProductID(12451);
            p.setProductName("testProduct");
            bool b = c.storeProduct(connection, 12451, "testProduct", p);
            Assert.IsTrue(b);
        }

        [TestMethod()]
        public void retrieveProductTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");
            c.openConnection(connection);
            List<Product> l = c.retrieveProduct(connection, -1, "testProduct");
        }

        [TestMethod()]
        public void storeEntryTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");
            c.openConnection(connection);
            SalesEntry 
        }
    }
}