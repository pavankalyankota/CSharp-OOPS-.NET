using System;

namespace ConsoleApp42
{
    class department
    {
        int depno;
        string depname;
        internal department(int depno, string depname)
        {
            this.depno = depno;
            this.depname = depname;
        }
        internal void displaydepartment()
        {
            Console.WriteLine("Department number is:" + depno);
            Console.WriteLine("Department name is:" + depname);

        }
    }
    class employee : department
    {
        int eno;
        string ename;
        public employee(int eno, string ename) : base(18, "Analyst")
        {
            this.eno = eno;
            this.ename = ename;
        }
        public void displayemployee()
        {
            Console.WriteLine("Employee number is:" + eno);
            Console.WriteLine("Employee name is:" + ename);
            base.displaydepartment();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee(9, "Pavan");
            emp1.displayemployee();
            Console.ReadLine();
        }
    }
}
