using System;
using System.Threading;

namespace ConsoleApp68
{
    class threadd
    {
        public void method()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "=" + i);
                Thread.Sleep(500);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            threadd obj = new threadd();
            Thread thr1 = new Thread(new ThreadStart(obj.method));
            Thread thr2 = new Thread(new ThreadStart(obj.method));
            thr1.Name = "Pavan";
            thr2.Name = "Kalyan";
            thr1.Start();
            thr2.Start();
            Console.ReadLine();
        }
    }
}
