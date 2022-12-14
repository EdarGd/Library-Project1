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

namespace AppLayer.Components.Book
{
    public partial class UpdateBook : UserControl
    {

        DataAccessLayer.Entities.Book book;
        List<string> categories;
        List<string> secondaryCategorySelect;

        public UpdateBook()
        {
            InitializeComponent();
        }


        public void setBook(DataAccessLayer.Entities.Book upBook)
        {
            book = upBook;
        }

        private void UpdateBook_Load(object sender, EventArgs e)
         {

            categories = new List<string>();
            secondaryCategorySelect = new List<string>();

            ExistingCategoriesFun.createCategories(categories, category);

            if (book != null)
            {
                code.Text = book.Code;
                title.Text = book.Title;
                firstNameAuthor.Text = book.FirstName_Author;
                lastNameAuthor.Text = book.LastName_Author;
                publicationDate.MaxDate = book.PublicationDate;
                category.Text = book.Category;
                secondaryCategory.Text = book.SecondaryCategory;
            }

            else
            {
                publicationDate.MaxDate = DateTime.Now;
            }



        }

        private void category_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ExistingCategoriesFun.category_SelectedIndexChanged(secondaryCategorySelect, secondaryCategory, category.Text);
        }
    }
}
