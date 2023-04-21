using System;

namespace ConsoleApp72
{
    struct pavan
    {
        int a;
        int b;
        static int c;
        static int d;
        public pavan(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        static pavan()
        {
            c = 1000;
            d = 2000;
        }
        public void displayinstancemembers()
        {
            Console.WriteLine("a value is:" + a);
            Console.WriteLine("b value is:" + b);
        }
        public static void displaystaticmembers()
        {
            Console.WriteLine("c value is:" + c);
            Console.WriteLine("d value is:" + d);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            pavan obj = new pavan(200, 500);
            obj.displayinstancemembers();
            pavan.displaystaticmembers();
            Console.ReadLine();
        }
    }
}
