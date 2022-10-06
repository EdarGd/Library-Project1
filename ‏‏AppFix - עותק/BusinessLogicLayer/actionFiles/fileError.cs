using DataAccessLayer.Entities;
using Newtonsoft.Json;

namespace BusinessLogicLayer.actionFiles
{
    public class FileError
    {

        string directoryPath { get; set; }
        string filePath { get; set; }

        public FileError()
        {
            //PresentionLayer 
            DirectoryInfo pathToApp = Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!;
            directoryPath = Path.Combine(pathToApp.FullName, "Files");
            filePath = Path.Combine(directoryPath, "Errors.txt");

        }

        //// Create textWriter to add and read errors to file 

        public void addError(string type, string desc)
        {

            TextWriter txt = new StreamWriter(filePath, append: true);

            Server_Error newServerErrorObj = new Server_Error()
            {
                typeRequest = type,
                description = desc,
                errorTime = DateTime.Now.ToString("dd'-'MM'-'yyyy' 'HH':'mm':'ss")
            };

            string newServerErrorStr = JsonConvert.SerializeObject(newServerErrorObj);
            txt.WriteLine(newServerErrorStr);
            txt.Close();
        }

        public void getErrors()
        {
            string[] lines = { };
            lines = System.IO.File.ReadAllLines(filePath);
            List<Server_Error> errors = new List<Server_Error>();
            foreach (string line in lines)
            {
                errors.Add(JsonConvert.DeserializeObject<Server_Error>(line)!);
            }
        }
    }
}
