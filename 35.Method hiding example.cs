using System;

namespace ConsoleApp55
{
    class Bc
    {
        public void display()
        {
            Console.WriteLine("Bc method is calling");
        }
    }
    class Dc : Bc
    {
        public new void display()
        {
            Console.WriteLine("Dc method is calling");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dc obj = new Dc();
            obj.display();
            Console.ReadLine();
        }
    }
}
