using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Field_Sales_System.Utility_Classes
{
    public class SecurityManager
    {
        ConnectionManager c = new ConnectionManager();
        public string computeHash(String pwd) {
            SHA256Cng hashFunction = new SHA256Cng();
            byte[] pwdBytes = System.Text.Encoding.ASCII.GetBytes(pwd);
            byte[] pwdHash = hashFunction.ComputeHash(pwdBytes);
            StringBuilder password = new StringBuilder();
            for (int i = 0; i < pwdHash.Length; i++) {
                password.Append(pwdHash[i].ToString("X3"));
            }
            return password.ToString();
            
        }

        //following method is used to authenticate the login of a user
        public bool login(int empId, string password) {
            
            MySqlConnection connection = c.connectDatabase(Properties.Settings.Default.dbServerConnectionString);
            c.openConnection(connection);
            ArrayList arr = c.readRecord(connection, "users",empId);
            if (computeHash(password).Equals(arr[1]))
            {
                return true;
            }
            else {
                return false;
            }
        }

        //this method can be used to change the password of a user
        //return value determines the status of the operation
        public int modifyPassword(int empId, string oldPassword, string newPassword) {
            if (!login(empId, oldPassword))
            {
                //old password is wrong
                return 0;
            }
            else {
                try
                {
                    string pwd = computeHash(newPassword);
                    MySqlConnection connection = c.connectDatabase(Properties.Settings.Default.dbServerConnectionString);
                    c.openConnection(connection);
                    ArrayList columns = new ArrayList();
                    columns.Add("pwdHash");
                    ArrayList values = new ArrayList();
                    values.Add(computeHash(newPassword));
                    c.modifyRecord(empId, columns, values, "users", connection);
                    return 1;
                }
                catch (Exception e) {
                    //failed with exception
                    return -1;
                }

            }
        }

        public bool modifyStatus(int empId,bool status) {
            try
            {
                MySqlConnection connection = c.connectDatabase(Properties.Settings.Default.dbServerConnectionString);
                c.openConnection(connection);
                ArrayList columns = new ArrayList();
                columns.Add("status");
                ArrayList values = new ArrayList();
                values.Add(status);
                c.modifyRecord(empId, columns, values, "users", connection);
                return true;
            }
            catch (Exception e) {
                return false;
            }
        }

        

    }
}
