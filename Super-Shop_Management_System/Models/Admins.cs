using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Shop_Management_System.Models
{
    public class Admins
    {
        SqlConnection conn;
        public Admins() { }

        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddAdmin(Admin user)
        {
            conn.Open();
            string query = string.Format("INSERT INTO Admins VALUES ('{0}','{1}','{2}')", user.Name, user.Username, user.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }



        public Admin AuthenticateAdmin(string username, string password)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Admins WHERE Username='{0}' AND Password='{1}'", username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin user = null;
            while (reader.Read())
            {
                user = new Admin();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                user.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return user;
        }



        public ArrayList GetAllAdmins()
        {
            ArrayList Admins = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Admins";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Admin user = new Admin();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                user.Password = reader.GetString(reader.GetOrdinal("Password"));

                Admins.Add(user);
            }
            conn.Close();
            return Admins;
        }
        public Admin GetAdmin(string username)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Admins WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin user = null;
            while (reader.Read())
            {
                user = new Admin();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                user.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return user;
        }

        public bool UpdateAdmin(Admin user)
        {
            conn.Open();
            string query = string.Format("UPDATE Admins SET Name='{0}' WHERE Username='{1}'", user.Name, user.Username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

        public bool DeleteAdmin(string username)
        {
            conn.Open();
            string query = string.Format("DELETE FROM Admins WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
    }
}
