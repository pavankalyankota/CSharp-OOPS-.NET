using System;

namespace ConsoleApp56
{
    abstract class ac
    {
        int a;
        int b;
        public ac(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void display()
        {
            Console.WriteLine("A value is:" + a);
            Console.WriteLine("B value is:" + b);
        }
        public abstract int X
        {
            get;
            set;
        }
        public abstract void show();
    }
    class dc : ac
    {
        int x;
        public dc() : base(100, 200)
        {
        }
        public override int X
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
        public override void show()
        {
            Console.WriteLine("Show method is calling");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ac obj = new dc();
            obj.display();
            obj.X = 10;
            Console.WriteLine("X value is:" + obj.X);
            obj.show();
            Console.ReadLine();
        }
    }
}
