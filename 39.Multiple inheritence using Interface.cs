using ConsoleApp61;
using System;

namespace ConsoleApp61
{
    interface Interface11
    {
        int X
        {
            get;
            set;
        }
        void display();
    }
    interface Interface22
    {
        void show();
        void display();
    }
    class Dc : Interface11, Interface22
    {
        int x;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public void display()
        {
            Console.WriteLine("Display method is calling");
        }
        public void show()
        {
            Console.WriteLine("Show method is calling");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Interface11 obj1 = new Dc();
            obj1.X = 10;
            Console.WriteLine("X value is:" + obj1.X);
            obj1.display();
            Interface22 obj2 = (Interface22)obj1;
            obj2.show();
            obj2.display();
            Console.ReadLine();
        }
    }
}
