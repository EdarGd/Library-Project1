using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLogicLayer.StoredProceduresLogic;
using AppLayer.SpecialComponents;
using DataAccessLayer.Entities;



namespace AppLayer.Components.comBook
{
    public partial class AddBook : UserControl
    {
        List<string> categories;
        List<string> secondaryCategorySelect;
        Book book;
        public Book Book
        {
            get { return book; }
            set { book = value; }
        }


        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            publicationDate.MaxDate = DateTime.Now;
            categories = new List<string>();
            secondaryCategorySelect = new List<string>();

            ExistingCategoriesFun.createCategories(categories, category);

            if (Book != null)
            {
                code.Text = book.Code;
                publicationDate.Value = book.PublicationDate;
                title.Text = book.Title;
                firstNameAuthor.Text = book.FirstName_Author;
                lastNameAuthor.Text = book.LastName_Author;
                category.Text = book.Category;
                secondaryCategory.Text = book.SecondaryCategory;
            }

            
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExistingCategoriesFun.category_SelectedIndexChanged(secondaryCategorySelect, secondaryCategory, category.Text);

        }
    }
}
