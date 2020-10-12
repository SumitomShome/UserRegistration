using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace RegexUserValidation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RegexValidation regex = new RegexValidation();
            regex.ValidateFirstName();
            regex.ValidateLastName();
            regex.ValidateMobileNumber();
            regex.ValidatePassword();
        }
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public bool ValidateEmail(string email)
        {
            string EMAIL_REGEX = "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
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
    }
}
