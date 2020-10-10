using System;
namespace RegexUserValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexValidation regex = new RegexValidation();
            bool validResult = regex.ValidateFirstName();
            Console.WriteLine("First name: " + validResult);
            Console.ReadKey();
        }
    }
}
