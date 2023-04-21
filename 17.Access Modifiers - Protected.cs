using System;

namespace ConsoleApp34
{
    class class1
    {
        protected void method1()
        {
            Console.WriteLine("Protected method1 is calling");
        }
    }
    class class2 : class1
    {
        internal void method2()
        {
            Console.WriteLine("Internal method2 is claling");
            method1();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            class2 obj2 = new class2();
            obj2.method2();
            Console.ReadLine();
        }
    }
}
