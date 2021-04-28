using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexApp
{
    public class Pattern
    {
        string REGEX_FIRSTNAME = "^[A-Z][a-z]{2,}$";
        string REGEX_LASTNAME = "^[A-Z][a-z]{2,}$";
        string REGEX_EMAIL = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        string REGEX_MOBILE = "^[0-9]{2}[ ][1-9][0-9]{9}$";
        string REGEX_PASSWORD = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&-+=()])(?=\\S+$).{8,20}$";
        public bool validateFirstName(string input)
        {
            return Regex.IsMatch(input, REGEX_FIRSTNAME);
        }
        public bool validateLastName(string input)
        {
            return Regex.IsMatch(input, REGEX_LASTNAME);
        }
        public bool validateEmail(string input)
        {
            return Regex.IsMatch(input, REGEX_EMAIL);
        }
        public bool validateMobile(string input)
        {
            return Regex.IsMatch(input, REGEX_MOBILE);
        }
        public bool validatePassword(string input)
        {
            return Regex.IsMatch(input, REGEX_PASSWORD);
        }
    }
}
