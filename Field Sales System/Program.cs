using Field_Sales_System.Utility_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Field_Sales_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConnectionManager c = new ConnectionManager();
            Console.Out.WriteLine(c.isOnline()+"  netCon");
            if (c.isOnline())
            {
                MessageBox.Show("NET CON");
            }
            else
            {
                MessageBox.Show("No NET CON");
            }
        }
            
        
    }
}
