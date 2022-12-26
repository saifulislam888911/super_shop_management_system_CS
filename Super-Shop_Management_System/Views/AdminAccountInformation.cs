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
    public partial class AdminAccountInformation : Form
    {
        public AdminAccountInformation()
        {
            InitializeComponent();
            var ds = AdminController.GetAllAdmins();
            dataGridViewAdminInfo.DataSource = ds;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new AdminPage().Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string username = textBoxSearch.Text;
            dynamic user = AdminController.GetAdmin(username);
            if (user != null)
            {
                textBoxName.Text = user.Name;
                textBoxUsername.Text = user.Username;
                textBoxPassword.Text = user.Password;
                
            }
            else
            {
                textBoxName.Text = "";
                textBoxUsername.Text = "";
                MessageBox.Show("No Manager Found");
            }
        }


        private void dataGridViewAdminInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
