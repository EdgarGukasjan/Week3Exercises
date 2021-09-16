using System;

namespace InstagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kui vana sa oled?");

            int Age = Convert.ToInt32(Console.ReadLine());

            if (Age >= 13)
            {
                Console.WriteLine("Oled piisavalt Vana. Welcome!");
            }
            else if (Age < 13)
            {
                Console.WriteLine("Oled liiga noor!");
            }
        }
    }
}
