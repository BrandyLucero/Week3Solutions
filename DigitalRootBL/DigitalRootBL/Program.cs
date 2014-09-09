using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRootBL
{
    class Program
    {
        static void Main(string[] args)
        {
            //call digital root function
            DigitalRoot("");

            //keep console open
            Console.ReadKey();

        }
        static void DigitalRoot(string rootThis)
        {

            Console.WriteLine("Enter a a positive string of integers: ");
            Console.WriteLine();

            rootThis = Console.ReadLine();

            //declare variables
            long number = 0;
            bool isANumber = long.TryParse(rootThis, out number);

            Console.WriteLine();
            //if statement for rootThis
            if (isANumber == true && rootThis.Length < 100 && !rootThis.Contains(".") && !rootThis.Contains("-"))
            {
                //declare long total variable
                long total = 0;
                //for loop
                for (int i = 0; i < rootThis.Length; i++)
                {
                    //declare long number2 variable
                    long number2 = long.Parse(rootThis[i].ToString());
                    //declare total variable
                    total += number;
                }
                //While loop for total
                while (total.ToString().Length > 1)
                {
                    for (int i = 0; i < total.ToString().Length; i++)
                    {
                        //lambda expression for total
                        total = long.Parse(total.ToString()[i].ToString());
                    }

                }
                //Outputs for RootThis
                Console.WriteLine("Input: " + rootThis);
                Console.WriteLine("Output: " + total);
                Console.WriteLine();
                DigitalRoot(" ");

            }
            else
            {
                DigitalRoot(" ");
            }
        }
    }
}

