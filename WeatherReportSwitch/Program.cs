using System;

namespace WeatherReportSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mitu kraadi õues on?");
            int userTemp = Convert.ToInt32(Console.ReadLine());
            switch (userTemp)
            {
                case var _ when userTemp < 0:
                    Console.WriteLine("Üli külm");
                        break;
                case var _ when userTemp  >= 0 && userTemp < 10:
                    Console.WriteLine("Külm");
                    break;
                case var _ when userTemp >= 10 && userTemp < 20:
                    Console.WriteLine("Jahe");
                    break;
                case var _ when userTemp >= 20 && userTemp < 30:
                    Console.WriteLine("Mõnus");
                    break;
                case var _ when userTemp >= 30 && userTemp < 35:
                    Console.WriteLine("Kuum");
                    break;
                default:
                    Console.WriteLine("Üli kuum");
                    break;





            } 
    }
}
