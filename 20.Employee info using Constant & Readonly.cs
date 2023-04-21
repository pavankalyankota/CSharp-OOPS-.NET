using System;

namespace ConsoleApp173
{
    class employee
    {
        readonly ulong eno;
        readonly string ename;
        double esal;
        byte eage;
        static string compname;
        static string comploc;
        static ulong compphno;
        const string cfounder = "Microsoft";
        const int cestd = 1995;
        internal employee(ulong eno, string ename, double esal, byte eage)
        {
            this.eno = eno;
            this.ename = ename;
            this.esal = esal;
            this.eage = eage;
        }
        static employee()
        {
            compname = "C#.NET";
            comploc = "Windows";
            compphno = 123456789;
        }
        internal void displayempinfo()
        {
            Console.WriteLine("Employee number is:"+eno);
            Console.WriteLine("Employee name is:"+ename);
            Console.WriteLine("Employee salary is:"+esal);
            Console.WriteLine("Employee age is:"+eage);
        }
        internal static void displaycompinfo()
        {
            Console.WriteLine("Company founder name is:" + cfounder);
            Console.WriteLine("Company satablished year is:" + cestd);
            Console.WriteLine("Company name is:" + compname);
            Console.WriteLine("Company location is:" + comploc);
            Console.WriteLine("Company number is:" + compphno);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee(777, "Pavan", 77777, 23);
            emp1.displayempinfo();
            employee.displaycompinfo();
            Console.WriteLine("");
            employee emp2 = new employee(999, "Kalyan", 99999, 25);
            emp2.displayempinfo();
            employee.displaycompinfo();
            Console.ReadLine();
        }
    }
}
