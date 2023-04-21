using System;

namespace ConsoleApp86
{
    public class indexer
    {
        public string[] address = new string[2];
        public string this[int i]
        {
            get
            {
                return address[i];
            }
            set
            {
                address[i] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            indexer obj = new indexer();
            obj[0] = "Pavan";
            obj[1] = "Kalyan";
            for (int a = 0; a < obj.address.Length; a++)
            {
                Console.WriteLine(obj[a] + "");
            }
            Console.ReadLine();
        }
    }
}
