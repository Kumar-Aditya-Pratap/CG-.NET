using System;

class FootballTeamHeightStats
{
    static int[] GenerateHeights()
    {
        Random random = new Random();
        int[] heights = new int[11];
        for (int i = 0; i < heights.Length; i++)
            heights[i] = random.Next(150, 251);
        return heights;
    }

    static int Sum(int[] arr)
    {
        int sum = 0;
        foreach (int x in arr) sum += x;
        return sum;
    }

    static int Min(int[] arr)
    {
        int min = arr[0];
        foreach (int x in arr)
            if (x < min) min = x;
        return min;
    }

    static int Max(int[] arr)
    {
        int max = arr[0];
        foreach (int x in arr)
            if (x > max) max = x;
        return max;
    }

    static void Main()
    {
        int[] heights = GenerateHeights();

        Console.WriteLine("Shortest: " + Min(heights));
        Console.WriteLine("Tallest: " + Max(heights));
        Console.WriteLine("Mean Height: " + (Sum(heights) / (double)heights.Length));
    }
}
