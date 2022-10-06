using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLayer.Components.Single.Show;

using AppLayer.SpecialComponents;

namespace AppLayer.Components.Single
{
    public partial class btnShow : UserControl
    {
        public btnShow()
        {
            InitializeComponent();
            try
            {
                HelpFunc.addImgCursor("Move.png", new Size(50, 50), pictureBox1);
            }
            catch
            {
                return;
            }
        }

        public void addEventTopictureBox1Click(object objShow,string nameTableOfItem)
        {
            pictureBox1.Click += new EventHandler((sender, e) => seeItem(objShow,nameTableOfItem));
        }

        public void seeItem(object objShow, string nameTableOfItem)
        {
            switch (nameTableOfItem)
            {
                case "Book":
                    if(objShow != null)
                    {
                        showFormBook showBook = new showFormBook(objShow as DataAccessLayer.Entities.Book);
                        openPopForm(showBook);
                    }
                    else
                    {
                        MessageBox.Show("no null !");
                    }
                    break;

                case "Borrow":
                    if (objShow != null)
                    {
                        showFormBorrow showBorrow = new showFormBorrow(objShow as DataAccessLayer.Entities.Borrow);
                        openPopForm(showBorrow);
                    }
                    else
                    {
                        MessageBox.Show("no null !");
                    }
                    
                    break;

                case "ExistingCategories":
                    if (objShow != null)
                    {
                        showFormExistingCategory showExistingCategory = new showFormExistingCategory(objShow as DataAccessLayer.Entities.ExistingCategory);
                        openPopForm(showExistingCategory);
                    }
                    else
                    {
                        MessageBox.Show("no null !");
                    }
                    break;

                case "User":
                    if (objShow != null)
                    {
                        showFormUser showUser = new showFormUser(objShow as DataAccessLayer.Entities.User);
                        openPopForm(showUser);
                    }
                    else
                    {
                        MessageBox.Show("no null !");
                    }
                    
                    break;

            }
        }

        private void openPopForm(Form popForm)
        {
            popForm.Activate();
            popForm.Show();
            //popForm.Location = new Point((this.Width - popForm.Width) / 2, (this.Height - popForm.Height) / 2);
            // button in table in user in form
            Form mainForm = this.Parent.Parent.Parent as Form;
            // we want center so we divide width by 2
            int XplusWidth = mainForm!.Location.X + mainForm!.Width / 2;
            int resXWithPopWidth = XplusWidth - popForm.Width / 2;

            // we want center so we divide width by 2
            int YplusHeight = mainForm.Location.Y + mainForm.Height / 2;
            int resYWithPopHeight = YplusHeight - popForm.Height / 2;

            //popForm.Location = new Point((this.Parent.Parent.Parent.Width - popForm.Width) + popForm.Location.X, resHeightWithLocation);
            //popForm.StartPosition = mainForm.CenterScreen;
            popForm.Location = new Point(resXWithPopWidth,resYWithPopHeight);
        }



    }
}
