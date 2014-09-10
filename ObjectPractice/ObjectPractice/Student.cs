using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Student
    {
        //Step 1 declare prperties
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> Courses { get; set; }

        //Step 2 create contructors
        public Student(int studentID, String firstName, string lastName)
        {
            this.StudentID = studentID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Courses = new List<Course>();
        }
        //STEP 3 Methods and Functions
        public void PrintInfo()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName);
            Console.WriteLine("Student ID: " + this.StudentID);

            //write out each course and its grade 

            Console.WriteLine(string.Join("\n", this.Courses.Select(x => x.GetCourseInfo())));

            Console.WriteLine("GPA: {0}", this.Courses.Average(x => x.GradePoints));
        }
           
    }
}
