using System;

namespace ConsoleApp53
{
    class employee
    {
        public virtual void calsal(double basicsal)
        {
            double grosssal = basicsal;
            Console.WriteLine("Employee salary is:" + grosssal);
        }
    }
    class software : employee
    {
        public override void calsal(double basicsal)
        {
            double gra = basicsal * 0.4;
            double grosssal = basicsal + gra;
            Console.WriteLine("Software salary is:" + grosssal);
        }
    }
    class manager : employee
    {
        public override void calsal(double basicsal)
        {
            double gra = basicsal * 0.4;
            double hr = basicsal * 0.3;
            double grosssal = gra + hr + basicsal;
            Console.WriteLine("Manager salary is:" + grosssal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new software();
            emp1.calsal(500);
            emp1 = new manager();
            emp1.calsal(1000);
            Console.ReadLine();
        }
    }
}
