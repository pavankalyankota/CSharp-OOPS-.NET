using System;

namespace ConsoleApp25
{
    class student
    {
        ulong sid;
        string sname;
        double totmarks;
        double avgmarks;
        string result;
        internal student(ulong stid, string stname)
        {
            sid = stid;
            sname = stname;
        }
        internal void calresult(double m1, double m2, double m3)
        {
            totmarks = m1 + m2 + m3;
            avgmarks = totmarks / 3;
            if (m1 < 35 || m2 < 35 || m3 < 35)
            {
                result = "fail";
            }
            else if (avgmarks >= 65)
            {
                result = "first class";
            }
            else if (avgmarks >= 55)
            {
                result = "second class";
            }
            else
            {
                result = "fail";
            }

        }
        internal void display()
        {
            Console.WriteLine("student id is:" + sid);
            Console.WriteLine("studenr name is:" + sname);
            Console.WriteLine("student total marks is:" + totmarks);
            Console.WriteLine("student average marks is:" + avgmarks);
            Console.WriteLine("student result is:" + result);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student st1 = new student(123, "Pavan");
            st1.calresult(70, 80, 80);
            st1.display();
            student st2 = new student(456, "Kalyan");
            st2.calresult(60, 60, 90);
            st2.display();
            Console.ReadLine();
        }
    }
}
