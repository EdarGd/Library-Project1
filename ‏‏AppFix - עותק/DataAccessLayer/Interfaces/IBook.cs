using DataAccessLayer.Entities;

namespace DataAccessLayer.Interfaces
{
    public interface IBook
    {
        // which functions must be used at sql 
        public object addNewBook(Book newBook);
        public object deleteSelectedBook(string selectedCode);
        public object getBooks();
        public object ShowFromBook_BookFromSpecificCode(string code);
        public object ShowFromBook_BooksFromCategory(string category);
        public object ShowFromBook_BooksFromFirstName_Author(string firstName_Author);
        public object ShowFromBook_BooksFromLastName_Author(string lastName_Author);
        public object ShowFromBook_BooksFromName_Author(string firstName_Author, string lastName_Author);
        public object ShowFromBook_BooksFromPublicationYear(int publicationYear);
        public object ShowFromBook_BooksFromTitle(string title);
        public object updateSelectedBook(Book updateBook);


        // 11 Fun
    }
}
