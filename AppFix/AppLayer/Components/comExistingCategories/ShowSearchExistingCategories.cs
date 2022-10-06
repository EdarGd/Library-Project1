using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppLayer.SpecialComponents;

namespace AppLayer.Components.comExistingCategories
{
    public partial class ShowSearchExistingCategories : UserControl
    {
        public ShowSearchExistingCategories()
        {
            InitializeComponent();
        }

        private void ShowExistingCategories_Load(object sender, EventArgs e)
        {
            string[] fieldsName = {"Category", "Secondary Category","All"};
            Control[] fieldsControls = { panelSecondaryCategory, panelCategory };
            foreach (Control field in fieldsControls)
            {
                field.Hide();
                field.Tag = "hide";
            }
            panel1.Hide();
            HelpFunc.createCheckComboBoxList(fieldsName, checkComboBox1, fieldsControls, panel1);

            Bitmap bitmap = new Bitmap(new Bitmap("Search.png"), new Size(30, 30));
            specialButton1.Cursor = new Cursor(bitmap.GetHicon());
        }
    }
}
