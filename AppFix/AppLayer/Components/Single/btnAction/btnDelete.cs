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

namespace AppLayer.Components.Single
{
    //point to function
    public delegate void sqlAction();

    public partial class btnDelete : UserControl
    {
        //public sqlAction deleteItem;
        public btnDelete()
        {
            InitializeComponent();
            try
            {
                HelpFunc.addImgCursor("Delete.png", new Size(50, 50), pictureBox1);
            }
            catch
            {
                return;
            }

        }

        public void addEventTopictureBox1Click(object key, string nameTableOfItem)
        {
            pictureBox1.Click += new EventHandler((sender,e)=>deleteItem(key, nameTableOfItem));
        }

        public void deleteItem(object key, string nameTableOfItem)
        {
            if (MessageBox.Show("Are you sure you want to delete this information?", "ConfirmationSoniccccc", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {

                switch (nameTableOfItem)
                {
                    case "Book":
                        if (key != null)
                        {
                            BookFunc.deleteSelectedBook(key as string);
                        }
                        break;

                    case "Borrow":
                        if (key != null)
                        {
                            BorrowFunc.deleteSelectedBorrow(key as string);
                        }
                        break;

                    case "ExistingCategories":
                        if (key != null)
                        {
                            ExistingCategoriesFun.deleteSelectedExistingCategory(key as DataAccessLayer.Entities.ExistingCategory);
                        }
                        break;

                    case "User":
                        if (key != null)
                        {
                            UserFunc.deleteSelectedUser(key as string);
                        }
                        break;

                }
            }

            else
            {
                MessageBox.Show("Yaaay we stay ! ");
            }
          
        }

    }
}
