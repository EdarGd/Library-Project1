using DataAccessLayer.Interfaces;
using DataAccessLayer.DataContext;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Entities;
using DataAccessLayer.GeneralSettingsForSQL;

namespace DataAccessLayer.StoredProcedures
{
    public class ExistingCategoryStoredProcedures : IExistingCategory
    {


        //We will connect to the database and run procedures
        private AppConfiguration settings { get; set; }
        private SqlConnection connection { get; set; }

        public ExistingCategoryStoredProcedures()
        {
            settings = new AppConfiguration();
            connection = new SqlConnection();
            connection.ConnectionString = settings.sqlConectionString;
        }

        public object addNewExistingCategory(ExistingCategory newExistingCategory)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "addNewExistingCategory";
            spData.SetParam("@newCategory", SqlDbType.NVarChar, newExistingCategory.Category, ParameterDirection.Input);
            spData.SetParam("@newSecondaryCategory", SqlDbType.NVarChar, newExistingCategory.SecondaryCategory, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);

        }

        public object deleteSelectedExistingCategory(ExistingCategory selectedExistingCategory)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "deleteSelectedExistingCategory";
            spData.SetParam("@selectedCategory", SqlDbType.NVarChar, selectedExistingCategory.Category, ParameterDirection.Input);
            spData.SetParam("@selectedSecondaryCategory", SqlDbType.NVarChar, selectedExistingCategory.SecondaryCategory, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object getExistingCategories()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "getExistingCategories";
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object ShowFromExistingCategories_SubcategoryFromSpecificCategory(string category)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromExistingCategories_SubcategoryFromSpecificCategory";
            spData.SetParam("@category", SqlDbType.NVarChar, category, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object ShowFromExistingCategories_SubcategoryFromCategory(string category)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromExistingCategories_SubcategoryFromCategory";
            spData.SetParam("@category", SqlDbType.NVarChar, category, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object updateSelectedExistingCategory(ExistingCategory currentExistingCategory, ExistingCategory updateExistingCategory)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "updateSelectedExistingCategory";
            spData.SetParam("@currentCategory", SqlDbType.NVarChar, currentExistingCategory.Category, ParameterDirection.Input);
            spData.SetParam("@currentSecondaryCategory", SqlDbType.NVarChar, currentExistingCategory.SecondaryCategory, ParameterDirection.Input);
            spData.SetParam("@updateCategory", SqlDbType.NVarChar, updateExistingCategory.Category, ParameterDirection.Input);
            spData.SetParam("@updateSecondaryCategory", SqlDbType.NVarChar, updateExistingCategory.SecondaryCategory, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }
    }
}
