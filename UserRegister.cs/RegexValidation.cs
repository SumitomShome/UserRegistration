using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace RegexUserValidation
{
    public class RegexValidation
    {
        public static string FIRST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3,}$";
	public static string LAST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3,}$";
	public static string EMAIL_REGEX = "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
	public static string MOBILE_REGEX = "^[0-9]{2}[ ][6-9]{1}[0-9]{9}$";
	public static string PASSWORD_REGEX = "(?=.*?[._+-@#&*$])(?=.*[A-Z])(?=.*[0-9])([0-9a-zA-z]{7,})"
        public bool ValidateFirstName()
        {
            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine();
            return Regex.IsMatch(firstName, FIRST_NAME_REGEX);
        }
	public bool ValidateLastName()
        {
            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();
            return Regex.IsMatch(lastName, LAST_NAME_REGEX);
        }
	public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, EMAIL_REGEX);
        }
	public bool ValidateMobileNumber()
        {
            Console.WriteLine("Enter country code, then give space and then provide 10 digit mobile number: ");
            string mobile = Console.ReadLine();
            return Regex.IsMatch(mobile, MOBILE_REGEX);
        }
	public bool ValidatePassword()
        {
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            return Regex.IsMatch(password, PASSWORD_REGEX);
        }
    }
}
