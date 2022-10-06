using DataAccessLayer.Entities;

namespace DataAccessLayer.Interfaces
{
    public interface IBorrow
    {
        // which functions must be used at sql 
        public object addNewBorrow(Borrow newBorrow);
        public object deleteSelectedBorrow(string selectedCode);
        public object getBorrows();
        public object ShowFromBorrow_byUserCheckType(bool type, string id);
        public object ShowFromBorrow_SpecificBook(string codeBook);
        public object ShowFromBorrow_UserBorrows(string idUser);
        public object updateSelectedBorrow(Borrow updateBorrow);

        // 6 Fun


    }
}
