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
    public partial class AllProductsList : Form
    {
        public AllProductsList()
        {
            InitializeComponent();
            var ds = ProductController.GetAllProducts();
            dataGridViewAllProductList.DataSource = ds;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewAllProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllProductsList_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string name = textBoxSearch.Text;
            //dynamic user = ProductController.GetProduct(name);
            //if (user != null)
            //{
            //    textBoxProductName.Text = user.Name;
            //    textBoxPrice.Text = user.Price;
            //}
            //else
            //{
            //    textBoxProductName.Text = "";
            //    textBoxPrice.Text = "";
            //    MessageBox.Show("No Product Found");
            //}
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new AdminPage().Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //var user = new
            //{
            //    Name = textBoxProductName.Text,
            //    Price = textBoxPrice.Text
            //};
            //bool result = ProductController.UpdateProduct(user);
            //if (result)
            //{
            //    MessageBox.Show("Product Updated");
            //}
            //else
            //{
            //    MessageBox.Show("Could not Update");
            //}
            //var ds = ProductController.GetAllProducts();
            //dataGridViewAllProductList.DataSource = ds;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //var r = ProductController.DeleteProduct(textBoxProductName.Text);
            //if (r)
            //{
            //    MessageBox.Show("Product Deleted");
            //}
            //else
            //{
            //    MessageBox.Show("Could not Delete");
            //}
        }
    }
}
