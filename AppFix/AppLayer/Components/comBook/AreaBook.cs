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
using AppLayer.SpecialComponents;
using DataAccessLayer.Entities;

namespace AppLayer.Components.comBook
{
    public partial class AreaBook : Form
    {
        string kindActionNow;
        Book book;
        public string KindActionNow
        {
            get { return kindActionNow; }
            set { kindActionNow = value; }
        }
        public Book Book
        {
            get { return book; }
            set { book = value; }
        }
        public AreaBook(string kindAction,Book sentBook)
        {
            InitializeComponent();

            Book book = new Book()
            {
                Code = "a",
                FirstName_Author = "b",
                LastName_Author = "c",
                Title = "d",
                PublicationDate = DateTime.Now,
                Category = "A",
                SecondaryCategory = "B"
            };

            if(sentBook == null)
            {
                Book = book;
            }

            kindActionNow = kindAction;

            if (Book != null)
            {
                switch (KindActionNow)
                {
                    case "Add":
                        addBook2.Book = book;
                        break;
                }
            }


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

        private void AreaBook_Load(object sender, EventArgs e)
        {
            if (Book != null)
            {
                switch (KindActionNow)
                {
                    case "Add":
                        addBook2.Book = book;
                        break;
                }
            }
            UserControl[] UCsBook = { addBook2, deleteBook1, showAllBooks1, showSearchBook1, updateBook1 };
            HelpFunc.hideAndShowUC(UCsBook, KindActionNow, this.MdiParent);
           
            
        }
    }
}
