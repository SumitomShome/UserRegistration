using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
namespace RegexUserValidation
{
    public class RegexValidation
    {
        public List <string> mail = new List<string>()
        {
            "abc@yahoo.com",
            "abc-100@yahoo.com",
            "abc.100@yahoo.com",
            "abc111@abc.com",
            "abc-100@abc.net",
            "abc@1.com",
            "abc@gmail.com.com",
            "abc+100@gmail.com"
        };
        public static string FIRST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3,}$";
        public static string LAST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3,}$";
        public static string EMAIL_REGEX = "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public static string MOBILE_REGEX = "^[0-9]{2}[ ][6-9]{1}[0-9]{9}$";
        public static string PASSWORD_REGEX = "^(?=.*[A-Z])(?=.*[0-9])(?=[0-9a-zA-Z]*[!@#$%+-]){8,}$";
        public bool ValidateFirstName(string firstName) => Regex.IsMatch(firstName, FIRST_NAME_REGEX) ? true : throw new URCustomException(URCustomException.ExceptionType.INVALID_FIRST_NAME, "Invalid first name");
        public bool ValidateLastName(string lastName) => Regex.IsMatch(lastName, LAST_NAME_REGEX) ? true : throw new URCustomException(URCustomException.ExceptionType.INVALID_LAST_NAME, "Invalid last name");
        public bool ValidateEmail(string email) => Regex.IsMatch(email, EMAIL_REGEX) ? true : throw new URCustomException(URCustomException.ExceptionType.INVALID_EMAIL, "Invalid email");
        public bool ValidateMobileNumber(string mobile) => Regex.IsMatch(mobile, MOBILE_REGEX) ? true : throw new URCustomException(URCustomException.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid mobile number");
        public bool ValidatePassword(string password) => Regex.IsMatch(password, PASSWORD_REGEX) ? true : throw new URCustomException(URCustomException.ExceptionType.INVALID_PASSWORD, "Invalid password");
    }
}
