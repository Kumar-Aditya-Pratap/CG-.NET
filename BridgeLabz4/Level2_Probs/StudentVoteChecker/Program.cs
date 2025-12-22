using System;

class StudentVoteChecker
{
    static bool CanVote(int age) => age >= 18;

    static void Main()
    {
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine(CanVote(age) ? "Eligible to Vote" : "Not Eligible to Vote");
    }
}
