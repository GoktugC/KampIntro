using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Inheritance
    class LegalEntity:Customer
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
        //TCNO, TaxNo gibi şeylerin long yerine string olarak yazılmasının sebebi, matemaiksel bir işlem yapılmayacak olması. Veri uyumsuzluğunu önler.
    }
}
