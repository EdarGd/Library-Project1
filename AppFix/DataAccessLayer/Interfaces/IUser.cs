using DataAccessLayer.Entities;

namespace DataAccessLayer.Interfaces
{
    public interface IUser
    {
        // which functions must be used at sql 
        public object addNewUser(User newUser);
        public object deleteSelectedUser(string selectedId);
        public object getUsers();
        public object ShowFromUser_UserFromSpecific_Id_Email_Password(string id, string email, string password);
        public object ShowFromUser_UserFromSpecificEmail(string email);
        public object ShowFromUser_UserFromSpecificId(string id);
        public object ShowFromUser_UserFromSpecificPassword (string password);
        public object ShowFromUser_UsersFromFirstName(string firstName);
        public object ShowFromUser_UsersFromLastName(string lastName);
        public object ShowFromUser_UsersFromName(string firstName, string lastName);

        public object updateSelectedUser(User updateUser);

        // 11 Fun
    }
}
