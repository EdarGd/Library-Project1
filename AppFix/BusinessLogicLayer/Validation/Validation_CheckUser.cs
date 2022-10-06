using System.Text.RegularExpressions;
using BusinessLogicLayer.actionFiles;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Validation
{
    public static class Validation_CheckUser
    {
        private static FileError _fileError = new FileError();

        public static string? checkEmail(string email)
        {
            var trimmedEmail = email.Trim();
            //            ^     Begin the match at the start of the string.
            //          [^@\s] +  Match one or more occurrences of any character other than the @ character or whitespace.
            //          @	Match the @ character.
            //          \.	Match a single period character.
            //          $	End the match at the end of the string.
            //          a@a.a
            string emailReg = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.Match(trimmedEmail, emailReg).Success ||
               trimmedEmail.EndsWith(".") || trimmedEmail.StartsWith(".") || trimmedEmail.Contains("..") || trimmedEmail.Contains("..") ||
                // compare IndexOf to LastIndexOf to check
                // if there is more than one @
                trimmedEmail.IndexOf("@") != trimmedEmail.LastIndexOf("@"))
            {
                return "The email is not written correctly !";
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address != trimmedEmail)
                {
                    return "The email is not written correctly !";
                }
            }
            catch
            {
                return "The email is not written correctly !";
            }

            return null;
        }

        public static string? checkPassword(string password)
        {
            if (password.Length != 10)
            {
                return "Password must be 10 characters in length !";
            }

            else
            {
                string resCheck = "";
                if (!password.Any(char.IsUpper))
                {
                    resCheck = "Password must contain  an uppercase letter !";
                }
                if (!password.Any(char.IsLower))
                {
                    if (resCheck != "")
                        resCheck += "\n" + "Password must contain  an uppercase letter !";
                }
                if (!password.Any(char.IsLower))
                {
                    if (resCheck != "")
                        resCheck += "\n" + "Password must contain  an uppercase letter !";
                }
                Regex rgx = new Regex("[^A-Za-z0-9]");
                if (!rgx.IsMatch(password))
                {
                    if (resCheck != "")
                        resCheck += "\n" + "Password must contain a special character !";
                }

                if (resCheck != "")
                { return resCheck; }

                else
                { return null; }
            }
        }


        public static string? checkId(string id)
        {
            if (id.Length != 9)
            {
                return "Id must contain 9 digits ! ";
            }

            else
            {

                  //    The test coefficient is in the form of
                 //     1 2 1 2 1 2 1 2 1

                int[] id_12_digits = { 1, 2, 1, 2, 1, 2, 1, 2, 1 };
                int count = 0;

                // The right digit is the check digit
                id = id.PadLeft(9, '0');

                for (int i = 0; i < 9; i++)
                {
                    //Multiply a digit by a check factor and add decimal digits
                    int num = Int32.Parse(id.Substring(i, 1)) * id_12_digits[i];

                    if (num > 9)
                        num = (num / 10) + (num % 10);

                    count += num;
                }

                //Checking if divisible by 10
                if (count % 10 != 0)
                {
                    return "The id format is incorrect ";
                }
                else
                {
                    return null;
                }
            }
        }


        public static string? checkUser(User checkUser)
        {
            #region Checking the correct input

            // Validation for null
            string errsValidUser = "";
            if (checkUser == null)
            {
                errsValidUser = Validation_General.insertErr("", "Values cannot be null", "Client Exception");
                return errsValidUser;
            }

            // Validation for values
            else
            {
                string? checkValid;
                checkValid = checkId(checkUser.Id);
                if (checkValid != null)
                {
                    errsValidUser = Validation_General.insertErr("", checkValid, "Client Exception");
                }

                checkValid = Validation_General.checkOnlyLetter(checkUser.FirstName);
                if (checkValid != null)
                {
                    errsValidUser = Validation_General.insertErr(errsValidUser, checkValid, "Client Exception");
                }

                checkValid = Validation_General.checkOnlyLetter(checkUser.LastName);
                if (checkValid != null)
                {
                    errsValidUser = Validation_General.insertErr(errsValidUser, checkValid, "Client Exception");
                }

                checkValid = checkEmail(checkUser.Email);
                if (checkValid != null)
                {
                    errsValidUser = Validation_General.insertErr(errsValidUser, checkValid, "Client Exception");
                }

                checkValid = checkPassword(checkUser.Password);
                if (checkValid != null)
                {
                    errsValidUser = Validation_General.insertErr(errsValidUser, checkValid, "Client Exception");
                }

            }

            if (errsValidUser != null)
            { return errsValidUser; }

            else
            { return null; }
            #endregion

        }
    }
}
