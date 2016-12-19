using System;

class GrandTheftExamo
{
    static void Main()
    {
        int escapeAttempts = int.Parse(Console.ReadLine());

        long thievesSlapped = 0;
        long thievesEscaped = 0;
        long drunkBeers = 0;

        for (int i = 0; i < escapeAttempts; i++)
        {
            long thievesAttempsEscape = long.Parse(Console.ReadLine());
            long beersToDrink = long.Parse(Console.ReadLine());

            if (thievesAttempsEscape >= 5)
            {
                thievesSlapped += 5;
                thievesEscaped += thievesAttempsEscape - 5;
            }
            else
            {
                thievesSlapped += thievesAttempsEscape;
            }
            drunkBeers += beersToDrink;
        }

        long drunkBeerPacks = drunkBeers / 6;
        long beersLeft = drunkBeers % 6;

        Console.WriteLine("{0} thieves slapped.", thievesSlapped);
        Console.WriteLine("{0} thieves escaped.", thievesEscaped);
        Console.WriteLine("{0} packs, {1} bottles.", drunkBeerPacks, beersLeft);
    }
}

