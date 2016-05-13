﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Field_Sales_System.Utility_Classes;
using System.Collections;

namespace Field_Sales_System.Business_Logic
{
    class Agent : User, OrderManagement
    {
        private string agencyName;
        private string coverageArea;
        OrderPickupSchedule orderpickedup;
        ObjectFactory Object;
       

        public Agent(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string address, string url)
            : base(empId, empNIC, gender, firstName, lastName, mobileNo, landNo, email, address, url)
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

        public void placeorder(int orderID, DateTime orderaddedtime, string orderproduct, int quantity, int productID)
        {
            ArrayList inputset = new ArrayList();
            inputset.Add(orderID);
            inputset.Add(orderaddedtime);
            inputset.Add(orderproduct);
            inputset.Add(quantity);
            inputset.Add(productID);
            Object.setObject(inputset);
            neworder.setOrderId(orderID);
            neworder.setOrderDate(ordertime);
            neworder.addorderentry(quantity, product);
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
            Order editorder = getorder(OrdereditID); //Implement builder object
            editorder.editordentryquantity(OrdereditID, editorderquantity);
            editorder.passtobuilder(editorder);


        }
        public void editOrderproduct(int OrdereditID, Product editorderproduct)
        {
            Order editorder = getorder(OrdereditID); //Implement builder object
            editorder.editordentryproduct(OrdereditID, editorderproduct);
        }
        public Order viewOrderSummary(int orderid)
        {
            return getorder(orderid);//Implement builder object
        }
        public void removeOrder(int orderid)
        {//  remove a record 


        }
        public void removeOrderentry(int orderid, int orderentryid)
        {
            Order editorder = getorder(OrdereditID); //Implement builder object
            editorder.deleteorderentry(orderentryid);

        }
    }

}
