using System;

namespace ConsoleApp156
{
    class employee
    {
        ulong empno;
        string empname;
        double empsal;
        internal void empinfo()
        {
            empno = 123;
            empname = "Pavan";
            empsal = 999999;
        }
        internal void empdisplay()
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
            
            obj.empinfo();
            obj.empdisplay();
            Console.ReadLine();
        }
    }
}
