using Super_Shop_Management_System.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Shop_Management_System.Views
{
    public partial class NewProductAdd : Form
    {
        public NewProductAdd()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var user = new
            {
                Name = textBoxName.Text,
                Price = textBoxPrice.Text,
                CategoryId = textBoxCategoryId.Text
            };
            var result1 = ProductController.AddProduct(user);//var result=
            if (result1)
            {
                MessageBox.Show("Product Added");
            }
            else
            {
                MessageBox.Show("Could not Add Product");
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new AdminPage().Show();
        }
    }
}
