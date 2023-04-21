using System;

namespace ConsoleApp165
{
    class studentinfo
    {
        ulong sid;
        string sname;
        string sloc;
        static string colgname;
        static studentinfo()
        {
            colgname = "C#.NET";
        }
        internal studentinfo(ulong sid, string sname, string sloc)
        {
            this.sid = sid;
            this.sname = sname;
            this.sloc = sloc;
        }
        internal void display()
        {
            Console.WriteLine("Student id is:" + sid);
            Console.WriteLine("Student name is:" + sname);
            Console.WriteLine("Student location is:" + sloc);
            Console.WriteLine("student college name is:" + colgname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            studentinfo obj = new studentinfo(999, "Pavan", "UK");
            obj.display();
            Console.ReadLine();
        }
    }
}
