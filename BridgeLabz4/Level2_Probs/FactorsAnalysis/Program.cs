using System;

class FactorsAnalysis
{
    static void PrintFactors(int number)
    {
        Console.Write("Factors: ");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                Console.Write(i + " ");
        }
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        PrintFactors(number);
    }
}
