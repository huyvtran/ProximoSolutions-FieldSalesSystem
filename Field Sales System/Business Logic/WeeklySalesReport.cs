using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    public class WeeklySalesReport
    {
        
        private DateTime date;
        private int reportNumber;
        private string weeklySalesSummary;

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public void setReportNumber(int reportNumber)
        {
            this.reportNumber = reportNumber;
        }

        public void setSummary(string weeklySalesSummary)
        {
            this.weeklySalesSummary = weeklySalesSummary;
        }


        

        public int getReportNumber()
        {
            return this.reportNumber;
        }

        public string getWeeklySalesSummary()
        {
            return this.weeklySalesSummary;
        }




    }
}

