using System;

namespace ConsoleApp62
{
    interface Interface11
    {
        int X
        {
            get;
            set;
        }
        public void display();
        void show();
    }
    class Dc : Interface11
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
            obj1.show();
            Console.ReadLine();
        }
    }
}
