using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class DailySalesReport
    {
        private string author;
        private string date;
        private int reportNumber;
        private string dailySalesSummary;
        

        public void setAuthor(string author)
        {
            this.author = author;
        }
        public void setDate(string date)
        {
            this.date = date;
        }

        public void setReportNumber(int reportNumber)
        {
            this.reportNumber = reportNumber;
        }

        public void setSummary(string dailySalesSummary)
        {
            this.dailySalesSummary = dailySalesSummary;
        }

        public string getAuthor()
        {
            return this.author;
        }

        public string getDate()
        {
            return this.date;
        }

        public int getReportNumber()
        {
            return this.reportNumber;
        }

        public string getDailySalesSummary()
        {
            return this.dailySalesSummary;
        }




    }
}
