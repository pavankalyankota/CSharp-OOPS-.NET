using System;

namespace ConsoleApp159
{
    class employee
    {
        ulong empno;
        string empname;
        double empsal;
        internal employee(ulong eno, string ename, double esal)
        {
            empno = eno;
            empname = ename;
            empsal = esal;
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
            employee obj1 = new employee(999,"Pavan",9999999);
            obj1.display();
            employee obj2 = new employee(777, "Kalyan",77777777);
            obj2.display();
            Console.ReadLine();
        }
    }
}
