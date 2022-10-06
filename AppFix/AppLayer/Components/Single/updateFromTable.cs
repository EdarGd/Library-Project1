using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppLayer.Components;

namespace AppLayer.Components.Single
{
    public partial class updateFromTable : Form
    {
        public updateFromTable(Object objUpdate,string kindUpdate)
        {
            InitializeComponent();
            foreach(UserControl userControl in this.Controls)
            {
                userControl.Hide();
            }
            showBook3.Show();
            //showBorrow1.Show();
            //showUser1.Show();
            //switch(kindUpdate)
            //{
            //    case "Book":
            //        updateBook1 = new Book.UpdateBook(objUpdate as DataAccessLayer.Entities.Book);
            //        updateBook1.Show();
            //        this.Controls.Add(updateBook1);
            //        break;
            //    case "Borrow":
            //        updateBorrow1.Show();
            //        break;
            //    case "existingCategory":
            //        updateExistingCategories1.Show();
            //        break;
            //    case "user":
            //        updateUser1.Show();
            //        break;
            //}
        }
    }
}
