using System;

namespace ConsoleApp185
{
    class calculate
    {
        internal void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Addition of 2 integers is:" + c);
        }
        internal void add(int a, int b, int c)
        {
            int d = a + b + c;
            Console.WriteLine("Addiiton of 3 integers is:" + d);
        }
        internal void add(double a, double b)
        {
            double c = a + b;
            Console.WriteLine("Addition of 2 double value is:" + c);
        }
        internal void add(double a, double b, double c)
        {
            double d = a + b + c;
            Console.WriteLine("Addition of 3 double value is:" + d);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            calculate obj = new calculate();
            obj.add(7, 7);
            obj.add(9, 9, 9);
            obj.add(7.77, 7.77);
            obj.add(9.99, 9.99, 9.99);
            Console.ReadLine();
        }
    }
}
