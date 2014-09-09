using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda
{
    class Program
    {
        static void Main(string[] args)
        {

            TextStats("My Name is Brandy. I am slowly but surely getting this coding down. I will continue to work hard so can be as good as Dustin");

            Console.ReadKey();
        }

        static void TextStats(string input)
        {
            List<string> inputList = input.Split(' ').ToList();
            Console.WriteLine("Number of characters: " + input.Length);
            Console.WriteLine("Number of words: " + inputList.Count);
            int vowelCount = input.Count(x => "aeiou".Contains(Char.ToLower(x)));
            Console.WriteLine("Number of vowels: " + vowelCount);
            int consCount = input.Count(x => "qwrtypsdfghjklzxcvbnm".Contains(Char.ToLower(x)));
            Console.WriteLine("Number of consonants: " + consCount);
            int specCount = input.Count(x => "!@#$%^&*()_+-=;':,./<>?".Contains(x));
            Console.WriteLine("Number of special characters: " + specCount);
            Console.WriteLine("Longest Word: " + inputList.OrderByDescending(x => x.Length).First());
            Console.WriteLine("Shortest Word: " + inputList.OrderBy(x => x.Length).First());
        }
    }
}