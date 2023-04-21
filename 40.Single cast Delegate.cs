using System;

namespace ConsoleApp63
{
    class degclass
    {
        public int mul(int a, int b)
        {
            return a * b;
        }
    }
    public delegate int mydeleg(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            degclass obj = new degclass();
            mydeleg dobj = new mydeleg(obj.mul);
            int res = dobj(50, 50);
            Console.WriteLine("Multiplication result is:" + res);
            Console.ReadLine();
        }
    }
}
