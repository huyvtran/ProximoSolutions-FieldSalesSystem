using Microsoft.VisualStudio.TestTools.UnitTesting;
using Field_Sales_System.Utility_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Field_Sales_System.Utility_Classes.Tests
{
    [TestClass()]
    public class ImageHandlerTests
    {
        ImageHandler ih = new ImageHandler();

        [TestMethod()]
        public void resizeImageTest()
        {
            try
            {
                Image newImg = ih.resizeImage(ih.openImage("C:/testImg/test.jpg"));
                newImg.Save("C:/testImg/newImg.jpg");
                

            }
            catch (Exception e) {

            }
        }
    }
}