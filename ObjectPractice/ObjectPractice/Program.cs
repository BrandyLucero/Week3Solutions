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
            TicketExample();

            //Car myCar = new Car("Honda", "Civic");
            //Car car2 = new Car();

            ////write info for both cars
            //Console.WriteLine(myCar.GetInfo());
            //Console.WriteLine(car2.GetInfo());

            //myCar.Honk();
            ////Keep console open

            ////create a new nudent
            //Student Pat = new Student(10001, "Pat", "McClary");
            //Student Logan = new Student(10002, "Logan", "Nicklebac k");

            //Pat.Courses.Add(new Course("Hocky 101", "A"));
            //Pat.Courses.Add(new Course("English", "A"));
            //Pat.Courses.Add(new Course("Slackin 101", "F"));
            //Pat.Courses.Add(new Course("Professional Development", "B"));

            //Pat.PrintInfo();

            //Console.ReadKey();


        }

        static void TicketExample()
        {
            // create a new list tohold our tickets
            List<ticket> ticketList = new List<ticket>();
            //create a new ticket 
            ticket ticket1 = new ticket("Nicole", "RSVP form is broken", Priority.Critical);
            //let some time pass
            System.Threading.Thread.Sleep(1000);
            //resolved ticket1
            ticket1.ResolvedTicket();
            //add to ticket list
            ticketList.Add(ticket1);
            // add two more tickets to the list
            //using the hig importance and non critical priorities
            ticketList.Add(new ticket("Brandy" , "Broken Back", Priority.HighImportance));

            Console.WriteLine(string.Join("\n", ticketList.OrderBy(x => x.Priority).Select(x => x.GetTicketInfo())));

            
        }
    }
}
