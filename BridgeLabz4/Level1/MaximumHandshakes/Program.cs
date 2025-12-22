using System;

class MaximumHandshakes
{
    static int CalculateHandshakes(int students)
    {
        return (students * (students - 1)) / 2;
    }

    static void Main()
    {
        Console.Write("Enter number of students: ");
        int students = int.Parse(Console.ReadLine());

        int handshakes = CalculateHandshakes(students);
        Console.WriteLine($"Maximum handshakes possible: {handshakes}");
    }
}
