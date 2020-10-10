using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace RegexUserValidation
{
    public class RegexValidation
    {
        public static string FIRST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3,}$";
        public bool ValidateFirstName()
        {
            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine();
            return Regex.IsMatch(firstName, FIRST_NAME_REGEX);
        }
    }
}
