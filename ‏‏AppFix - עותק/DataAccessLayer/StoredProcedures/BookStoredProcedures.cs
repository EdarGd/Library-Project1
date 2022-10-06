using DataAccessLayer.DataContext;
using DataAccessLayer.Interfaces;
using System.Data.SqlClient;
using DataAccessLayer.Entities;
using System.Data;
using DataAccessLayer.GeneralSettingsForSQL;


namespace DataAccessLayer.StoredProcedures
{
    public class BookStoredProcedures : IBook
    {

        //We will connect to the database and run procedures
        private AppConfiguration settings { get; set; }
        private SqlConnection connection { get; set; }

        public BookStoredProcedures()
        {
            settings = new AppConfiguration();
            connection = new SqlConnection();
            connection.ConnectionString = settings.sqlConectionString;
        }

        public object addNewBook(Book newBook)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "addNewBook";
            spData.SetParam("@newBook_Code", SqlDbType.NChar, newBook.Code, ParameterDirection.Input);
            spData.SetParam("@newBook_Title", SqlDbType.NVarChar, newBook.Title, ParameterDirection.Input);
            spData.SetParam("@newBook_FirstName_Author", SqlDbType.NVarChar, newBook.FirstName_Author, ParameterDirection.Input);
            spData.SetParam("@newBook_LastName_Author", SqlDbType.NVarChar, newBook.LastName_Author, ParameterDirection.Input);
            spData.SetParam("@newBook_PublicationDate", SqlDbType.DateTime, newBook.PublicationDate, ParameterDirection.Input);
            spData.SetParam("@newBook_Category", SqlDbType.NVarChar, newBook.Category, ParameterDirection.Input);
            spData.SetParam("@newBook_SecondaryCategory", SqlDbType.NVarChar, newBook.SecondaryCategory, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);

        }

        public object deleteSelectedBook(string selectedCode)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "deleteSelectedBook";
            spData.SetParam("@selectedBook_Code", SqlDbType.NChar, selectedCode, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object getBooks()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "getBooks";
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object ShowFromBook_BookFromSpecificCode(string code)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromBook_BookFromSpecificCode";
            spData.SetParam("@code", SqlDbType.NChar, code, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object ShowFromBook_BooksFromCategory(string category)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromBook_BooksFromCategory";
            spData.SetParam("@category", SqlDbType.NVarChar, category, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object ShowFromBook_BooksFromFirstName_Author(string firstName_Author)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromBook_BooksFromFirstName_Author";
            spData.SetParam("@firstName_Author", SqlDbType.NVarChar, firstName_Author, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object ShowFromBook_BooksFromLastName_Author(string lastName_Author)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromBook_BooksFromLastName_Author";
            spData.SetParam("@lastName_Author", SqlDbType.NVarChar, lastName_Author, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object ShowFromBook_BooksFromName_Author(string firstName_Author, string lastName_Author)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromBook_BooksFromName_Author";
            spData.SetParam("@firstName_Author", SqlDbType.NVarChar, firstName_Author, ParameterDirection.Input);
            spData.SetParam("@lastName_Author", SqlDbType.NVarChar, lastName_Author, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object ShowFromBook_BooksFromPublicationYear(int publicationYear)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromBook_BooksFromPublicationYear";
            spData.SetParam("@publicationYear", SqlDbType.Int, publicationYear, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object ShowFromBook_BooksFromTitle(string title)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromBook_BooksFromTitle";
            spData.SetParam("@title", SqlDbType.NVarChar, title, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }
        public object updateSelectedBook(Book updateBook)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "updateSelectedBook";
            spData.SetParam("@updateBook_Code", SqlDbType.NChar, updateBook.Code, ParameterDirection.Input);
            spData.SetParam("@updateBook_Title", SqlDbType.NVarChar, updateBook.Title, ParameterDirection.Input);
            spData.SetParam("@updateBook_FirstName_Author", SqlDbType.NVarChar, updateBook.FirstName_Author, ParameterDirection.Input);
            spData.SetParam("@updateBook_LastName_Author", SqlDbType.NVarChar, updateBook.LastName_Author, ParameterDirection.Input);
            spData.SetParam("@updateBook_PublicationDate", SqlDbType.DateTime, updateBook.PublicationDate, ParameterDirection.Input);
            spData.SetParam("@updateBook_Category", SqlDbType.NVarChar, updateBook.Category, ParameterDirection.Input);
            spData.SetParam("@updateBook_SecondaryCategory", SqlDbType.NVarChar, updateBook.SecondaryCategory, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }
    }
}
