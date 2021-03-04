using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string course1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string course2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string course3 = "Java";
            string course4 = "C#";

            Console.WriteLine("Yazılım Geliştirici Yetiştirme Kampı");
            Console.WriteLine("Programlamaya Başlangıç İçin Temel Kurs");
            Console.WriteLine("Java");
            Console.WriteLine("C#");



            // ARRAY (Dizi)

            string[] courses = new string[] {
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs",
                "Java",
                "Pyhton",
                "C#"};

            for (int i = 0; i < courses.Length; i++)                      //"i++" demek i'yi birer birer arttır demek. "i=i+x" demek i'yi x kadar arttır demek.
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("For Bitti!");

            foreach (string course in courses)                          //Dizilere uygulanır.
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}