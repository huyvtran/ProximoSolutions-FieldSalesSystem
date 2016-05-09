using Field_Sales_System.Utility_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System.Collections;
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
        public void readRecordTest()
        {
            MySqlConnection connection = c.openConnection(c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f"));
            ArrayList al = c.readRecord(connection, "employee",0,"Isuru");
            System.Console.WriteLine(al.Count);
            Assert.IsTrue(al[3].Equals("Isuru"));
        }

        [TestMethod()]
        public void writeRecordTest()
        {
            ArrayList values = new ArrayList();
            values.Add("empId");
            values.Add("pwdHash");
            values.Add("status");
            //values.Add("firstName");
            //values.Add("lastName");
            ArrayList empData = new ArrayList();
            empData.Add(2828);
            //empData.Add(451114);
            //empData.Add(true);
            empData.Add("yingyang");
            //empData.Add("CCCDDD");
            empData.Add(false);
            MySqlConnection connection = c.openConnection(c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f"));
            bool flag = c.writeRecord(empData, values, connection, "users");
            Assert.IsTrue(flag);
        }

        [TestMethod()]
        public void modifyRecordTest()
        {
            ConnectionManager cnct = new ConnectionManager();
            MySqlConnection connection = cnct.openConnection(cnct.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f"));
            ArrayList values = new ArrayList();
            values.Add("firstName");
            values.Add("lastName");
            ArrayList newValues = new ArrayList();
            newValues.Add("Kasun");
            newValues.Add("Pathirage");
            bool b = cnct.modifyRecord(1245, values, newValues, "employee", connection);
            //ArrayList arrlst = cnct.readRecord(1245,connection,"employee");
            Assert.IsTrue(b);
        }

        [TestMethod()]
        public void storeImageTest()
        {
            ConnectionManager cnct = new ConnectionManager();
            MySqlConnection connection = cnct.openConnection(cnct.connectDatabase("Database=proximoImageDB;Data Source=us-cdbr-azure-central-a.cloudapp.net;User Id=bc4e805be8c5fd;Password=f4c3aed8"));
            ImageHandler ih = new ImageHandler();
            Image imgToSave = ih.resizeImage(ih.openImage("C:/testImg/test.jpg"));
            bool b = cnct.storeImage(1515, imgToSave, connection);
            Assert.IsTrue(b);

        }

        [TestMethod()]
        public void retrieveImageTest()
        {
            ConnectionManager cnct = new ConnectionManager();
            MySqlConnection connection = cnct.openConnection(cnct.connectDatabase("Database=proximoImageDB;Data Source=us-cdbr-azure-central-a.cloudapp.net;User Id=bc4e805be8c5fd;Password=f4c3aed8"));
            ImageHandler ih = new ImageHandler();
            Image i = cnct.retrieveImage(1515,connection);
            bool b = ih.saveImage(1515, "C:/testImg", i);
            Assert.IsTrue(b);
        }
    }
}