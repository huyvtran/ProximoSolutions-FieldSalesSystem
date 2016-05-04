using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Utility_Classes
{
    public class ConnectionManager
    {
        public bool isOnline()
        {
            string url = "http://www.google.com";
            try
            {
                System.Net.WebRequest myRequest = System.Net.WebRequest.Create(url);
                System.Net.WebResponse myResponse = myRequest.GetResponse();
            }
            catch (System.Net.WebException)
            {
                return false;
            }
            return true;

        }
    }

        
}
