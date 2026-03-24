using System;

namespace MyApp
{
    internal class Movie
    {
        public string genre;
        public string title;
        public int runTimeMinutes;

        public string GetRuntimeInHours()
        {
            int hours = runTimeMinutes / 60;
            int minutes = runTimeMinutes % 60;

            return $"{hours}h {minutes}m";
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{title} - {genre} ({runTimeMinutes} min)");
            Console.WriteLine($"Runtime: {GetRuntimeInHours()}");
        }
    }

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
            Movie movie1 = new Movie();

            movie1.title = "Steven Universe: The Movie";
            movie1.genre = "Fantasy";
            movie1.runTimeMinutes = 94;

            movie1.ShowInfo();
        }
    }
}