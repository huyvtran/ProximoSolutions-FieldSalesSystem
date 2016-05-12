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
            Image i = cnct.retrieveImage(1212, connection);
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
            c.storeUser(manager, connection);
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
            bool b = cnct.storeImage(1212, img, connection);
            Assert.IsTrue(b);
        }

        [TestMethod()]
        public void storeContactDetailsTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");
            c.openConnection(connection);
            bool b = c.storeContactDetails(1212, new ContactDetails(121241, 54451245, "izu@as.com", "add1", "add2", "add3"), connection);
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
            c.storeUser(manager, connection);
            List<User> u = c.retrieveUser(connection, 1212);
            u[0].setFirstName("Izzzzzzzzz");
            c.modifyUser(u[0],connection);
            List<User> u2 = c.retrieveUser(connection, 1212);
        }
    }
}