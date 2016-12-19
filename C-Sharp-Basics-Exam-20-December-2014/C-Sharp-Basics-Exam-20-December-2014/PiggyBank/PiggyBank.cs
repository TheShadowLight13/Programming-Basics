using System;

class PiggyBank
{
    static void Main()
    {
        long tankPrice = long.Parse(Console.ReadLine());
        long partyDays = long.Parse(Console.ReadLine());

        long normalDays = 30 - partyDays;
        long normalDaySaved = normalDays * 2;
        long partyDaySpend = partyDays * 5;

        long saveInMonth = normalDaySaved - partyDaySpend;
        double timeInMonths = (double)tankPrice / saveInMonth;

        if (saveInMonth <= 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            double neededYears = timeInMonths / 12;
            double neededMonths = timeInMonths % 12;

            if (Math.Ceiling(neededMonths) == 12)
            {
                neededYears += 1;
                neededMonths = 0;
            }

            Console.WriteLine("{0} years, {1} months", 
                (long)neededYears, Math.Ceiling(neededMonths));
        }
    }
}

