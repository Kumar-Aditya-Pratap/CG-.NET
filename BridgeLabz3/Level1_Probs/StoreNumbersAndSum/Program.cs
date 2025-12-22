using System;

class StoreNumbersAndSum
{
    static void Main(string[] args)
    {
        double[] numbers = new double[10];
        int index = 0;
        double sum = 0;

        while (true)
        {
            Console.Write("Enter a number: ");
            double input = double.Parse(Console.ReadLine());

            if (input <= 0 || index == numbers.Length)
                break;

            numbers[index++] = input;
        }

        for (int i = 0; i < index; i++)
        {
            sum += numbers[i];
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine($"Sum = {sum}");
    }
}
