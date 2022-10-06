using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using BusinessLogicLayer.actionFiles;
using BusinessLogicLayer.Validation;
using System.Data;

namespace BusinessLogicLayer.StoredProceduresLogic
{
    public class BookLogic
    {
        // We will implement the functions we defined
        // in the "DataAccessLayer" and check the results
        private IBook _IBook = new DataAccessLayer.StoredProcedures.BookStoredProcedures();
        private FileError _fileError = new FileError();
        public object addNewBook(Book newBook)
        {
            #region Checking the correct input
            string? checkBook = Validation_CheckBook.checkBook(newBook);
            if (checkBook != null)
            {
                return checkBook; 
            }
            #endregion

            #region Query execution
            try
            {
                object result = _IBook.addNewBook(newBook);
                // check if return true / message
                if (result.GetType() != typeof(Boolean))
                {
                    return Validation_General.insertErr("", result.ToString()!, "SQL Exception");
                }
                else
                    return "Book successfully added !";
            }
            catch (Exception ex)
            {
                return Validation_General.insertErr("", ex.Message, "Server Exception");
            }
            #endregion
        }

        public object deleteSelectedBook(string selectedCode)
        {
            #region Checking the correct input

            string? checkValid = Validation_CheckBook.checkCode(selectedCode);
            if (checkValid != null)
            {
                return Validation_General.insertErr("", checkValid, "Client Exception");
            }

            #endregion

            #region Query execution
            try
            {
                object result = _IBook.deleteSelectedBook(selectedCode);
                // check if return true / message
                if (result.GetType() != typeof(Boolean))
                {
                    return Validation_General.insertErr("", result.ToString()!, "SQL Exception");

                }
                else
                    return "Book successfully deleted !";

            }
            catch (Exception ex)
            {
                _fileError.addError("Server Exception", ex.Message);
                return Validation_General.insertErr("", ex.Message, "Server Exception");
            }
            #endregion

        }

        public object getBooks()
        {
            try
            {
                object result = _IBook.getBooks()!;
                // check if type of DataTable -> data to show
                if (result.GetType() != typeof(DataTable))
                {
                    _fileError.addError("SQL Exception", result + "");
                }
                return result;

            }
            catch (Exception ex)
            {
                return Validation_General.insertErr("", ex.Message, "Server Exception");
            }
        }

        public object ShowFromBook_BookFromSpecificCode(string code)
        {
            #region Checking the correct input

            string? checkValid = Validation_CheckBook.checkCode(code);
            if (checkValid != null)
            {
                return Validation_General.insertErr("", checkValid, "Client Exception");
            }

            #endregion

            #region Query execution
            try
            {
                object result = _IBook.ShowFromBook_BookFromSpecificCode(code);
                // check if type of DataTable -> data to show
                if (result.GetType() != typeof(DataTable))
                {
                    _fileError.addError("SQL Exception", result + "");
                }
                return result;

            }
            catch (Exception ex)
            {
                return Validation_General.insertErr("", ex.Message, "Server Exception");
            }

            #endregion
        }

        public object ShowFromBook_BooksFromCategory(string category)
        {
            #region Checking the correct input

            string? checkValid = Validation_General.checkOnlyLetter(category);
            if (checkValid != null)
            {
                return Validation_General.insertErr("", checkValid, "Client Exception");
            }

            #endregion

            #region Query execution
            try
            {
                object result = _IBook.ShowFromBook_BooksFromCategory(category);
                // check if type of DataTable -> data to show
                if (result.GetType() != typeof(DataTable))
                {
                    _fileError.addError("SQL Exception", result + "");
                }
                return result;

            }
            catch (Exception ex)
            {
                return Validation_General.insertErr("", ex.Message, "Server Exception");
            }

            #endregion
        }

        public object ShowFromBook_BooksFromFirstName_Author(string firstName_Author)
        {
            #region Checking the correct input

            string? checkValid = Validation_General.checkOnlyLetter(firstName_Author);
            if (checkValid != null)
            {
                return Validation_General.insertErr("", checkValid, "Client Exception");
            }

            #endregion

