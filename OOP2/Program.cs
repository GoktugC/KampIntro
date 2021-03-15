using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            NaturalCustomer customer1 = new NaturalCustomer();
            customer1.ID = 1;
            customer1.CustomerNO = "12345";
            customer1.Name = "Engin";
            customer1.Surname = "Demiroğ";
            customer1.TCNO = "1234567890";

            LegalEntity customer2 = new LegalEntity();
            customer2.ID = 2;
            customer2.CustomerNO = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new NaturalCustomer();
            Customer customer4 = new LegalEntity();


        }
    }
}
