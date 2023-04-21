using System;
using System.Threading;

namespace ConsoleApp67
{
    class thrd
    {
        public void method()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Method=" + i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            thrd obj = new thrd();
            ThreadStart tStart = new ThreadStart(obj.method);
            Thread thr1 = new Thread(tStart);
            Thread thr2 = new Thread(tStart);
            thr1.Start();
            thr2.Start();
            Console.ReadLine();
        }
    }
}
