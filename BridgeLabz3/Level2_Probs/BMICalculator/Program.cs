using System;

class BMICalculator
{
    static void Main()
    {
        Console.Write("Enter number of persons: ");
        int n = int.Parse(Console.ReadLine());

        double[] height = new double[n];
        double[] weight = new double[n];
        double[] bmi = new double[n];
        string[] status = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Height (m) of person {i + 1}: ");
            height[i] = double.Parse(Console.ReadLine());

            Console.Write($"Weight (kg) of person {i + 1}: ");
            weight[i] = double.Parse(Console.ReadLine());

            bmi[i] = weight[i] / (height[i] * height[i]);

            if (bmi[i] < 18.5) status[i] = "Underweight";
            else if (bmi[i] < 25) status[i] = "Normal";
            else if (bmi[i] < 30) status[i] = "Overweight";
            else status[i] = "Obese";
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Person {i + 1}: BMI={bmi[i]} Status={status[i]}");
        }
    }
}
