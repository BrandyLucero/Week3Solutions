using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Honda", "Civic");
            Car car2 = new Car();

            //write info for both cars
            Console.WriteLine(myCar.GetInfo());
            Console.WriteLine(car2.GetInfo());

            myCar.Honk();
            //Keep console open

            Console.ReadKey();

        }
    }
}
