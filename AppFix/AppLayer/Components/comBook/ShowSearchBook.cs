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

namespace AppLayer.Components.comBook
{
    public partial class ShowSearchBook : UserControl
    {
        public ShowSearchBook()
        {
            InitializeComponent();

            // add three check box items to the combo box and set their checked states to true
            string[] fieldsName = { "Code", "Title",
                                    "First Name Author", "Last Name Author",
                                    "Publication Date",
                                    "Category", "Secondary Category","All"};
            Control[] fieldsControls = { panelCode, panelTitle, panelFirstNameAuthor, panelLastNameAuthor, panelPublicationDate, panelSecondaryCategory, panelCategory };
            foreach (Control field in fieldsControls)
            {
                field.Hide();
                field.Tag = "hide";
            }
            panel1.Hide();

            try
            {
                HelpFunc.createCheckComboBoxList(fieldsName, checkComboBox1, fieldsControls, panel1);

                Bitmap bitmap = new Bitmap(new Bitmap("Search.png"), new Size(30, 30));
                specialButton1.Cursor = new Cursor(bitmap.GetHicon());
            }
            catch
            {
                return;
            }
        }

        private void secondaryCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowBook_Load(object sender, EventArgs e)
        {

        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLastNameAuthor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFirstNameAuthor_Paint(object sender, PaintEventArgs e)
        {

        }

        // this message handler gets called when the user checks/unchecks an item the combo box
        //private void checkComboBox1_CheckStateChanged(object sender, EventArgs e)
        //{
        //    if (sender is CheckComboBoxItem)
        //    {
        //        CheckComboBoxItem item = (CheckComboBoxItem)sender;
        //        MessageBox.Show(item.Text);
        //        MessageBox.Show(item.CheckState.ToString());
        //        switch (item.Text)
        //        {
        //            case "One":
        //                //checkBox1.Checked = item.CheckState;
        //                break;
        //            case "Two":
        //                //checkBox2.Checked = item.CheckState;
        //                break;
        //            case "Three":
        //                //checkBox3.Checked = item.CheckState;
        //                break;
        //        }
        //    }
        //}
    }
}
