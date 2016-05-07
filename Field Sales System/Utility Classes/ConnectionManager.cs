using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Field_Sales_System.Utility_Classes
{
    
    public class ConnectionManager
    {
        public bool isOnline()
        {
            string url = "http://www.google.com";
            try
            {
                WebRequest myRequest = WebRequest.Create(url);
                WebResponse myResponse = myRequest.GetResponse();
            }
            catch (System.Net.WebException)
            {
                return false;
            }
            return true;

        }

        public MySqlConnection connectDatabase()
        {
            try
            {
                return new MySqlConnection(Properties.Settings.Default.dbServerConnectionString);
            }
            catch (Exception e) {
                return null;
            }
        }

        public MySqlConnection openConnection(MySqlConnection connection) {
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception e) {
                return null;
            }
        }

        public void closeConnection(MySqlConnection connection) {
            connection.Close();
        }

        public ArrayList readRecord(int empId, MySqlConnection connection,string table) {
            try
            {
                string command = "SELECT * FROM "+table+" WHERE empId = " + empId + ";";
                MySqlCommand c = new MySqlCommand(command, connection);
                MySqlDataReader reader = c.ExecuteReader();
                ArrayList userData = new ArrayList();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    reader.Read();
                    userData.Add(reader[i]);
                }
                return userData;
            }
            catch (Exception e) {
                return null;
            }
            
        }

        public bool writeRecord(ArrayList empData,ArrayList type, MySqlConnection connection,string table) {
            

            try
            {
                if (empData.Count != type.Count)
                {
                    return false;
                }
                else
                {
                    string command = "INSERT INTO " + table + " (";
                    for (int i = 0; i < type.Count; i++)
                    {
                        command += type[i];
                        if (i == (type.Count-1))
                        {
                            break;
                        }
                        command += " , ";
                    }
                    command += ") VALUES ( ";
                    for (int i = 0; i < empData.Count; i++)
                    {

                        if (empData[i].GetType().Equals("".GetType()))
                        {
                            command += ("\"" + empData[i] + "\"");
                        }
                        else {
                            command += empData[i];
                        }
                        

                        if (i == (empData.Count-1))
                        {
                            break;
                        }
                        command += " , ";
                    }
                    command += ");";

                    MySqlCommand cmd = new MySqlCommand(command, connection);
                    cmd.ExecuteNonQuery();
                    return true;

                }
                
            }
            catch (Exception e) {
                return false;
            }
            

        }

        public bool modifyRecord(int empId, ArrayList columns, ArrayList values, string table, MySqlConnection connection) {
            try
            {
                string command = "update " + table + " set ";
                for (int i = 0; i < columns.Count; i++)
                {
                    if (values[i].GetType().Equals("".GetType()))
                    {
                        command += columns[i] + " = " + "\"" + values[i] + "\"";
                    }
                    else
                    {
                        command += columns[i] + " = " + values[i];
                    }
                    
                    if (i != columns.Count - 1)
                    {
                        command += " , ";
                    }
                }
                command += " where empId=" + empId+" ;";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                return false;
            }

            
        }




    }

        
}
