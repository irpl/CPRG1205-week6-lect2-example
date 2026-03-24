using System;

namespace MyApp
{
    internal class Product
    {
        public string name;
        public double price;
        public int quantity;

        public double GetTotal()
        {
            return price * quantity;
        }

        public void PrintReceipt()
        {
            Console.WriteLine($"{name}\t - ${price:F2} x {quantity} = ${GetTotal():F2}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.name = "Lotion";
            product1.price = 250;
            product1.quantity = 1;

            Product product2 = new Product();
            product2.name = "Doritos";
            product2.price = 200;
            product2.quantity = 2;

            product1.PrintReceipt();
            product2.PrintReceipt();

            double grandTotal = product1.GetTotal() + product2.GetTotal();
            Console.WriteLine($"\nGrand Total: ${grandTotal:F2}");
        }
    }
}