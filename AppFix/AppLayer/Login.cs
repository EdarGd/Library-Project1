
using System.Data;
using BusinessLogicLayer.Validation;
using BusinessLogicLayer.StoredProceduresLogic;
using DataAccessLayer.Entities;
using AppLayer.SpecialComponents;



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
            HelpFunc.addImgCursor("Move.png", new Size(80, 80), specialButton1);
            HelpFunc.Form_LoadCreateRectangles(ref originalFormSize, ref controls, ref controlerOriginalRectangle, this);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            HelpFunc.Form_Resize(controls, controlerOriginalRectangle, originalFormSize, this);
        }

        private void specialButton1_Click(object sender, EventArgs e)
        {
            string? checkValues;
            checkValues = Validation_CheckUser.checkId(id.Text);
            HelpFunc.checkAndSetError(id,checkValues,errorId);

            checkValues = Validation_CheckUser.checkEmail(email.Text);
            HelpFunc.checkAndSetError(email, checkValues, errorEmail);

            checkValues = Validation_CheckUser.checkPassword(password.Text);
            HelpFunc.checkAndSetError(password, checkValues, errorPassword);

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
                    Main main = new Main(user);
                    main.Location = new Point((this.MdiParent.Width) / 2, (this.MdiParent.Height) / 2);
                    main.Activate();   
                    main.Show();
                    this.MdiParent.Hide();
                }

            }

        }
    }
}
