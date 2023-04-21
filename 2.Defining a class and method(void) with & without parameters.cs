using System;

namespace ConsoleApp153
{
    class myclass
    {
        internal void greet()
        {
            Console.WriteLine("Welcome to my repository");
            Console.WriteLine("Thanks for your time & patience");
            Console.WriteLine();
        }
        internal void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Result after addition is:" + c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            obj.greet();
            Console.Write("Enter first number:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            int y = int.Parse(Console.ReadLine());
            obj.add(x, y);
            Console.ReadLine();
        }
    }
}

