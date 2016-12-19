using System;

class DreamItem
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');
        
        string month = input[0];
        decimal moneyPerHour = decimal.Parse(input[1]);
        int workingHours = int.Parse(input[2]);
        decimal itemPrice = decimal.Parse(input[3]);

        int daysInMonth = 0;

        switch (month)
        {
            case "Feb": daysInMonth = 28; break;
            case "Apr":
            case "June":
            case "Sept":
            case "Nov": daysInMonth = 30; break;
            default: daysInMonth = 31; break;
        }

        decimal totalSalary = (daysInMonth - 10) * moneyPerHour * workingHours;
        if (totalSalary > 700)
        {
            totalSalary *= 1.1M;
        }

        if (totalSalary >= itemPrice)
        {
            Console.WriteLine("Money left = {0:F2} leva.", totalSalary - itemPrice);
        }
        else
        {
            Console.WriteLine("Not enough money. {0:F2} leva needed.", itemPrice - totalSalary);
        }

    }
}

