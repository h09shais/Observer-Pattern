namespace ObserverPattern
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("Product 1", 1235.00);
            product.Attach(new SalesChannel("Shop 1"));
            product.Attach(new SalesChannel("Shop 2"));

            product.Price = 1235.10;
            product.Price = 1235.00;
            product.Price = 1235.00;
            product.Price = 1235.50;
            product.Price = 1235.75;

            Console.ReadLine();
        }
    }
}
