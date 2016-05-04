﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    abstract class Employee
    {
        private int empId;
        private int empNIC;
        private bool gender;
        private string firstName;
        private string lastName;
        private DisplayPicture dp;
        private ContactDetails contactDetails;

        public Employee(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string address,string url) {
            this.contactDetails = new ContactDetails(mobileNo, landNo, email, address);
            this.dp = new DisplayPicture(url);
            this.empId = empId;
            this.empNIC = empNIC;
            this.gender = gender;
            this.firstName = firstName;
            this.lastName = lastName;

        }
        public void setEmpId(int empId) {
            this.empId = empId;
        }

        public void setEmpNIC(int empNIC) {
            this.empNIC = empNIC;
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
        public void setContactDetails() { }
        public ContactDetails getContactDetails() {
            return this.contactDetails;
        }


    }
}
