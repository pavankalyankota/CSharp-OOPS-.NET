using System;

namespace ConsoleApp155
{
    class myclass
    {
        internal void add(int a, int b)
        {
           int c = a + b;
           Console.WriteLine("Result after addition is:" + c);
        }
        internal void sub(int a, int b)
        {
            int d = a - b;
            Console.WriteLine("Result after subtraction is:" + d);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            Console.Write("Enter first number:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            int y = int.Parse(Console.ReadLine());
            obj.add(x, y);
            obj.sub(x, y);
            Console.ReadLine();
        }
    }
}
