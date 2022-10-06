using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using BusinessLogicLayer.actionFiles;
using BusinessLogicLayer.Validation;
using System.Data;

namespace BusinessLogicLayer.StoredProceduresLogic
{
    public class ExistingCategorylogic
    {
        // We will implement the functions we defined
        // in the "DataAccessLayer" and check the results
        private IExistingCategory _IExistingCategory = new DataAccessLayer.StoredProcedures.ExistingCategoryStoredProcedures();
        private FileError _fileError = new FileError();

        public ExistingCategorylogic()
        {
             IExistingCategory _IExistingCategory = new DataAccessLayer.StoredProcedures.ExistingCategoryStoredProcedures();
             FileError _fileError = new FileError();
        }
        public object addNewExistingCategory(ExistingCategory newExistingCategory)
        {
            #region Checking the correct input
            string? checkExistingCategory = Validation_CheckExistingCategory.checkExistingCategory(newExistingCategory);
            if (checkExistingCategory != null)
            {
                return checkExistingCategory;
            }
            #endregion

            #region Query execution
            try
            {
                object result = _IExistingCategory.addNewExistingCategory(newExistingCategory);
                // check if return true / message
                if (result.GetType() != typeof(Boolean))
                {
                    return Validation_General.insertErr("", result.ToString()!, "SQL Exception");
                }
                else
                    return "ExistingCategory successfully added !";
            }
            catch (Exception ex)
            {
                return Validation_General.insertErr("", ex.Message, "Server Exception");
            }
            #endregion
        }

        public string deleteSelectedExistingCategory(ExistingCategory selectedExistingCategory)
        {
            #region Checking the correct input
            string? checkExistingCategory = Validation_CheckExistingCategory.checkExistingCategory(selectedExistingCategory);
            if (checkExistingCategory != null)
            {
                return checkExistingCategory;
            }
            #endregion

            #region Query execution
            try
            {
                object result = _IExistingCategory.deleteSelectedExistingCategory(selectedExistingCategory);
                // check if return true / message
                if (result.GetType() != typeof(Boolean))
                {
                    return Validation_General.insertErr("", result.ToString()!, "SQL Exception");

                }
                else
                    return "ExistingCategory successfully deleted !";

            }
            catch (Exception ex)
            {
                _fileError.addError("Server Exception", ex.Message);
                return Validation_General.insertErr("", ex.Message, "Server Exception");
            }
            #endregion

        }

        public object getExistingCategories()
        {
            try
            {
                object result = _IExistingCategory.getExistingCategories();
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

        public object ShowFromExistingCategories_SubcategoryFromSpecificCategory(string category)
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
                object result = _IExistingCategory.ShowFromExistingCategories_SubcategoryFromSpecificCategory(category);
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

        public object ShowFromExistingCategories_SubcategoryFromCategory(string category)
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
                object result = _IExistingCategory.ShowFromExistingCategories_SubcategoryFromCategory(category);
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

        public object updateSelectedExistingCategory(ExistingCategory currentExistingCategory, ExistingCategory updateExistingCategory)
        {
            #region Checking the correct input
            string? checkExistingCategory = Validation_CheckExistingCategory.checkExistingCategory(currentExistingCategory);
            if (checkExistingCategory != null)
            {
                return checkExistingCategory;
            }

            checkExistingCategory = Validation_CheckExistingCategory.checkExistingCategory(updateExistingCategory);
            if (checkExistingCategory != null)
            {
                return checkExistingCategory;
            }

            #endregion

            #region Query execution
            try
            {
                object result = _IExistingCategory.updateSelectedExistingCategory(currentExistingCategory, updateExistingCategory);
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
