using System.Collections.Generic;

namespace Field_Sales_System.Utility_Classes
{
    public interface ISecurityManager
    {
        string computeHash(string pwd);
        string login(int empId, string password);
        string modifyPassword(int empId, string oldPassword, string newPassword);
        string modifyPasswordAdmin(int empId, string newPassword);
        string modifyStatus(int empId, int status);
        string requestPasswordReset(int empId);
        List<int> getPasswordResetRequests();
    }
}