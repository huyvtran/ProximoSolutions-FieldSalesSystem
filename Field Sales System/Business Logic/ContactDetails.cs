using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class ContactDetails
    {
        private int mobileNo;
        private int landNo;
        private string emailAddress;
        private string address;

        public ContactDetails( int mobileNo, int landNo, string emailAddress, string address) {
            this.mobileNo = mobileNo;
            this.landNo = landNo;
            this.emailAddress = emailAddress;
            this.address = address;
        }

        public void setMobileNo(int mobileNo) {
            this.mobileNo = mobileNo;
        }
        public void setLandNo(int landNo) {
            this.landNo = landNo;
        }
        public void setEmailAddress(string emailAddress) {
            this.emailAddress = emailAddress;
        }
        public void setAddress(string address) {
            this.address = address;
        }
        public int getMobileNo() {
            return this.mobileNo;
        }
        public int getLandNo() {
            return this.landNo;
        }
        public string getEmailAddress() {
            return this.emailAddress;
        }
        public string getAddress() {
            return this.address;
        }


    }
}
