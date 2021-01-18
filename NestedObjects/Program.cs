using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor currInst = new Instructor()
            {
                FullName = "Homer Simpson",
                Email = "Homer.Simpson@cptc.edu"
            };

            Student s1 = new Student()
            {
                FirstName = "Jim",
                LastName = "Halpert"
            };

            Student s2 = new Student()
            {
                FirstName = "Creed",
                LastName = "Bratton"
            };

            Student s3 = new Student()
            {
                FirstName = "Kelly",
                LastName = "Brown"
            };

            Course testCourse = new Course();
            testCourse.Title = "CPW 212 - Adv .NET";
            testCourse.Credits = 5;
            testCourse.CourseInstructor = currInst;
            testCourse.Roster = new List<Student>();

            // Adding students to course
            testCourse.Roster.Add(s1);
            testCourse.Roster.Add(s2);
            testCourse.Roster.Add(s3);

            Console.WriteLine(testCourse.Title);
            Console.WriteLine("Is taught by " +
                testCourse.CourseInstructor.FullName);

            Console.WriteLine("Currently Enrolled Students: ");
            foreach(Student s in testCourse.Roster)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}");
            }
            Console.ReadKey();
        }
    }
}
