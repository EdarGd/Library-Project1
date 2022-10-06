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
using BusinessLogicLayer.StoredProceduresLogic;

namespace AppLayer.Components.Book
{
    public partial class AreaBook : Form
    {
        public AreaBook(string kindAction)
        {
            InitializeComponent();
            updateBook1.Hide();
            addBook2.Hide();
            DataAccessLayer.Entities.Book book = new DataAccessLayer.Entities.Book()
            {
                Code = "a",
                FirstName_Author = "b",
                LastName_Author = "c",
                Title = "d",
                PublicationDate = DateTime.Now,
                Category = "A",
                SecondaryCategory = "B"
            };

            updateBook1.setBook(book);
            updateBook1.Show();
            updateBook1.Focus();

            //UserControl[] UCsBook = { addBook1, deleteBook1, showBook1, updateBook1 };
            //HelpFunc.hideAndShowUC(UCsBook, kindAction, this.Owner);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.Close();

        }

        private void updateBook1_Load(object sender, EventArgs e)
        {

        }

        private void addBook1_Load(object sender, EventArgs e)
        {

        }
    }
}
