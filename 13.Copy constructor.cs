using System;

namespace ConsoleApp166
{
    class employee
    {
        int eno;
        string ename;
        int esal;
        internal employee()
        {
            Console.Write("Enter employee number:");
            eno = int.Parse(Console.ReadLine());
            Console.Write("Enter employee name:");
            ename = Console.ReadLine();
            Console.Write("Employee salary is:");
            esal = int.Parse(Console.ReadLine());
        }
        internal employee(employee obj)
        {
            eno = obj.eno;
            ename = obj.ename;
            esal = obj.esal;
        }
        internal void display()
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
            employee obj1 = new employee();
            employee obj2 = new employee(obj1);
            obj1.display();
            obj2.display();
            Console.ReadLine();
        }
    }
}
