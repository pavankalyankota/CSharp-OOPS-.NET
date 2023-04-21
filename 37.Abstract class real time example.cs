using System;

namespace ConsoleApp59
{
    abstract class customer
    {
        public void amount()
        {
            Console.WriteLine("Total amount is displaying;");
        }
        public abstract void calbill(int totunits);
    }
    class Industrycustomer : customer
    {
        public override void calbill(int totunits)
        {
            double totbill = totunits * 10;
            Console.WriteLine("Industry customer bill is:" + totbill);
        }
    }
    class residentialcustomer : customer
    {
        public override void calbill(int totunits)
        {
            double totbill = totunits * 6;
            Console.WriteLine("Residential customer bill is:" + totbill);
        }
    }
    class agriculturecustomer : customer
    {
        public override void calbill(int totunits)
        {
            double totbill = totunits * 2;
            Console.WriteLine("Agriculture customer bill is:" + totbill);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            customer cust = new Industrycustomer();
            cust.amount();
            cust.calbill(90);
            cust = new residentialcustomer();
            cust.calbill(100);
            cust = new agriculturecustomer();
            cust.calbill(100);
            Console.ReadLine();
        }
    }
}
