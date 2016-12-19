using System;

class Budget
{
    static void Main()
    {
        long money = long.Parse(Console.ReadLine());
        int weekdaysGoesOut = int.Parse(Console.ReadLine());
        int hometownWeekends = int.Parse(Console.ReadLine());

        int normalWeekends = 4 - hometownWeekends;
        int normalWeekendDays = 2 * normalWeekends;
        int normalWeekDays = 22 - weekdaysGoesOut;
        
        double spentNormalWeekendDays = 20 * normalWeekendDays;
        double spentWeekdaysGoesOut = weekdaysGoesOut * (Math.Floor((0.03 * money)) + 10);
        double spentNormalWeekDays = 10 * normalWeekDays;

        double totalSpent = spentNormalWeekendDays + spentWeekdaysGoesOut 
            + spentNormalWeekDays + 150;

        if (money > totalSpent)
        {
            Console.WriteLine("Yes, leftover {0}.", money - totalSpent);
        }
        else if (money < totalSpent)
        {
            Console.WriteLine("No, not enough {0}.", totalSpent - money);
        }
        else
        {
            Console.WriteLine("Exact Budget.");
        }
    }
}

