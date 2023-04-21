using System;

namespace ConsoleApp77
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
                Console.Write("Enter second number");
                int b = int.Parse(Console.ReadLine());
                div = a / b;
                Console.WriteLine("Result after division is:" + div);
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine(de.Message);
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            finally
            {
                Console.WriteLine("Final block is calling");
            }
            Console.ReadLine();
        }
    }
}
