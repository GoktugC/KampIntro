using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {
        //Naming Convencion 
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + product.Name);
        }

        public void Add2(string productName, string productDescription, double productPrice)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + productName);
        }
    }
}
