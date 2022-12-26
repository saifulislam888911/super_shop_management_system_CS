using Super_Shop_Management_System.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Shop_Management_System.Controllers
{
    public class ProductController
    {
        static Database db3 = new Database();
        public static Product AuthenticateProduct(string username, string password)
        {
            return db3.Products.AuthenticateProduct(username, password);
        }

        public static bool AddProduct(dynamic user)
        {
            Product u = new Product();
            u.Name = user.Name;
            u.Price = user.Price;
            //u.Quantity = user.Quantity;
            u.CategoryId = user.CategoryId;
            //var u = (User)user;//boxing---> it was not working because this is user type and registration form btnclick is anonymous type

            return db3.Products.AddProduct(u);
        }

        public static Product GetProduct(string username)
        {
            return db3.Products.GetProduct(username);
        }

        public static bool UpdateProduct(dynamic user)
        {
            Product u1 = new Product();
            u1.Price = user.Price;
            u1.Name = user.Name;

            return db3.Products.UpdateProduct(u1);
        }
        public static bool DeleteProduct(string username)
        {
            return db3.Products.DeleteProduct(username);
        }
        public static ArrayList GetAllProducts()
        {
            return db3.Products.GetAllProducts();
        }
    }
}
