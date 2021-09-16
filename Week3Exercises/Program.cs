using System;

namespace Week
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma Pin");

            int userPin = Convert.ToInt32(Console.ReadLine()); 

           /*f (userPin == 1234)
            {
                Console.WriteLine("PIN correct");
            }
            else
            {
                Console.WriteLine("Vale PIN, proovi uuesto");
            }*/

            if(userPin != 1234)
            {
                Console.WriteLine("Vale PIN. Proov uuesti");
            }
            else
            {
                Console.WriteLine("tere tulemast");
            }
        }
    }
}
