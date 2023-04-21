using System;

namespace ConsoleApp76
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
            finally
            {
                Console.WriteLine("Final block is calling");
            }
            Console.ReadLine();
        }
    }
}
