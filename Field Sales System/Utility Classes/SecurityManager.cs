using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Collections;
using Field_Sales_System.Business_Logic;

namespace Field_Sales_System.Utility_Classes
{
    public class SecurityManager : ISecurityManager
    {
        private ConnectionManager dbManager = new ConnectionManager();
        private MySqlConnection connection = new MySqlConnection();

        public SecurityManager()
        {
            connection = dbManager.connectDatabase(Properties.Settings.Default.dbServerConnectionString);
        }
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
        public string login(int empId, string password) {


            bool isOnline = false;
            isOnline = dbManager.isOnline();
            if (isOnline)
                    {
                        connection = dbManager.openConnection(connection);
                        if (connection !=null)

                        {
                            List<object> arr = c.retrieveLoginInfo(connection, empId);
                            bool pwdMatch = false;
                            bool isActive = false;
                            bool userNotExisting = false;
                            if (arr != null)
                            {
                                pwdMatch = computeHash(password).Equals(arr[1].ToString());
                                isActive = (bool)arr[2];
                            }
                            else {
                                pwdMatch = false;
                                userNotExisting = true;
                            }

                            if (connection.State == System.Data.ConnectionState.Open)
                            {
                                dbManager.closeConnection(connection);
                            }


                            if (pwdMatch && isActive)
                            {

                                return "Successfully logged in!";
                            }
                            else {
                                if (isActive)
                                {
                                    return "Wrong password! Try again!";
                                }
                                else {
                                    if (userNotExisting)
                                    {
                                        return "Requested user is not existing. Contact administrator!";
                                    }
                                    else {
                                        return "Requested user is not active. Contact administrator!";
                                    }

                                }

                            }

                        }
                        else {
                            return "Error! Cannot establish a connection with database. Try again later.";
                        }

                    }
                    else {
                        return "Error! No internet connection! Fix the internet connection and try again.";
                    }
                       
                
    }

        //this method can be used to change the password of a user
        //return value determines the status of the operation
        public string modifyPassword(int empId, string oldPassword, string newPassword) {
            if (login(empId, oldPassword).Equals("Successfully logged in!"))
            {
                //old password is wrong
                return "Your old password is wrong!";
            }
            else {
                if (dbManager.isOnline())
                {
                    connection = dbManager.openConnection(connection);
                    if (!connection.Equals(null))
                    {

                        bool b = dbManager.modifyLoginInfo(connection, empId, computeHash(newPassword));
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            dbManager.closeConnection(connection);
                        }

                        if (b)
                        {

                            return "Successfully changed password!";
                        }
                        else {
                            return "There was some error during password change. Try again!";
                        }

                    }
                    else {
                        return "Error! Cannot establish a connection with database. Try again later.";
                    }

                }
                else {
                    return "Error! No internet connection! Fix the internet connection and try again.";
                }

            }

        }

        public string addUserLoginInformation(int empId, string password) {
            if (dbManager.isOnline())
            {
                connection = dbManager.openConnection(connection);
                if (!connection.Equals(null))
                {
                    string pwdHash = computeHash(password);
                    bool b = dbManager.storeLoginInfo(connection,empId,pwdHash);
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        dbManager.closeConnection(connection);
                    }

                    if (b)
                    {

                        return "Success!";
                    }
                    else {
                        return "There was some error during password change. Try again!";
                    }

                }
                else {
                    return "Error! Cannot establish a connection with database. Try again later.";
                }

            }
            else {
                return "Error! No internet connection! Fix the internet connection and try again.";
            }
        }

        public string modifyStatus(int empId,int status) {
            if (dbManager.isOnline())
            {
                connection = dbManager.openConnection(connection);
                if (!connection.Equals(null))
                {

                    bool b = dbManager.modifyLoginInfo(connection,empId,"",status);
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        dbManager.closeConnection(connection);
                    }

                    if (b)
                    {

                        return "Successfully changed password!";
                    }
                    else {
                        return "There was some error during password change. Try again!";
                    }

                }
                else {
                    return "Error! Cannot establish a connection with database. Try again later.";
                }

            }
            else {
                return "Error! No internet connection! Fix the internet connection and try again.";
            }
        }

        public string requestPasswordReset(int empId) {
            if (dbManager.isOnline())
            {
                connection = dbManager.openConnection(connection);
                if (!connection.Equals(null))
                {

                    bool b = dbManager.modifyLoginInfo(connection, empId, "", -1, 1);
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        dbManager.closeConnection(connection);
                    }

                    if (b)
                    {

                        return "Successfully sent password reset request";
                    }
                    else {
                        return "There was some error during the request. Try again!";
                    }

                }
                else {
                    return "Error! Cannot establish a connection with database. Try again later.";
                }

            }
            else {
                return "Error! No internet connection! Fix the internet connection and try again.";
            }

        }

        public string modifyPasswordAdmin(int empId, string newPassword) {
            if (dbManager.isOnline())
            {
                connection = dbManager.openConnection(connection);
                if (!connection.Equals(null))
                {

                    bool b = dbManager.modifyLoginInfo(connection, empId, computeHash(newPassword));
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        dbManager.closeConnection(connection);
                    }

                    if (b)
                    {

                        return "Successfully changed password!";
                    }
                    else {
                        return "There was some error during password change. Try again!";
                    }

                }
                else {
                    return "Error! Cannot establish a connection with database. Try again later.";
                }

            }
            else {
                return "Error! No internet connection! Fix the internet connection and try again.";
            }
        }

        public List<int> getPasswordResetRequests() {
            if (dbManager.isOnline())
            {
                connection = dbManager.openConnection(connection);
                if (!connection.Equals(null))
                {
                    List<int> arr = dbManager.retrievePasswordResetRequests(connection); 
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        dbManager.closeConnection(connection);
                    }
                    return arr;
                    
                }
                else {
                    return null;
                }

            }
            else {
                return null;
            }
        }

    }


    }

        

    

