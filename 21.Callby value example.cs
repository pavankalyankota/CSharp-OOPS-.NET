using System;

namespace ConsoleApp174
{
    class student
    {
        internal void calfee(double totfee)
        {
            double semfee = 1000;
            double admfee = 2000;
            totfee = semfee + admfee;
            Console.WriteLine("Total fee is:" + totfee);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double intfee = 1000;
            student obj = new student();
            obj.calfee(intfee);
            Console.WriteLine("Initial fee is:" + intfee);
            Console.ReadLine();
        }
    }
}
