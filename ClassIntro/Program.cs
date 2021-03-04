using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Göktuğ";
            int age = 21;

            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Instructor = "Engin Demiroğ";
            course1.WatchRate = 68;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Instructor = "Kerem Varış";
            course2.WatchRate = 64;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.Instructor = "Berkay Bilgin";
            course3.WatchRate = 80;

            //Console.WriteLine(course1.CourseName + " " + course1.Instructor);

            Course[] courses = new Course[] { course1, course2, course3 };

            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + " : " + course.Instructor);
            }
        }
    }

    class Course
    {
        public string CourseName { get; set; }

        public string Instructor { get; set; }

        public int WatchRate { get; set; }
    }

}
