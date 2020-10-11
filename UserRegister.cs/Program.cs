using System;
namespace RegexUserValidation
 {
    class Program
    {
        static void Main(string[] args)
        {
            RegexValidation regex = new RegexValidation();
            bool validResult = regex.ValidateFirstName();
            bool validLastNameResult = regex.ValidateLastName();
            bool validEmail = regex.ValidateEmail();
            bool validNumber = regex.ValidateMobileNumber();
            bool validPassword = regex.ValidatePassword();
            Console.WriteLine("First name: " + validResult);
            Console.WriteLine("Last name: " + validLastNameResult);
            Console.WriteLine("Email: " + validEmail);
            Console.WriteLine("Mobile number: " + validNumber);
            Console.WriteLine("Password: " + validPassword);
            Console.ReadKey();
        }
    }
}
