using System;

class RepairingTheTiles
{
    static void Main()
    {
        double playgroundLength = double.Parse(Console.ReadLine());
        double tileWidth = double.Parse(Console.ReadLine());
        double tileLength = double.Parse(Console.ReadLine());
        double benchWidth = double.Parse(Console.ReadLine());
        double benchLength = double.Parse(Console.ReadLine());

        const double timeForTile = 0.2; 

        double totalArea = playgroundLength * playgroundLength;
        double benchArea = benchWidth * benchLength;
        double tileArea = tileWidth * tileLength;
        double coverArea = totalArea - benchArea;

        double tilesNeeded = coverArea / tileArea;
        double timeNeeded = tilesNeeded * timeForTile;

        Console.WriteLine(tilesNeeded);
        Console.WriteLine(timeNeeded);

    }
}

