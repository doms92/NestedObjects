using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Course
    {
        /// <summary>
        /// The title of the course.
        /// Ex: Advanced .NET Programming
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The course catalog official description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of college credits awarded for
        /// passing the course
        /// </summary>
        public byte Credits { get; set; }

        /// <summary>
        /// The Instructor that teaches the course
        /// </summary>
        public Instructor CourseInstructor { get; set; }
        
        /// <summary>
        /// All the students currently enrolled in the class 
        /// </summary>
        public List<Student> Roster { get; set; }
    }
}
