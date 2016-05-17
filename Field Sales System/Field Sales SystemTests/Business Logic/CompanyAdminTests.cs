using Microsoft.VisualStudio.TestTools.UnitTesting;
using Field_Sales_System.Business_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Field_Sales_System.Utility_Classes;
using System.Drawing;

namespace Field_Sales_System.Business_Logic.Tests
{
    [TestClass()]
    public class CompanyAdminTests
    {
        [TestMethod()]
        public void addUserTest()
        {
            ObjectFactory of = new ObjectFactory();
            SecurityManager sm = new SecurityManager();
            ImageHandler ih = new ImageHandler();
            Image i = ih.resizeImage(ih.openImage("C:/testImg/test.jpg"));
            //CompanyAdmin ca = new CompanyAdmin(1245,444444,true,"Poiya","Passi",45112441,451114,"poiya@poiya.com","poi1","poi2","poi3",i);
            //string c = ca.addUser(of, sm, 2225, 45444114, false, "Pasindu", "Senanayake", 12454114, 12541144, "suji@thasu.com", "add1", "add2", "add3", i, "Representative", null, "ABC123");

        }
    }
}