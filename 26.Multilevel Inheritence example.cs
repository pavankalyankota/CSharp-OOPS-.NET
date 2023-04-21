using System;

namespace ConsoleApp40
{
    class department
    {
        int depno;
        string depname;
        public department(int depno, string depname)
        {
            this.depno = depno;
            this.depname = depname;
        }
        public void displaydepartment()
        {
            Console.WriteLine("Department number is:" + depno);
            Console.WriteLine("Department name is:" + depname);
        }
    }
    class branch : department
    {
        int bid;
        string bname;
        public branch(int bid, string bname) : base(18, "Developer")
        {
            this.bid = bid;
            this.bname = bname;
        }
        public void displaybranch()
        {
            Console.WriteLine("Branch id is:" + bid);
            Console.WriteLine("Branch name is:" + bname);
            base.displaydepartment();
        }
    }
    class employee : branch
    {
        double eno;
        string ename;
        double esal;
        public employee(double eno, string ename, double esal) : base(7, "Birmingham")
        {
            this.eno = eno;
            this.ename = ename;
            this.esal = esal;
        }
        public void displayemployee()
        {
            Console.WriteLine("Employee number is:" + eno);
            Console.WriteLine("Employee name is:" + ename);
            Console.WriteLine("Employee salary is:" + esal);
            base.displaybranch();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee(99, "Pavan", 999);
            emp1.displayemployee();
            Console.ReadLine();
        }
    }
}
