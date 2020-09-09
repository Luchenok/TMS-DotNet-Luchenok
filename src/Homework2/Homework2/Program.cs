using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            string day;
            Console.Write("Enter day: ");
            day = Console.ReadLine();
            var d = Convert.ToInt32(day);
            while (d > 32)
            {
                Console.WriteLine("Error!");
                Console.Write("Enter day: ");
                day = Console.ReadLine();
                d = Convert.ToInt32(day);
            }
                Console.Write("Enter month: ");
                string month = Console.ReadLine();
                int m = int.Parse(month);
                while (m>=13)
                Console.WriteLine("Error!");
                if (((m != 2 && d < 29)) || (((m == 4) || (m == 6) || (m == 9) || (m == 11)) && d != 31))
                {
                    Console.Write("Enter year: ");
                    string year = Console.ReadLine();
                    int y = int.Parse(year);
                    string total = (day + "." + month + "." + year);
                    Console.WriteLine(total);
                    bool result = DateTime.TryParse(total, out DateTime date);
                    if (result)
                    {
                        Console.WriteLine(date.DayOfWeek);
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong.");
                    }
                }
                else
                {
                    Console.WriteLine("There are no days this month");
                }
            Console.ReadLine();
        }
    }
}