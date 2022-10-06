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

namespace AppLayer.Components.comBorrow
{
    public partial class ShowSearchBorrow : UserControl
    {
        public ShowSearchBorrow()
        {
            InitializeComponent();
        }

        private void ShowBorrow_Load(object sender, EventArgs e)
        {
            string[] fieldsName = { "Code", "Id","All"};
            Control[] fieldsControls = { panelCode, panelId};
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
