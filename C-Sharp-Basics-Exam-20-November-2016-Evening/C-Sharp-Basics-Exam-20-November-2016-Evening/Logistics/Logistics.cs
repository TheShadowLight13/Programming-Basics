using System;
using System.Runtime.CompilerServices;

class Logistics
{
    static void Main()
    {
        int loadsCount = int.Parse(Console.ReadLine());

        int microbusLoads = 0;
        int truckLoads = 0;
        int trainLoads = 0;

        int totalLoads = 0;

        for (int i = 0; i < loadsCount; i++)
        {
            int carriageTonnage = int.Parse(Console.ReadLine());

            if (carriageTonnage <= 3)
            {
                microbusLoads += carriageTonnage;
            }
            else if (carriageTonnage >= 4 && carriageTonnage <= 11)
            {
                truckLoads += carriageTonnage;
            }
            else if (carriageTonnage >= 12)
            {
                trainLoads += carriageTonnage;
            }

            totalLoads += carriageTonnage;

        }

        decimal averagePricePerLoad = 
            ((microbusLoads*200) + (truckLoads*175) + (trainLoads*120)) / (decimal)totalLoads;
        decimal microbusLoadsPercent = (microbusLoads/(decimal) totalLoads)*100;
        decimal truckLoadsPercent = (truckLoads/(decimal) totalLoads)*100;
        decimal trainLoadsPercent = (trainLoads/(decimal) totalLoads)*100;

        Console.WriteLine("{0:F2}", averagePricePerLoad);
        Console.WriteLine("{0:F2}%", microbusLoadsPercent);
        Console.WriteLine("{0:F2}%", truckLoadsPercent);
        Console.WriteLine("{0:F2}%", trainLoadsPercent);

    }
}

