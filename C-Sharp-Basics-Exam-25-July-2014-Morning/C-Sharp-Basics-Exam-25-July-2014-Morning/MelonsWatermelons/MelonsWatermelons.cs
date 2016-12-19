using System;

class MelonsWatermelons
{
    static void Main()
    {
        int dayOfWeek = int.Parse(Console.ReadLine());
        int sequentialDays = int.Parse(Console.ReadLine());

        CalculateMelonsWatermelons(dayOfWeek, sequentialDays);

    }

    private static void CalculateMelonsWatermelons(int dayOfWeek, int sequentialDays)
    {
        int currentDayCounter = dayOfWeek;
        int melons = 0;
        int watermelons = 0;
        
        for (int i = dayOfWeek; i < dayOfWeek + sequentialDays; i++)
        {
            if (currentDayCounter > 7)
            {
                currentDayCounter = 1;
            }

            switch (currentDayCounter)                         
            {
                case 1: watermelons += 1; 
                    break;
                case 2: melons += 2;
                    break;
                case 3: watermelons += 1; melons += 1;
                    break;
                case 4: watermelons += 2;
                    break;
                case 5: watermelons += 2; melons += 2;
                    break;
                case 6: watermelons += 1; melons += 2;
                    break;
            }
            
            currentDayCounter++;
        }

        if (watermelons == melons)
        {
            Console.WriteLine("Equal amount: {0}", watermelons);
        }
        else if (watermelons > melons)
        {
            Console.WriteLine("{0} more watermelons", watermelons - melons);
        }
        else if (melons > watermelons)
        {
            Console.WriteLine("{0} more melons", melons - watermelons);
        }
    }
}

