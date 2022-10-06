using BusinessLogicLayer.StoredProceduresLogic;
using DataAccessLayer.Entities;

namespace AppLayer
{
    public partial class Form1 : Form
    {
        // General login

        private BookLogic bookLogic;

        public Form1()
        {
            bookLogic = new BookLogic();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormChild formChild = new FormChild();
            formChild.MdiParent = this;
            formChild.Show();
            formChild.Activate();
            //center child in parent
            formChild.Location = new Point((this.Width - formChild.Width) / 2, (this.Height - formChild.Height) / 2);

            Book book = new Book()
            {
                Code = "1312345678123",
                Title = "aa",
                Category = "a",
                SecondaryCategory = null,
                FirstName_Author = "A",
                LastName_Author = "B",
                PublicationDate = DateTime.Now
            };
            label1.Text = bookLogic.addNewBook(book).ToString();
        }
    }
}