using BusinessLogicLayer.actionFiles;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Validation
{
    public static class Validation_CheckBorrow
    {
        private static FileError _fileError = new FileError();

        public static string? checkBorrow(Borrow checkBorrow)
        {
            #region Checking the correct input

            // Validation for null
            string errsValidBorrow = "";
            if (checkBorrow == null)
            {
                errsValidBorrow = Validation_General.insertErr("", "Values cannot be null", "Client Exception");
                return errsValidBorrow;
            }

            // Validation for values
            else
            {
                string? checkValid;
                checkValid = Validation_CheckBook.checkCode(checkBorrow.Code);
                if (checkValid != null)
                {
                    errsValidBorrow = Validation_General.insertErr("", checkValid, "Client Exception");
                }

                checkValid = Validation_CheckUser.checkId(checkBorrow.Id);
                if (checkValid != null)
                {
                    errsValidBorrow = Validation_General.insertErr(errsValidBorrow, checkValid, "Client Exception");
                }

            }

            if (errsValidBorrow != null)
            { return errsValidBorrow; }

            else
            { return null; }
            #endregion

        }
    }
}
