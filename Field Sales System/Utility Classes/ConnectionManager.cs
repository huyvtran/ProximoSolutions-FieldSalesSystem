using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using Field_Sales_System.Business_Logic;
using System.Runtime.Serialization.Formatters.Binary;

namespace Field_Sales_System.Utility_Classes
{
    [Serializable]
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

        public MySqlConnection connectDatabase(string conString)
        {
            try
            {
                return new MySqlConnection(conString);
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

        public List<User> retrieveUser(MySqlConnection connection,int empId = 0,string empFName="",string empLName="") {
            try
            {
                string command = "SELECT * FROM employee WHERE empId = @eId or firstName=@fName or lastName=@lName;";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.Parameters.Add("@eId", MySqlDbType.Int32);
                cmd.Parameters.Add("@fName", MySqlDbType.VarChar);
                cmd.Parameters.Add("@lName", MySqlDbType.VarChar);
                cmd.Parameters["@eId"].Value = empId;
                cmd.Parameters["@fName"].Value = empFName;
                cmd.Parameters["@lName"].Value = empLName;
                MySqlDataReader reader = cmd.ExecuteReader();
                List<User> userData = new List<User>();
                while (reader.Read()) {
                    BinaryFormatter bin = new BinaryFormatter();
                    MemoryStream ms = new MemoryStream((byte[])reader[3]);
                    ms.Seek(0, SeekOrigin.Begin);
                    userData.Add((User)bin.Deserialize(ms));
                }
                    
                    
                
                return userData;
            }
            catch (Exception e) {
                return null;
            }
            
        }

        public List<Object> retrieveLoginInfo(MySqlConnection connection, int empId) {
            try
            {
                string command = "SELECT * FROM user WHERE empId = @eId;";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.Parameters.Add("@eId", MySqlDbType.Int32);              
                cmd.Parameters["@eId"].Value = empId;
                MySqlDataReader reader = cmd.ExecuteReader();
                List<Object> userData = new List<Object>();
                reader.Read();
                for (int i = 0; i < reader.FieldCount; i++)
                {                   
                    userData.Add(reader[i]);
                }
                return userData;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool storeUser(User user, MySqlConnection connection) {
            

            try
            {   
                string command = "INSERT INTO employee (empId,firstName,lastName,employee) values(@empId,@fName,@lName,@employee)";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.Parameters.Add("@empId", MySqlDbType.Int64);
                cmd.Parameters.Add("@fName", MySqlDbType.VarChar);
                cmd.Parameters.Add("@lName", MySqlDbType.VarChar);
                cmd.Parameters.Add("@employee", MySqlDbType.MediumBlob);
                MemoryStream ms = new MemoryStream();
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, user);
                cmd.Parameters["@empId"].Value = user.getEmpId();
                cmd.Parameters["@fName"].Value = user.getFirstName();
                cmd.Parameters["@lName"].Value = user.getLastName();
                cmd.Parameters["@employee"].Value = ms.ToArray();
                cmd.ExecuteNonQuery();
                return true;        
            }
            catch (Exception e) {
                return false;
            }
            

        }

        public bool storeContactDetails(int empId,ContactDetails contacts, MySqlConnection connection)
        {
            try
            {
                string command = "INSERT INTO contact_details (empId,contactDetails) values(@empId,@contactDetails)";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.Parameters.Add("@empId", MySqlDbType.Int64);
                cmd.Parameters.Add("@contactDetails", MySqlDbType.MediumBlob);
                MemoryStream ms = new MemoryStream();
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, contacts);
                cmd.Parameters["@empId"].Value = empId;
                cmd.Parameters["@contactDetails"].Value = ms.ToArray();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }


        }

        public List<ContactDetails> retrieveContactDetails(MySqlConnection connection, int empId)
        {
            try
            {
                string command = "SELECT * FROM contact_details WHERE empId = @eId";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.Parameters.Add("@eId", MySqlDbType.Int32);          
                cmd.Parameters["@eId"].Value = empId;               
                MySqlDataReader reader = cmd.ExecuteReader();
                List<ContactDetails> userData = new List<ContactDetails>();
                while (reader.Read())
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    MemoryStream ms = new MemoryStream((byte[])reader[1]);
                    ms.Seek(0, SeekOrigin.Begin);
                    userData.Add((ContactDetails)bin.Deserialize(ms));
                }



                return userData;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public bool modifyUser(User user, MySqlConnection connection) {
            try
            {
                string command = "update proximodb.employee set employee = @employee  where empId = @empId; ";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.Parameters.Add("@eId", MySqlDbType.Int32);
                cmd.Parameters["@eId"].Value = user.getEmpId();
                MemoryStream ms = new MemoryStream();
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, user);
                cmd.Parameters.Add("@employee", MySqlDbType.MediumBlob);
                cmd.Parameters["@employee"].Value = ms.ToArray();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                return false;
            }

            
        }

        public bool storeImage(int empId, Image image, MySqlConnection connection) {
            try
            {
                MemoryStream ms = new MemoryStream();
                image.Save(ms, ImageFormat.Jpeg);
                byte[] imageByteStream = ms.ToArray();
                string command = "insert into profile_picture(empId,picture) values(@empId,@userImage)";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.Parameters.Add("@userImage", MySqlDbType.MediumBlob);
                cmd.Parameters.Add("@empId", MySqlDbType.Int64);
                cmd.Parameters["@empId"].Value = empId;
                cmd.Parameters["@userImage"].Value = imageByteStream;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    return true;
                }
                else {
                    return false;
                }

                
            }
            catch (Exception e) {
                return false;
            }
        }

        public Image retrieveImage(int empId, MySqlConnection connection) {
            try
            {
                string command = "SELECT picture FROM profile_picture WHERE empId = @eId ;";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.Parameters.Add("@eId", MySqlDbType.Int32);  
                cmd.Parameters["@eId"].Value = empId;
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                MemoryStream ms = new MemoryStream((byte [])reader[0]);
                
                return Image.FromStream(ms);
            }
            catch (Exception e)
            {
                return null;
            }
            

        }




    }

        
}
