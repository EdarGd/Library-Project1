using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using DataAccessLayer.Entities;

namespace AppLayer.Components.Single
{
    public partial class getData : Form
    {
        string conStrin = @"Data Source=.;Initial Catalog=Library;Integrated Security=True";

        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public getData()
        {
            InitializeComponent();
            sda = new SqlDataAdapter();

            using (SqlConnection sqlConnection = new SqlConnection(conStrin))
            {
                SqlCommand cmd = new SqlCommand("getUsers", sqlConnection);
                try
                {

                    if (sqlConnection.State != ConnectionState.Open)
                        sqlConnection.Open();
                    // call to procedure that get books
                    //cmd.Parameters.Add(new SqlParameter("@newDay_Date", dayAdd.date));
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ERROR", SqlDbType.NVarChar, 500);
                    cmd.Parameters["@ERROR"].Direction = ParameterDirection.Output;
                    SqlDataReader dr = cmd.ExecuteReader();
                    //cmd.ExecuteNonQuery();
                    //sqlConnection.Close();

                    // Check if was problem with the command
                    if (cmd.Parameters["@ERROR"].Value != null && cmd.Parameters["@ERROR"].Value.ToString().Length > 0)
                    {
                        string message = (string)cmd.Parameters["@ERROR"].Value;
                        MessageBox.Show(message);
                    }

                    else if (dr.HasRows)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(dr);
                        dt = dataTable;
                        sqlConnection.Close();

                        DataAccessLayer.Entities.User user = new DataAccessLayer.Entities.User();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            user = new DataAccessLayer.Entities.User()
                            {
                                Id = row["Id"].ToString()!,
                                Email = row["Email"].ToString()!,
                                Password = row["Password"].ToString()!,
                                FirstName = row["FirstName"].ToString()!,
                                LastName = row["LastName"].ToString()!,
                                Type = (bool)row["Type"] 
                            };
                            MessageBox.Show(user.FirstName.ToString());

                        }
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = dataTable;
                        dataGridView2.DataSource = dataTable;
                    }

                }
                catch (SqlException e)
                {
                    sqlConnection.Close();
                    MessageBox.Show(e.Message);
                }
                

            }
        }

        private void getData_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells.Count.ToString());
        }
    }
}
