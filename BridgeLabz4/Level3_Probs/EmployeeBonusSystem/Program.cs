using System;

class EmployeeBonusSystem
{
    static double[,] GenerateEmployees()
    {
        Random r = new Random();
        double[,] data = new double[10, 2];

        for (int i = 0; i < 10; i++)
        {
            data[i, 0] = r.Next(10000, 99999);
            data[i, 1] = r.Next(1, 11);
        }
        return data;
    }

    static void CalculateBonus(double[,] data)
    {
        double totalOld = 0, totalNew = 0, totalBonus = 0;

        Console.WriteLine("OldSalary\tYears\tBonus\tNewSalary");

        for (int i = 0; i < 10; i++)
        {
            double salary = data[i, 0];
            double years = data[i, 1];
            double bonus = years > 5 ? salary * 0.05 : salary * 0.02;

            double newSalary = salary + bonus;

            totalOld += salary;
            totalNew += newSalary;
            totalBonus += bonus;

            Console.WriteLine($"{salary}\t{years}\t{bonus}\t{newSalary}");
        }

        Console.WriteLine("\nTotal Old Salary: " + totalOld);
        Console.WriteLine("Total Bonus: " + totalBonus);
        Console.WriteLine("Total New Salary: " + totalNew);
    }

    static void Main()
    {
        double[,] employees = GenerateEmployees();
        CalculateBonus(employees);
    }
}
