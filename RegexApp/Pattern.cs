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
        static string REGEX_FIRSTNAME = "^[A-Z][a-z]{2,}$";
        static string REGEX_LASTNAME = "^[A-Z][a-z]{2,}$";
        static string REGEX_EMAIL = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        static string REGEX_MOBILE = "^[0-9]{2}[ ][1-9][0-9]{9}$";
        static string REGEX_PASSWORD = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&-+=()])(?=\\S+$).{8,20}$";
        
        public Func<string, bool> validateFirstName = (input) =>
        { return Regex.IsMatch(input, REGEX_FIRSTNAME); };
        public Func<string, bool> validateLastName = (input) =>
        { return Regex.IsMatch(input, REGEX_LASTNAME); };
        public Func<string, bool> validateEmail = (input) =>
        { return Regex.IsMatch(input, REGEX_EMAIL); };
        public Func<string, bool> validateMobile = (input) =>
        { return Regex.IsMatch(input, REGEX_MOBILE); };
        public Func<string, bool> validatePassword = (input) =>
        { return Regex.IsMatch(input, REGEX_PASSWORD); };

    }
}
