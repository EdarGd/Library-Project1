using BusinessLogicLayer.actionFiles;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Validation
{
    public static class Validation_CheckExistingCategory
    {
        private static FileError _fileError = new FileError();

        public static string? checkExistingCategory(ExistingCategory checkExistingCategory)
        {
            #region Checking the correct input

            // Validation for null
            string errsValidBook = "";
            if (checkExistingCategory == null)
            {
                errsValidBook = Validation_General.insertErr("", "Values cannot be null", "Client Exception");
                return errsValidBook;
            }

            // Validation for values
            else
            {
                string? checkValid;
                checkValid = Validation_General.checkOnlyLetter(checkExistingCategory.Category);
                if (checkValid != null)
                {
                    errsValidBook = Validation_General.insertErr("", checkValid, "Client Exception");
                }

                checkValid = Validation_General.checkOnlyLetter(checkExistingCategory.SecondaryCategory);
                if (checkValid != null)
                {
                    errsValidBook = Validation_General.insertErr(errsValidBook, checkValid, "Client Exception");
                }

            }

            if (errsValidBook != null)
            { return errsValidBook; }

            else
            { return null; }
            #endregion

        }
    }
}
