using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using BusinessLogicLayer.actionFiles;
using BusinessLogicLayer.Validation;
using System.Data;

namespace BusinessLogicLayer.StoredProceduresLogic
{
    public class Borrowlogic
    {
        // We will implement the functions we defined
        // in the "DataAccessLayer" and check the results
        private IBorrow _IBorrow = new DataAccessLayer.StoredProcedures.BorrowStoredProcedures();
        private FileError _fileError = new FileError();
        public object addNewBorrow(Borrow newBorrow)
        {
            #region Checking the correct input
            string? checkBorrow = Validation_CheckBorrow.checkBorrow(newBorrow);
            if (checkBorrow != null)
            {
                return checkBorrow;
            }
            #endregion

            #region Query execution
            try
            {
                object result = _IBorrow.addNewBorrow(newBorrow);
                // check if return true / message
                if (result.GetType() != typeof(Boolean))
                {
                    return Validation_General.insertErr("", result.ToString()!, "SQL Exception");
                }
                else
                    return "Borrow successfully added !";
            }
            catch (Exception ex)
            {
                return Validation_General.insertErr("", ex.Message, "Server Exception");
            }
            #endregion
        }

        public object deleteSelectedBorrow(string selectedCode)
        {
            #region Checking the correct input
            string? checkBorrow = Validation_CheckBook.checkCode(selectedCode);
            if (checkBorrow != null)
            {
                return checkBorrow;
            }
            #endregion

            #region Query execution
            try
            {
                object result = _IBorrow.deleteSelectedBorrow(selectedCode);
                // check if return true / message
                if (result.GetType() != typeof(Boolean))
                {
                    return Validation_General.insertErr("", result.ToString()!, "SQL Exception");

                }
                else
                    return "Borrow successfully deleted !";

            }
            catch (Exception ex)
            {
                _fileError.addError("Server Exception", ex.Message);
                return Validation_General.insertErr("", ex.Message, "Server Exception");
            }
            #endregion

        }

        public object getBorrows()
        {
            try
            {
                object result = _IBorrow.getBorrows();
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

        public object ShowFromBorrow_byUserCheckType(bool type, string id)
        {
            #region Checking the correct input

            string? checkValid = Validation_CheckUser.checkId(id);
            if (checkValid != null)
            {
                return Validation_General.insertErr("", checkValid, "Client Exception");
            }

            #endregion

            #region Query execution
            try
            {
                object result = _IBorrow.ShowFromBorrow_byUserCheckType(type,id);
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



        public object ShowFromBorrow_SpecificBook(string codeBook)
        {
            #region Checking the correct input

            string? checkValid = Validation_CheckBook.checkCode(codeBook);
            if (checkValid != null)
            {
                return Validation_General.insertErr("", checkValid, "Client Exception");
            }

            #endregion

            #region Query execution
            try
            {
                object result = _IBorrow.ShowFromBorrow_SpecificBook(codeBook);
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

        public object ShowFromBorrow_UserBorrows(string idUser)
        {
            #region Checking the correct input

            string? checkValid = Validation_CheckUser.checkId(idUser);
            if (checkValid != null)
            {
                return Validation_General.insertErr("", checkValid, "Client Exception");
            }

            #endregion

            #region Query execution
            try
            {
                object result = _IBorrow.ShowFromBorrow_UserBorrows(idUser);
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

        public object updateSelectedBorrow(Borrow updateBorrow)
        {
            #region Checking the correct input
            string? checkBorrow = Validation_CheckBorrow.checkBorrow(updateBorrow);
            if (checkBorrow != null)
            {
                return checkBorrow;
            }

            #endregion

            #region Query execution
            try
            {
                object result = _IBorrow.updateSelectedBorrow(updateBorrow);
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
    }
}