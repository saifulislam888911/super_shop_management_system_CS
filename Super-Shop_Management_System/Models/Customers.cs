using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Shop_Management_System.Models
{
    public class Customers
    {
        SqlConnection conn;
        public Customers() { }

        public Customers(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddCustomer(Customer user)
        {
            conn.Open();
            string query = string.Format("INSERT INTO Customers VALUES ('{0}','{1}','{2}')", user.Name, user.Username, user.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }



        public Customer AuthenticateCustomer(string username, string password)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Customers WHERE Username='{0}' AND Password='{1}'", username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Customer user = null;
            while (reader.Read())
            {
                user = new Customer();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                user.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return user;
        }



        public ArrayList GetAllCustomers()
        {
            ArrayList Customers = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Customers";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Customer user = new Customer();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                user.Password = reader.GetString(reader.GetOrdinal("Password"));

                Customers.Add(user);
            }
            conn.Close();
            return Customers;
        }
        public Customer GetCustomer(string username)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Customers WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Customer user = null;
            while (reader.Read())
            {
                user = new Customer();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                user.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return user;
        }

        public bool UpdateCustomer(Customer user)
        {
            conn.Open();
            string query = string.Format("UPDATE Customers SET Name='{0}' WHERE Username='{1}'", user.Name, user.Username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

        public bool DeleteCustomer(string username)
        {
            conn.Open();
            string query = string.Format("DELETE FROM Customers WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
    }
}
