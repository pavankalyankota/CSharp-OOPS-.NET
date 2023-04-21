using System;

namespace ConsoleApp64
{
    class muldel
    {
        public void m1()
        {
            Console.WriteLine("Method1 is calling");
        }
        public void m2()
        {
            Console.WriteLine("Method2 is calling");
        }
    }
    public delegate void mydeleg();
    class Program
    {
        static void Main(string[] args)
        {
            muldel obj = new muldel();
            mydeleg dobj = new mydeleg(obj.m1);
            dobj();
            dobj += new mydeleg(obj.m2);
            dobj();
            Console.WriteLine("Multi caste delegate example");
            Console.ReadLine();
        }
    }
}
