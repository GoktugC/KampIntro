using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Can be written in both ways.
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryID = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {ID = 2, CategoryID = 5, UnitsInStock = 5, ProductName  = "Kalem", UnitPrice = 35};

            //C# is case sensitive.
            //Pascal Case  //camelCase
            ProductManager productManager = new ProductManager();
            string name = "Göktuğ";
            productManager.Add();
            Console.WriteLine(product1.ProductName);

            //int, double, bool - Value Type
            //arrays, class, abstract class, interface - Reference Type
        }
    }
}
