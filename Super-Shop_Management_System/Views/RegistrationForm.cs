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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var user = new
            {
                Name = textBoxName.Text,
                Username = textBoxUsername.Text,
                Password = textBoxPassword.Text
            };
            var result1 = CustomerController.AddCustomer(user);//var result=
            if (result1)
            {
                MessageBox.Show("Customer Added");
            }
            else
            {
                MessageBox.Show("Could not Add Customer");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
        }

        private void btnManagerRegister_Click(object sender, EventArgs e)
        {
            new ManagerRegistrationForm().Show();
        }

        private void btnEmployeeRegister_Click(object sender, EventArgs e)
        {
            new EmployeeRegistrationForm().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminRegistrationForm().Show();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
