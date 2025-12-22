using System;

class StudentGradeCalculator
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        double[] percentage = new double[n];
        char[] grade = new char[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Student {i + 1}");
            double phy = double.Parse(Console.ReadLine());
            double chem = double.Parse(Console.ReadLine());
            double math = double.Parse(Console.ReadLine());

            percentage[i] = (phy + chem + math) / 3;

            if (percentage[i] >= 90) grade[i] = 'A';
            else if (percentage[i] >= 75) grade[i] = 'B';
            else if (percentage[i] >= 60) grade[i] = 'C';
            else grade[i] = 'D';
        }

        for (int i = 0; i < n; i++)
            Console.WriteLine($"Student {i + 1}: {percentage[i]}% Grade {grade[i]}");
    }
}
