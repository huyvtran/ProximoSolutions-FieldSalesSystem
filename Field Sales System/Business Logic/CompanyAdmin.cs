using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class CompanyAdmin : User, UserManagement
    {
        public CompanyAdmin(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string address, string url):base(empId,empNIC,gender,firstName,lastName,mobileNo,landNo,email,address,url)
        {
        }
        public void addRepresentative(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string address) {
            string url="have to build"; // Create url 
            Representative newrep = new Representative(empId, empNIC, gender, firstName, lastName, mobileNo, landNo, email, address, url);
        }
        public void addAgent(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string address) {
            string url = "have to build"; // Create url 
            Agent newagent = new Agent(empId, empNIC, gender, firstName, lastName, mobileNo, landNo, email, address, url);
           
        }
        public void updateProduct(Product p) {
            //update details of product p
        }

        public void updateUser(int userid) {
            //get object from database
           


        }
        public void deactivateUser(User user) { }
        public void activateUser(User user) { }
        public void changePassword(User user) { }
        public void reviewUpdate() { }
        public void acceptUpdate() { }

    }
}
