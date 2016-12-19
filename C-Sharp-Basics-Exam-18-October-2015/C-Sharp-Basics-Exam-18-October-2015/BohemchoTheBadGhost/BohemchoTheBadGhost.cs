using System;
using System.Linq;
using System.Collections.Generic;

class BohemchoTheBadGhost
{
    static void Main()
    {
        long bohemchoFinalScore = 0;
        long lightsOnCounter = 0;

        List<long> floorsScores = new List<long>();

        string command = Console.ReadLine();

        while (command != "Stop, God damn it")
        {
            long floor = long.Parse(command);
            long[] apartments = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long currentFloorScores = SwitchLights(floor, apartments);
            floorsScores.Add(currentFloorScores);

            command = Console.ReadLine();
        }

        for (int floor = 0; floor < floorsScores.Count; floor++)
        {
            for (int apartment = 0; apartment < 32; apartment++)
            {
                if (((floorsScores[floor] >> apartment) & 1) == 1)
                {
                    lightsOnCounter++;
                }
            }

            bohemchoFinalScore += floorsScores[floor];
        }
        
        Console.WriteLine("Bohemcho left {0} lights on and his score is {1}", 
            lightsOnCounter, bohemchoFinalScore);
    }

    private static long SwitchLights(long floor, long[] apartments)
    {
        long currentFloorScore = 0;

        for (int i = 0; i < apartments.Length; i++)
        {
            long mask = 1L << (int)apartments[i];
            floor ^= mask;
        }
        currentFloorScore = floor;
        
        return currentFloorScore;
    }
}

