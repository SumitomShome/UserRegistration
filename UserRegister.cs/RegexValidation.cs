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
            string firstName = "Sumitom";
            if (Regex.IsMatch(firstName, FIRST_NAME_REGEX))
            {
                return true;
            }
            else
            {
                throw new URCustomException(URCustomException.ExceptionType.INVALID_FIRST_NAME, "Invalid first name");
            }
        }
        public bool ValidateLastName()
        {
            string lastName = "Shome";
            if (Regex.IsMatch(lastName, LAST_NAME_REGEX))
            {
                return true;
            }
            else
            {
                throw new URCustomException(URCustomException.ExceptionType.INVALID_LAST_NAME, "Invalid last name");
            }
        }
        public bool ValidateEmail(string email)
        {
            RegexValidation regex = new RegexValidation();
            if (Regex.IsMatch(email, EMAIL_REGEX))
            {
                return true;
            }
            else
            {
                throw new URCustomException(URCustomException.ExceptionType.INVALID_EMAIL, "Invalid email");
            }
        }
        public bool ValidateMobileNumber()
        {
            string mobile = "91 9433430056";
            if (Regex.IsMatch(mobile, MOBILE_REGEX))
            {
                return true;
            }
            else
            {
                throw new URCustomException(URCustomException.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid mobile number");
            }
        }
        public bool ValidatePassword()
        {
            string password = "Sa@124534";
            if (Regex.IsMatch(password, PASSWORD_REGEX))
            {
                return true;
            }
            else
            {
                throw new URCustomException(URCustomException.ExceptionType.INVALID_PASSWORD, "Invalid password");
            }
        }
    }
}
