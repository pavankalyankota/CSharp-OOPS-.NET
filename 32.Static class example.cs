using System;

namespace ConsoleApp50
{
    static class myclass
    {
        public static void show()
        {
            Console.WriteLine("Show method is calling");
        }
        public static void display()
        {
            Console.WriteLine("Display method is calling");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass.show();
            myclass.display();
            Console.ReadLine();
        }
    }
}
