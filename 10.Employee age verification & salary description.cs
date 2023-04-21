using System;

namespace ConsoleApp26
{
    class employee
    {
        ulong eno;
        string ename;
        int eage;
        double basicsal;
        double da;
        double hra;
        double grosssal;
        internal employee(ulong empno, string empname, int empage, double bassal)
        {
            eno = empno;
            ename = empname;
            eage = empage;
            while (empage <= 21 || empage >= 60)
            {
                Console.WriteLine("Please enter the age of employee between 21 and 60");
                int eage = int.Parse(Console.ReadLine());
            }
            basicsal = bassal;
            da = basicsal * 0.10;
            hra = basicsal * 0.20;
            grosssal = basicsal + da + hra;
        }
        internal void display()
        {
            Console.WriteLine("Employee no is:" + eno);
            Console.WriteLine("Employee name is:" + ename);
            Console.WriteLine("Employee age is:" + eage);
            Console.WriteLine("Employee basic salary is:" + basicsal);
            Console.WriteLine("Employee da salary is:" + da);
            Console.WriteLine("Employee hra salary is:" + hra);
            Console.WriteLine("Employee gross salary is:" + grosssal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee(123, "Pavan", 23, 40000);
            emp1.display();
            Console.ReadLine();

        }
    }
}
