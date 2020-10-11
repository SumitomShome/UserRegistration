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
            Console.WriteLine("First name: " + validResult);
	    Console.WriteLine("Last name: " + validLastNameResult);
            Console.ReadKey();
        }
    }
}
