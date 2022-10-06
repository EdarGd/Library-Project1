using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using BusinessLogicLayer.StoredProceduresLogic;

namespace AppLayer.SpecialComponents
{
    public static class ExistingCategoriesFun
    {
        private static ExistingCategorylogic existingCategorylogic = new ExistingCategorylogic();
        public static void createCategories(List<string> categories, ComboBox category)
        {
            object resFun = existingCategorylogic.getExistingCategories();
            if (resFun.GetType() != typeof(DataTable))
            {
                MessageBox.Show(resFun.ToString());
            }
            else
            {
                DataTable dt = (DataTable)resFun;
                foreach (DataRow row in dt.Rows)
                {
                    categories.Add((string)row["Category"]);

                }
            }
            category.DataSource = categories;

        }

        public static void category_SelectedIndexChanged(List<string> secondaryCategorySelect, ComboBox secondaryCategory, string choose)
        {
            
            secondaryCategory.DataSource = null;
            secondaryCategorySelect.Clear();
            object resFun = existingCategorylogic.ShowFromExistingCategories_SubcategoryFromCategory(choose);
            if (resFun.GetType() != typeof(DataTable))
            {
                MessageBox.Show(resFun.ToString());
            }
            else
            {
                secondaryCategorySelect.Add("No secondary category");
                DataTable dt = (DataTable)resFun;
                foreach (DataRow row in dt.Rows)
                {
                    secondaryCategorySelect.Add((string)row["secondaryCategory"]);
                }

            }

            secondaryCategory.DataSource = secondaryCategorySelect;
        }

        public static void deleteSelectedExistingCategory(DataAccessLayer.Entities.ExistingCategory existingCategory)
        {
            MessageBox.Show(existingCategorylogic.deleteSelectedExistingCategory(existingCategory));
        }
    }
}
