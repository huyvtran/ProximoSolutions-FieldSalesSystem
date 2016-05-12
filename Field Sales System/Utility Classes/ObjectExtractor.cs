using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Utility_Classes
{
    class ObjectExtractor
    {
        private static void GetPropertyValues(Object obj, String[] fields)
        {
            Console.WriteLine(fields[0]);
            Type t = obj.GetType();
            ArrayList sendpacket = new ArrayList();
            sendpacket.Add(t.Name);
            //Console.WriteLine("Type is: {0}", t.Name);
            PropertyInfo[] props = t.GetProperties();
            foreach (var field in fields)
            {
                Console.WriteLine(field);
                foreach (var prop in props)
                    if (prop.GetIndexParameters().Length == 0)
                    {
                        if (prop.Name.Equals(field))
                        {
                            //Console.WriteLine("   {0} ({1}): {2}", prop.Name,
                                       // prop.PropertyType.Name,
                                           // prop.GetValue(obj));
                            sendpacket.Add(prop.GetValue(obj));
                        }

                    }
                    else {
                        //Console.WriteLine("   {0} ({1}): <Indexed>", prop.Name,
                                          //prop.PropertyType.Name);
                    }
            }
            sendpacket.Add(obj);
        }
    }
}
