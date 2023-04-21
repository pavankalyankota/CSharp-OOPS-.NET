using System;

namespace ConsoleApp177
{
    class employee
    {
        int eno;
        string ename;
        double esal;
        string designation;
        internal employee(int eno, string ename, double esal, string designation)
        {
            this.eno = eno;
            this.ename = ename;
            this.esal = esal;
            this.designation = designation;
        }
        internal void hike()
        {
            double incsal = esal * 0.2;
            esal = esal + incsal;
        }
        internal void display()
        {
            Console.WriteLine("Employee number is:" + eno);
            Console.WriteLine("Employee name is:" + ename);
            Console.WriteLine("Employee salary is:" + esal);
            Console.WriteLine("Employee designation is:" + designation);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee obj = new employee(777, "Pavan", 9999, "Developer");
            obj.hike();
            obj.display();
            Console.ReadLine();
        }
    }
}
