using System;

class StudentGrade
{
    static void Main()
    {
        Console.Write("Physics: ");
        int physics = int.Parse(Console.ReadLine());

        Console.Write("Chemistry: ");
        int chemistry = int.Parse(Console.ReadLine());

        Console.Write("Maths: ");
        int maths = int.Parse(Console.ReadLine());

        double average = (physics + chemistry + maths) / 3.0;

        Console.WriteLine($"Average: {average}");

        if (average >= 90)
            Console.WriteLine("Grade A - Excellent");
        else if (average >= 75)
            Console.WriteLine("Grade B - Very Good");
        else if (average >= 60)
            Console.WriteLine("Grade C - Good");
        else if (average >= 40)
            Console.WriteLine("Grade D - Pass");
        else
            Console.WriteLine("Grade F - Fail");
    }
}
