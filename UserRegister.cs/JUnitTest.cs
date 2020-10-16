using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using RegexUserValidation;
namespace RegexUserValidation
{
    [TestClass]
    public class UnitTest1
    {
        //Happy Test Cases
        [TestMethod]
        public void GivenUserFirstNameWhenValidatedShouldReturnTrue()
        {
            RegexValidation user = new RegexValidation();
            string firstName = "Sumitom";
            bool result = user.ValidateFirstName(firstName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenUserLastNameWhenValidatedShouldReturnTrue()
        {
            RegexValidation user = new RegexValidation();
            string lastName = "Shome";
            bool result = user.ValidateLastName(lastName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenUserEmailIDWhenValidatedShouldReturnTrue()
        {
            RegexValidation user = new RegexValidation();
            string email = "sumitomshome@gmail.com";
            bool result = user.ValidateEmail(email);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenUserMobileNumberWhenValidatedShouldReturnTrue()
        {
            RegexValidation user = new RegexValidation();
            string mobileNumber = "91 9433430056";
            bool result = user.ValidateMobileNumber(mobileNumber);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenUserPasswordWhenValidatedShouldReturnTrue()
        {
            RegexValidation user = new RegexValidation();
            string password = "8S@99SSaa";
            bool result = user.ValidatePassword(password);
            Assert.IsTrue(result);
        }
        //Sad Test Cases
        [TestMethod]
        public void GivenUserFirstNameWhenValidatedShouldReturnFalse()
        {
            RegexValidation user = new RegexValidation();
            string firstName = "sumitom";
            bool result = user.ValidateFirstName(firstName);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenUserLastNameWhenValidatedShouldReturnFalse()
        {
            RegexValidation user = new RegexValidation();
            string lastName = "shome";
            bool result = user.ValidateLastName(lastName);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenUserEmailIDWhenValidatedShouldReturnFalse()
        {
            RegexValidation user = new RegexValidation();
            string email = "sumitomshome";
            bool result = user.ValidateEmail(email);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenUserMobileNumberWhenValidatedShouldReturnFalse()
        {
            RegexValidation user = new RegexValidation();
            string mobileNumber = "91 94";
            bool result = user.ValidateMobileNumber(mobileNumber);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenUserPasswordWhenValidatedShouldReturnFalse()
        {
            RegexValidation user = new RegexValidation();
            string password = "@S";
            bool result = user.ValidatePassword(password);
            Assert.IsFalse(result);
        }
    }
}
