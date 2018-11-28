using System;

namespace human
{
  partial class Program
    {
        static void Main(string[] args)
        {
            var greg = new Samurai("Greg");
            System.Console.WriteLine(greg.Health);
        }
    }
}
