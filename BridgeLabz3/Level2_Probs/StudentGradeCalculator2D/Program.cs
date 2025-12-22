using System;

class StudentGradeCalculator2D
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        double[,] marks = new double[n, 3];
        double[] percentage = new double[n];
        char[] grade = new char[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Student {i + 1}");
            for (int j = 0; j < 3; j++)
                marks[i, j] = double.Parse(Console.ReadLine());

            percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3;

            if (percentage[i] >= 90) grade[i] = 'A';
            else if (percentage[i] >= 75) grade[i] = 'B';
            else if (percentage[i] >= 60) grade[i] = 'C';
            else grade[i] = 'D';
        }

        for (int i = 0; i < n; i++)
            Console.WriteLine($"Student {i + 1}: {percentage[i]}% Grade {grade[i]}");
    }
}
