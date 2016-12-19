using System;

class MasterHerbalist
{
    static void Main()
    {
        int dailyExpenses = int.Parse(Console.ReadLine());

        double totalEarnings = 0;
        int workdays = 0;
        string information = Console.ReadLine();

        while (information != "Season Over")
        {

            int hours = int.Parse(information.Split()[0]);
            string path = information.Split()[1];
            int herbPrice = int.Parse(information.Split()[2]);

            int currentHerbs = CountHerbs(path, hours);
            totalEarnings += (currentHerbs * herbPrice);

            workdays++;
            information = Console.ReadLine();
        }

        double averageEarnings = totalEarnings / workdays;

        if (averageEarnings >= dailyExpenses)
        {
            double extraMoney = averageEarnings - dailyExpenses;
            Console.WriteLine("Times are good. Extra money per day: {0:F2}.", extraMoney);
        }
        else
        {
            int totalExpenses = dailyExpenses * workdays;
            int neededMoney = (int)(totalExpenses - totalEarnings);
            Console.WriteLine("We are in the red. Money needed: {0}.", neededMoney);
        }
    }

    private static int CountHerbs(string path, int hours)
    {
        int herbsCounter = 0;

        int pathIndex = 0;

        for (int i = 1; i <= hours; i++)
        {
            if (pathIndex == path.Length)
            {
                pathIndex = 0;
            }

            if (path[pathIndex] == 'H')
            {
                herbsCounter++;
            }

            pathIndex++;
        }
        return herbsCounter;
    }
}

