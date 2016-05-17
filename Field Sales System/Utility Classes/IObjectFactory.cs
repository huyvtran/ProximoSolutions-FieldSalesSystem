using System;
using System.Collections.Generic;
using System.Drawing;
using Field_Sales_System.Business_Logic;

namespace Field_Sales_System.Utility_Classes
{
    public interface IObjectFactory
    {
        ContactDetails createContactDetails(int empId, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3);
        Permission createPermission(string permName, int permId);
        UserRole createUserRole(string userRole, List<Permission> permissions);
        List<DailySalesReport> getDailyReport(DateTime beginDate, DateTime endDate);
        List<DailySalesDetails> getDailySalesDetails(User validate_user, DateTime beginDate, DateTime endDate);
        List<Order> getOrder(User validate_user, DateTime beginDate, DateTime endDate);
        List<Order> getOrderByStatus(User validate_user, string status);
        Product getProduct(int productId = -1, string productName = "");
        List<SalesReturn> getSalesReturns(User validate_user, DateTime beginDate, DateTime endDate);
        User getUser(int empId);
        List<WeeklySalesReport> getWeeklyReport(DateTime beginDate, DateTime endDate);
        string modifyOrderStatus(Order updatedOrder, string orderStatus);
        string modifyProduct(Product product);
        string modifyUser(User user);
        ProductDetails newProductDetails(string category, int batchNo);
        List<User> searchUser(int empId = 0, string firstName = "", string lastName = "");
        OrderEntry setOrderEntry(Product product, int Quantity);
        string storeContactDetails(ContactDetails contact);
        string storeDailySalesDetails(DailySalesDetails dsd);
        string storeNewOrder(int orderID, DateTime OrderRequestedDate, List<OrderEntry> orderEntries, int placedEmpID);
        string storeNewProduct(string productName, int productId, string productDescription, float pricePerUnit, DisplayPicture productPicture, string category, int batchNo);
        string storeReport(object report);
        string storeSalesReturns(SalesReturn returns);
        string storeUser(int empId, int empNIC, DateTime DOB, bool gender, string firstName, string lastName, int mobileNo, int landNo, string email, string addressLine_1, string addressLine_2, string addressLine_3, Image img, string userType, List<UserRole> roles);
        Product updateProcuctDetails(Product product, int batchNo, DateTime MFD, DateTime EXP, string category);
        


    }
}