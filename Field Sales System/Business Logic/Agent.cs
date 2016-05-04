using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class Agent : User , OrderManagement
    {
        private string agencyName;
        private string coverageArea;

        public Agent(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string address, string url)
            :base(empId,empNIC,gender,firstName,lastName,mobileNo,landNo,email,address,url)
        {
        }
        public void setAgencyName(string agencyName) {
            this.agencyName = agencyName;
        }
        public void setCoverageArea(string coverageArea) {
            this.coverageArea = coverageArea;
        }
        public string getAgencyName() {
            return this.agencyName;
        }
        public string getCoverageArea() {
            return this.coverageArea;
        }

        public void requestOrder(int orderId) { }
        public void editOrder(int editOrder) { }
        public void viewOrderSummary() { }
        public void removeOrder(int orderId) { }
    }
}
