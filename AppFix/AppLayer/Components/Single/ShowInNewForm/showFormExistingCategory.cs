using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLayer.Components.Single.Show
{
    public partial class showFormExistingCategory : Form
    {
        public showFormExistingCategory(DataAccessLayer.Entities.ExistingCategory existingCategory)
        {
            InitializeComponent();
            category.Text = existingCategory.Category;
            secondaryCategory.Text = existingCategory.SecondaryCategory;
        }
    }
}