            #region Query execution
            try
            {
                object result = _IBook.ShowFromBook_BooksFromFirstName_Author(firstName_Author);
                // check if type of DataTable -> data to show
                if (result.GetType() != typeof(DataTable))
                {
                    _fileError.addError("SQL Exception", result + "");
                }
                return result;

            }
            catch (Exception ex)
            {
                return Validation_General.insertErr("", ex.Message, "Server Exception");
            }

            #endregion
        }

        public object ShowFromBook_BooksFromLastName_Author(string lastName_Author)
        {
            #region Checking the correct input

            string? checkValid = Validation_General.checkOnlyLetter(lastName_Author);
            if (checkValid != null)
            {
                return Validation_General.insertErr("", checkValid, "Client Exception");
            }

            #endregion

            #region Query execution
            try
            {
                object result = _IBook.ShowFromBook_BooksFromLastName_Author(lastName_Author);
                // check if type of DataTable -> data to show
                if (result.GetType() != typeof(DataTable))
                {
                    _fileError.addError("SQL Exception", result + "");
                }
                return result;

            }
            catch (Exception ex)
            {
                return Validation_General.insertErr("", ex.Message, "Server Exception");
            }

            #endregion
        }

        public object ShowFromBook_BooksFromName_Author(string firstName_Author, string lastName_Author)
        {
            #region Checking the correct input
            string errors = "";
            string? checkValid;
            checkValid = Validation_General.checkOnlyLetter(firstName_Author);
            if (checkValid != null)
            {
                errors = Validation_General.insertErr("", checkValid, "Client Exception");
            }
            checkValid = Validation_General.checkOnlyLetter(lastName_Author);
            if (checkValid != null)
            {
                errors = Validation_General.insertErr(errors, checkValid, "Client Exception");
            }

            if (errors != "")
            { return errors; }
            #endregion

            #region Query execution
            try
            {
                object result = _IBook.ShowFromBook_BooksFromName_Author(firstName_Author, lastName_Author);
                // check if type of DataTable -> data to show
                if (result.GetType() != typeof(DataTable))
                {
                    _fileError.addError("SQL Exception", result + "");
                }
                return result;

            }
            catch (Exception ex)
            {
                return Validation_General.insertErr("", ex.Message, "Server Exception");
            }

            #endregion
        }

        public object ShowFromBook_BooksFromPublicationYear(int publicationYear)
        {
            #region Checking the correct input

            
            if (publicationYear < 0 || publicationYear > 9999)
            {
                return Validation_General.insertErr("", "Do you want to travel in time? This year makes no sense", "Client Exception");
            }

            #endregion

            #region Query execution
            try
            {
                object result = _IBook.ShowFromBook_BooksFromPublicationYear(publicationYear);
                // check if type of DataTable -> data to show
                if (result.GetType() != typeof(DataTable))
                {
                    _fileError.addError("SQL Exception", result + "");
                }
                return result;

            }
            catch (Exception ex)
            {
                return Validation_General.insertErr("", ex.Message, "Server Exception");
            }

            #endregion
        }

        public object ShowFromBook_BooksFromTitle(string title)
        {

            #region Query execution
            try
            {
                object result = _IBook.ShowFromBook_BooksFromTitle(title);
                // check if type of DataTable -> data to show
                if (result.GetType() != typeof(DataTable))
                {
                    _fileError.addError("SQL Exception", result + "");
                }
                return result;

            }
            catch (Exception ex)
            {
                return Validation_General.insertErr("", ex.Message, "Server Exception");
            }

            #endregion
        }

        public object updateSelectedBook(Book updateBook)
        {
            #region Checking the correct input
            string? checkBook = Validation_CheckBook.checkBook(updateBook);
            if (checkBook != null)
            {
                return checkBook;
            }
            #endregion

            #region Query execution
            try
            {
                object result = _IBook.updateSelectedBook(updateBook)!;
                // check if return true / message
                if (result.GetType() != typeof(Boolean))
                {
                    return Validation_General.insertErr("", result.ToString()!, "SQL Exception");
                }
                else
                    return "Book successfully updated !";
            }
            catch (Exception ex)
            {
                return Validation_General.insertErr("", ex.Message, "Server Exception");
            }
            #endregion
        }


    }
}
