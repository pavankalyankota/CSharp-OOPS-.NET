using System;

namespace ConsoleApp80
{
    public enum weekdays
    {
        monday = 1,
        tuesday = 2,
        wednesday = 3,
        thursday = 4,
        friday = 5,
        saturday = 6,
        sunday = 7
    }
    class wdays
    {
        public static void display(weekdays d)
        {
            switch (d)
            {
                case weekdays.monday:
                    Console.WriteLine("First day");
                    break;
                case weekdays.tuesday:
                    Console.WriteLine("Second day");
                    break;
                case weekdays.wednesday:
                    Console.WriteLine("Third day");
                    break;
                case weekdays.thursday:
                    Console.WriteLine("Fourth day");
                    break;
                case weekdays.friday:
                    Console.WriteLine("Fifth day");
                    break;
                case weekdays.saturday:
                    Console.WriteLine("Sixth day");
                    break;
                case weekdays.sunday:
                    Console.WriteLine("Seventh day");
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            weekdays obj = weekdays.saturday;
            wdays.display(obj);
            Console.ReadLine();
        }
    }
}
