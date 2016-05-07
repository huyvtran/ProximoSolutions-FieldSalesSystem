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
    public class SecurityManagerTests
    {
        [TestMethod()]
        public void computeHashTest()
        {
            SecurityManager sm = new SecurityManager();
            string hash = sm.computeHash("ISURUbjhdfshfwefhweiufhweofhsdfeiuwhfuihsdfbsdhbfkhaskhawyeweauhfuwehfouwehufhsdhfkjsdbkwaehuafhukhduwfkadsbkjawehfuhe");
            int a = hash.Length;
            Assert.IsTrue(sm.computeHash("ISURU") == sm.computeHash("ISURU"));
        }

        [TestMethod()]
        public void modifyPasswordTest()
        {
            SecurityManager sm = new SecurityManager();
            int i = sm.modifyPassword(2828, "ABCDEF", "ABC123");
            Assert.IsTrue(i == 1);
        }

        [TestMethod()]
        public void loginTest()
        {
            SecurityManager sm = new SecurityManager();
            Assert.IsTrue(sm.login(2828, "ABC123"));
        }

        [TestMethod()]
        public void setStatusOfUserTest()
        {
            SecurityManager sm = new SecurityManager();
            sm.modifyStatus(1235, false);
        }
    }
}