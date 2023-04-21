using System;

namespace ConsoleApp182
{
    class myclass
    {
        internal void print()
        {
            Console.WriteLine("Zero parameter method is calling");
        }
        internal void print(int a)
        {
            Console.WriteLine("One parameter method is calling and value is:" + a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            obj.print();
            obj.print(9);
            Console.ReadLine();
        }
    }
}
