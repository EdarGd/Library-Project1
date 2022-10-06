using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppLayer.Components.comBook;
using AppLayer.Components.comBorrow;
using AppLayer.Components.comExistingCategories;
using AppLayer.Components.comUser;

using DataAccessLayer.Entities;


using AppLayer.SpecialComponents;

namespace AppLayer
{
    public partial class Main : Form
    {

        private Rectangle[] controlerOriginalRectangle;
        // save pointer to controls
        private Control[] controls;
        private Rectangle originalFormSize;
        User user;
        


        public Main(User _user)
        {
            InitializeComponent();
            HelpFunc.Form_LoadCreateRectangles(ref originalFormSize, ref controls, ref controlerOriginalRectangle, this);
            user = _user;
        }

        private void Main_Load(object sender, EventArgs e)
        {

            nameUser.Text = user.FirstName+ " " + user.LastName;
            HelpFunc.playSound(@"appSong.wav");

            // rules - 
            // Library employees can access everything
            //// A library subscriber can access:
            //Book : show
            //Borrow : show only of him

            #region createBasicMenu

            #region createMenuApp
            // 
            // menuApp
            // 
            menuApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            showToolStripMenuItem,
            showToolStripMenuItem1});
            #endregion

            #region ToolStripMenu - Book
            // 
            // ToolStripMenu - Book
            // 
            this.showToolStripMenuItem.Image = global::AppLayer.Properties.Resources.BookIcon;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.showToolStripMenuItem.Text = "Books";
            this.showToolStripMenuItem.DropDownItems.Add(this.showToolStripMenuItem5);
            // 
            // Show
            // 
            this.showToolStripMenuItem5.Name = "showToolStripMenuItem5";
            this.showToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem5.Text = "Show";
            this.showToolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.showAllToolStripMenuItem1,
                this.showSearchToolStripMenuItem1}); ;
            //
            // Show All
            //
            this.showAllToolStripMenuItem1.Size = new System.Drawing.Size(200, 30);
            this.showAllToolStripMenuItem1.Text = "Show All";
            this.showAllToolStripMenuItem1.Click += new System.EventHandler(this.MenuItem_Click);
            //
            // Show Search
            //
            this.showSearchToolStripMenuItem1.Size = new System.Drawing.Size(200, 30);
            this.showSearchToolStripMenuItem1.Text = "Show Search";
            this.showSearchToolStripMenuItem1.Click += new System.EventHandler(this.MenuItem_Click);
            #endregion

            #region ToolStripMenu - Borrow

            // 
            // ToolStripMenu - Borrow
            // 
            this.showToolStripMenuItem1.DropDownItems.Add(this.showToolStripMenuItem7);
            this.showToolStripMenuItem1.Image = global::AppLayer.Properties.Resources.BorrowIcon;
            this.showToolStripMenuItem1.Name = "showToolStripMenuItem1";
            this.showToolStripMenuItem1.Size = new System.Drawing.Size(73, 20);
            this.showToolStripMenuItem1.Text = "Borrow";

            // 
            // Show
            // 
            this.showToolStripMenuItem7.Name = "showToolStripMenuItem7";
            this.showToolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem7.Text = "Show";
            this.showToolStripMenuItem7.DropDownItems.Add(this.showSearchToolStripMenuItem2);

            //
            // Show Search
            //
            this.showSearchToolStripMenuItem2.Size = new System.Drawing.Size(200, 30);
            this.showSearchToolStripMenuItem2.Text = "Show Search";
            this.showSearchToolStripMenuItem2.Click += new System.EventHandler(this.MenuItem_Click);


            #endregion

            #endregion

            if (true)
            {
                #region createAdvanceMenu

                #region addToMenu
                // 
                // menuApp
                // 
                menuApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                showToolStripMenuItem2,
                showToolStripMenuItem3});
                #endregion

                #region ToolStripMenu - Book
                // 
                // ToolStripMenu - Book
                // 
                this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.addToolStripMenuItem,
                this.showToolStripMenuItem4,
                this.showToolStripMenuItem5,
                this.updateToolStripMenuItem});
               
                // 
                // Add
                // 
                this.addToolStripMenuItem.Name = "addToolStripMenuItem";
                this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
                this.addToolStripMenuItem.Text = "Add";
                this.addToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
                // 
                // Delete
                // 
                this.showToolStripMenuItem4.Name = "showToolStripMenuItem4";
                this.showToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
                this.showToolStripMenuItem4.Text = "Delete";
                this.showToolStripMenuItem4.Click += new System.EventHandler(this.MenuItem_Click);
                // 
                // Update
                // 
                this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
                this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
                this.updateToolStripMenuItem.Text = "Update";
                this.updateToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
                #endregion

                #region ToolStripMenu - Borrow

                // 
                // ToolStripMenu - Borrow
                // 
                this.showToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.addToolStripMenuItem1,
                this.showToolStripMenuItem6,
                this.showToolStripMenuItem7,
                this.updateToolStripMenuItem1});
                // 
                // Add
                // 
                this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
                this.addToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
                this.addToolStripMenuItem1.Text = "Add";
                this.addToolStripMenuItem1.Click += new System.EventHandler(this.MenuItem_Click);
                // 
                // Delete
                // 
                this.showToolStripMenuItem6.Name = "showToolStripMenuItem6";
                this.showToolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
                this.showToolStripMenuItem6.Text = "Delete";
                this.showToolStripMenuItem6.Click += new System.EventHandler(this.MenuItem_Click);
                //
                // Show All 
                //
                this.showToolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.showAllToolStripMenuItem2,this.showSearchToolStripMenuItem2});
                this.showAllToolStripMenuItem2.Text = "Show All";
                this.showAllToolStripMenuItem2.Size = new System.Drawing.Size(200, 30);
                // 
                // Update
                // 
                this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
                this.updateToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
                this.updateToolStripMenuItem1.Text = "Update";
                this.updateToolStripMenuItem1.Click += new System.EventHandler(this.MenuItem_Click);

                #endregion


                #region ToolStripMenu - Categories
                // 
                // ToolStripMenu - Categories
                // 
                this.showToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.addToolStripMenuItem2,
                this.deleteToolStripMenuItem,
                this.showToolStripMenuItem8,
                this.updateToolStripMenuItem2});
                this.showToolStripMenuItem2.Image = global::AppLayer.Properties.Resources.ExistingCategoriesIcon;
                this.showToolStripMenuItem2.Name = "showToolStripMenuItem2";
                this.showToolStripMenuItem2.Size = new System.Drawing.Size(91, 20);
                this.showToolStripMenuItem2.Text = "Categories";

                // 
                // Add
                // 
                this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
                this.addToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
                this.addToolStripMenuItem2.Text = "Add";
                this.addToolStripMenuItem2.Click += new System.EventHandler(this.MenuItem_Click);
                // 
                // Delete
                // 
                this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
                this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
                this.deleteToolStripMenuItem.Text = "Delete";
                this.deleteToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
                // 
                // Show
                // 
                this.showToolStripMenuItem8.Name = "showToolStripMenuItem8";
                this.showToolStripMenuItem8.Size = new System.Drawing.Size(180, 22);
                this.showToolStripMenuItem8.Text = "Show";
                this.showToolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                    this.showAllToolStripMenuItem3, this.showSearchToolStripMenuItem3 });
                //
                // Show All
                //
                this.showAllToolStripMenuItem3.Size = new System.Drawing.Size(200, 30);
                this.showAllToolStripMenuItem3.Text = "Show All";
                this.showAllToolStripMenuItem3.Click += new System.EventHandler(this.MenuItem_Click);
                //
                // Show Search
                //
                this.showSearchToolStripMenuItem3.Size = new System.Drawing.Size(200, 30);
                this.showSearchToolStripMenuItem3.Text = "Show Search";
                this.showSearchToolStripMenuItem3.Click += new System.EventHandler(this.MenuItem_Click);
                // 
                // updateToolStripMenuItem2
                // 
                this.updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
                this.updateToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
                this.updateToolStripMenuItem2.Text = "Update";
                this.updateToolStripMenuItem2.Click += new System.EventHandler(this.MenuItem_Click);

                #endregion

                #region ToolStripMenu - Users
                // 
                // ToolStripMenu - Users
                // 
                this.showToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.addToolStripMenuItem3,
                this.deleteToolStripMenuItem1,
                this.showToolStripMenuItem9,
                this.updateToolStripMenuItem3});
                this.showToolStripMenuItem3.Image = global::AppLayer.Properties.Resources.UserIcon;
                this.showToolStripMenuItem3.Name = "showToolStripMenuItem3";
                this.showToolStripMenuItem3.Size = new System.Drawing.Size(63, 20);
                this.showToolStripMenuItem3.Text = "Users";


                // 
                // Add
                // 
                this.addToolStripMenuItem3.Name = "addToolStripMenuItem3";
                this.addToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
                this.addToolStripMenuItem3.Text = "Add";
                this.addToolStripMenuItem3.Click += new System.EventHandler(this.MenuItem_Click);
                // 
                // Delete
                // 
                this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
                this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
                this.deleteToolStripMenuItem1.Text = "Delete";
                this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.MenuItem_Click);
                // 
                // Show
                // 
                this.showToolStripMenuItem9.Name = "showToolStripMenuItem9";
                this.showToolStripMenuItem9.Size = new System.Drawing.Size(180, 22);
                this.showToolStripMenuItem9.Text = "Show";
                this.showToolStripMenuItem9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                    this.showAllToolStripMenuItem4,this.showSearchToolStripMenuItem4 });
                //
                // Show All
                //
                this.showAllToolStripMenuItem4.Size = new System.Drawing.Size(200, 30);
                this.showAllToolStripMenuItem4.Text = "Show All";
                this.showAllToolStripMenuItem4.Click += new System.EventHandler(this.MenuItem_Click);
                //
                // Show Search
                //
                this.showSearchToolStripMenuItem4.Size = new System.Drawing.Size(200, 30);
                this.showSearchToolStripMenuItem4.Text = "Show Search";
                this.showSearchToolStripMenuItem4.Click += new System.EventHandler(this.MenuItem_Click);
                // 
                // Update
                // 
                this.updateToolStripMenuItem3.Name = "updateToolStripMenuItem3";
                this.updateToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
                this.updateToolStripMenuItem3.Text = "Update";
                this.updateToolStripMenuItem3.Click += new System.EventHandler(this.MenuItem_Click);

                #endregion
                #endregion

            }




        }

        private void MenuItem_Click(object sender, EventArgs e)
        {

            FormCollection FormsOpen = Application.OpenForms;
            for (int i = 0; i < FormsOpen.Count; i++)
            {
                if (FormsOpen[i].Name != "Main")
                    FormsOpen[i].Close();
            }

            ToolStripMenuItem menuStrip = (ToolStripMenuItem)sender;
            ToolStripItem parent = menuStrip.OwnerItem;
            // show all example in show
            if (parent.Text != "Books" && parent.Text != "Borrow" && parent.Text != "Categories" && parent.Text != "Users")
            {
                parent = parent.OwnerItem;
            }


                switch (parent.Text)
            {
                case "Books":
                    AreaBook book = new AreaBook(menuStrip.Text,null);
                    book.MdiParent = this;
                    book.Activate();
                    book.Show();
                    book.Size = new Size(this.Width - 100, this.Height - 150);
                    book.Location = new Point((this.Width - book.Width) / 2 - 10, (this.Height - book.Height) / 2 - 30);
                    break;

                case "Borrow":
                    AreaBorrow borrow = new AreaBorrow(menuStrip.Text);
                    borrow.MdiParent = this;
                    borrow.Activate();
                    borrow.Show();
                    borrow.Size = new Size(this.Width - 100, this.Height - 150);
                    borrow.Location = new Point((this.Width - borrow.Width) / 2 - 10, (this.Height - borrow.Height) / 2 - 30);
                    break;

                case "Categories":
                    AreaExistingCategories existingCategories = new AreaExistingCategories(menuStrip.Text);
                    existingCategories.MdiParent = this;
                    existingCategories.Activate();
                    existingCategories.Show();
                    existingCategories.Size = new Size(this.Width - 100, this.Height - 150);
                    existingCategories.Location = new Point((this.Width - existingCategories.Width) / 2 - 10, (this.Height - existingCategories.Height) / 2 - 30);
                    break;

                case "Users":
                    AreaUser user = new AreaUser(menuStrip.Text);
                    user.MdiParent = this;
                    user.Activate();
                    user.Show();
                    user.Size = new Size(this.Width - 100, this.Height - 150);
                    user.Location = new Point((this.Width - user.Width) / 2 - 10, (this.Height - user.Height) / 2 - 30);
                    break;
            }

         
        }


        private void Main_Resize(object sender, EventArgs e)
        {
            HelpFunc.Form_Resize(controls, controlerOriginalRectangle, originalFormSize, this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
//MainApp mainApp = new MainApp();
//mainApp.TopLevel = false;
//mainApp.Parent = this.MdiParent;
//mainApp.Activate();
//mainApp.Location = new Point((this.MdiParent.Width - mainApp.Width) / 2, (this.MdiParent.Height - mainApp.Height) / 2);
//mainApp.Show();
//this.Close();
//MainApp mainApp = new MainApp();
//mainApp.Show();
//this.Hide();