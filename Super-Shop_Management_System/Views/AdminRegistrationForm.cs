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
    public partial class AdminRegistrationForm : Form
    {
        public AdminRegistrationForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var user = new
            {
                Name = textBoxName.Text,
                Username = textBoxUsername.Text,
                Password = textBoxPassword.Text
            };
            var result1 = AdminController.AddAdmin(user);//var result=
            if (result1)
            {
                MessageBox.Show("Admin Added");
            }
            else
            {
                MessageBox.Show("Could not Add Admin");
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
