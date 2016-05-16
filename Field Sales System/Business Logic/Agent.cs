using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Field_Sales_System.Utility_Classes;
using System.Collections;
using System.Drawing;



namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    public class Agent : User
    {
        private string agencyName;
        private string coverageArea;
        

        public Agent(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img)
            : base(empId, empNIC, gender, firstName, lastName, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3, img)
        {
        }
        public void setAgencyName(string agencyName)
        {
            this.agencyName = agencyName;
        }
        public void setCoverageArea(string coverageArea)
        {
            this.coverageArea = coverageArea;
        }
        public string getAgencyName()
        {
            return this.agencyName;
        }
        public string getCoverageArea()
        {
            return this.coverageArea;
        }

  

        public override string activateUser(SecurityManager securityManager, User user)
        {
            return "You do not have permission to perform this action!";
        }

        public override string addRole(ObjectFactory factory, User user, UserRole newRole)
        {
            return "You do not have permission to perform this action!";
        }

        public override string removeRole(ObjectFactory factory, User user, string roleName)
        {
            return "You do not have permission to perform this action!";
        }

        public override string addOrder(ObjectFactory factory, Order order)
        {
            return "You do not have permission to perform this action!";
        }

        

        public override string deactivateUser(SecurityManager securityManager, User user)
        {
            return "You do not have permission to perform this action!";
        }

        public override string addUser(ObjectFactory factory, SecurityManager securityManager, int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img, string userType, List<UserRole> rolesList, string password)
        {
            return "You do not have permission to perform this action!";
        }
    }
}
