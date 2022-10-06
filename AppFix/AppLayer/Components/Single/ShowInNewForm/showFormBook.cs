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
    public partial class showFormBook : Form
    {
        public showFormBook(DataAccessLayer.Entities.Book showBook)
        {
            InitializeComponent();
            code.Text = showBook.Code;
            firstNameAuthor.Text = showBook.FirstName_Author;
            lastNameAuthor.Text = showBook.LastName_Author;
            title.Text = showBook.Title;
            publicationDate.Text = showBook.PublicationDate.ToString("MM/dd/yy");
            category.Text = showBook.Category;
            secondaryCategory.Text = showBook.SecondaryCategory;

        }
    }
}
