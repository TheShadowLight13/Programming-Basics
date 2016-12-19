using System;

class BackToThePast
{
    static void Main()
    {
        double heritage = double.Parse(Console.ReadLine());
        int yearLive = int.Parse(Console.ReadLine());

        int IvanchoAge = 18;
        double spendedMoney = 0;

        for (int year = 1800; year <= yearLive; year++)
        {
            if (year > 1800)
            {
                IvanchoAge++;
            }

            if (year % 2 == 0)
            {
                spendedMoney += 12000;
            }
            else
            {
                spendedMoney += 12000 + (50 * IvanchoAge);
            }
        }

        if (spendedMoney <= heritage)
        {
            double moneyLeft = heritage - spendedMoney;

            Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.",
                moneyLeft);
        }
        else
        {
            double moneyNeeded = spendedMoney - heritage;
            Console.WriteLine("He will need {0:F2} dollars to survive.", moneyNeeded);
        }
    }
}

