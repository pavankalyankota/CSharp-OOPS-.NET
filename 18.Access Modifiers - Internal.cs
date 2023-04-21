using System;

namespace ConsoleApp34
{
    class class1
    {
        internal void method1()
        {
            Console.WriteLine("Internal method1 is calling");
        }
    }
    class class2 
    {
        internal void method2()
        {
            Console.WriteLine("Internal method2 is claling");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            class1 obj1 = new class1();
            obj1.method1();
            class2 obj2 = new class2();
            obj2.method2();
            Console.ReadLine();
        }
    }
}
