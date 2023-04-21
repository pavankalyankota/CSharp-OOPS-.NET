using System;

namespace ConsoleApp28
{
    class employee
    {
        ulong empno;
        string empname;
        double empsal;
        internal employee(ulong empno, string empname, double empsal)
        {
            this.empno = empno;
            this.empname = empname;
            this.empsal = empsal;

        }
        internal void display()
        {
            Console.WriteLine("Employee number is:" + empno);
            Console.WriteLine("Employee name is:" + empname);
            Console.WriteLine("Employee salary is:" + empsal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee(123, "Pavan", 40000);
            emp1.display();
            employee emp2 = new employee(456, "Kalyan", 60000);
            emp2.display();
            Console.ReadLine();
        }
    }
}
