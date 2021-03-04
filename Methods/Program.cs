using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1, product2};

            // type-safe -- tip güvenli
            foreach (Product product in products)
	        {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("---------------------");
	        }

            Console.WriteLine("-----------Methods-----------");
            //Encapsulation

            CartManager cartManager = new CartManager();
            cartManager.Add(product1);
            cartManager.Add(product2);

            cartManager.Add2("Armut", "Yeşil Armut", 12);
            cartManager.Add2("Elma", "Yeşil Elma", 12);
            cartManager.Add2("Karpuz", "Diyarbakır Karpuzu", 12);
        }
    }
}