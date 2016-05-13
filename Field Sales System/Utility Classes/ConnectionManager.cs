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
    public class ConnectionManager : IConnectionManager
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

        //retrieves all the fields from the table user which has login information for users
        
        //creates a new record for a user in the user table. 
        public bool storeLoginInfo(MySqlConnection connection, int empId, string pwdHash) {
            try
            {
                string command = "INSERT INTO user (empId,pwdHash,isActive,pwdReset) values(@empId,@pwdHash,@isActive,@pwdReset)";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.Parameters.Add("@empId", MySqlDbType.Int32);
                cmd.Parameters.Add("@pwdHash", MySqlDbType.VarChar);
                cmd.Parameters.Add("@isActive", MySqlDbType.Bit);
                cmd.Parameters.Add("@pwdReset", MySqlDbType.Bit);
                cmd.Parameters["@empId"].Value = empId;
                cmd.Parameters["@pwdHash"].Value = pwdHash;
                cmd.Parameters["@isActive"].Value = 1;
                cmd.Parameters["@pwdReset"].Value = 0;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                return false;
            }
        }

        public List<Object> retrieveLoginInfo(MySqlConnection connection, int empId) {
            try
            {
                string command = "SELECT * FROM user WHERE empId = @eId";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.Parameters.Add("@eId", MySqlDbType.Int32);
                cmd.Parameters["@eId"].Value = empId;
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                List<object> userData = new List<object>();
                for(int i = 0;i<reader.FieldCount;i++) {
                    userData.Add(reader[i]);
                }
                return userData;
            }
            catch (Exception e) {
                return null;
            }

        }
        //modifies login information of a given user default variables are set so this can be used for modifying any field in the database
        public bool modifyLoginInfo(MySqlConnection connection, int empId, string pwdHash = "", int isActive=-1, int pwdReset=-1) {
            try
            {
                if (!pwdHash.Equals("") && isActive == -1 && pwdReset == -1)
                {
                    string command = "update user set pwdHash = @pwdHash where empId = @empId; ";
                    MySqlCommand cmd = new MySqlCommand(command, connection);
                    cmd.Parameters.Add("@empId", MySqlDbType.Int32);
                    cmd.Parameters["@empId"].Value = empId;
                    cmd.Parameters.Add("@pwdHash", MySqlDbType.VarChar);
                    cmd.Parameters["@pwdHash"].Value = pwdHash;
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        return true;
                    }
                    else {
                        return false;
                    }
                }
                else if (pwdHash.Equals("") && isActive != -1 && pwdReset == -1)
                {
                    string command = "update user set isActive = @isActive where empId = @empId; ";
                    MySqlCommand cmd = new MySqlCommand(command, connection);
                    cmd.Parameters.Add("@empId", MySqlDbType.Int32);
                    cmd.Parameters["@empId"].Value = empId;
                    cmd.Parameters.Add("@isActive", MySqlDbType.Bit);
                    cmd.Parameters["@isActive"].Value = isActive;
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        return true;
                    }
                    else {
                        return false;
                    }
                }
                else if (pwdHash.Equals("") && isActive == -1 && pwdReset != -1)
                {
                    string command = "update user set pwdReset = @pwdReset where empId = @empId; ";
                    MySqlCommand cmd = new MySqlCommand(command, connection);
                    cmd.Parameters.Add("@empId", MySqlDbType.Int32);
                    cmd.Parameters["@empId"].Value = empId;
                    cmd.Parameters.Add("@pwdReset", MySqlDbType.Bit);
                    cmd.Parameters["@pwdReset"].Value = pwdReset;
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        return true;
                    }
                    else {
                        return false;
                    }
                }
                else {
                    return false;
                }
            }
            catch (Exception e) {
                return false;
            }
        }



        //retrieves user objects from database
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
      
        //stores a user in the database
        public bool storeUser(MySqlConnection connection, User user) {
            

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

        //modifies user object in the database with the input value
        public bool modifyUser(MySqlConnection connection, User user)
        {
            try
            {
                string command = "update employee set employee = @employee  where empId = @empId; ";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.Parameters.Add("@eId", MySqlDbType.Int32);
                cmd.Parameters["@eId"].Value = user.getEmpId();
                MemoryStream ms = new MemoryStream();
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, user);
                cmd.Parameters.Add("@employee", MySqlDbType.MediumBlob);
                cmd.Parameters["@employee"].Value = ms.ToArray();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }


        }
        //stores a contact details object in the database
        public bool storeContactDetails(MySqlConnection connection,int empId,ContactDetails contacts )
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
        //retrieves a list of contact details objects for a given user
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

        
        //stores an image given in the database
        public bool storeImage(MySqlConnection connection, int empId, Image image ) {
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
        //retrieves an Image object for a given user from the database
        public Image retrieveImage(MySqlConnection connection, int empId ) {
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
        //modifies an already existing image in the database
        public bool modifyImage(MySqlConnection connection, Image image, int empId) {
            try
            {
                MemoryStream ms = new MemoryStream();
                image.Save(ms, ImageFormat.Jpeg);
                byte[] imageByteStream = ms.ToArray();
                string command = "update profile_picture set picture = @userImage where empId = @empId";
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
        //stores a product object in the database
        public bool storeProduct(MySqlConnection connection, int productId, string productName, Product product) {
            try
            {
                string command = "INSERT INTO product (productId,productName,product) values(@productId,@productName,@product)";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.Parameters.Add("@productId", MySqlDbType.Int32);
                cmd.Parameters.Add("@productName", MySqlDbType.VarChar);
                cmd.Parameters.Add("@product", MySqlDbType.MediumBlob);
                MemoryStream ms = new MemoryStream();
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, product);
                cmd.Parameters["@productId"].Value = productId ;
                cmd.Parameters["@productName"].Value = productName;
                cmd.Parameters["@product"].Value = ms.ToArray();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                return false;
            }
        }
        //retrieves a list of products for given product name or productId
        public List<Product> retrieveProduct(MySqlConnection connection, int productId = -1, string productName = "") {
            try
            {

                string command = "SELECT * FROM product WHERE productId = @productId or productName = @productName";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.Parameters.Add("@productId", MySqlDbType.Int32);
                cmd.Parameters["@productId"].Value = productId;
                cmd.Parameters.Add("@productName", MySqlDbType.VarChar);
                cmd.Parameters["@productName"].Value = productName;
                MySqlDataReader reader = cmd.ExecuteReader();
                List<Product> userData = new List<Product>();
                while (reader.Read())
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    MemoryStream ms = new MemoryStream((byte[])reader[2]);
                    ms.Seek(0, SeekOrigin.Begin);
                    userData.Add((Product)bin.Deserialize(ms));
                }
                return userData;

            }
            catch (Exception e) {
                return null;
            }
        }
        //Modifies the given product object in the database
        public bool modifyProduct(MySqlConnection connection, Product product) {
            try
            {
                string command = "update product set productName = @productName, product = @product  where productId = @productId; ";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.Parameters.Add("@productId", MySqlDbType.Int32);
                cmd.Parameters["@productId"].Value = product.getProductID();
                cmd.Parameters.Add("@productName", MySqlDbType.VarChar);
                cmd.Parameters["@productName"].Value = product.getProductName();
                MemoryStream ms = new MemoryStream();
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, product);
                cmd.Parameters.Add("@product", MySqlDbType.MediumBlob);
                cmd.Parameters["@product"].Value = ms.ToArray();
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

        public bool storeEntry(MySqlConnection connection, DateTime dateTime, Object entry) {
            try
            {
                String command;
                int entererId;
                if (entry is DailySalesDetails)
                {
                    command = "insert into sales (sellerId,date,sales) values(@entererId,@date,@entry)";
                    entererId = ((DailySalesDetails)entry).getSubmitterID();
                }
                else if (entry is SalesReturn)
                {
                    command = "insert into return (returnerId,date,return) values(@entererId,@date,@entry)";
                    entererId = ((SalesReturn)entry).getSubmitterID();
                }
                else {
                    command = "";
                }
                if (command != "")
                {
                    MySqlCommand cmd = new MySqlCommand(command,connection);
                    cmd.Parameters.Add("@entererId", MySqlDbType.Int32);
                    cmd.Parameters.Add("@date", MySqlDbType.DateTime);
                    cmd.Parameters.Add("@entry", MySqlDbType.MediumBlob);
                    cmd.Parameters["entererId"].Value = entererId;
                    cmd.Parameters["@date"].Value = dateTime;
                    MemoryStream ms = new MemoryStream();
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ms, entry);
                    cmd.Parameters["@entry"].Value = ms.ToArray();
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

        //Need similar methods to store, retrieve, modify for displayPicture, Contact details, DailySalesReport, WeeklySalesReport,
        //Order,Warehouse, etc.. Assume there are such methods when you code for ObjectFactory




    }

        
}
