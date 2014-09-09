using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsBL
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a list of test strings
            List<string> myList = new List<string>() { "tyler", "kiwi", "strawberry", "mango", "peach", "pinapple" };

                OrderByExample(myList);
                WhereExample(myList);
                
                
                
                
            //call the where example 
           
                Console.ReadKey();

        }
        static void OrderByExample(IEnumerable<String> list)
        {
            //order the list by lenght and print them to the console
            List<string> orderedList = list.OrderBy(x => x.Length).ThenBy(x => x).ToList();
            Console.WriteLine(string.Join(" , ", orderedList));

        }
        static void WhereExample(IEnumerable<string> list)
        {
            //print to console all the items in the lis that contains "berry"
            List<string> berries = list.Where(x => x.Contains("berry")).ToList();
            Console.WriteLine(string.Join  (", ", berries));

            List<string> notBerries = list.Where(x => !x.Contains("berry")).ToList();
            Console.WriteLine(string.Join (", ", notBerries));

        }

        static void DistinctExample(IEnumerable<string> list)
        {

            List<int> intList = new List<int>() { 1, 2, 2, 3, 4, 5, 5, 6 };
            Console.WriteLine(string.Join (" , " ,intList.Distinct()));

        }

        static void FirstAndLastExample(IEnumerable<string> list)
        {

        }


        static void SkipAndTakeExample(IEnumerable<string> list)
        {
            List<string> sorted = list.OrderBy(x => x.Length).ToList();
            Console.Write(sorted.Skip(2).Take(1).First());

        }
    }
}

