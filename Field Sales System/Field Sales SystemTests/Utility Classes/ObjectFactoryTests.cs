using Microsoft.VisualStudio.TestTools.UnitTesting;
using Field_Sales_System.Utility_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Field_Sales_System.Business_Logic;

namespace Field_Sales_System.Utility_Classes.Tests
{
    [TestClass()]
    public class ObjectFactoryTests
    {
        [TestMethod()]
        public void retrieveAllProductsTest()
        {
            ConnectionManager c = new ConnectionManager();
            ObjectFactory of = new ObjectFactory();
            MySqlConnection connection = c.connectDatabase("Database = proximoDB; Data Source = us-cdbr-azure-central-a.cloudapp.net; User Id = b5fb261919a40c; Password = aff5b96f");
            c.openConnection(connection);
            List<Product> products = of.retrieveAllProducts();
        }
    }
}