using System;
using System.Linq;

class ImpressTheGirlfriend
{
    static void Main()
    {
        double gamePriceRubles = double.Parse(Console.ReadLine());
        double gamePriceDollars = double.Parse(Console.ReadLine());
        double gamePriceEuro = double.Parse(Console.ReadLine());
        double gamePriceLevaB = double.Parse(Console.ReadLine());
        double gamePriceLevaM = double.Parse(Console.ReadLine());

        double gameRublesInLeva = (gamePriceRubles / 100) * 3.5;
        double gameDollarsInLeva = gamePriceDollars * 1.5;
        double gameEuroInLeva = gamePriceEuro * 1.95;
        double oneGamePriceLevaB = gamePriceLevaB / 2;

        double[] gamePrices = new double[] {gameRublesInLeva, gameDollarsInLeva, gameEuroInLeva,
                                           oneGamePriceLevaB, gamePriceLevaM};

        double mostExpensiveGame = gamePrices.Max();
        Console.WriteLine("{0:F2}", Math.Ceiling(mostExpensiveGame));
    }
}

