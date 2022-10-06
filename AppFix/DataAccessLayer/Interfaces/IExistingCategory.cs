using DataAccessLayer.Entities;

namespace DataAccessLayer.Interfaces
{
    public interface IExistingCategory
    {
        // which functions must be used at sql 
        public object addNewExistingCategory(ExistingCategory newExistingCategory);
        public object deleteSelectedExistingCategory(ExistingCategory selectedExistingCategory);
        public object getExistingCategories();
        public object ShowFromExistingCategories_SubcategoryFromSpecificCategory(string category);
        public object ShowFromExistingCategories_SubcategoryFromCategory(string category);
        public object updateSelectedExistingCategory(ExistingCategory currentExistingCategory, ExistingCategory updateExistingCategory);

        // 6 Fun
    }
}
