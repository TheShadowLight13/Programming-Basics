using System;
using System.Threading;
using System.Globalization;

class ProspectInHospitality
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        uint builders = uint.Parse(Console.ReadLine());
        uint receptionists = uint.Parse(Console.ReadLine());
        uint chambermaids = uint.Parse(Console.ReadLine());
        uint technicians = uint.Parse(Console.ReadLine());
        uint others = uint.Parse(Console.ReadLine());
        decimal nikiSalaryUSD = decimal.Parse(Console.ReadLine());
        decimal currencyUSARate = decimal.Parse(Console.ReadLine());
        decimal mySalary = decimal.Parse(Console.ReadLine());
        decimal budget = decimal.Parse(Console.ReadLine());

        decimal totalExpenses = (builders * 1500.04M) + (receptionists * 2102.10M) +
                               (chambermaids * 1465.46M) + (technicians * 2053.33M) + (others * 3010.98M) +
                               (nikiSalaryUSD * currencyUSARate) + mySalary;

        Console.WriteLine("The amount is: {0:F2} lv.", totalExpenses);

        if (totalExpenses <= budget)
        {
            Console.WriteLine("YES \\ Left: {0:F2} lv.", budget - totalExpenses);
        }
        else
        {
            Console.WriteLine("NO \\ Need more: {0:F2} lv.", totalExpenses - budget);
        }
    }
}

