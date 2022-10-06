using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataAccessLayer.Entities;

namespace AppLayer.Components.Single
{

    public partial class singleBook : UserControl
    {
        #region Set Values to UC
        private DataAccessLayer.Entities.Book book;

        public del_Child_To_Main del_Child_To_Main;
        public DataAccessLayer.Entities.Book Book
        {
            get { return book; }
            set {
                book = value;
                if(book != null)
                {
                    code.Text = book.Code;
                    Title.Text = book.Title;
                    firstName_Author.Text = book.FirstName_Author;
                    lastName_Author.Text = book.LastName_Author;
                    publicationDate.Text = book.PublicationDate.ToString("MM/dd/yy");
                    category.Text = book.Category;
                    secondaryCategory.Text = book.SecondaryCategory;
                    num.Text = CountLine + "";
                }
                
            }
        }
        #endregion

        static int countline = 0;
        public static int CountLine
        {
            get { return countline; }
            set { countline = value; }
        }

        public singleBook()
        {
            InitializeComponent();
        }
        public singleBook(DataAccessLayer.Entities.Book showBook)
        {
            InitializeComponent();
            countline++;
            Book = showBook;
            btnDelete1.addEventTopictureBox1Click(showBook.Code,"Book");
            btnShow1.addEventTopictureBox1Click(showBook, "Book");
            btnUpDate1.addEventTopictureBox1Click(showBook, "Book");
             try
            {
               
            }
            catch (Exception)
            {

                return ;
            }
        }

        private void category_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aaaa");
            del_Child_To_Main("bbbb");
        }


        int hover;
        Color temp;

        private void tableLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            if (hover == 0)
            {
                temp = BackColor;
                BackColor = Color.AliceBlue;
                hover++;
            }
        }

        private void singleBook_MouseLeave(object sender, EventArgs e)
        {
            if (hover == 1)
            {
                hover--;
                BackColor = temp;
            }
        }

        public void setCode(string newCode)
        {
            code.Text = newCode;
        }
    }
}
