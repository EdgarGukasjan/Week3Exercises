using System;

namespace VowelesAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta täht");
            char userCharacter = Convert.ToChar(Console.ReadLine().ToLower());

			switch (userCharacter)
                {
				case 'a':
					Console.WriteLine("Vowel");
					break;
				case 'e':
					Console.WriteLine("Vowel");
					break;
				case 'i':
					Console.WriteLine("Vowel");
					break;
				case 'o':
					Console.WriteLine("Vowel");
					break;
				case 'u':
					Console.WriteLine("Vowel");
					break;
				default:
					Console.WriteLine("Consonants");
					break;
			}
			Console.WriteLine("Have a nice day bby");
		}

    }
}
