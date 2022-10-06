using BusinessLogicLayer.actionFiles;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Validation
{
    public static class Validation_CheckBook
    {
        private static FileError _fileError = new FileError();

        public static string? checkDate(DateTime dateBook)
        {
            if (dateBook > DateTime.Now)
            {
                return "Date cannot be greater than current date !";
            }
            else
            {
                return null;
            }
        }

        public static string? checkCode(string codeBook)
        {
            if (codeBook.Length != 13)
            {
                return "Barcode must contain 13 digits !";
            }

            //Note that the IsDigit() method does not strictly check for a character in the range 0 through 9.
            //It allows a few characters such as Thai numerals ๐ ๑ ๒ ๓ ๔ ๕ ๖ ๗ ๘ ๙.
            //We can use the following code to strictly check for ASCII digits:

            else if (!codeBook.All(c => (c >= 48 && c <= 57)))
            {
                return "Barcode must contain only digits ! -> " + codeBook;
            }
            else
            {
                return null;
            }
        }

        public static string? checkBook(Book checkBook)
        {
            #region Checking the correct input

            // Validation for null
            string errsValidBook = "";
            if (checkBook == null)
            {
                errsValidBook = Validation_General.insertErr("", "Values cannot be null", "Client Exception");
                return errsValidBook;
            }

            // Validation for values
            else
            {
                string? checkValid;
                checkValid = checkDate(checkBook.PublicationDate);
                if (checkValid != null)
                {
                    errsValidBook = Validation_General.insertErr("", checkValid, "Client Exception");
                }

                checkValid = checkCode(checkBook.Code);
                if (checkValid != null)
                {
                    errsValidBook = Validation_General.insertErr(errsValidBook, checkValid, "Client Exception");
                }


                checkValid = Validation_General.checkOnlyLetter(checkBook.FirstName_Author);
                if (checkValid != null)
                {
                    errsValidBook = Validation_General.insertErr(errsValidBook, checkValid, "Client Exception");
                }

                checkValid = Validation_General.checkOnlyLetter(checkBook.LastName_Author);
                if (checkValid != null)
                {
                    errsValidBook = Validation_General.insertErr(errsValidBook, checkValid, "Client Exception");
                }

                checkValid = Validation_General.checkOnlyLetter(checkBook.Category);
                if (checkValid != null)
                {
                    errsValidBook = Validation_General.insertErr(errsValidBook, checkValid, "Client Exception");
                }

                if(checkBook.SecondaryCategory != null)
                {
                    checkValid = Validation_General.checkOnlyLetter(checkBook.SecondaryCategory);
                    if (checkValid != null)
                    {
                        errsValidBook = Validation_General.insertErr(errsValidBook, checkValid, "Client Exception");
                    }
                }

            }

            if (errsValidBook != "")
            { return errsValidBook; }

            else
            { return null; }
            #endregion

        }
    }
}
