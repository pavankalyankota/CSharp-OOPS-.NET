using System;

namespace ConsoleApp183
{
    class myclass
    {
        internal void print(int a)
        {
            Console.WriteLine("The value of a is:" + a);
        }
        internal void print(String s)
        {
            Console.WriteLine("The value of s is:" + s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            obj.print(9);
            obj.print("Pavan");
            Console.ReadLine();
        }
    }
}
