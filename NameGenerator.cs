using System;

namespace NameGenerator
{
    class Program
    {
        static string[] firstNames = { "James", "Robert", "Barbara", "Joseph", "Mary", "Stephanie", "Cynthia", "Nicholas", "Brandon",
                "Gregory", "Patrick", "Ruth", "Julie", "Abigail"};

        static string[] lastNames = {"Smith", "Brown", "Davis", "Thomas", "Taylor", "Rodriguez", "Garcia", "Hill", "Nelson",
                "Rivera", "Campbell", "Baker", "Torres", "Flores" };

        static void Main(string[] args)
        {
            Console.WriteLine(NameGen());

            Console.ReadKey();

        }

        static string NameGen()
        {
            Random rand = new Random();

            string randomName = $"{firstNames[rand.Next(0, 13)]} {lastNames[rand.Next(0, 13)]}";

            return randomName;
        }
    }
}
