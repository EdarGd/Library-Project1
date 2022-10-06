using System.Data;
using System.Runtime.InteropServices;

namespace DataAccessLayer.GeneralSettingsForSQL
{
    //A class that will represent a procedure,
    //with a list of parameters and the name of the procedure
    public class StoredProcedure
    {
        List<ParamData> sParams;
        public string ProcName;

        public StoredProcedure()
        {
            sParams = new List<ParamData>();
            ProcName = "";
        }
        public void SetParam(string pName, SqlDbType pDataType, object? pValue, ParameterDirection pDirection, [OptionalAttribute] int? pSize)
        {

            ParamData pData = new ParamData(pName, pDataType, pValue, pDirection, pSize);
            sParams.Add(pData);
        }


        //We will add a function to get the
        //list of parameters, parameter by name

        public List<ParamData>? GetParams()
        {
            if (sParams.Count != 0)
            {
                return sParams;
            }
            else
            {
                return null;
            }
        }


        public ParamData? GetParamByName(string pNameGet)
        {
            if (sParams.Count != 0)
            {
                foreach (ParamData pData in sParams)
                {
                    if (pData.pName == pNameGet)
                    {
                        return pData;
                    }
                }
                return null;

            }
            else
            {
                return null;
            }
        }
    }

}
