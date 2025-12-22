using System;

class BMICalculator2D
{
    static void CalculateBMI(double[,] data)
    {
        for (int i = 0; i < data.GetLength(0); i++)
        {
            double bmi = data[i, 0] / (data[i, 1] * data[i, 1]);
            Console.WriteLine($"Person {i + 1} BMI: {bmi}");
        }
    }

    static void Main()
    {
        double[,] persons =
        {
            { 70, 1.75 },
            { 80, 1.80 }
        };

        CalculateBMI(persons);
    }
}
