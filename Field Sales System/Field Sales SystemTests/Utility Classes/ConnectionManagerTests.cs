using Field_Sales_System.Utility_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System.Collections;

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

            MySql.Data.MySqlClient.MySqlConnection connection = c.connectDatabase();

            Assert.IsFalse(connection == null);
        }

        [TestMethod()]
        public void openConnectionTest()
        {
            MySql.Data.MySqlClient.MySqlConnection connection = c.openConnection(c.connectDatabase());
            Assert.IsFalse(connection == null);

        }

        [TestMethod()]
        public void readRecordTest()
        {
            MySql.Data.MySqlClient.MySqlConnection connection = c.openConnection(c.connectDatabase());
            //connection.Open();
            ArrayList al = c.readRecord(1545, connection, "employee");
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
            MySqlConnection connection = c.openConnection(c.connectDatabase());
            bool flag = c.writeRecord(empData, values, connection, "users");
            Assert.IsTrue(flag);
        }

        [TestMethod()]
        public void modifyRecordTest()
        {
            ConnectionManager cnct = new ConnectionManager();
            MySqlConnection connection = cnct.openConnection(cnct.connectDatabase());
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
       
    }
}