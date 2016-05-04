using Microsoft.VisualStudio.TestTools.UnitTesting;
using Field_Sales_System.Utility_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Utility_Classes.Tests
{
    [TestClass()]
    public class ConnectionManagerTests
    {
        [TestMethod()]
        public void isOnlineTest()
        {
            ConnectionManager c = new ConnectionManager();
            Assert.IsTrue(c.isOnline());
        }

        
    }
}