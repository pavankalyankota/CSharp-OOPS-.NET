using System;

namespace ConsoleApp33
{
    class class1
    {
        private void method1()
        {
            Console.WriteLine("Private method1 is calling");
        }
    }
    class class2
    {
        public void method2()
        {
            Console.WriteLine("Public method2 is calling");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //class1 d1 = new class1();
            // d1.method1();
            class2 d2 = new class2();
            d2.method2();
            Console.ReadLine();
        }
    }
}
