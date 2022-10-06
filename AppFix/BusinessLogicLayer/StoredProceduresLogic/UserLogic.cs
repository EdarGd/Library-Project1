using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using BusinessLogicLayer.actionFiles;
using BusinessLogicLayer.Validation;
using System.Data;

namespace BusinessLogicLayer.StoredProceduresLogic
{
    public class UserLogic
    {

        // We will implement the functions we defined
        // in the "DataAccessLayer" and check the results
        private IUser _IUser = new DataAccessLayer.StoredProcedures.UserStoredProcedures();
        private FileError _fileError = new FileError();
        public object addNewUser(User newUser)
        {
            #region Checking the correct input
            string? checkUser = Validation_CheckUser.checkUser (newUser);
            if (checkUser != null)
            {
                return checkUser;
            }
            #endregion

            #region Query execution
            try
            {
                object result = _IUser.addNewUser(newUser);
                // check if return true / message
                if (result.GetType() != typeof(Boolean))
                {
                    return Validation_General.insertErr("", result.ToString()!, "SQL Exception");
                }
                else
                    return "User successfully added !";
            }
            catch (Exception ex)
            {
                return Validation_General.insertErr("", ex.Message, "Server Exception");
            }
            #endregion
        }

        public string deleteSelectedUser(string selectedId)
        {
            #region Checking the correct input

            string? checkValid = Validation_CheckUser.checkId(selectedId);
            if (checkValid != null)
            {
                return Validation_General.insertErr("", checkValid, "Client Exception");
            }

            #endregion

            #region Query execution
            try
            {
                object result = _IUser.deleteSelectedUser(selectedId);
                // check if return true / message
                if (result.GetType() != typeof(Boolean))
                {
                    return Validation_General.insertErr("", result.ToString()!, "SQL Exception");

                }
                else
                    return "User successfully deleted !";

            }
            catch (Exception ex)
            {
                _fileError.addError("Server Exception", ex.Message);
                return Validation_General.insertErr("", ex.Message, "Server Exception");
            }
            #endregion

        }

        public object getUsers()
        {
            try
            {
                object result = _IUser.getUsers();
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

        public object ShowFromUser_UserFromSpecific_Id_Email_Password(string id, string email, string password)
        {
            #region Checking the correct input

            string? checkValid;
            string resCheck = "";
            checkValid = Validation_CheckUser.checkId(id);
            if (checkValid != null)
            {
                resCheck =  Validation_General.insertErr("", checkValid, "Client Exception");
            }

            checkValid = Validation_CheckUser.checkEmail(email);
            if (checkValid != null)
            {
                resCheck = Validation_General.insertErr(resCheck, checkValid, "Client Exception");
            }

            checkValid = Validation_CheckUser.checkEmail(email);
            if (checkValid != null)
            {
                resCheck = Validation_General.insertErr(resCheck, checkValid, "Client Exception");
            }
            if(resCheck != "")
            { return resCheck; }

            #endregion

            #region Query execution
            try
            {
                object result = _IUser.ShowFromUser_UserFromSpecific_Id_Email_Password(id,email,password);
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

        public object ShowFromUser_UserFromSpecificEmail(string email)
        {
            #region Checking the correct input

            string? checkValid = Validation_CheckUser.checkEmail(email);
            if (checkValid != null)
            {
                return Validation_General.insertErr("", checkValid, "Client Exception");
            }

            #endregion

            #region Query execution
            try
            {
                object result = _IUser.ShowFromUser_UserFromSpecificEmail(email);
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

        public object ShowFromUser_UserFromSpecificId(string id)
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
                object result = _IUser.ShowFromUser_UserFromSpecificId(id);
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

        public object ShowFromUser_UserFromSpecificPassword(string password)
        {
            #region Checking the correct input

            string? checkValid = Validation_CheckUser.checkPassword(password);
            if (checkValid != null)
            {
                return Validation_General.insertErr("", checkValid, "Client Exception");
            }

            #endregion

            #region Query execution
            try
            {
                object result = _IUser.ShowFromUser_UserFromSpecificPassword(password);
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

        public object ShowFromUser_UsersFromFirstName(string firstName)
        {
            #region Checking the correct input

            string? checkValid = Validation_General.checkOnlyLetter(firstName);
            if (checkValid != null)
            {
                return Validation_General.insertErr("", checkValid, "Client Exception");
            }

            #endregion

            #region Query execution
            try
            {
                object result = _IUser.ShowFromUser_UsersFromFirstName(firstName);
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

        public object ShowFromUser_UsersFromLastName(string lastName)
        {
            #region Checking the correct input

            string? checkValid = Validation_General.checkOnlyLetter(lastName);
            if (checkValid != null)
            {
                return Validation_General.insertErr("", checkValid, "Client Exception");
            }

            #endregion

            #region Query execution
            try
            {
                object result = _IUser.ShowFromUser_UsersFromFirstName(lastName);
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

        public object ShowFromUser_UsersFromName(string firstName, string lastName)
        {
            #region Checking the correct input
            string errors = "";
            string? checkValid;
            checkValid = Validation_General.checkOnlyLetter(firstName);
            if (checkValid != null)
            {
                errors = Validation_General.insertErr("", checkValid, "Client Exception");
            }
            checkValid = Validation_General.checkOnlyLetter(lastName);
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
                object result = _IUser.ShowFromUser_UsersFromName(firstName, lastName);
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

        public object updateSelectedUser(User updateUser)
        {
            #region Checking the correct input
            string? checkBook = Validation_CheckUser.checkUser(updateUser);
            if (checkBook != null)
            {
                return checkBook;
            }
            #endregion

            #region Query execution
            try
            {
                object result = _IUser.updateSelectedUser(updateUser);
                // check if return true / message
                if (result.GetType() != typeof(Boolean))
                {
                    return Validation_General.insertErr("", result.ToString()!, "SQL Exception");
                }
                else
                    return "User successfully updated !";
            }
            catch (Exception ex)
            {
                return Validation_General.insertErr("", ex.Message, "Server Exception");
            }
            #endregion
        }
    }
}
