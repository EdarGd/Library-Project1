using DataAccessLayer.Interfaces;
using DataAccessLayer.DataContext;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Entities;
using DataAccessLayer.GeneralSettingsForSQL;

namespace DataAccessLayer.StoredProcedures
{
    public class BorrowStoredProcedures : IBorrow
    {


        //We will connect to the database and run procedures
        private AppConfiguration settings { get; set; }
        private SqlConnection connection { get; set; }

        public BorrowStoredProcedures()
        {
            settings = new AppConfiguration();
            connection = new SqlConnection();
            connection.ConnectionString = settings.sqlConectionString;
        }

        public object addNewBorrow(Borrow newBorrow)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "addNewBorrow";
            spData.SetParam("@newBorrow_Code", SqlDbType.NChar, newBorrow.Code, ParameterDirection.Input);
            spData.SetParam("@newBorrow_Id", SqlDbType.NChar, newBorrow.Id, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);

        }

        public object deleteSelectedBorrow(string selectedCode)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "deleteSelectedBorrow";
            spData.SetParam("@selectedCode", SqlDbType.NVarChar, selectedCode, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object getBorrows()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "getBorrows";
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object ShowFromBorrow_byUserCheckType(bool type, string id)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromBorrow_byUserCheckType";
            spData.SetParam("@type", SqlDbType.Bit, type, ParameterDirection.Input);
            spData.SetParam("@id", SqlDbType.NChar, id, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }
        public object ShowFromBorrow_SpecificBook(string codeBook)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromBorrow_SpecificBook";
            spData.SetParam("@codeBook", SqlDbType.NChar, codeBook, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object ShowFromBorrow_UserBorrows(string idUser)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromBorrow_User'sBorrows";
            spData.SetParam("@idUser", SqlDbType.NChar, idUser, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object updateSelectedBorrow(Borrow updateBorrow)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "updateSelectedBorrow";
            spData.SetParam("@updateCode", SqlDbType.NChar, updateBorrow.Code, ParameterDirection.Input);
            spData.SetParam("@updateId", SqlDbType.NChar, updateBorrow.Id, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }
    }
}
