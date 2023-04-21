using System;

namespace ConsoleApp75
{
    class Program
    {
        static void Main(string[] args)
        {
            int div = 0;
            try
            {
                Console.Write("Enter first number:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter second number:");
                int b = int.Parse(Console.ReadLine());
                div = a / b;
                Console.WriteLine("Result after division is:" + div);
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine(de.Message);
            }
            Console.ReadLine();
        }
    }
}
