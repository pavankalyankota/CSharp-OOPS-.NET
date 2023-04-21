using System;

namespace ConsoleApp158
{
    class arithematic
    {
       
        internal int add(int x, int y)
        {
            int c = x + y;
            return c;
        }
        internal int sub(int x, int y)
        {
            int c = x - y;
            return c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            arithematic obj = new arithematic();
            Console.Write("Enter x value:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y value:");
            int y = int.Parse(Console.ReadLine());
            int addrel=obj.add(x, y);
            Console.WriteLine("Result after addition is:" + addrel);
            int subrel=obj.sub(x, y);
            Console.WriteLine("Result after subtraction is:" + subrel);
            Console.ReadLine();
;        }
    }
}
