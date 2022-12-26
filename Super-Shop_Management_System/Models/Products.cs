using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Shop_Management_System.Models
{
    public class Products
    {
        //void Add() { }
        //void Update() { }
        //void Delete() { }
        SqlConnection conn;
        public Products() { }

        public Products(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddProduct(Product user)
        {
            conn.Open();
            string query = string.Format("INSERT INTO Products VALUES ('{0}','{1}','{2}')", user.Name, user.Price, user.CategoryId);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }



        public Product AuthenticateProduct(string username, string password)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Products WHERE Name='{0}' AND Price='{1}'", username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Product user = null;
            while (reader.Read())
            {
                user = new Product();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Price = reader.GetString(reader.GetOrdinal("Price"));
                //user.Quantity = reader.GetString(reader.GetOrdinal("Quantity"));
                user.CategoryId = reader.GetString(reader.GetOrdinal("CategoryId"));
            }
            conn.Close();
            return user;
        }



        public ArrayList GetAllProducts()
        {
            ArrayList Products = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product user = new Product();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Price = reader.GetString(reader.GetOrdinal("Price"));
                //user.Quantity = reader.GetString(reader.GetOrdinal("Quantity"));
                user.CategoryId = reader.GetString(reader.GetOrdinal("CategoryId"));

                Products.Add(user);
            }
            conn.Close();
            return Products;
        }
        public Product GetProduct(string username)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Products WHERE Name='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Product user = null;
            while (reader.Read())
            {
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Price = reader.GetString(reader.GetOrdinal("Price"));
                //user.Quantity = reader.GetString(reader.GetOrdinal("Quantity"));
                user.CategoryId = reader.GetString(reader.GetOrdinal("CategoryId"));
            }
            conn.Close();
            return user;
        }

        public bool UpdateProduct(Product user)
        {
            conn.Open();
            string query = string.Format("UPDATE Products SET Name='{0}' WHERE Price='{1}'", user.Name, user.Price);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

        public bool DeleteProduct(string name)
        {
            conn.Open();
            string query = string.Format("DELETE FROM Products WHERE Name='{0}'", name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
    }
}
