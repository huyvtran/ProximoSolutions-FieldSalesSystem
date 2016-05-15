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

        /*public void placeOrder(int orderID, DateTime orderaddedTime, string orderproduct, List<int> quantity, List<int> productID)
        {
            int placedempID = this.getEmpId();
            String quantityString = "";
            for (int i = 0; i < quantity.Count; i++)
            {
                quantityString = quantityString + Convert.ToString(quantity[i]);
                quantityString = quantityString + ",";
            }

            String productIDString = "";
            for (int i = 0; i < productID.Count; i++)
            {
                productIDString = productIDString + Convert.ToString(productID[i]);
                productIDString = productIDString + ",";
            }
            int[] qunatityList = Array.ConvertAll((quantityString).Split(','), int.Parse);
            int[] productIDList = Array.ConvertAll((productIDString).Split(','), int.Parse);
            // Object.neworder(orderID,orderaddedTime,orderaddedTime, qunatityList,productIDList, placedempID);


        }
        */
        

        

        

        public override string activateUser(SecurityManager securityManager, User user)
        {
            return "You do not have permission to perform this action!";
        }

        public override string addRole(ObjectFactory factory, User user, UserRole newRole)
        {
            throw new NotImplementedException();
        }

        public override string removeRole(ObjectFactory factory, User user, string roleName)
        {
            throw new NotImplementedException();
        }

        public override string addOrder(ObjectFactory factory, Order order)
        {
            throw new NotImplementedException();
        }

        

        public override List<Order> viewOrder(ObjectFactory factory, DateTime beginDate, DateTime endDate, int ordererId)
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
        /*public void pickUpOrder(DateTime pickeduptime, int orderId)
{
//Order pickUpOrderObject = Object.getOrder(orderId)[0];
//pickUpOrderObject.getProcessDetails().getOrderPickupSchedule().PickUpAgency = this.getAgencyName();
//pickUpOrderObject.getProcessDetails().getOrderPickupSchedule().PickUpId = this.getEmpId();
//pickUpOrderObject.getProcessDetails().getOrderPickupSchedule().PickUpDateAndTime = pickeduptime;
//pickUpOrderObject.getProcessDetails().getOrderPickupSchedule().PickUpStatus = "PickedUP";
// Object.saveOrder(pickUpOrderObject,orderId);

}

public List<Order> requestOrder(int orderId)

{
int placedEmpId;
if (orderId == -1)
{
placedEmpId = this.getEmpId();
}
else
{
placedEmpId = -1;
}
//List<Order> requestedList = Object.getOrder(orderId, placedEmpId);
//edited
if (true)
{
if (orderId==-1)
{
this.noOrdersHaveMade();
}
else
{
this.requestOrderSuch(orderId);
}
return null;
}
return null;
}
public void editOrder(int orderEditID, int orderEntryId, int editorderquantity, int productId)
{
//Product gotProduct = Object.getProduct(productId)[0];
//Order editOrderObject = Object.getOrder(orderEditID)[0];
//editOrderObject.editordentryquantity(orderEntryId, editorderquantity, gotProduct);
//editOrderObject.getProcessDetails().setProcessedBy(this.getEmpId());
//Object.saveOrder(editOrderObject,orderEditID);


}

public void addEntry(int orderId, int quantity, int productId)
{
//Order addEntryObject = Object.getOrder(orderId)[0];
//int entryId = addEntryObject.getentrysize();
//OrderEntry newOrderEntry = Object.setOrderEntry(entryId, quantity, productId);
//addEntryObject.addorderentry(newOrderEntry);//Check whether it was done
//addEntryObject.getProcessDetails().setProcessedBy(this.getEmpId());
//Object.saveOrder(addEntryObject,orderId);
}       
//public Order viewOrderSummary(int orderid)
//{
//return getorder(orderid);//Implement builder object
//}
public Boolean removeOrder(int orderId)
{
/*Order removeOrderObject = (Object.getOrder(orderId)[0]);
removeOrderObject.getProcessDetails().setOrderStatus("Cancelled");
removeOrderObject.getProcessDetails().setProcessedBy(this.getEmpId());
Object.saveOrder(removeOrderObject,orderId);
return true;*/
        /*
    }
    public Boolean removeOrderentry(int orderId, int orderEntryId)
    {
        /*Order removeOrderentryObject = (Object.getOrder(orderId)[0]);
        removeOrderentryObject.deleteorderentry(orderEntryId);
        removeOrderentryObject.getProcessDetails().setProcessedBy(this.getEmpId());
        Object.saveOrder(removeOrderentryObject,orderId);
        return true;*/
        /*
                }

                public bool requestOrderSuch(int orderId)
                {
                    throw new NotImplementedException();
                }
                public bool noOrdersHaveMade()
                {
                    throw new NotImplementedException();
                }

                public bool addEntry(Order order, OrderEntry entry)
                {
                    throw new NotImplementedException();
                }

                public bool removeEntry(Order order, OrderEntry entry)
                {
                    throw new NotImplementedException();
                }

                ArrayList OrderManagement.viewOrderSummary(int orderId)
                {
                    throw new NotImplementedException();
                }

                bool OrderManagement.removeOrder(int orderId)
                {
                    throw new NotImplementedException();
                }

                public bool requestOrder(Order order)
                {
                    throw new NotImplementedException();
                }
            }*/

    }
}
