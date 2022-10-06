using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLayer.Components.Single.Show
{
    public partial class showFormUser : Form
    {
        public showFormUser(DataAccessLayer.Entities.User showUser)
        {
            InitializeComponent();
            id.Text = showUser.Id;
            firstName.Text = showUser.FirstName;
            lastName.Text = showUser.LastName;
            email.Text = showUser.Email;
            if (showUser.Type)
                userType.Text = "Worker";
            else
                userType.Text =  "Library subscription";
            password.Text = showUser.Password;

        }
    }
}
