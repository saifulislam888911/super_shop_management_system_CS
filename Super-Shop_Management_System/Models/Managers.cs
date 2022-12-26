using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Shop_Management_System.Models
{
    public class Managers
    {
        SqlConnection conn;
        public Managers() { }

        public Managers(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddManager(Manager user)
        {
            conn.Open();
            string query = string.Format("INSERT INTO Managers VALUES ('{0}','{1}','{2}')", user.Name, user.Username, user.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }



        public Manager AuthenticateManager(string username, string password)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Managers WHERE Username='{0}' AND Password='{1}'", username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Manager user = null;
            while (reader.Read())
            {
                user = new Manager();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                user.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return user;
        }



        public ArrayList GetAllManagers()
        {
            ArrayList Managers = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Managers";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Manager user = new Manager();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                user.Password = reader.GetString(reader.GetOrdinal("Password"));

                Managers.Add(user);
            }
            conn.Close();
            return Managers;
        }
        public Manager GetManager(string username)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Managers WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Manager user = null;
            while (reader.Read())
            {
                user = new Manager();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                user.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return user;
        }

        public bool UpdateManager(Manager user)
        {
            conn.Open();
            string query = string.Format("UPDATE Managers SET Name='{0}' WHERE Username='{1}'", user.Name, user.Username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

        public bool DeleteManager(string username)
        {
            conn.Open();
            string query = string.Format("DELETE FROM Managers WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
    }
}
