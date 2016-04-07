using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class Agent : User
    {
        private string agencyName;
        private string coverageArea;
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
    }
}
