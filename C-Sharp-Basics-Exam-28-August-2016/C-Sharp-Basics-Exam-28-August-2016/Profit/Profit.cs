using System;

class Profit
{
    static void Main()
    {
        const int monthsInYear = 12;
        const int daysInYear = 365;
        const double bonusRate = 2.5;
        const double taxPercent = 0.25;

        int workDays = int.Parse(Console.ReadLine());
        double moneyPerDay = double.Parse(Console.ReadLine());
        double dollarExchange = double.Parse(Console.ReadLine());

        double salaryPerMonth = moneyPerDay * workDays;
        double yearlyIncomes = salaryPerMonth * monthsInYear + salaryPerMonth * bonusRate;
        double tax = yearlyIncomes * taxPercent;

        double totalProfit = (yearlyIncomes - tax) * dollarExchange;
        double averageProfitPerDay = totalProfit / daysInYear;

        Console.WriteLine($"{averageProfitPerDay:F2}");
    }
}

