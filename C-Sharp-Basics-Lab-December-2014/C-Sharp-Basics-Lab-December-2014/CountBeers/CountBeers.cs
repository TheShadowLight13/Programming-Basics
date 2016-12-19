using System;

class CountBeers
{
    static void Main()
    {
        string command = Console.ReadLine();

        int beers = 0;
        int stacks = 0;

        const int beersInStack = 20;

        while (command != "End")
        {
            int countBeers = int.Parse(command.Split()[0]);
            string measure = command.Split()[1];
            
            if (measure.Equals("beers"))
            {
                beers += countBeers;
            }
            else if (measure.Equals("stacks"))
            {
                stacks += countBeers;
            }

            command = Console.ReadLine();
        }

        stacks += beers / beersInStack;
        beers = beers % beersInStack;

        Console.WriteLine("{0} stacks + {1} beers", stacks, beers);

    }
}

