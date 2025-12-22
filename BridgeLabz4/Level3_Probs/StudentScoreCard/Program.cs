using System;

class StudentScoreCard
{
    static int[,] GenerateScores(int students)
    {
        Random r = new Random();
        int[,] scores = new int[students, 3];

        for (int i = 0; i < students; i++)
            for (int j = 0; j < 3; j++)
                scores[i, j] = r.Next(10, 100);

        return scores;
    }

    static void Display(int[,] scores)
    {
        Console.WriteLine("Phy\tChem\tMath\tTotal\tAvg\t%");

        for (int i = 0; i < scores.GetLength(0); i++)
        {
            int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double avg = Math.Round(total / 3.0, 2);
            double percent = Math.Round((total / 300.0) * 100, 2);

            Console.WriteLine($"{scores[i, 0]}\t{scores[i, 1]}\t{scores[i, 2]}\t{total}\t{avg}\t{percent}");
        }
    }

    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[,] scores = GenerateScores(n);
        Display(scores);
    }
}
