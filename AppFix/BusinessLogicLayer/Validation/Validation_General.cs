using System.Text.RegularExpressions;
using BusinessLogicLayer.actionFiles;

namespace BusinessLogicLayer.Validation
{
    public  static class Validation_General
    {
        private static FileError _fileError = new FileError();
      
        public static string? checkOnlyLetter(string word)
        {
            if (!Regex.IsMatch(word, @"^[a-zA-Zא-ת]+$"))
            {
                return "Must write only letters ! -> " + word;
            }
            else
            {
                return null;
            }
        }

        public static string insertErr(string err, string newErr, string kindErr)
        {
            _fileError.addError(kindErr, newErr);
            if (err != "")
                err += "\n" + newErr;
            else
                err = newErr;

            return err;


        }
    }
}
