using System;

class YoungestAndTallestFriends
{
    static void FindYoungestTallest(int[] ages, int[] heights)
    {
        int youngest = ages[0];
        int tallest = heights[0];

        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < youngest) youngest = ages[i];
            if (heights[i] > tallest) tallest = heights[i];
        }

        Console.WriteLine($"Youngest Age: {youngest}");
        Console.WriteLine($"Tallest Height: {tallest}");
    }

    static void Main()
    {
        int[] ages = { 21, 18, 25, 20 };
        int[] heights = { 165, 170, 180, 160 };

        FindYoungestTallest(ages, heights);
    }
}
