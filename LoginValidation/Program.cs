using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Username");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your Password");
            string userPassword = Console.ReadLine();

            if(userName != "admin" || userPassword != "a1234") 
            {
                Console.WriteLine("true");
            }
            else
               {
                Console.WriteLine("vale");
            }
        }
    }
}