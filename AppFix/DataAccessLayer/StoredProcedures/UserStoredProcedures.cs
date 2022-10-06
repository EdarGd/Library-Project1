using DataAccessLayer.Interfaces;
using DataAccessLayer.DataContext;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Entities;
using DataAccessLayer.GeneralSettingsForSQL;

namespace DataAccessLayer.StoredProcedures
{
    public class UserStoredProcedures : IUser
    {


        //We will connect to the database and run procedures
        private AppConfiguration settings { get; set; }
        private SqlConnection connection { get; set; }

        public UserStoredProcedures()
        {
            settings = new AppConfiguration();
            connection = new SqlConnection();
            connection.ConnectionString = settings.sqlConectionString;
        }

        public object addNewUser(User newUser)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "addNewUser";
            spData.SetParam("@newUser_Id", SqlDbType.NChar, newUser.Id, ParameterDirection.Input);
            spData.SetParam("@newUser_FirstName", SqlDbType.NVarChar, newUser.FirstName, ParameterDirection.Input);
            spData.SetParam("@newUser_LastName", SqlDbType.NVarChar, newUser.LastName, ParameterDirection.Input);
            spData.SetParam("@newUser_Type", SqlDbType.Bit, newUser.Type, ParameterDirection.Input);
            spData.SetParam("@newUser_Email", SqlDbType.NVarChar, newUser.Email, ParameterDirection.Input);
            spData.SetParam("@newBook_Password", SqlDbType.NChar, newUser.Password, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);

        }

        public object deleteSelectedUser(string selectedUser_id)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "deleteSelectedUser";
            spData.SetParam("@selectedUser_id", SqlDbType.NChar, selectedUser_id, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object getUsers()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "getUsers";
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object ShowFromUser_UserFromSpecific_Id_Email_Password(string id, string email, string password)
        { 
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromUser_UserFromSpecific_Id_Email_Password";
            spData.SetParam("@id", SqlDbType.NChar, id, ParameterDirection.Input);
            spData.SetParam("@email", SqlDbType.NVarChar, email, ParameterDirection.Input);
            spData.SetParam("@password", SqlDbType.NChar, password, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object ShowFromUser_UserFromSpecificEmail(string email)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromUser_UserFromSpecificEmail";
            spData.SetParam("@email", SqlDbType.NVarChar, email, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }
        public object ShowFromUser_UserFromSpecificId(string id)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromUser_UserFromSpecificId";
            spData.SetParam("@id", SqlDbType.NChar, id, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }
        public object ShowFromUser_UserFromSpecificPassword(string password)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromUser_UserFromSpecificPassword";
            spData.SetParam("@password", SqlDbType.NChar, password, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }
        public object ShowFromUser_UsersFromFirstName(string firstName)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromUser_UsersFromFirstName";
            spData.SetParam("@firstName", SqlDbType.NVarChar, firstName, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }
        public object ShowFromUser_UsersFromLastName(string lastName)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromUser_UsersFromLastName";
            spData.SetParam("@lastName", SqlDbType.NVarChar, lastName, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }
        public object ShowFromUser_UsersFromName(string firstName, string lastName)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "ShowFromUser_UsersFromName";
            spData.SetParam("@firstName", SqlDbType.NVarChar, firstName, ParameterDirection.Input);
            spData.SetParam("@lastName", SqlDbType.NVarChar, lastName, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }

        public object updateSelectedUser(User updateUser)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            StoredProcedureCollection spCollection = new StoredProcedureCollection();
            StoredProcedure spData = new StoredProcedure();
            spData.ProcName = "updateSelectedUser";
            spData.SetParam("@updateUser_Id", SqlDbType.NChar, updateUser.Id, ParameterDirection.Input);
            spData.SetParam("@updateUser_FirstName", SqlDbType.NVarChar, updateUser.FirstName, ParameterDirection.Input);
            spData.SetParam("@updateUser_LastName", SqlDbType.NVarChar, updateUser.LastName, ParameterDirection.Input);
            spData.SetParam("@updateUser_Type", SqlDbType.Bit, updateUser.Type, ParameterDirection.Input);
            spData.SetParam("@updateUser_Email", SqlDbType.NVarChar, updateUser.Email, ParameterDirection.Input);
            spData.SetParam("@updateUser_Password", SqlDbType.NChar, updateUser.Password, ParameterDirection.Input);
            spData.SetParam("@ERROR", SqlDbType.NVarChar, "", ParameterDirection.InputOutput, 500);
            spCollection.add(spData);
            return Execute.ExecuteSps(spCollection, connection);
        }
    }
}
