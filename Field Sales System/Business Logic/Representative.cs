using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Field_Sales_System.Utility_Classes;

namespace Field_Sales_System.Business_Logic
{
    [Serializable()]
    public class Representative : User
    {

        public Representative(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1,string addressLine_2,string addressLine_3, Image img)
            :base(empId,empNIC,gender,firstName,lastName,mobileNo,landNo,email,addressLine_1,addressLine_2,addressLine_3,img)
        {
        
        }

        public override string activateUser(SecurityManager securityManager, User user)
        {
            throw new NotImplementedException();
        }

        

        public override string addOrder(ObjectFactory factory, Order order)
        {
            throw new NotImplementedException();
        }

        public override string addRole(ObjectFactory factory, User user, UserRole newRole)
        {
            throw new NotImplementedException();
        }

        

        public override string cancelOrder(ObjectFactory factory, Order order)
        {
            throw new NotImplementedException();
        }

        public override string deactivateUser(SecurityManager securityManager, User user)
        {
            throw new NotImplementedException();
        }

        

        public override string removeRole(ObjectFactory factory, User user, string roleName)
        {
            throw new NotImplementedException();
        }

        public bool requestOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public override List<Order> viewOrder(ObjectFactory factory, DateTime beginDate, DateTime endDate, int ordererId)
        {
            throw new NotImplementedException();
        }

                
    }
}
