using System;

namespace ConsoleApp167
{
    class employee
    {
        ulong eno;
        string ename;
        ulong esal;
        static string compname;
        static string location;
        static string phnumber;
        static employee()
        {
            compname = "OOPS";
            location = ".NET";
            phnumber = "0123456789";
        }
        internal static void display()
        {
            Console.WriteLine("Company name is:" + compname);
            Console.WriteLine("Company location is:" + location);
            Console.WriteLine("Company contact number is:" + phnumber);
        }
        internal employee(ulong eno, string ename, ulong esal)
        {
            this.eno = eno;
            this.ename = ename;
            this.esal = esal;
        }
        internal void displayy()
        {
            Console.WriteLine("Employee number is:" + eno);
            Console.WriteLine("Employee name is:" + ename);
            Console.WriteLine("Employee salary is:" + esal);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            employee obj1 = new employee(777, "Pavan", 777777);
            obj1.displayy();
            employee.display();
            employee obj2 = new employee(999, "Kalyan", 999999);
            obj2.displayy();
            employee.display();
            Console.ReadLine();
        }
    }
}
