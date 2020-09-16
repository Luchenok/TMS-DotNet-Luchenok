using System;

namespace Homework3
{
    class Program
    {
        enum Week
        {
            unknown,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday,
        }

        static void Main(string[] args)
        {
            var (isCorrect, day) = InputAndCheckUserData();
            if (!isCorrect)
            {
                Console.WriteLine("The entered data is incorrect..");
                Console.ReadKey();
                return;
            }

            var dates = GetDates();
            FindAndShowSuitableDates(dates, day);

            Console.ReadKey();
        }
        private static (bool isCorrect, Week day) InputAndCheckUserData()
        {
            Console.Write("Input value: ");
            var userInput = Console.ReadLine();
            userInput = userInput.ToLower();
            return CheckUserInput(userInput);
        }

        private static (bool isCorrect, Week day) CheckUserInput(string userInput)
        {
            return userInput switch
            {
                "monday" => (true, Week.monday),
                "tuesday" => (true, Week.tuesday),
                "wednesday" => (true, Week.wednesday),
                "thursday" => (true, Week.thursday),
                "friday" => (true, Week.friday),
                "saturday" => (true, Week.saturday),
                "sunday" => (true, Week.sunday),
                _ => (false, Week.unknown),
            };
        }

        private static DateTime[] GetDates()
        {
            var currentMonth = DateTime.Now.Date.Month;
            var currentYear = DateTime.Now.Date.Year;
            var daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);

            var dates = new DateTime[31];
            for (int i = 1; i < daysInMonth + 1; i++)
            {
                dates[i] = new DateTime(currentYear, currentMonth, i);
            }

            return dates;
        }

        private static void FindAndShowSuitableDates(DateTime[] dates, Week day)
        {
            foreach (var date in dates)
            {
                if (date != DateTime.MinValue && date.DayOfWeek.ToString() == day.ToString())
                {
                    Console.WriteLine(date);
                }
            }
        }
    }
}