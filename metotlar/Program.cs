using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "elma";
            product1.ProductPrice = 15.4;
            product1.Properties = "Tadı ekşi olan yeşil olanlardır";
            product1.Quantity = 28;

            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductName = "karpuz";
            product2.ProductPrice = 20.5;
            product2.Properties = "Adana karpuz u yaz sıcağında yenir asıl";
            product2.Quantity = 23;

            Product product3 = new Product();
            product3.Id = 3;
            product3.ProductName = "kivi";
            product3.ProductPrice = 15.4;
            product3.Properties = "hangi meyveyi düşünürsen onun tadını alırsın denir :)";

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.ProductPrice);
                Console.WriteLine(product.Properties);
            }
            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);



        }
    }
}
