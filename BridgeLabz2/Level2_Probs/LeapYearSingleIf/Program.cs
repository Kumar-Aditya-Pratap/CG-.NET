using System;

class LeapYearSingleIf
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        bool isLeap =
            year >= 1582 &&
            ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);

        Console.WriteLine(isLeap ? "Leap Year" : "Not a Leap Year");
    }
}
