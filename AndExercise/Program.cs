using System;

namespace AndExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisseta oma punktid matemaatika testist");

            int userMathTest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisseta oma punktid keemia testist");

            int userChemTest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisseta oma punktid bioloogia testist");

            int userBioTest = Convert.ToInt32(Console.ReadLine());

            if (userMathTest >= 85 && userChemTest >= 90 && userBioTest >= 95)
            {
                Console.WriteLine("Saad sisse");
            }
            else
            {
                Console.WriteLine("Pole piisavalt");
            }
        }
    }
}
