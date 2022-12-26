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
    public partial class CustomerAllinfomation : Form
    {
        public CustomerAllinfomation()
        {
            InitializeComponent();
            var ds = CustomerController.GetAllCustomers();
            dataGridViewCustomerInfo.DataSource = ds;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string username = textBoxSearch.Text;
            dynamic user = CustomerController.GetCustomer(username);
            if (user != null)
            {
                textBoxName.Text = user.Name;
                textBoxUsername.Text = user.Username;
            }
            else
            {
                textBoxName.Text = "";
                textBoxUsername.Text = "";
                MessageBox.Show("No Customer Found");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var user = new
            {
                Name = textBoxName.Text,
                Username = textBoxUsername.Text
            };
            bool result = CustomerController.UpdateCustomer(user);
            if (result)
            {
                MessageBox.Show("User Updated");
            }
            else
            {
                MessageBox.Show("Could not Update");
            }
            var ds = CustomerController.GetAllCustomers();
            dataGridViewCustomerInfo.DataSource = ds;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var r = CustomerController.DeleteCustomer(textBoxUsername.Text);
            if (r)
            {
                MessageBox.Show("Customer Deleted");
            }
            else
            {
                MessageBox.Show("Could not Delete");
            }
        }

        private void dataGridViewCustomerInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new AdminPage().Show();
        }
    }
}
