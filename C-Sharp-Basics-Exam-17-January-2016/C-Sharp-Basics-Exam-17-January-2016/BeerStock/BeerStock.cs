using System;

class BeerStock
{
    static void Main()
    {
        long reservedBeers = long.Parse(Console.ReadLine());

        long beersAvailable = 0;

        string command = Console.ReadLine();

        while (command != "Exam Over")
        {
            long beerAmount = long.Parse(command.Split()[0]);
            string type = command.Split()[1];

            switch (type)
            {
                case "beers": beersAvailable += beerAmount; break;
                case "sixpacks": beersAvailable += (beerAmount * 6); break;
                case "cases": beersAvailable += (beerAmount * 24); break;
            }

            command = Console.ReadLine();
        }

        beersAvailable = beersAvailable - (beersAvailable / 100);

        if (beersAvailable >= reservedBeers)
        {
            long leftBeers = beersAvailable - reservedBeers;

            long beersCasesLeft = leftBeers / 24;
            leftBeers = leftBeers % 24;

            long beersSixPacksLeft = leftBeers / 6;
            leftBeers = leftBeers % 6;

            Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.",
                beersCasesLeft, beersSixPacksLeft, leftBeers);
        }
        else
        {
            long neededBeers = reservedBeers - beersAvailable;

            long beersCasesLeft = neededBeers / 24;
            neededBeers = neededBeers % 24;

            long beersSixPacksLeft = neededBeers / 6;
            neededBeers = neededBeers % 6;

            Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.",
                beersCasesLeft, beersSixPacksLeft, neededBeers);
        }
    }
}

