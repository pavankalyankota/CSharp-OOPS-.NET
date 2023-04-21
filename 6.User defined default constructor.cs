using System;

namespace ConsoleApp159
{
    class employee
    {
        ulong empno;
        string empname;
        double empsal;
        internal employee()
        {
            empno = 999;
            empname = "Pavan";
            empsal = 9999999999;
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
            employee obj = new employee();
            obj.display();
            Console.ReadLine();
        }
    }
}
