using System;

class BMICalculator2D
{
    static void Main()
    {
        Console.Write("Enter number of persons: ");
        int n = int.Parse(Console.ReadLine());

        double[][] personData = new double[n][];
        string[] status = new string[n];

        for (int i = 0; i < n; i++)
        {
            personData[i] = new double[3];

            Console.Write($"Height (m) of person {i + 1}: ");
            personData[i][0] = double.Parse(Console.ReadLine());

            Console.Write($"Weight (kg) of person {i + 1}: ");
            personData[i][1] = double.Parse(Console.ReadLine());

            personData[i][2] = personData[i][1] /
                               (personData[i][0] * personData[i][0]);

            double bmi = personData[i][2];
            if (bmi < 18.5) status[i] = "Underweight";
            else if (bmi < 25) status[i] = "Normal";
            else if (bmi < 30) status[i] = "Overweight";
            else status[i] = "Obese";
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Person {i + 1}: BMI={personData[i][2]} Status={status[i]}");
        }
    }
}
