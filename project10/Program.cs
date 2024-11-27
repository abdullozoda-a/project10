using System;

namespace project10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choise the day");
            var day = Int32.Parse(Console.ReadLine());
            var month = Int32.Parse(Console.ReadLine());
            int daysInMonth = 0;
            switch (month)
            {
                case 1:case 3:case 5:case 7:case 8:case 10:case 12:
                    daysInMonth = 31; break;
                case 4:case 6:case 9:case 11:
                    daysInMonth = 30; break;
                case 2:
                    daysInMonth = 28; break;
                default:
                    Console.WriteLine("Invalid month!");
                    return;
            }

            if (day < daysInMonth)
            {
                day += 1;
            }
            else
            {
                day = 1;
                month += 1;
                if (month > 12)
                {
                    month = 1;
                }
            }
            Console.WriteLine($"next day is: {"day:"+day + " . " + "month:"+month}");
        }
    }
}