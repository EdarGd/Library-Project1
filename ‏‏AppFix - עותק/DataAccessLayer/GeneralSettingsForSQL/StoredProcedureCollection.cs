namespace DataAccessLayer.GeneralSettingsForSQL
{

    //We will create a class that will be a collection
    //of procedures that we will define,
    //with add and remove functions as needed

    public class StoredProcedureCollection
    {

        public List<StoredProcedure> listStoredProcedures;
        public StoredProcedureCollection()
        {
            listStoredProcedures = new List<StoredProcedure>();
        }

        public void add(StoredProcedure value)
        {
            listStoredProcedures.Add(value);
        }

        public void remove(int index)
        {
            if (index > listStoredProcedures.Count - 1 || index < 0)
            {
                Console.WriteLine("No data to remove");
            }
            else
            {
                listStoredProcedures.RemoveAt(index);
            }
        }

        //In addition there will be a function to receive a specific procedure

        public StoredProcedure getProcedureByIndex(int Index)
        {
            //return (StoredProcedure)listStoredProcedures[Index];
            return listStoredProcedures[Index];
        }

    }
}
