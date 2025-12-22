using System;

class VotingEligibility
{
    static void Main(string[] args)
    {
        int[] ages = new int[10];

        Console.WriteLine("Enter age of 10 students:");

        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Student {i + 1}: ");

            if (!int.TryParse(Console.ReadLine(), out ages[i]))
            {
                Console.Error.WriteLine("Invalid age input.");
                Environment.Exit(1);
            }
        }

        Console.WriteLine("\nVoting Eligibility:");

        for (int i = 0; i < ages.Length; i++)
        {
            if (ages[i] < 0)
            {
                Console.Error.WriteLine($"Invalid age: {ages[i]}");
            }
            else if (ages[i] >= 18)
            {
                Console.WriteLine($"Age {ages[i]} → Can Vote");
            }
            else
            {
                Console.WriteLine($"Age {ages[i]} → Cannot Vote");
            }
        }
    }
}
