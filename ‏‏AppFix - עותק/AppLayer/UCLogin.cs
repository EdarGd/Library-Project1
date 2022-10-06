using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Media;
using BusinessLogicLayer.Validation;
using BusinessLogicLayer.StoredProceduresLogic;
using DataAccessLayer.Entities;

using AppLayer.SpecialComponents;

namespace AppLayer
{
    public partial class UCLogin : UserControl
    {
        private UserLogic userLogic;


        private Rectangle[] controlerOriginalRectangle;
        // save pointer to controls
        private Control[] controls;
        private Rectangle originalFormSize;

        public UCLogin()
        {
            InitializeComponent();
            HelpFunc.Form_LoadCreateRectangles(ref originalFormSize, ref controls, ref controlerOriginalRectangle, this);
            BusinessLogicLayer.StoredProceduresLogic.BookLogic bookLogic = new BusinessLogicLayer.StoredProceduresLogic.BookLogic();
        }
        
        private void UCLogin_Load(object sender, EventArgs e)
        {
            userLogic = new UserLogic();
            Bitmap cm = new Bitmap(new Bitmap("Move.png"), 80, 80);
            specialButton1.Cursor = new Cursor(cm.GetHicon());

        }

        private void specialButton1_Click(object sender, EventArgs e)
        {
            string? checkValues;
            checkValues = Validation_CheckUser.checkId(id.Text);
            checkAndSetError(id, checkValues);

            checkValues = Validation_CheckUser.checkEmail(email.Text);
            checkAndSetError(email, checkValues);

            checkValues = Validation_CheckUser.checkPassword(password.Text);
            checkAndSetError(password, checkValues);

            if (checkValues == null)
            {
                object resFun = userLogic.ShowFromUser_UserFromSpecific_Id_Email_Password(id.Text, email.Text, password.Text);
                if (resFun.GetType() != typeof(DataTable))
                {
                    MessageBox.Show(resFun.ToString());
                }
                else
                {
                    DataTable dt = (DataTable)resFun;
                    User user = new User();
                    foreach (DataRow row in dt.Rows)
                    {
                        user = new User()
                        {
                            Id = row["id"].ToString()!,
                            Email = row["email"].ToString()!,
                            Password = row["password"].ToString()!,
                            FirstName = row["FirstName"].ToString()!,
                            LastName = row["LastName"].ToString()!,
                            Type = (bool)row["type"]
                        };

                    }

                    MainApp mainApp = new MainApp();
                    mainApp.Show();
                    mainApp.Activate();
                    mainApp.Size = new Size(this.Parent.Width, this.Parent.Height);
                    mainApp.Location = new Point(this.Parent.Location.X, this.Parent.Location.Y);
                    this.Parent.Hide();
                    //mainApp.Parent = this.Parent;
                    //mainApp.Location = new Point(this.Parent.Location.X+((this.Parent.Width - mainApp.Width)/2), this.Parent.Location.Y + ((this.Parent.Height - mainApp.Height) / 2));
                    ////mainApp.Location = new Point(0,0);


                }

            }

        }

        public void checkAndSetError(Control insertErrNext, string? checkRes)
        {
            if (checkRes != null)
            {
                errorPassword.SetError(insertErrNext, checkRes);
            }
            else
            {
                errorPassword.SetError(insertErrNext, String.Empty);
            }
        }

        private void UCLogin_Resize(object sender, EventArgs e)
        {
            HelpFunc.Form_Resize(controls, controlerOriginalRectangle, originalFormSize, this);

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