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
    class Agent : User, OrderManagement
    {
        private string agencyName;
        private string coverageArea;
        OrderPickupSchedule orderpickedup;
        //ObjectFactory Object;
       

        public Agent(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1,string addressLine_2,string addressLine_3, Image img)
            : base(empId, empNIC, gender, firstName, lastName, mobileNo, landNo, email, addressLine_1,addressLine_2,addressLine_3, img)
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

        public void placeOrder(int orderID, DateTime orderaddedtime, string orderproduct, List<int> quantity, List<int> productID)
        {
           
            String quantityString = "";
            for (int i = 0; i < quantity.Count; i++)
            {
                quantityString = quantityString + Convert.ToString(quantity[i]);
                quantityString = quantityString + ",";
            }

            String productIDString = "";
            for (int i = 0; i < qproductID.Count; i++)
            {
                productIDString = productIDString + Convert.ToString(productID[i]);
                productIDString = productIDString + ",";
            }

            ArrayList inputset = new ArrayList();
            inputset.Add(orderID);
            inputset.Add(orderaddedtime);
            inputset.Add(orderproduct);
<<<<<<< HEAD
            inputset.Add(quantity);
            inputset.Add(productID);
            //Object.setObject(inputset);
            //neworder.setOrderId(orderID);
            //neworder.setOrderDate(ordertime);
            //neworder.addorderentry(quantity, product);
=======
            inputset.Add(quantityString);
            inputset.Add(productIDString);
            Object.setObject(inputset);
>>>>>>> master
        }
        public void pickuporder(DateTime pickeduptime)
        {
            orderpickedup.setPickedUpBy(this.agencyName);
            orderpickedup.setPickUpDateAndTime(pickeduptime); //ordertime has to be given 
        }

        public void requestOrder(int orderId)
        {
        }
        public void editOrderquantity(int OrdereditID, int editorderquantity)
        {
            //Order editorder = getorder(OrdereditID); //Implement builder object
            //editorder.editordentryquantity(OrdereditID, editorderquantity);
            //editorder.passtobuilder(editorder);


        }
        public void editOrderproduct(int OrdereditID, Product editorderproduct)
        {
            //Order editorder = getorder(OrdereditID); //Implement builder object
            //editorder.editordentryproduct(OrdereditID, editorderproduct);
        }
        //public Order viewOrderSummary(int orderid)
        //{
            //return getorder(orderid);//Implement builder object
        //}
        public void removeOrder(int orderid)
        {//  remove a record 


        }
        public void removeOrderentry(int orderid, int orderentryid)
        {
            //Order editorder = getorder(OrdereditID); //Implement builder object
            //editorder.deleteorderentry(orderentryid);

        }

        public bool requestOrder(Order order)
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
    }

}
