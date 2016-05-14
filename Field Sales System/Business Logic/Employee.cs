using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    public abstract class Employee
    {
        private int empId;
        private int empNIC;
        private bool gender;
        private string firstName;
        private string lastName;
        [NonSerialized()] private DisplayPicture dp;
        [NonSerialized()] private ContactDetails contactDetails;

        internal ContactDetails ContactDetails
        {
            get
            {
                return contactDetails;
            }

            set
            {
                contactDetails = value;
            }
        }

        public Employee(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1,string addressLine_2,string addressLine_3,Image img) {
            this.ContactDetails = new ContactDetails(mobileNo, landNo, email, addressLine_1,addressLine_2,addressLine_3);
            this.dp = new DisplayPicture(img);
            this.empId = empId;
            this.empNIC = empNIC;
            this.gender = gender;
            this.firstName = firstName;
            this.lastName = lastName;

        }
        public void setGender(bool gender) {
            this.gender = gender;
        }

        public void setFirstName(string firstName) {
            this.firstName = firstName;
        }

        public void setLastName(string lastName) {
            this.lastName = lastName;
        }

        public int getEmpId() {
            return this.empId;
        }

        public int getEmpNIC() {
            return this.empNIC;
        }

        public bool getGender() {
            return this.gender;
        }

        public string getFirstName() {
            return this.firstName; ;
        }

        public string getLastName() {
            return this.lastName;
        }
        

    }
}
