using System;

class RandomNumberStatistics
{
    static void GenerateStats(int count)
    {
        Random rand = new Random();
        int sum = 0, min = int.MaxValue, max = int.MinValue;

        for (int i = 0; i < count; i++)
        {
            int num = rand.Next(1, 100);
            sum += num;
            if (num < min) min = num;
            if (num > max) max = num;
        }

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {sum / (double)count}");
        Console.WriteLine($"Min: {min}");
        Console.WriteLine($"Max: {max}");
    }

    static void Main()
    {
        Console.Write("Enter count: ");
        int count = int.Parse(Console.ReadLine());

        GenerateStats(count);
    }
}
