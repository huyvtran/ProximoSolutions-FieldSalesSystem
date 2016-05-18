using Field_Sales_System.Business_Logic;
using Field_Sales_System.Utility_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System;
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
            connection = c.openConnection(connection);
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
            //WarehouseManager manager = new WarehouseManager(1212, 454545, true, "fName", "sName", 0775487515, 112451414, "email@asd", "Add1", "add2", "add3", image);
            //c.storeUser(connection, manager);
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
            bool b = c.storeContactDetails(connection, 1212, new ContactDetails(121241, 544512555, "izu@as.com", "add1", "add2", "add3"));
            Assert.IsTrue(b);
        }

        [TestMethod()]
        public void retrieveContactDetailsTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");
            c.openConnection(connection);
            List<ContactDetails> cnt = c.retrieveContactDetails(connection, 2222);
        }

        [TestMethod()]
        public void modifyUserTest()
        {
            ImageHandler ih = new ImageHandler();
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");

            c.openConnection(connection);
            Image image = ih.openImage("C:/testImg/1515.jpg");
            //WarehouseManager manager = new WarehouseManager(1212, 454545, true, "fName", "sName", 0775487515, 112451414, "email@asd", "Add1", "add2", "add3", image);
            //c.storeUser(connection, manager);
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
            //c.openConnection(connection);
            //bool b = c.storeLoginInfo(connection, 1545, "test");
            c.closeConnection(connection);
            // Assert.IsTrue(b);
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
            p.ProductID = 12451;
            p.ProductName = "testProduct";
            bool b = c.storeProduct(connection, 12451, "testProduct", p);
            Assert.IsTrue(b);
        }

        [TestMethod()]
        public void retrieveProductTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");
            c.openConnection(connection);
            Product l = c.retrieveProduct(connection, -1, "testProduct");
        }

        [TestMethod()]
        public void storeEntryTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");

            SalesEntry se = new SalesEntry();
            DailySalesDetails ds = new DailySalesDetails();
            SalesReturn sr = new SalesReturn();
            ReturnEntry re = new ReturnEntry();
            Order newOrder = new Order();
            newOrder.OrderId = 4578;
            newOrder.OrderRequestedDate = System.DateTime.Now;
            sr.addReturnEntry(re);
            sr.ReturnerID = 750;
            ds.SubmitterID = 565;
            ds.addEntry(se);
            se.Quantity = 50;
            se.Product = new Product();
            c.openConnection(connection);
            System.DateTime now = System.DateTime.Now;
            ds.setDate(now);
            bool b = c.storeEntry(connection, ds);
            c.closeConnection(connection);
        }

        [TestMethod()]
        public void retrieveEntryTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");
            c.openConnection(connection);
            DateTime dt1 = new DateTime(2015, 01, 01);
            DateTime dt2 = new DateTime(2017, 01, 01);
            List<object> l = c.retrieveEntry(connection, dt1, dt2, "salesEntry", 559);

        }

        [TestMethod()]
        public void modifyEntryTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");

            DateTime dt1 = new DateTime(2015, 01, 01);
            DateTime dt2 = new DateTime(2017, 01, 01);
            c.openConnection(connection);
            List<object> l = c.retrieveEntry(connection, dt1, dt2, "orderEntry");
            c.closeConnection(connection);
            c.openConnection(connection);
            ((DailySalesDetails)l[1]).setDate(DateTime.Now);
            SalesEntry se = new SalesEntry();
            DailySalesDetails ds = new DailySalesDetails();
            SalesReturn sr = new SalesReturn();
            ReturnEntry re = new ReturnEntry();
            sr.addReturnEntry(re);
            sr.ReturnerID = 750;
            ds.SubmitterID = 565;
            ds.addEntry(se);
            se.Quantity = 50;
            System.DateTime now = System.DateTime.Now;
            ds.setDate(now);
            //c.modifyEntry(connection, ds, l[1]);

        }

        [TestMethod()]
        public void storeOrderTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");
            c.openConnection(connection);
            Order order = new Order();
            order.OrderId = 15451;
            order.OrderRequestedDate = System.DateTime.Now;
            bool b = c.storeOrder(connection, "New Order", order);
        }

        [TestMethod()]
        public void setOrderStatusTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");

            DateTime dt1 = new DateTime(2015, 01, 01);
            DateTime dt2 = new DateTime(2017, 01, 01);
            c.openConnection(connection);
            List<object> l = c.retrieveEntry(connection, dt1, dt2, "orderEntry");
            c.closeConnection(connection);
            ((Order)l[0]).OrderNote = "New note";
            c.openConnection(connection);
            bool b = c.setOrderStatus(connection, "Note Added", ((Order)l[0]));
            List<object> l2 = c.retrieveEntry(connection, dt1, dt2, "orderEntry");
        }

        [TestMethod()]
        public void retrieveOrdersByStatusTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");
            c.openConnection(connection);
            List<Order> or = c.retrieveOrdersByStatus(connection, "Processing", 15471);
        }

        [TestMethod()]
        public void storeReportTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");
            c.openConnection(connection);
            DailySalesReport dsr = new DailySalesReport();
            WeeklySalesReport wsr = new WeeklySalesReport();
            wsr.Date = DateTime.Now;
            dsr.setDate(DateTime.Now);
            bool b = c.storeReport(connection, wsr);
        }

        [TestMethod()]
        public void retrieveReportTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");

            DateTime dt1 = new DateTime(2015, 01, 01);
            DateTime dt2 = new DateTime(2017, 01, 01);
            c.openConnection(connection);
            List<object> l = c.retrieveReport(connection, dt1, dt2, "Weekly Report");
        }

        [TestMethod()]
        public void retrievePasswordResetRequestsTest()
        {
            ConnectionManager c = new ConnectionManager();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");
            c.openConnection(connection);
            List<int> i = c.retrievePasswordResetRequests(connection);
        }

        [TestMethod()]
        public void retrieveAllProductsTest()
        {
           
        }
    }
}