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

namespace AppLayer.Components.comUser
{
    public partial class ShowSearchUser : UserControl
    {
        public ShowSearchUser()
        {
            InitializeComponent();
        }

        private void ShowUser_Load(object sender, EventArgs e)
        {
            string[] fieldsName = { "Id",
                                    "First Name", "Last Name",
                                    "Kind User",
                                    "Email", "Password","All"};
            Control[] fieldsControls = { panelPassword, panelType, panelEmail, panelLastName, panelFirstName, panelId };
            foreach (Control field in fieldsControls)
            {
                field.Hide();
                field.Tag = "hide";
            }
            panel1.Hide();
            HelpFunc.createCheckComboBoxList(fieldsName, checkComboBox1, fieldsControls, panel1);
            //CheckComboBoxItem[] checkComboBoxItems = new CheckComboBoxItem[fieldsName.Length];
            //foreach (var (field, index) in fieldsName.Select((field, index) => (field, index)))
            //{
            //    checkComboBoxItems[index] = new CheckComboBoxItem(field, false);
            //}
            //checkComboBox1.Items.AddRange(checkComboBoxItems);

            //// wire up the check state changed event
            //this.checkComboBox1.CheckStateChanged += new System.EventHandler(this.checkComboBox1_CheckStateChanged);

            Bitmap bitmap = new Bitmap(new Bitmap("Search.png"), new Size(30, 30));
            specialButton1.Cursor = new Cursor(bitmap.GetHicon());
        }
    }
}
