using System;

namespace ConsoleApp78
{
    class Program
    {

        static void Main(string[] args)
        {
            int div = 0;
            try
            {
                Console.WriteLine("Before throwing exception");
                throw new DivideByZeroException();
                Console.WriteLine("After throwing exception");

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
