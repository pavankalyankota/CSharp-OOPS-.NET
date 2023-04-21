using System;

namespace ConsoleApp188
{
    class bc
    {
        internal virtual void display()
        {
            Console.WriteLine("BC method is calling");
        }
    }
    class dc:bc
    {
        internal override void display()
        {
            Console.WriteLine("DC method is calling");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bc obj = new dc();
            obj.display();
            Console.ReadLine();
        }
    }
}
