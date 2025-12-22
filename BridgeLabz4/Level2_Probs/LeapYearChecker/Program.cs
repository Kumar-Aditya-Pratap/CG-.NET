using System;

class LeapYearChecker
{
    static bool IsLeapYear(int year)
    {
        return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
    }

    static void Main()
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine(IsLeapYear(year) ? "Leap Year" : "Not a Leap Year");
    }
}
