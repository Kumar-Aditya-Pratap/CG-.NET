using System;

class MonthlyCalendar
{
    static string GetMonthName(int month)
    {
        string[] months = {
            "January","February","March","April","May","June",
            "July","August","September","October","November","December"
        };
        return months[month - 1];
    }

    static int GetDaysInMonth(int month, int year)
    {
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (month == 2 && IsLeapYear(year))
            return 29;
        return days[month - 1];
    }

    static bool IsLeapYear(int year)
    {
        return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
    }

    static int GetFirstDay(int m, int y)
    {
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        return (1 + x + (31 * m0) / 12) % 7;
    }

    static void Main()
    {
        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("\n" + GetMonthName(month) + " " + year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        int firstDay = GetFirstDay(month, year);
        int days = GetDaysInMonth(month, year);

        for (int i = 0; i < firstDay; i++)
            Console.Write("    ");

        for (int day = 1; day <= days; day++)
        {
            Console.Write($"{day,3} ");
            if ((day + firstDay) % 7 == 0)
                Console.WriteLine();
        }
    }
}
