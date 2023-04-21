using System;

namespace ConsoleApp24
{
    class employee
    {
        ulong empno;
        string empname;
        string empdesig;
        double empsal;
        double incsal;
        internal employee(ulong eno, string ename, string edesig, double esal)
        {
            empno = eno;
            empname = ename;
            empdesig = edesig;
            empsal = esal;

        }
        internal void hike()
        {
            incsal = empsal + empsal * 0.1;
        }
        internal void display()
        {
            Console.WriteLine("employee no is:" + empno);
            Console.WriteLine("employee name is: " + empname);
            Console.WriteLine("employee designametion is:" + empdesig);
            Console.WriteLine("employee salary before increment is:" + empsal);
            Console.WriteLine("employee salary after increment is:" + incsal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee(123, "Pavan", "Analyst", 10000);
            emp1.hike();
            emp1.display();
            employee emp2 = new employee(456, "Kalyan", "programmer", 20000);
            emp2.hike();
            emp2.display();
            Console.ReadLine();
        }
    }
}
