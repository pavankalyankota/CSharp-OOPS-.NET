using System;

namespace ConsoleApp70
{
    partial class hello
    {
        public void goodmorning()
        {
            Console.WriteLine("Good Morning");
        }
    }
}
namespace ConsoleApp70
{
    partial class hello
    {
        public void goodafternoon()
        {
            Console.WriteLine("Good Afternoon");
        }
    }
}
namespace ConsoleApp70
{
    partial class hello
    {
        public void goodevening()
        {
            Console.WriteLine("Good Evening");
        }
    }
}
namespace ConsoleApp70
{
    class Program
    {
        static void Main(string[] args)
        {
            hello obj = new hello();
            obj.goodmorning();
            obj.goodafternoon();
            obj.goodevening();
            Console.ReadLine();
        }
    }
}
