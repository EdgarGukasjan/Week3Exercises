using System;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mitu kraadi õues on?");
            int userTemp = Convert.ToInt32(Console.ReadLine());

            if (userTemp > 35)
            {
                Console.WriteLine("Tuline");
            }
            else if (userTemp >= 30)
            {
                Console.WriteLine("Kuum");
            }
            else if (userTemp >= 20)
            {
                Console.WriteLine("Mõnus");
            }
            else if (userTemp >= 10)
            {
                Console.WriteLine("Jahe");
            }
            else if (userTemp >= 0)
            {
                Console.WriteLine("Külm");
            }
            Console.WriteLine("Minne õuese");
            /*switch (userTemp)
               {
                case > 35:
                    Console.WriteLine("Kettav kuum");
                    break;
                case (30 > 35):
                    Console.WriteLine("Väga hea");
                    break;
                case 20-30:
                    Console.WriteLine("Hea");
                    break;
                case 10 = 20:
                    Console.WriteLine("Rahuldav");
                    break;
                case 0-10:
                    Console.WriteLine("Puudulik");
                    break;   */
        }
    }
}
