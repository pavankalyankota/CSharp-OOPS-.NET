using System;

namespace ConsoleApp172
{
    class employee
    {
        ulong eno;
        string ename;
        double esal;
        byte eage;
        ulong ephno;
        static ulong compphno;
        internal employee(ulong eno, string ename, double esal, ulong ephno)
        {
            this.eno = eno;
            this.ename = ename;
            this.esal = esal;
            this.ephno = ephno;
        }
        static employee()
        {
            compphno = 0123456789;
        }
        internal byte Eage
        {
            get
            {
                return eage;
            }
            set
            {
                while (value < 20 || value > 60)
                {
                    Console.Write("Please enter the age between 21 and 60:");
                    value = byte.Parse(Console.ReadLine());
                }
                eage = value;
            }
        } 
        internal ulong Ephno
        {
            get
            {
                return ephno;
            }
        }
        internal static ulong Compphno
        {
            get
            {
                return compphno;
            }
        }
        internal void display()
        {
            Console.WriteLine("Employee number is:" + eno);
            Console.WriteLine("Employee name is:" + ename);
            Console.WriteLine("Employee age is:" + eage);
            Console.WriteLine("Employee salary is:" + esal);
            Console.WriteLine("Employee phonne number is:" + ephno);
            Console.WriteLine("Employee company number is:" + compphno);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee(777, "Pavan", 9999, 7799556688);
            emp1.Eage = 100;
            emp1.display();
            Console.ReadLine();
        }
    }
}
