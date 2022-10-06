using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLayer.SpecialComponents;

namespace AppLayer.Components.User
{
    public partial class AreaUser : Form
    {
        public AreaUser(string kindAction)
        {
            InitializeComponent();
            //UserControl[] UCs= { addUser1,deleteUser1,showUser1,updateUser2};
            //HelpFunc.hideAndShowUC(UCs, kindAction,(Form)this.Parent);

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //this.Close();
            DataAccessLayer.Entities.User user = new DataAccessLayer.Entities.User()
            {
                Id = "3",
                Email = "a",
                FirstName = "a",
                LastName = "b",
                Password = "c",
                Type = true
            };
            //updateUser1 = new UpdateUser(user);
            updateUser2.user = user;
            updateUser2.Show();
        }
    }
}
