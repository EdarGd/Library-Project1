using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Media;
using BusinessLogicLayer.Validation;
using BusinessLogicLayer.StoredProceduresLogic;
using DataAccessLayer.Entities;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppLayer
{
    public partial class Login : Form
    {
        // save values
        private Rectangle[] controlerOriginalRectangle;
        // save pointer to controls
        private Control[] controls;
        private Rectangle originalFormSize;

        private UserLogic userLogic;

        public Login()
        {
            InitializeComponent();
            userLogic = new UserLogic();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"appSong.wav");
            simpleSound.Stop();
            simpleSound.PlayLooping();
            //simpleSound.Play();

            specialButton1.Cursor = new Cursor("Click.cur");

            Bitmap cm = new Bitmap(new Bitmap("Move.png"), 80, 80);
            specialButton1.Cursor = new Cursor(cm.GetHicon());

            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);

            controlerOriginalRectangle = new Rectangle[this.Controls.Count];
            controls = new Control[this.Controls.Count];
            // copy all collection to array from 0
            this.Controls.CopyTo(controls, 0);

            //// Loop over tuples with the item and its index
            foreach (var (control, index) in controls.Select((value, i) => (value, i)))
            {
                controlerOriginalRectangle[index] = new Rectangle(control.Location.X, control.Location.Y, control.Width, control.Height);
            }

            List<Control> listControls = controls.ToList();
        }

        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // loop over controls and updates values
            foreach (var (control, index) in controls.Select((value, i) => (value, i)))
            {
                resizeControl(controlerOriginalRectangle[index], control);
            }

        }

        private void specialButton1_Click(object sender, EventArgs e)
        {
            string? checkValues;
            checkValues = Validation_CheckUser.checkId(id.Text);
            checkAndSetError(id,checkValues);

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
                    mainApp.TopLevel = false;
                    mainApp.Parent = this.MdiParent;
                    mainApp.Activate();
                    mainApp.Location = new Point((this.MdiParent.Width - mainApp.Width) / 2, (this.MdiParent.Height - mainApp.Height) / 2);
                    mainApp.Show();
                    this.Close();

                    //MainApp mainApp = new MainApp();
                    //mainApp.Show();
                    //this.Hide();
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
    }
}
