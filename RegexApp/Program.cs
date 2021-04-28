using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            bool isFirstNameCorrect = pattern.validateFirstName("Captain");
            bool isLastNameCorrect = pattern.validateLastName("Singh");
            bool isEmailCorrect = pattern.validateEmail("singh.captain@gmail.com");
            bool isMobileCorrect = pattern.validateMobile("91 3767563427");
            bool isPasswordCorrect = pattern.validatePassword("Captain#007");

            Console.WriteLine(isFirstNameCorrect);
            Console.WriteLine(isLastNameCorrect);
            Console.WriteLine(isEmailCorrect);
            Console.WriteLine(isMobileCorrect);
            Console.WriteLine(isPasswordCorrect);

            List<string> emailList = new List<string>()
            {
                "abc@yahoo.com",
                "abc-100@yahoo.com",
                "abc.100@yahoo.com",
                "abc111@abc.com",
                "abc-100@abc.net",
                "abc.100@abc.com.au",
                "abc@1.com",
                "abc@gmal.com.co",
                "abc+100@gmail.com"
            };

            foreach (string email in emailList)
            {
                bool isEmail = pattern.validateEmail(email);
                Console.WriteLine(isEmail);
            }


            Console.ReadKey();
        }
    }
}
