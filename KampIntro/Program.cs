using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //type safety

            string categoryTag = "Kategoriler";
            //"string" yazı tutar

            int numberOfStudents = 32000;
            //"int" tam sayı tutar

            double interestRate = 1.45;
            //"double" ondalıklı sayı tutar

            bool signIn = true;
            //"bool" (boolean) true-false verilerini tutar

            double dolarYesterday = 7.35;
            double dolarToday = 7.25;

            if (dolarYesterday > dolarToday)
            {
                Console.WriteLine("Azalış Butonu");
            }

            else if (dolarYesterday < dolarToday)
            {
                Console.WriteLine("Artış Butonu");
            }

            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


            if (signIn == true)
            {
                Console.WriteLine("Kullanııc Ayarları Butonu!");
            }

            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
        }
    }
}
