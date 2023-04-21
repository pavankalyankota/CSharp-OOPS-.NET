using System;
using System.Threading;

namespace ConsoleApp66
{
    class thread
    {
        public void method1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Method1=" + i);
            }
        }
        public void method2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Method2=" + i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            thread obj = new thread();
            ThreadStart tstart1 = new ThreadStart(obj.method1);
            ThreadStart tstart2 = new ThreadStart(obj.method2);
            Thread thr1 = new Thread(tstart1);
            Thread thr2 = new Thread(tstart2);
            thr1.Start();
            thr2.Start();
            Console.ReadLine();
        }
    }
}
