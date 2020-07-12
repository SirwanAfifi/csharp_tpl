using System;

namespace csharp_tpl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class PriceEventArgs : EventArgs
    {
        public PriceEventArgs(string name, decimal price)
        {
            TimeStampUtc = DateTime.UtcNow;
            Price = price;
            Name = string.Intern(name);
        }
        public DateTime TimeStampUtc { get; }
        public decimal Price { get; }
        public string Name { get; }
    }
}
