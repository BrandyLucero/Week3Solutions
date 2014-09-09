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
            //Call TextStats Function
            TextStats("My Name is Brandy. I am slowly but surely getting this coding down. I will continue to work hard so can be as good as Dustin");

            Console.ReadKey();
        }
        //create function TextStats
        static void TextStats(string input)
        {
            //Lambda expresstion lists out puts 
            List<string> inputList = input.Split(' ').ToList();
            //output number of characters
            Console.WriteLine("Number of characters: " + input.Length);
            //otput number of words
     
            Console.WriteLine("Number of words: " + inputList.Count);
            //output number of vowels
            int vowelCount = input.Count(x => "aeiou".Contains(Char.ToLower(x)));

            Console.WriteLine("Number of vowels: " + vowelCount);
            //lambda expression for number of consonants
            int consCount = input.Count(x => "qwrtypsdfghjklzxcvbnm".Contains(Char.ToLower(x)));
            //output number f consonants
            Console.WriteLine("Number of consonants: " + consCount);
            //lambda expresstion for specialcharachters
            int specCount = input.Count(x => "!@#$%^&*()_+-=;':,./<>?".Contains(x));
            // output number of characters
            Console.WriteLine("Number of special characters: " + specCount);
            //output longeest word
            Console.WriteLine("Longest Word: " + inputList.OrderByDescending(x => x.Length).First());
            //output shortest word
            Console.WriteLine("Shortest Word: " + inputList.OrderBy(x => x.Length).First());
        }
    }
}