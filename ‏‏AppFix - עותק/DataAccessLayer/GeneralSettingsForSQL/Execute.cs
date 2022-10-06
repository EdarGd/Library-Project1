using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer.GeneralSettingsForSQL
{
    //We create class Execute , with static function
    //to execute the stored procedures from the collection.
    //static -> not need create a object of the class

    public class Execute
    {
        // return -> error message / boolean ( true )
        public static object ExecuteSps(StoredProcedureCollection spCollection, SqlConnection Connection)
        {
            try
            {
                // Go over the procedures to be performed
                foreach (StoredProcedure spData in spCollection.listStoredProcedures)
                {
                    SqlCommand cmd = new SqlCommand();
                    if (Connection.State != ConnectionState.Open)
                        Connection.Open();
                    cmd.Connection = Connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = spData.ProcName;

                    //Go over the parameters of the procedure
                    IEnumerator myEnumerator = spData.GetParams()!.GetEnumerator();
                    int i = 0;
                    while (myEnumerator.MoveNext())
                    {
                        ParamData pData = (ParamData)myEnumerator.Current;
                        cmd.Parameters.Add(pData.pName, pData.pDataType);
                        cmd.Parameters[i].Value = pData.pValue;
                        cmd.Parameters[i].Direction = pData.pDirection;
                        if (pData.pSize.HasValue)
                            cmd.Parameters[i].Size = (int)pData.pSize;
                        i++;
                    }
                    //Carrying out the procedure and checking
                    //whether there was an error during the execution

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (cmd.Parameters["@ERROR"].Value != null && cmd.Parameters["@ERROR"].Value.ToString()!.Length > 0)
                    {
                        string message = (string)cmd.Parameters["@ERROR"].Value;

                        // We'll close the connection path so you can read more procedures

                        Connection.Close();
                        return message;
                    }


                    //Checking if there is data
                    else if (dr.HasRows)
                    {
                        SqlDataReader sqlDataReader = (SqlDataReader)dr;
                        var dataTable = new DataTable();
                        dataTable.Load(sqlDataReader);
                        Connection.Close();
                        return dataTable;
                    }
                }
                //Closing the database connection
                Connection.Close();
                return true;
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
    }
}
