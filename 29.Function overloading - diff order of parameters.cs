using System;

namespace ConsoleApp184
{
    class myclass
    {
        internal void print(int a, string s)
        {
            Console.WriteLine("A value is:{0}, S value is:{1}", a, s);
        }
        internal void print(string s, int a)
        {
            Console.WriteLine("S value is:{0}, A value is:{1}", s, a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            obj.print(9, "Pavan");
            obj.print(18, "Kalyan");
            Console.ReadLine();
        }
    }
}
