using System;

namespace ConsoleApp99
{
    class generic
    {
        public void print(int a)
        {
            Console.WriteLine("Print method is calling and value is:" + a);
        }
        public static void show(string s)
        {
            Console.WriteLine("Show method is calling and value is:" + s);
        }
        public void generic1<t>(t x, t y)
        {
            Console.WriteLine("First value is:{0},Second value is:{1}", x, y);
        }
        public static void generic2<t>(t a)
        {
            Console.WriteLine("First value is:{0}", a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            generic.show("Pavan");
            generic.generic2<string>("Kalyan");
            generic.generic2<int>(10);
            generic.generic2<double>(1.23456789);
            generic.generic2<char>('P');
            generic obj = new generic();
            obj.print(99);
            obj.generic1<int>(10, 50);
            obj.generic1<double>(1.234567, 9.999999999);
            obj.generic1<string>("Kota", "Kalyan");
            Console.ReadLine();
        }
    }
}
