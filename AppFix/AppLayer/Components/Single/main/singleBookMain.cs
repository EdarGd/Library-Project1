using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public delegate void del_Main_To_Child(string show);
public delegate void del_Child_To_Main(string show);

namespace AppLayer.Components.Single
{
   
    public partial class singleBookMain : Form
    {
        public del_Main_To_Child del_Main_To_Child;


        public singleBookMain()
        {
            InitializeComponent();


            DataAccessLayer.Entities.Book book = new DataAccessLayer.Entities.Book()
            {
                Code = "1",
                Category = "2",
                FirstName_Author = "3",
                LastName_Author = "4",
                PublicationDate = DateTime.Now,
                SecondaryCategory = "5",
                Title = "6"
            };
            //AppLayer.Components.Single.singleBook singleBook  = new AppLayer.Components.Single.singleBook(book);
            //this.Controls.Add(singleBook);
            //singleBook.Show();
            //singleBook.Location = new System.Drawing.Point(10, 250);
            ////singleBook.TabIndex = 7;

            //AppLayer.Components.Single.singleBook.CountLine = 0  ;
            //AppLayer.Components.Single.singleBook singleBook2 = new AppLayer.Components.Single.singleBook(book);
            //this.Controls.Add(singleBook2);
            //singleBook2.Show();
            //singleBook2.Location = new System.Drawing.Point(10, 400);

            //singleBook.Size = new System.Drawing.Size(758, 110);

        }


        public void set_child_to_main(string s)
        {
            label1.Text = s;
        }
        public void showBookName (string bookName)
        {
            MessageBox.Show(bookName);
        }
        // ctrl + k + s
        private void singleBookMain_Load(object sender, EventArgs e)
        {
            del_Main_To_Child += new del_Main_To_Child(singleBook1.setCode);
            singleBook1.del_Child_To_Main += new del_Child_To_Main(set_child_to_main);
            del_Main_To_Child("aaaa");

            BusinessLogicLayer.StoredProceduresLogic.BookLogic bookLogic = new BusinessLogicLayer.StoredProceduresLogic.BookLogic();
            object resFun = bookLogic.getBooks();
            if (resFun.GetType() != typeof(DataTable))
            {
                MessageBox.Show(resFun.ToString());
            }
            else
            {
                DataTable dt = (DataTable)resFun;
                DataAccessLayer.Entities.Book book;
                //dt = dt.AsEnumerable().Reverse().CopyToDataTable();
                foreach (DataRow row in dt.Rows)
                {
                    book = new DataAccessLayer.Entities.Book()
                    {
                        Code = row["Code"].ToString()!,
                        Title = row["Title"].ToString()!,
                        FirstName_Author = row["FirstName_Author"].ToString()!,
                        LastName_Author = row["LastName_Author"].ToString()!,
                        PublicationDate = DateTime.Parse(row["PublicationDate"].ToString()!),
                        Category = row["Category"].ToString()!,
                        SecondaryCategory = row["SecondaryCategory"].ToString()!
                    };

                    singleBook single = new singleBook(book);
                    single.Dock = DockStyle.Top;

                    single.BackColor = getTheme();
                    panelData.Controls.Add(single);
                }
                panelData.AutoScrollPosition = new Point(0, 0);
                //Main main = new Main(user);
                //main.Location = new Point((this.MdiParent.Width) / 2, (this.MdiParent.Height) / 2);
                //main.Activate();
                //main.Show();
                //this.MdiParent.Hide();
            }
        }

        int counter = 0;
        public Color getTheme()
        {
            if(counter %2 == 0)
            {
                counter++;
                return Color.Salmon;
            }
            else
            {
                counter++;
                return Color.Red;   
            }
        }

        private async void LoadBooks()
        {
            await Task.Run(() =>
            {
                BusinessLogicLayer.StoredProceduresLogic.BookLogic bookLogic = new BusinessLogicLayer.StoredProceduresLogic.BookLogic();
                object resFun = bookLogic.getBooks();
                if (resFun.GetType() != typeof(DataTable))
                {
                    MessageBox.Show(resFun.ToString());
                }
                else
                {
                    DataTable dt = (DataTable)resFun;
                    DataAccessLayer.Entities.Book book;
                    //dt = dt.AsEnumerable().Reverse().CopyToDataTable();
                    foreach (DataRow row in dt.Rows)
                    {
                        book = new DataAccessLayer.Entities.Book()
                        {
                            Code = row["Code"].ToString()!,
                            Title = row["Title"].ToString()!,
                            FirstName_Author = row["FirstName_Author"].ToString()!,
                            LastName_Author = row["LastName_Author"].ToString()!,
                            PublicationDate = DateTime.Parse(row["PublicationDate"].ToString()!),
                            Category = row["Category"].ToString()!,
                            SecondaryCategory = row["SecondaryCategory"].ToString()!
                        };

                        singleBook single = new singleBook(book);
                        single.Dock = DockStyle.Top;

                        single.BackColor = getTheme();
                        panelData.Controls.Add(single);
                    }
                    panelData.AutoScrollPosition = new Point(0, 0);
                    //Main main = new Main(user);
                    //main.Location = new Point((this.MdiParent.Width) / 2, (this.MdiParent.Height) / 2);
                    //main.Activate();
                    //main.Show();
                    //this.MdiParent.Hide();
                }
            });

        }

        public async Task<List<string>> getStrings()
        {
            List<string> strings = new List<string>();
            await Task.Run(() =>
            {
                strings.Add("ssss");

            });
            return strings;

        }

        public async void getget()
        {
            List<string> a = await getStrings();
            MessageBox.Show(a.Count+"");
        }
    }
}
