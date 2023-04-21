using System;

namespace ConsoleApp186
{
    sealed class myclass
    {
        int a;
        static int x;
        internal myclass(int a)
        {
            this.a = a;
        }
       static myclass()
        {
            x = 9;
        }
        internal void display()
        {
            Console.WriteLine("a value is:" + a);
        }
        internal static void display1()
        {
            Console.WriteLine("x value is:" + x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass.display1();
            myclass obj = new myclass(9);
            obj.display();
            Console.ReadLine();
        }
    }
}
