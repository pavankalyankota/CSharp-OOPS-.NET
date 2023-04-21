using System;

namespace ConsoleApp100
{
    class generic<t>
    {
        t a;
        public generic(t a1)
        {
            a = a1;
        }
        public void generic1<t>(t x)
        {
            Console.WriteLine("x value is:" + x);
            Console.WriteLine("a value is:" + a);
        }
        public void nongeneric()
        {
            Console.WriteLine("Non-Generic method is calling");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            generic<int> obj = new generic<int>(99);
            obj.generic1(10);
            obj.generic1("Pavan");
            obj.generic1('P');
            obj.nongeneric();
            generic<string> obj2 = new generic<string>("Kota");
            obj2.generic1(10);
            obj2.generic1("Kalyan");
            obj2.generic1('K');
            obj2.nongeneric();
            Console.ReadLine();
        }
    }
}
