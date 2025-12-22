using System;

class EmployeeBonusCalculator
{
    static void Main()
    {
        int employeeCount = 10;

        double[] salary = new double[employeeCount];
        double[] years = new double[employeeCount];
        double[] bonus = new double[employeeCount];
        double[] newSalary = new double[employeeCount];

        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;

        for (int i = 0; i < employeeCount; i++)
        {
            Console.Write($"Enter salary of employee {i + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out salary[i]) || salary[i] <= 0)
            {
                Console.Error.WriteLine("Invalid salary. Try again.");
                i--;
                continue;
            }

            Console.Write($"Enter years of service of employee {i + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out years[i]) || years[i] < 0)
            {
                Console.Error.WriteLine("Invalid years. Try again.");
                i--;
                continue;
            }
        }

        for (int i = 0; i < employeeCount; i++)
        {
            bonus[i] = years[i] > 5 ? salary[i] * 0.05 : salary[i] * 0.02;
            newSalary[i] = salary[i] + bonus[i];

            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];
        }

        Console.WriteLine($"Total Bonus Paid: {totalBonus}");
        Console.WriteLine($"Total Old Salary: {totalOldSalary}");
        Console.WriteLine($"Total New Salary: {totalNewSalary}");
    }
}
