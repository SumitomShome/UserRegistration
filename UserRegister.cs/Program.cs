using System;
namespace RegexUserValidation
 {
    class Program
    {
        static void Main(string[] args)
        {
            RegexValidation regex = new RegexValidation();
            bool validEmail1 = regex.ValidateEmail("abc@yahoo.com");
            Console.WriteLine("Email abc@yahoo.com: " + validEmail1);
            bool validEmail2 = regex.ValidateEmail("abc-100@yahoo.com");
            Console.WriteLine("Email abc-100@yahoo.com: " + validEmail2);
            bool validEmail3 = regex.ValidateEmail("abc.100@yahoo.com");
            Console.WriteLine("Email abc.100@yahoo.com: " + validEmail3);
            bool validEmail4 = regex.ValidateEmail("abc111@abc.com");
            Console.WriteLine("Email abc111@abc.com: " + validEmail4);
            bool validEmail5 = regex.ValidateEmail("abc-100@abc.net");
            Console.WriteLine("Email abc-100@abc.net: " + validEmail5);
            bool validEmail6 = regex.ValidateEmail("abc.100@abc.com.au");
            Console.WriteLine("Email abc.100@abc.com.au: " + validEmail6);
            bool validEmail7 = regex.ValidateEmail("abc@1.com");
            Console.WriteLine("Email abc@1.com: " + validEmail7);
            bool validEmail8 = regex.ValidateEmail("abc@gmail.com.com");
            Console.WriteLine("Email abc@gmail.com.com: " + validEmail8);
            bool validEmail9 = regex.ValidateEmail("abc");
            Console.WriteLine("Email abc: " + validEmail9);
            bool validEmail10 = regex.ValidateEmail("abc@.com.my");
            Console.WriteLine("Email abc@.com.my: " + validEmail10);
            bool validEmail11 = regex.ValidateEmail("abc123@gmail.a");
            Console.WriteLine("Email abc123@gmail.a: " + validEmail11);
            bool validEmail12 = regex.ValidateEmail("abc123@.com");
            Console.WriteLine("Email abc123@gmail.com: " + validEmail12);
            bool validEmail13 = regex.ValidateEmail("abc@.com.com");
            Console.WriteLine("Email abc@.com.com: " + validEmail13);
            bool validEmail14 = regex.ValidateEmail(".abc@abc.com");
            Console.WriteLine("Email .abc@abc.com: " + validEmail14);
            bool validEmail15 = regex.ValidateEmail("abc()*@gmail.com");
            Console.WriteLine("Email abc()@gmail.com: " + validEmail15);
            bool validEmail16 = regex.ValidateEmail("abc@%*.com");
            Console.WriteLine("Email abc@%*.com: " + validEmail16);
            bool validEmail17 = regex.ValidateEmail("abc..2002@gmail.com");
            Console.WriteLine("Email abc..2002@gmail.com: " + validEmail17);
            bool validEmail18 = regex.ValidateEmail("abc.@gmail.com");
            Console.WriteLine("Email abc.@gmail.com: " + validEmail18);
            bool validEmail19 = regex.ValidateEmail("abc@abc@gmail.com");
            Console.WriteLine("Email abc@abc@gmail.com: " + validEmail19);
            bool validEmail20 = regex.ValidateEmail("abc@gmail.com.1a");
            Console.WriteLine("Email abc@gmail.com.1a: " + validEmail20);
            bool validEmail21 = regex.ValidateEmail("abc@gmail.com.aa.au");
            Console.WriteLine("Email abc@gmail.com.aa.au: " + validEmail21);
            Console.ReadKey();
        }
    }
}
