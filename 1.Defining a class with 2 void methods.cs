using System;

namespace ConsoleApp152
{
    class myclass
    {
        internal void Display()
        {
            Console.WriteLine("Display method is calling");
        }
        internal void show()
        {
            Console.WriteLine("Show method is calling");
        }
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            obj.Display();
            obj.show();
            Console.ReadLine();
        }
    }
}
