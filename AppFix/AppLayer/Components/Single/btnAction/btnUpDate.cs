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
using AppLayer.Components.comBook;
using AppLayer.Components.comBorrow;
using AppLayer.Components.comExistingCategories;
using AppLayer.Components.comUser ;

namespace AppLayer.Components.Single.btnAction
{
    public partial class btnUpDate : UserControl
    {
        public btnUpDate()
        {
            InitializeComponent();
            try
            {
                HelpFunc.addImgCursor("Click.png", new Size(50, 50), pictureBox1);
            }
            catch
            {
                return;
            }
        }

        public void addEventTopictureBox1Click(object objUpdate, string nameTableOfItem)
        {
            pictureBox1.Click += new EventHandler((sender, e) => updateItem(objUpdate, nameTableOfItem));
        }

        public void updateItem(object objUpdate, string nameTableOfItem)
        {
            switch (nameTableOfItem)
            {
                case "Book":
                    if (objUpdate != null)
                    {
                        //UpdateBook upBook = new UpdateBook(objShow as DataAccessLayer.Entities.Book);
                        updateFromTable up1 = new updateFromTable(objUpdate, "Book");
                        up1.Show();
                        
                        //showUpUc(upBook);
                    }
                    else
                    {
                        MessageBox.Show("no null !");
                    }
                    break;

                //case "Borrow":
                //    if (objShow != null)
                //    {
                //        showBorrow showBorrow = new showBorrow(objShow as DataAccessLayer.Entities.Borrow);
                //        openPopForm(showBorrow);
                //    }
                //    else
                //    {
                //        MessageBox.Show("no null !");
                //    }

                //    break;

                //case "ExistingCategories":
                //    if (objShow != null)
                //    {
                //        showExistingCategory showExistingCategory = new showExistingCategory(objShow as DataAccessLayer.Entities.ExistingCategory);
                //        openPopForm(showExistingCategory);
                //    }
                //    else
                //    {
                //        MessageBox.Show("no null !");
                //    }
                //    break;

                //case "User":
                //    if (objShow != null)
                //    {
                //        showUser showUser = new showUser(objShow as DataAccessLayer.Entities.User);
                //        openPopForm(showUser);
                //    }
                //    else
                //    {
                //        MessageBox.Show("no null !");
                //    }

                //    break;

            }
        }

        //public void showUpUc(UserControl uc)
        //{
        //    uc.Show();
        //    this.Parent.Parent.Parent.Controls.Add(uc);
        //}
    }
}
