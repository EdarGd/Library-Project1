using System.Data;
using System.Runtime.InteropServices;

namespace DataAccessLayer.GeneralSettingsForSQL
{
    // We create structure to display the structure of a parameter -> 
    // { parameter name, parameter value , parameter direction, size and data type }

    public struct ParamData
    {
        public string pName;
        public SqlDbType pDataType;
        public object? pValue; // can be number , string , date
        public ParameterDirection pDirection;
        public int? pSize;

        public ParamData(string pName, SqlDbType pDataType, object? pValue, ParameterDirection pDirection, [OptionalAttribute] int? size)
        {
            this.pName = pName;
            this.pDataType = pDataType;
            this.pValue = pValue;
            this.pDirection = pDirection;
            this.pSize = size;

        }
    }
}
