using System;
namespace RegexUserValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexValidation regex = new RegexValidation();
            string firstName = "Sumitom";
            bool validResult = regex.ValidateFirstName(firstName);
            string lastName = "Shome";
            bool validLastNameResult = regex.ValidateLastName(lastName);
            string mail = "sumitomshome@gmail.com";
            bool validEmail = regex.ValidateEmail(mail);
            string mobileNumber = "9433430056";
            bool validNumber = regex.ValidateMobileNumber(mobileNumber);
            string passwords = "@S9aS982s";
            bool validPassword = regex.ValidatePassword(passwords);
            Console.WriteLine("First name: " + validResult);
            Console.WriteLine("Last name: " + validLastNameResult);
            Console.WriteLine("Email: " + validEmail);
            Console.WriteLine("Mobile number: " + validNumber);
            Console.WriteLine("Password: " + validPassword);
            Console.ReadKey();
        }
    }
}
