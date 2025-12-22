using System;

class MeanHeightFootball
{
    static void Main(string[] args)
    {
        double[] heights = new double[11];
        double sum = 0;

        Console.WriteLine("Enter heights of 11 players:");

        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = double.Parse(Console.ReadLine());
            sum += heights[i];
        }

        Console.WriteLine($"Mean Height = {sum / heights.Length}");
    }
}
