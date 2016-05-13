using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Field_Sales_System.Business_Logic;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Windows.Documents;

namespace Field_Sales_System.Utility_Classes
{
    class ObjectFactory
    { ObjectExtractor chekcObjects;
        ArrayList memoryStack = new ArrayList();

        //Tracker Method
        private StackTrace checker()
    {
        StackTrace stackTrace = new StackTrace();
        return stackTrace;

    }



    // Method to set objects 
        object send;
        public Object setObject(ArrayList inputset)
        {
            // Get calling method name
            Console.WriteLine(this.checker().GetFrame(1).GetMethod().Name);
            String check = this.checker().GetFrame(1).GetMethod().Name;
            switch (check)
            {

               case "placeorder":

                    {
                        int[] quantity = Array.ConvertAll((Convert.ToString(inputset[3])).Split(','), int.Parse);
                        int[] productID = Array.ConvertAll((Convert.ToString(inputset[4])).Split(','), int.Parse);
                  
                        //object send = this.neworder(Convert.ToInt32(inputset[0]), Convert.ToDateTime(inputset[1]), Convert.ToDateTime(inputset[2]), quantity, productID);
                        return send;
                    }

            }
            return null;
        }




        


        //Method to get objects
        public Object getObject(ArrayList inputget)
        {
            Console.WriteLine(this.checker().GetFrame(1).GetMethod().Name);
            String check = this.checker().GetFrame(1).GetMethod().Name;
            switch (check)
            {
                case "addtext":
                    {
                        return null;
                    }

            }
            return null;
        }







        /*
        //Create new order
        private Object neworder(int OrderID, DateTime OrderaddedDate, DateTime OrderRequestedDate, int[] quantity, int[] productID)
        {

            OrderProcessDetails gotprocessDetails = getOrderProcessDetails();
           // Order neworder = new Order(OrderID, OrderaddedDate, OrderRequestedDate, gotprocessDetails);
            for (int i = 0; i < quantity.Length; i++)
            {
                int entryID = neworder.getentrysize();
                //OrderEntry orderedProductEntry = this.setProductEntry(entryID, productID[i], quantity[i] );
                //neworder.addorderentry(orderedProductEntry);

            }
            return null;

        }
        */

       
       
        //Create Orderentry
        /*private OrderEntry setProductEntry(int entryID, int ProductID, int Quantity)
        {
            Product gotProduct = (getProduct(ProductID)[0]);
            //OrderEntry newEntry= new OrderEntry(entryID, Quantity , gotProduct);
            return newEntry;
        }*/




      
        //set OrderProcessDetails
        private OrderProcessDetails getOrderProcessDetails()
        {
            OrderProcessDetails gotOrderProcessDetails = new OrderProcessDetails() ;
            return gotOrderProcessDetails;
        }




        //Get Product Method
        private List<Product> getProduct(int ProductID)

        {
          
            List<Product> gotproduct =(cache(ProductID)).Cast<Product>().ToList();
            return gotproduct;
        }




        //Memory Stack and Connection
        private List<Object> cache(int inputvalue=-1, String inputCode = "none")
        {   if (inputCode.Equals("none"))
            {
                inputCode = Convert.ToString(inputvalue);
            }
            List<Object> sendlist = new List<object>();
            Type Mytype = Type.GetType("parminfo");
            String check = this.checker().GetFrame(1).GetMethod().Name;
            //Get and display the method.
            MethodBase Mymethodbase = Mytype.GetMethod(check);
        

            //Get the ParameterInfo array.
            ParameterInfo[] Myarray = Mymethodbase.GetParameters();

            //Get and display the ParameterInfo of each parameter.
            foreach (ParameterInfo Myparam in Myarray)
            {
                foreach (Object Obj in memoryStack)
                {
                    if (chekcObjects.Checkmatching(Obj, inputCode, Myparam.Name))
                    {
                        sendlist.Add(Obj);
                    }
                }
                //sendlist = Connect.Connect(sendlist, Myarray[0].Name, inputvalue, inputCode);
                foreach (Object obj in sendlist)
                {
                    if (memoryStack.Contains(obj))
                    { }
                    else {
                        memoryStack.Add(obj);
                    }
                }
            }
            return null;
        }



        public User crerateUser(int empId, int empNIC, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img, string userRole, List<Permission> permissions)
        {
            try
            {

                switch(userRole)
                {
                    case "Representative":
                    
                        User rep = new Representative(empId, empNIC, gender, firstName, lastName, mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3, img);
                        ContactDetails c = new ContactDetails(mobileNo, landNo, email, addressLine_1, addressLine_2, addressLine_3);
                        UserRole ur = new UserRole();
                        ur.setRoleName(userRole);
                        for (int i = 0; i < permissions.Count; i++)
                        {
                            ur.addPermission(permissions[i]);
                        }


                        return rep;
                    
                }
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
