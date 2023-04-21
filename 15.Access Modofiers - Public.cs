using System;

namespace ConsoleApp32
{
    class class1
    {
        public void method1()
        {
            Console.WriteLine("Public method1 is calling");
        }
    }
    class class2
    {
        public void method2()
        {
            Console.WriteLine("Public method2 is calling");
            class1 obj1 = new class1();
            obj1.method1();
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
