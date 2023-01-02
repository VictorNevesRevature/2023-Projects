using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class InputValidation
    {
        public static bool ValidateEmail(string email)
        {
            Regex emailValid = new Regex(@"^[a-zA-Z0-9]{1,12}@[a-zA-Z]+.[a-zA-Z]{2,6}$"); //accepts up to 12 alphanumeric @ anynumber of alphabet . alpha 2-6 chars
            return emailValid.IsMatch(email);
        }

        public static bool ValidatePassword(string emailPassword)
        {
            Regex passValid = new Regex(@"^[a-zA-z0-9]{4,12}$"); //alphanumeric (lower or upper) between 4 and 12 chars
            return passValid.IsMatch(emailPassword);
        }
    }
}