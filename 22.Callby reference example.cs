using System;

namespace ConsoleApp175
{
    class student
    {
        internal void calfee(ref double totfee)
        {
            double transportfee = 6000;
            totfee = totfee + transportfee;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double totfee = 6000;
            student obj = new student();
            obj.calfee(ref totfee);
            Console.WriteLine("Total fee is:" + totfee);
            Console.ReadLine();
        }
    }
}
