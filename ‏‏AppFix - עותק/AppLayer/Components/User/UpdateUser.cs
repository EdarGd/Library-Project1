using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLayer.Components.User
{
    public partial class UpdateUser : UserControl
    {
        public DataAccessLayer.Entities.User user;

        public UpdateUser()
        {
            InitializeComponent();
        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            if (user != null)
            {
                id.Text = user.Id;
                password.Text = user.Password;
                firstName.Text = user.FirstName;
                lastName.Text = user.LastName;
                email.Text = user.Email;
                if (user.Type)
                    type.SelectedIndex = 0;
                else
                    type.SelectedIndex = 1;
            }
        }
    }
}
