using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.StoredProceduresLogic;

namespace AppLayer
{
    public partial class UserControl1 : UserControl
    {
        ExistingCategorylogic existingCategorylogic;
        public UserControl1()
        {
            InitializeComponent();
            existingCategorylogic = new ExistingCategorylogic();
        }
    }
}
